namespace WebImageCreator
{
    partial class LogViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewer));
            this.TableViewMain = new System.Windows.Forms.DataGridView();
            this.lblNoResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // TableViewMain
            // 
            this.TableViewMain.AllowUserToAddRows = false;
            this.TableViewMain.AllowUserToDeleteRows = false;
            this.TableViewMain.AllowUserToResizeRows = false;
            this.TableViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableViewMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TableViewMain.CausesValidation = false;
            this.TableViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableViewMain.Location = new System.Drawing.Point(0, 0);
            this.TableViewMain.Margin = new System.Windows.Forms.Padding(0);
            this.TableViewMain.MultiSelect = false;
            this.TableViewMain.Name = "TableViewMain";
            this.TableViewMain.ReadOnly = true;
            this.TableViewMain.RowTemplate.Height = 20;
            this.TableViewMain.RowTemplate.ReadOnly = true;
            this.TableViewMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TableViewMain.ShowEditingIcon = false;
            this.TableViewMain.Size = new System.Drawing.Size(684, 332);
            this.TableViewMain.TabIndex = 2;
            // 
            // lblNoResults
            // 
            this.lblNoResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.ForeColor = System.Drawing.Color.Red;
            this.lblNoResults.Location = new System.Drawing.Point(248, 142);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(181, 15);
            this.lblNoResults.TabIndex = 3;
            this.lblNoResults.Text = "No Errors To Display At This Time";
            this.lblNoResults.Visible = false;
            // 
            // LogViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(684, 332);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.TableViewMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.TableViewMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableViewMain;
        private System.Windows.Forms.Label lblNoResults;
    }
}