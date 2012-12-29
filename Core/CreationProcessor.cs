using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace WebImageCreator.Core
{
    class CreationProcessor
    {
        #region Private Members

        private InputData _objInputData;

        #endregion

        #region Public Properties

        public Action<Int32> OnProcessBegin { get; set; }
        public Action OnProcessEnd { get; set; }
        public Action<String, FileProcessResult> OnFileProcessed { get; set; }

        #endregion

        #region Protected Invoke Methods

        protected void InvokeProcessBegin(Int32 nTotalFileCnt)
        {
            if (this.OnProcessBegin != null)
            {
                this.OnProcessBegin.Invoke(nTotalFileCnt);
            }
        }

        protected void InvokeProcessEnd()
        {
            if (this.OnProcessEnd != null)
            {
                this.OnProcessEnd.Invoke();
            }
        }

        protected void InvokeFileProcessed(String szFileName, FileProcessResult objResult)
        {
            if (this.OnFileProcessed != null)
            {
                this.OnFileProcessed.Invoke(szFileName, objResult);
            }
        }

        #endregion

        public enum FileProcessResult
        {
            Created,
            Error,
            Skipped
        }

        public struct InputData
        {
            public String RootFolderPath { get; set; }
            public Int32 ImageMaxWidth { get; set; }
            public Int32 ImageMaxHeight { get; set; }
            public Int32 JPGQualityPercentage { get; set; }
            public String NewFolderName { get; set; }
            public String FileNameSuffix { get; set; }
            public Boolean IncludeSubFolders { get; set; }
        }

        public CreationProcessor(InputData objInputData)
        {
            _objInputData = objInputData;
        }

        /// <summary>
        /// Processes all files and creates the new images.
        /// </summary>
        /// <param name="objCancellationToken"></param>
        public void Process(CancellationToken objCancellationToken)
        {
            List<Task> lRunningTasks = new List<Task>();
            List<String> lProcessDirs = new List<String>();
            Int32 nTotalFileCnt = 0;

            try
            {
                //add the root directory
                lProcessDirs.Add(_objInputData.RootFolderPath);

                if (_objInputData.IncludeSubFolders)
                {   //get all the child directories
                    lProcessDirs.AddRange(from szDirPath in Directory.GetDirectories(_objInputData.RootFolderPath, "*", SearchOption.AllDirectories)
                                          where Path.GetFileName(szDirPath) != _objInputData.NewFolderName
                                          select szDirPath);
                }

                //get the number of files to be processed
                nTotalFileCnt = lProcessDirs.Aggregate(0, (nNumOfFiles, szDir) => nNumOfFiles + Directory.GetFiles(szDir).Length);

                this.InvokeProcessBegin(nTotalFileCnt);

                try
                {
                    //start the process for each directory
                    foreach (String szDirPath in lProcessDirs)
                    {
                        objCancellationToken.ThrowIfCancellationRequested();

                        String szCurrentDirPath = szDirPath; //create copy for the new thread
                        lRunningTasks.Add(Task.Factory.StartNew(() => ProcessDirectory(szCurrentDirPath, objCancellationToken), TaskCreationOptions.AttachedToParent));
                    }

                    //wait for all the directory processes
                    Task.WaitAll(lRunningTasks.ToArray());
                }
                catch (OperationCanceledException) { }

                this.InvokeProcessEnd();
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.CreationProcessor.Process");
            }
        }

        #region Private Methods

        private void ProcessDirectory(String szDirPath, CancellationToken objCancellationToken)
        {
            String szNewDirectoryPath;

            try
            {
                objCancellationToken.ThrowIfCancellationRequested();

                szNewDirectoryPath = Path.Combine(szDirPath, _objInputData.NewFolderName);

                Directory.CreateDirectory(szNewDirectoryPath); //ensure the new folder exists

                //process each individual file in the directory in parallel
                Parallel.ForEach(Directory.GetFiles(szDirPath).AsEnumerable(), (szFilePath, objLoopState) =>
                {
                    if (objCancellationToken.IsCancellationRequested)
                    {
                        objLoopState.Break();
                    }

                    ProcessImage(szFilePath);
                });

                //delete the new directory if no images were created
                if (Directory.GetFiles(szNewDirectoryPath).Length == 0)
                {
                    Directory.Delete(szNewDirectoryPath);
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.CreationProcessor.ProcessDirectory", false);
            }
        }

        private void ProcessImage(String szFilePath)
        {
            FileInfo fiImageFile = null;
            byte[] arrNewImageData = null;
            String szNewImagePath = "";

            try
            {
                fiImageFile = new FileInfo(szFilePath);

                //do not process system and hidden files
                if (fiImageFile.Attributes.HasFlag(FileAttributes.System | FileAttributes.Hidden))
                {
                    this.OnFileProcessed.Invoke(fiImageFile.Name, FileProcessResult.Skipped);
                    return;
                }

                using (FileStream fsImage = fiImageFile.OpenRead())
                {
                    using (Image objImage = Image.FromStream(fsImage))
                    {   //create the new optimized image
                        arrNewImageData = Core.ImageCreator.Create(objImage, _objInputData.ImageMaxWidth, _objInputData.ImageMaxHeight, _objInputData.JPGQualityPercentage);
                    }
                }

                //get the path and name for the new image
                szNewImagePath = Path.Combine(fiImageFile.DirectoryName, _objInputData.NewFolderName, Core.ImageCreator.GetNewImageName(Path.GetFileName(szFilePath), _objInputData.FileNameSuffix));

                //save the image file to disk
                File.WriteAllBytes(szNewImagePath, arrNewImageData);

                this.InvokeFileProcessed(fiImageFile.Name, FileProcessResult.Created);
            }
            catch (Exception ex)
            {
                this.OnFileProcessed.Invoke((fiImageFile != null ? fiImageFile.Name : ""), FileProcessResult.Error);
                Core.Diagnostics.LogException(ex, String.Format("Core.CreationProcessor.ProcessImage{0}", (fiImageFile != null ? " -> " + fiImageFile.Name : "")), false);
            }
        }

        #endregion
    }
}
