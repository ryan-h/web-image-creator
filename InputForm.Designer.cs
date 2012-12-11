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
            this.lnkImageFolder.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImageFolder.Location = new System.Drawing.Point(436, 226);
            this.lnkImageFolder.Name = "lnkImageFolder";
            this.lnkImageFolder.Size = new System.Drawing.Size(114, 15);
            this.lnkImageFolder.TabIndex = 11;
            this.lnkImageFolder.TabStop = true;
            this.lnkImageFolder.Text = "Open Images Folder";
            this.lnkImageFolder.Visible = false;
            this.lnkImageFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImageFolder_LinkClicked);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearErrorLogsToolStripMenuItem
            // 
            this.clearErrorLogsToolStripMenuItem.Name = "clearErrorLogsToolStripMenuItem";
            this.clearErrorLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearErrorLogsToolStripMenuItem.Text = "Clear";
            this.clearErrorLogsToolStripMenuItem.Click += new System.EventHandler(this.clearErrorLogsToolStripMenuItem_Click);
            // 
            // viewErrorLogsToolStripMenuItem
            // 
            this.viewErrorLogsToolStripMenuItem.Name = "viewErrorLogsToolStripMenuItem";
            this.viewErrorLogsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewErrorLogsToolStripMenuItem.Text = "View";
            this.viewErrorLogsToolStripMenuItem.Click += new System.EventHandler(this.viewErrorLogsToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewErrorLogsToolStripMenuItem,
            this.clearErrorLogsToolStripMenuItem});
            this.logToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // StatusStripEvents
            // 
            this.StatusStripEvents.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusStripEvents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMessage,
            this.StatusEventMessage});
            this.StatusStripEvents.Location = new System.Drawing.Point(0, 293);
            this.StatusStripEvents.Name = "StatusStripEvents";
            this.StatusStripEvents.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStripEvents.Size = new System.Drawing.Size(566, 22);
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
            this.StatusEventMessage.Size = new System.Drawing.Size(549, 17);
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
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(453, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(95, 24);
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
            this.lblOpt.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpt.Location = new System.Drawing.Point(219, 86);
            this.lblOpt.Name = "lblOpt";
            this.lblOpt.Size = new System.Drawing.Size(64, 15);
            this.lblOpt.TabIndex = 0;
            this.lblOpt.Text = "(optional)";
            // 
            // lblNewFolder
            // 
            this.lblNewFolder.AutoSize = true;
            this.lblNewFolder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewFolder.Location = new System.Drawing.Point(7, 31);
            this.lblNewFolder.Name = "lblNewFolder";
            this.lblNewFolder.Size = new System.Drawing.Size(121, 17);
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
            this.gbFolderDetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFolderDetails.Location = new System.Drawing.Point(258, 95);
            this.gbFolderDetails.Name = "gbFolderDetails";
            this.gbFolderDetails.Size = new System.Drawing.Size(290, 128);
            this.gbFolderDetails.TabIndex = 14;
            this.gbFolderDetails.TabStop = false;
            this.gbFolderDetails.Text = "Folder Details";
            // 
            // chkInclSubfolders
            // 
            this.chkInclSubfolders.AutoSize = true;
            this.chkInclSubfolders.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInclSubfolders.Location = new System.Drawing.Point(10, 93);
            this.chkInclSubfolders.Name = "chkInclSubfolders";
            this.chkInclSubfolders.Size = new System.Drawing.Size(136, 21);
            this.chkInclSubfolders.TabIndex = 8;
            this.chkInclSubfolders.Text = "Include Subfolders";
            this.chkInclSubfolders.UseVisualStyleBackColor = true;
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewFolder.Location = new System.Drawing.Point(128, 28);
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.Size = new System.Drawing.Size(155, 25);
            this.txtNewFolder.TabIndex = 6;
            this.txtNewFolder.Text = "Web_Images";
            this.txtNewFolder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewFolder_KeyPress);
            // 
            // lblFileSuffix
            // 
            this.lblFileSuffix.AutoSize = true;
            this.lblFileSuffix.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSuffix.Location = new System.Drawing.Point(7, 62);
            this.lblFileSuffix.Name = "lblFileSuffix";
            this.lblFileSuffix.Size = new System.Drawing.Size(111, 17);
            this.lblFileSuffix.TabIndex = 0;
            this.lblFileSuffix.Text = "File Name Suffix:";
            this.lblFileSuffix.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileSuffix
            // 
            this.txtFileSuffix.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileSuffix.Location = new System.Drawing.Point(128, 58);
            this.txtFileSuffix.Name = "txtFileSuffix";
            this.txtFileSuffix.Size = new System.Drawing.Size(155, 25);
            this.txtFileSuffix.TabIndex = 7;
            this.txtFileSuffix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFileSuffix_KeyPress);
            // 
            // pbMain
            // 
            this.pbMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbMain.Location = new System.Drawing.Point(220, 246);
            this.pbMain.Maximum = 0;
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(330, 27);
            this.pbMain.Step = 1;
            this.pbMain.TabIndex = 13;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(14, 45);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(79, 17);
            this.lblPath.TabIndex = 12;
            this.lblPath.Text = "Folder Path:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(478, 63);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(70, 27);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(17, 246);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(108, 246);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(105, 27);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create Images";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtImageFolderPath
            // 
            this.txtImageFolderPath.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImageFolderPath.Location = new System.Drawing.Point(17, 65);
            this.txtImageFolderPath.Name = "txtImageFolderPath";
            this.txtImageFolderPath.Size = new System.Drawing.Size(454, 25);
            this.txtImageFolderPath.TabIndex = 1;
            this.txtImageFolderPath.TextChanged += new System.EventHandler(this.txtImageFolderPath_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 31);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Web Image Creator";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(7, 94);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(153, 17);
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
            this.lblHeight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(7, 62);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHeight.Size = new System.Drawing.Size(81, 17);
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
            this.gbImageDetails.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImageDetails.Location = new System.Drawing.Point(17, 95);
            this.gbImageDetails.Name = "gbImageDetails";
            this.gbImageDetails.Size = new System.Drawing.Size(233, 128);
            this.gbImageDetails.TabIndex = 22;
            this.gbImageDetails.TabStop = false;
            this.gbImageDetails.Text = "Image Details";
            // 
            // lQuality
            // 
            this.lQuality.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuality.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lQuality.Location = new System.Drawing.Point(165, 92);
            this.lQuality.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lQuality.Name = "lQuality";
            this.lQuality.Size = new System.Drawing.Size(55, 25);
            this.lQuality.TabIndex = 5;
            this.lQuality.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // lWidth
            // 
            this.lWidth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWidth.Location = new System.Drawing.Point(90, 29);
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
            this.lWidth.Size = new System.Drawing.Size(130, 25);
            this.lWidth.TabIndex = 3;
            this.lWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // lHeight
            // 
            this.lHeight.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeight.Location = new System.Drawing.Point(90, 58);
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
            this.lHeight.Size = new System.Drawing.Size(130, 25);
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
            this.lblWidth.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(6, 31);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(76, 17);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Max Width:";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 315);
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
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(582, 353);
            this.MinimumSize = new System.Drawing.Size(582, 353);
            this.Name = "InputForm";
            this.Text = "WIC";
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