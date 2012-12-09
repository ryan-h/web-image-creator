using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WebImageCreator.Core
{
    class StatusMessage
    {
        public enum EventType
        {
            Success,
            Warning,
            Failure,
            Info
        }

        /// <summary>
        /// Clears the current message and writes the provided text to the status strip.
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="szMessageText"></param>
        public static void Write(EventType enumType, String szMessageText)
        {
            InputForm objForm = null;
            try
            {
                objForm = Core.Common.GetInputForm();
                if (objForm != null && !objForm.IsDisposed)
                {
                    Color cMessageColor = Color.Black;
                    switch (enumType)
                    {
                        case EventType.Success:
                            cMessageColor = Color.Green;
                            break;
                        case EventType.Warning:
                            cMessageColor = Color.FromArgb(240, 110, 25);
                            break;
                        case EventType.Failure:
                            cMessageColor = Color.Red;
                            break;
                    }

                    if (objForm.InvokeRequired)
                    {
                        objForm.Invoke((MethodInvoker)delegate() { objForm.UpdateStatusEventText(szMessageText, cMessageColor); });
                    }
                    else
                    {
                        objForm.UpdateStatusEventText(szMessageText, cMessageColor);
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.StatusMessage.Write");
            }
        }

        /// <summary>
        /// Clears any message currently displayed in the status strip.
        /// </summary>
        public static void Clear()
        {
            InputForm objForm = null;
            try
            {
                objForm = Core.Common.GetInputForm();
                if (objForm != null && !objForm.IsDisposed)
                {
                    if (objForm.InvokeRequired)
                    {
                        objForm.Invoke((MethodInvoker)delegate() { objForm.ClearStatusEventText(); });
                    }
                    else
                    {
                        objForm.ClearStatusEventText();
                    }
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.StatusMessage.Clear");
            }
        }
    }
}
