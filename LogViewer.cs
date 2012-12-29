using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace WebImageCreator
{
    partial class LogViewer : Form
    {
        public LogViewer()
        {
            InitializeComponent();
            InitializeViewer();
        }

        #region Private Methods

        private void InitializeViewer()
        {
            DataTable dtLog = new DataTable();
            DataRow drRow = null;
            string szLine;

            try
            {
                if (File.Exists(Core.Diagnostics.LogFilePath))
                {
                    //set up the log datatable
                    dtLog.Columns.Add(new DataColumn("Date", typeof(string)));
                    dtLog.Columns.Add(new DataColumn("Component/Event", typeof(string)));
                    dtLog.Columns.Add(new DataColumn("Message", typeof(string)));

                    //write contents of the log file into the datatable
                    using (StreamReader sr = new StreamReader(Core.Diagnostics.LogFilePath))
                    {
                        while ((szLine = sr.ReadLine()) != null)
                        {
                            drRow = dtLog.NewRow();
                            drRow.ItemArray = szLine.Split(new char[] { '|' });
                            dtLog.Rows.Add(drRow);
                            drRow = null;
                        }
                    }
                }

                if (dtLog.Rows.Count > 0)
                {
                    this.TableViewMain.DataSource = dtLog;
                }
                else
                {
                    this.TableViewMain.Visible = false;
                    this.lblNoResults.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Core.Diagnostics.LogException(ex, "LogViewer.InitializeViewer");
            }
            finally
            {
                dtLog.Dispose();
                dtLog = null;
            }
        }

        #endregion
    }
}
