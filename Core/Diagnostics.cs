using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Collections.Concurrent;

namespace WebImageCreator.Core
{
    public class Diagnostics
    {
        #region Private Members

        private static BlockingCollection<Error> _objErrorsQueue = new BlockingCollection<Error>();
        private static Thread _thLogWorker = null;

        #endregion

        #region Public Properties

        public static string LogFilePath
        {
            get
            {
                return Path.Combine(Environment.CurrentDirectory, "Errors.log");
            }
        }

        #endregion

        /// <summary>
        /// Adds the exception to the errors log file.
        /// </summary>
        /// <param name="objException"></param>
        /// <param name="szComponent"></param>
        /// <param name="bDisplayStatusMsg"></param>
        public static void LogException(Exception objException, String szComponent, Boolean bDisplayStatusMsg = true)
        {
            LogException(objException.Message, szComponent, bDisplayStatusMsg);
        }

        /// <summary>
        /// Adds a custom message to the erros log file.
        /// </summary>
        /// <param name="szMessage"></param>
        /// <param name="szComponent"></param>
        /// <param name="bDisplayStatusMsg"></param>
        public static void LogException(String szMessage, String szComponent, Boolean bDisplayStatusMsg = true)
        {
            try
            {
                if (_thLogWorker == null)
                {
                    InitializeLogWorker();
                }

                //queue the error to be written to file
                _objErrorsQueue.Add(new Error(szMessage, szComponent));

                if (bDisplayStatusMsg)
                {   //show generic status message
                    Core.StatusMessage.Write(StatusMessage.EventType.Failure, "Error occurred. See log for more details.");
                }
            }
            catch (Exception ex)
            {
                AppendToLog(new Error(ex.Message, "Core.Diagnostics.LogException"));
            }
        }

        /// <summary>
        /// Removes all errors contained in the log file.
        /// </summary>
        public static void ClearExceptions()
        {
            try
            {
                using (StreamWriter swLog = File.CreateText(LogFilePath))
                {
                    swLog.Write("");
                }
            }
            catch (Exception ex)
            {
                LogException(ex, "Core.Diagnostics.ClearExceptions");   
            }
        }

        #region Private Methods

        private static void InitializeLogWorker()
        {
            _thLogWorker = new Thread(() =>
            {
                foreach (Error objError in _objErrorsQueue.GetConsumingEnumerable())
                {
                    AppendToLog(objError);
                }
            });
            _thLogWorker.IsBackground = true;
            _thLogWorker.Start();
        }

        private static void AppendToLog(Error objError)
        {
            try
            {
                using (StreamWriter swLog = File.AppendText(LogFilePath))
                {
                    swLog.Write(System.DateTime.Now.ToString());
                    swLog.Write("|");
                    swLog.Write(objError.Component);
                    swLog.Write("|");
                    swLog.WriteLine(objError.Message.Replace(Environment.NewLine, " ")); //remove possible new lines
                }
            }
            catch (Exception) { }
        }

        #endregion

        #region Helper Classes

        private class Error
        {
            public string Message { get; set; }
            public string Component { get; set; }

            public Error(string szMessage, string szComponent)
            {
                this.Message = szMessage;
                this.Component = szComponent;
            }
        }

        #endregion
    }
}
