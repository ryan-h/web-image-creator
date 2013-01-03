using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebImageCreator.Core
{
    class Common
    {
        /// <summary>
        /// Gets the current InputForm.
        /// </summary>
        /// <returns>InputForm or null</returns>
        public static InputForm GetInputForm()
        {
            try
            {
                return Application.OpenForms.OfType<InputForm>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.Common.GetInputForm", false);
                return null;
            }
        }

        /// <summary>
        /// Checks if the provided character is valid for a folder or file.
        /// </summary>
        /// <param name="chr"></param>
        /// <returns>true if valid</returns>
        public static Boolean IsValidPathChar(Char chr)
        {
            try
            {
                //chars: \ / : * ? " < > |
                switch (chr)
                {
                    case (char)92:
                    case (char)47:
                    case (char)58:
                    case (char)42:
                    case (char)63:
                    case (char)34:
                    case (char)60:
                    case (char)62:
                    case (char)124:
                        return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "Core.Common.IsValidPathChar", false);
                return false;
            }
        }
    }    
}
