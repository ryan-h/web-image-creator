namespace WebImageCreator
{
    partial class InputForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputForm));
            this.lnkImageFolder = new System.Windows.Forms.LinkLabel();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearErrorLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStripEvents = new System.Windows.Forms.StatusStrip();
            this.lblStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusEventMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fbdImages = new System.Windows.Forms.FolderBrowserDialog();
            this.lblOpt = new System.Windows.Forms.Label();
            this.lblNewFolder = new System.Windows.Forms.Label();
            this.gbFolderDetails = new System.Windows.Forms.GroupBox();
            this.chkInclSubfolders = new System.Windows.Forms.CheckBox();
            this.txtNewFolder = new System.Windows.Forms.TextBox();
            this.lblFileSuffix = new System.Windows.Forms.Label();
            this.txtFileSuffix = new System.Windows.Forms.TextBox();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtImageFolderPath = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblHeight = new System.Windows.Forms.Label();
            this.gbImageDetails = new System.Windows.Forms.GroupBox();
            this.lQuality = new System.Windows.Forms.NumericUpDown();
            this.lWidth = new System.Windows.Forms.NumericUpDown();
            this.lHeight = new System.Windows.Forms.NumericUpDown();
            this.lblWidth = new System.Windows.Forms.Label();
            this.StatusStripEvents.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gbFolderDetails.SuspendLayout();
            this.gbImageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkImageFolder
            // 
            this.lnkImageFolder.AutoSize = true;
            this.lnkImageFolder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImageFolder.Location = new System.Drawing.Point(366, 196);
            this.lnkImageFolder.Name = "lnkImageFolder";
            this.lnkImageFolder.Size = new System.Drawing.Size(104, 15);
            this.lnkImageFolder.TabIndex = 20;
            this.lnkImageFolder.TabStop = true;
            this.lnkImageFolder.Text = "Open Images Folder";
            this.lnkImageFolder.Visible = false;
            this.lnkImageFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImageFolder_LinkClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearErrorLogsToolStripMenuItem
            // 
            this.clearErrorLogsToolStripMenuItem.Name = "clearErrorLogsToolStripMenuItem";
            this.clearErrorLogsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.clearErrorLogsToolStripMenuItem.Text = "Clear";
            this.clearErrorLogsToolStripMenuItem.Click += new System.EventHandler(this.clearErrorLogsToolStripMenuItem_Click);
            // 
            // viewErrorLogsToolStripMenuItem
            // 
            this.viewErrorLogsToolStripMenuItem.Name = "viewErrorLogsToolStripMenuItem";
            this.viewErrorLogsToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewErrorLogsToolStripMenuItem.Text = "View";
            this.viewErrorLogsToolStripMenuItem.Click += new System.EventHandler(this.viewErrorLogsToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewErrorLogsToolStripMenuItem,
            this.clearErrorLogsToolStripMenuItem});
            this.logToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(36, 24);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // StatusStripEvents
            // 
            this.StatusStripEvents.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.StatusEventMessage});
            this.StatusStripEvents.Location = new System.Drawing.Point(0, 251);
            this.StatusStripEvents.Name = "StatusStripEvents";
            this.StatusStripEvents.Size = new System.Drawing.Size(485, 22);
            this.StatusStripEvents.SizingGrip = false;
            this.StatusStripEvents.TabIndex = 21;
            // 
            // lblStatusMessage
            // 
            this.lblStatusMessage.ForeColor = System.Drawing.Color.Green;
            this.lblStatusMessage.Name = "lblStatusMessage";
            this.lblStatusMessage.Size = new System.Drawing.Size(0, 17);
            this.lblStatusMessage.Visible = false;
            // 
            // StatusEventMessage
            // 
            this.StatusEventMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusEventMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusEventMessage.Name = "StatusEventMessage";
            this.StatusEventMessage.Size = new System.Drawing.Size(470, 17);
            this.StatusEventMessage.Spring = true;
            this.StatusEventMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusEventMessage.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(392, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(84, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fbdImages
            // 
            this.fbdImages.Description = "Please select the folder which contains the original image files:";
            this.fbdImages.ShowNewFolderButton = false;
            // 
            // lblOpt
            // 
            this.lblOpt.AutoSize = true;
            this.lblOpt.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt.Location = new System.Drawing.Point(189, 75);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(54, 14);
            this.lblOpt.TabIndex = 0;
            this.lblOpt.Text = "(optional)";
            // 
            // lblNewFolder
            // 
            this.lblNewFolder.AutoSize = true;
            this.lblNewFolder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFolder.Location = new System.Drawing.Point(6, 25);
            this.lblNewFolder.Name = "lblNewFolder";
            this.lblNewFolder.Size = new System.Drawing.Size(98, 15);
            this.lblNewFolder.TabIndex = 0;
            this.lblNewFolder.Text = "New Folder Name:";
            this.lblNewFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbFolderDetails
            // 
            this.gbFolderDetails.Controls.Add(this.chkInclSubfolders);
            this.gbFolderDetails.Controls.Add(this.lblOpt);
            this.gbFolderDetails.Controls.Add(this.lblNewFolder);
            this.gbFolderDetails.Controls.Add(this.txtNewFolder);
            this.gbFolderDetails.Controls.Add(this.lblFileSuffix);
            this.gbFolderDetails.Controls.Add(this.txtFileSuffix);
            this.gbFolderDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFolderDetails.Location = new System.Drawing.Point(221, 82);
            this.gbFolderDetails.Name = "gbFolderDetails";
            this.gbFolderDetails.Size = new System.Drawing.Size(249, 111);
            this.gbFolderDetails.TabIndex = 14;
            this.gbFolderDetails.TabStop = false;
            this.gbFolderDetails.Text = "Folder Details";
            // 
            // chkInclSubfolders
            // 
            this.chkInclSubfolders.AutoSize = true;
            this.chkInclSubfolders.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInclSubfolders.Location = new System.Drawing.Point(9, 81);
            this.chkInclSubfolders.Name = "chkInclSubfolders";
            this.chkInclSubfolders.Size = new System.Drawing.Size(115, 19);
            this.chkInclSubfolders.TabIndex = 8;
            this.chkInclSubfolders.Text = "Include Subfolders";
            this.chkInclSubfolders.UseVisualStyleBackColor = true;
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.Location = new System.Drawing.Point(110, 24);
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.Size = new System.Drawing.Size(133, 21);
            this.txtNewFolder.TabIndex = 6;
            this.txtNewFolder.Text = "Web_Images";
            this.txtNewFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewFolder_KeyPress);
            // 
            // lblFileSuffix
            // 
            this.lblFileSuffix.AutoSize = true;
            this.lblFileSuffix.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSuffix.Location = new System.Drawing.Point(6, 51);
            this.lblFileSuffix.Name = "lblFileSuffix";
            this.lblFileSuffix.Size = new System.Drawing.Size(90, 15);
            this.lblFileSuffix.TabIndex = 0;
            this.lblFileSuffix.Text = "File Name Suffix:";
            this.lblFileSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileSuffix
            // 
            this.txtFileSuffix.Location = new System.Drawing.Point(111, 51);
            this.txtFileSuffix.Name = "txtFileSuffix";
            this.txtFileSuffix.Size = new System.Drawing.Size(132, 21);
            this.txtFileSuffix.TabIndex = 7;
            this.txtFileSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileSuffix_KeyPress);
            // 
            // pbMain
            // 
            this.pbMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbMain.Location = new System.Drawing.Point(194, 213);
            this.pbMain.Maximum = 0;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(278, 23);
            this.pbMain.Step = 1;
            this.pbMain.TabIndex = 13;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(12, 40);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(66, 13);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "Folder Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(409, 54);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 23);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(15, 213);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(96, 213);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 23);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "Create Images";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtImageFolderPath
            // 
            this.txtImageFolderPath.Location = new System.Drawing.Point(15, 56);
            this.txtImageFolderPath.Name = "txtImageFolderPath";
            this.txtImageFolderPath.Size = new System.Drawing.Size(388, 20);
            this.txtImageFolderPath.TabIndex = 1;
            this.txtImageFolderPath.TextChanged += new System.EventHandler(this.txtImageFolderPath_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(10, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(216, 30);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Web Image Creator";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(6, 81);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(124, 13);
            this.lblQuality.TabIndex = 0;
            this.lblQuality.Text = "JPG Quality Percentage:";
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.AutoPopDelay = 999999;
            this.HelpToolTip.InitialDelay = 100;
            this.HelpToolTip.IsBalloon = true;
            this.HelpToolTip.ReshowDelay = 100;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(6, 52);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeight.Size = new System.Drawing.Size(65, 13);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Max Height:";
            this.lblHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbImageDetails
            // 
            this.gbImageDetails.Controls.Add(this.lQuality);
            this.gbImageDetails.Controls.Add(this.lWidth);
            this.gbImageDetails.Controls.Add(this.lHeight);
            this.gbImageDetails.Controls.Add(this.lblQuality);
            this.gbImageDetails.Controls.Add(this.lblHeight);
            this.gbImageDetails.Controls.Add(this.lblWidth);
            this.gbImageDetails.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImageDetails.Location = new System.Drawing.Point(15, 82);
            this.gbImageDetails.Name = "gbImageDetails";
            this.gbImageDetails.Size = new System.Drawing.Size(200, 111);
            this.gbImageDetails.TabIndex = 22;
            this.gbImageDetails.TabStop = false;
            this.gbImageDetails.Text = "Image Details";
            // 
            // lQuality
            // 
            this.lQuality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lQuality.Location = new System.Drawing.Point(136, 79);
            this.lQuality.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lQuality.Name = "lQuality";
            this.lQuality.Size = new System.Drawing.Size(58, 21);
            this.lQuality.TabIndex = 5;
            this.lQuality.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // lWidth
            // 
            this.lWidth.Location = new System.Drawing.Point(77, 24);
            this.lWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.lWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(117, 21);
            this.lWidth.TabIndex = 3;
            this.lWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // lHeight
            // 
            this.lHeight.Location = new System.Drawing.Point(77, 50);
            this.lHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.lHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(117, 21);
            this.lHeight.TabIndex = 4;
            this.lHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 26);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(62, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Max Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 273);
            this.Controls.Add(this.lnkImageFolder);
            this.Controls.Add(this.StatusStripEvents);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbFolderDetails);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtImageFolderPath);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbImageDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(501, 311);
            this.MinimumSize = new System.Drawing.Size(501, 311);
            this.Name = "InputForm";
            this.Text = "Ryan Heigert - WIC";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.StatusStripEvents.ResumeLayout(false);
            this.StatusStripEvents.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFolderDetails.ResumeLayout(false);
            this.gbFolderDetails.PerformLayout();
            this.gbImageDetails.ResumeLayout(false);
            this.gbImageDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkImageFolder;
        
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearErrorLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.StatusStrip StatusStripEvents;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMessage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FolderBrowserDialog fbdImages;
        private System.Windows.Forms.Label lblOpt;
        private System.Windows.Forms.Label lblNewFolder;
        private System.Windows.Forms.GroupBox gbFolderDetails;
        private System.Windows.Forms.TextBox txtNewFolder;
        private System.Windows.Forms.Label lblFileSuffix;
        private System.Windows.Forms.TextBox txtFileSuffix;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtImageFolderPath;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.ToolTip HelpToolTip;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox gbImageDetails;
        private System.Windows.Forms.NumericUpDown lQuality;
        private System.Windows.Forms.NumericUpDown lWidth;
        private System.Windows.Forms.NumericUpDown lHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.CheckBox chkInclSubfolders;
        protected System.Windows.Forms.ToolStripStatusLabel StatusEventMessage;
    }
}