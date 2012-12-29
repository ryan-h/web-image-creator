using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebImageCreator
{
    partial class InputForm : Form
    {
        #region Private Members

        private CancellationTokenSource _objCancelTokenSource = null;
        private Int32 _nImagesCreatedCnt, _nImagesErrorCnt;
        private String _szLastProcessedFolderPath;
        
        #endregion

        public InputForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Updates the event text displayed in the status strip.
        /// </summary>
        /// <param name="szText"></param>
        /// <param name="cForeColor"></param>
        public void UpdateStatusEventText(String szText, Color cForeColor)
        {
            this.StatusEventMessage.Visible = true;
            this.StatusEventMessage.Text = szText;
            this.StatusEventMessage.ForeColor = cForeColor;
        }

        /// <summary>
        /// Clears any text currently displayed in the status strip.
        /// </summary>
        public void ClearStatusEventText()
        {
            this.StatusEventMessage.Visible = false;
            this.StatusEventMessage.Text = "";
            this.StatusEventMessage.ForeColor = Color.Black;
        }
   
        #region Private Event Methods

        private void InputForm_Load(object sender, EventArgs e)
        {
            this.txtImageFolderPath.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Text.Equals("Stop"))
                {   //stop all the processing threads
                    _objCancelTokenSource.Cancel();
                    (sender as Button).Text = "Stopping...";
                    (sender as Button).Enabled = false;
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.bntClose_Click");
            }
        }
       
        private void btnCreate_Click(object sender, EventArgs e)
        {
            Core.CreationProcessor objProcessor = null;
            Core.CreationProcessor.InputData objInputData;

            try
            {
                if (!Directory.Exists(this.txtImageFolderPath.Text))
                {   //ensure the entered directory exists
                    Core.StatusMessage.Write(Core.StatusMessage.EventType.Failure, "Folder path does not exist.");
                    return;
                }

                _nImagesCreatedCnt = 0;
                _nImagesErrorCnt = 0;

                Core.StatusMessage.Clear();

                if (!(this.txtNewFolder.Text.Trim().Length > 0))
                {   //ensure a new folder name
                    this.txtNewFolder.Text = "Web_Images";
                }

                //gather all of the user input data
                objInputData = new Core.CreationProcessor.InputData();
                objInputData.RootFolderPath = this.txtImageFolderPath.Text;
                objInputData.ImageMaxWidth = Convert.ToInt32(this.lWidth.Value);
                objInputData.ImageMaxHeight = Convert.ToInt32(this.lHeight.Value);
                objInputData.JPGQualityPercentage = Convert.ToInt32(this.lQuality.Value);
                objInputData.NewFolderName = this.txtNewFolder.Text;
                objInputData.FileNameSuffix = this.txtFileSuffix.Text;
                objInputData.IncludeSubFolders = this.chkInclSubfolders.Checked;

                //create the processor object and setup delegates
                objProcessor = new Core.CreationProcessor(objInputData);

                #region Processor Delegates

                objProcessor.OnProcessBegin = delegate(Int32 nTotalFileCnt)
                {
                    if (!this.IsDisposed)
                    {
                        this.Invoke((MethodInvoker)delegate()
                        {
                            try
                            {
                                btnClose.Text = "Stop";
                                btnCreate.Enabled = false;
                                btnBrowse.Enabled = false;
                                txtImageFolderPath.Enabled = false;
                                lnkImageFolder.Visible = false;
                                lWidth.Enabled = false;
                                lHeight.Enabled = false;
                                lQuality.Enabled = false;
                                txtNewFolder.Enabled = false;
                                txtFileSuffix.Enabled = false;
                                chkInclSubfolders.Enabled = false;
                                pbMain.Value = 0;
                                pbMain.Maximum = nTotalFileCnt;
                            }
                            catch (Exception ex)
                            {
                                Core.Diagnostics.LogException(ex, "InputForm.btnCreate_Click.OnProcessBegin");
                            }
                        });
                    }
                };

                objProcessor.OnProcessEnd = delegate()
                {
                    if (!this.IsDisposed)
                    {
                        this.Invoke((MethodInvoker)delegate()
                        {
                            try
                            {
                                btnCreate.Enabled = true;
                                btnBrowse.Enabled = true;
                                txtImageFolderPath.Enabled = true;
                                lWidth.Enabled = true;
                                lHeight.Enabled = true;
                                lQuality.Enabled = true;
                                txtNewFolder.Enabled = true;
                                txtFileSuffix.Enabled = true;
                                chkInclSubfolders.Enabled = true;
                                btnClose.Text = "Close";
                                btnClose.Enabled = true;

                                //display process result
                                if (_objCancelTokenSource.IsCancellationRequested)
                                {
                                    Core.StatusMessage.Write(Core.StatusMessage.EventType.Warning, String.Format("Image creation has been stopped ({0} image{1} created).", _nImagesCreatedCnt, (_nImagesCreatedCnt > 1 ? "s were" : " was")));
                                    lnkImageFolder.Visible = true;
                                }
                                else
                                {
                                    if (_nImagesCreatedCnt == 0)
                                    {
                                        if (_nImagesErrorCnt == 0)
                                        {
                                            Core.StatusMessage.Write(Core.StatusMessage.EventType.Warning, "No files were found in the selected folder.");
                                        }
                                        else
                                        {
                                            Core.StatusMessage.Write(Core.StatusMessage.EventType.Failure, "Unable to create any image files.");
                                        }
                                    }
                                    else
                                    {
                                        if (_nImagesErrorCnt == 0)
                                        {
                                            if (_nImagesCreatedCnt > 1)
                                            {
                                                Core.StatusMessage.Write(Core.StatusMessage.EventType.Success, String.Format("All {0} images were created successfully!", _nImagesCreatedCnt));
                                            }
                                            else
                                            {
                                                Core.StatusMessage.Write(Core.StatusMessage.EventType.Success, "Image was created successfully!");
                                            }
                                        }
                                        else
                                        {
                                            if (_nImagesCreatedCnt > 1)
                                            {
                                                Core.StatusMessage.Write(Core.StatusMessage.EventType.Warning, String.Format("{0} images out of {1} were created successfully. See log for more details.", _nImagesCreatedCnt, (_nImagesCreatedCnt +_nImagesErrorCnt)));
                                            }
                                            else
                                            {
                                                Core.StatusMessage.Write(Core.StatusMessage.EventType.Warning, String.Format("1 image out of {0} was created successfully. See log for more details.", (_nImagesCreatedCnt + _nImagesErrorCnt)));
                                            }
                                        }
                                        lnkImageFolder.Visible = true; //show the link to the root image folder
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Core.Diagnostics.LogException(ex, "InputForm.btnCreate_Click.OnProcessEnd");
                            }
                        });
                    }
                };

                objProcessor.OnFileProcessed = delegate(String szFileName, Core.CreationProcessor.FileProcessResult objResult)
                {
                    if (!this.IsDisposed)
                    {
                        this.Invoke((MethodInvoker)delegate()
                        {
                            try
                            {
                                switch (objResult)
                                {
                                    case Core.CreationProcessor.FileProcessResult.Created:
                                        _nImagesCreatedCnt++;
                                        break;
                                    case Core.CreationProcessor.FileProcessResult.Error:
                                        _nImagesErrorCnt++;
                                        break;
                                }

                                if (objResult != Core.CreationProcessor.FileProcessResult.Skipped)
                                {
                                    Core.StatusMessage.Write(Core.StatusMessage.EventType.Info, String.Concat("Processing - ", szFileName));
                                }

                                pbMain.Increment(1); //increment the progress indicator
                            }
                            catch (Exception ex)
                            {
                                Core.Diagnostics.LogException(ex, "InputForm.btnCreate_Click.OnFileProcessed");
                            }
                        });
                    }
                };

                #endregion

                //store processed path for open image folder link
                _szLastProcessedFolderPath = objInputData.RootFolderPath;

                //start the new process for creating the images
                _objCancelTokenSource = new CancellationTokenSource();
                Task.Factory.StartNew(() => objProcessor.Process(_objCancelTokenSource.Token), TaskCreationOptions.AttachedToParent);
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.btnCreate_Click");
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                if (fbdImages.ShowDialog() == DialogResult.OK)
                {
                    txtImageFolderPath.Text = fbdImages.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.btnBrowser_Click");
            }
        }
       
        private void txtImageFolderPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                btnCreate.Enabled = ((sender as TextBox).Text.Length > 0);
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.txtImageFolderPath_TextChanged");
            }
        }

        private void txtNewFolder_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Core.Common.IsValidPathChar(e.KeyChar))
                {
                    e.KeyChar = (char)0;
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.txtNewFolder_KeyPress");
            }
        }

        private void txtFileSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!Core.Common.IsValidPathChar(e.KeyChar))
                {
                    e.KeyChar = (char)0;
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.txtFileSuffix_KeyPress");
            }
        }

        private void lnkImageFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Directory.Exists(_szLastProcessedFolderPath))
                {
                    System.Diagnostics.Process.Start(_szLastProcessedFolderPath);
                }
                else
                {
                    Core.StatusMessage.Write(Core.StatusMessage.EventType.Failure, "The image folder path was not found.");
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.lnkImageFolder_LinkClicked");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox abAbout = new AboutBox();
            try
            {
                abAbout.ShowDialog();
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.aboutToolStripMenuItem_Click");
            }
            finally
            {
                abAbout.Dispose();
                abAbout = null;
            }
        }

        private void viewErrorLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogViewer objLogViewer = new LogViewer();
            try
            {
                objLogViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.viewErrorLogsToolStripMenuItem_Click");
            }
            finally
            {
                objLogViewer.Dispose();
                objLogViewer = null;
            }
        }

        private void clearErrorLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Core.Diagnostics.ClearExceptions();
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "InputForm.clearErrorLogsToolStripMenuItem_Click");
            }
        }

        #endregion
    }
}
