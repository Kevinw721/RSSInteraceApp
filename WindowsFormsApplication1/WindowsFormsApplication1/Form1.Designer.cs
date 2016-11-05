namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pullXML = new System.Windows.Forms.Button();
            this.ApiLinkCommands = new System.Windows.Forms.TextBox();
            this.FormatXML = new System.Windows.Forms.Button();
            this.LocalXMLPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SetImageFolder = new System.Windows.Forms.Button();
            this.ImageFolderPathDisplay = new System.Windows.Forms.Label();
            this.PullStatus = new System.Windows.Forms.Label();
            this.localFilePathDisplay = new System.Windows.Forms.Label();
            this.timeLeftLabel = new System.Windows.Forms.Label();
            this.timerRefreshButton = new System.Windows.Forms.Button();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StartPullTimerButton = new System.Windows.Forms.Button();
            this.progressBarTillPull = new System.Windows.Forms.ProgressBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pullXML
            // 
            this.pullXML.Location = new System.Drawing.Point(28, 31);
            this.pullXML.Name = "pullXML";
            this.pullXML.Size = new System.Drawing.Size(137, 43);
            this.pullXML.TabIndex = 0;
            this.pullXML.Text = "Pull XML";
            this.pullXML.UseVisualStyleBackColor = true;
            this.pullXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // ApiLinkCommands
            // 
            this.ApiLinkCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApiLinkCommands.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ApiLinkCommands.Location = new System.Drawing.Point(35, 178);
            this.ApiLinkCommands.Name = "ApiLinkCommands";
            this.ApiLinkCommands.Size = new System.Drawing.Size(355, 21);
            this.ApiLinkCommands.TabIndex = 2;
            // 
            // FormatXML
            // 
            this.FormatXML.Location = new System.Drawing.Point(171, 31);
            this.FormatXML.Name = "FormatXML";
            this.FormatXML.Size = new System.Drawing.Size(137, 43);
            this.FormatXML.TabIndex = 3;
            this.FormatXML.Text = "Format XML";
            this.FormatXML.UseVisualStyleBackColor = true;
            this.FormatXML.Click += new System.EventHandler(this.FormatXML_Click);
            // 
            // LocalXMLPath
            // 
            this.LocalXMLPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LocalXMLPath.Location = new System.Drawing.Point(6, 6);
            this.LocalXMLPath.Name = "LocalXMLPath";
            this.LocalXMLPath.Size = new System.Drawing.Size(162, 23);
            this.LocalXMLPath.TabIndex = 4;
            this.LocalXMLPath.Text = "Set Local XML Path";
            this.LocalXMLPath.UseVisualStyleBackColor = true;
            this.LocalXMLPath.Click += new System.EventHandler(this.LocalXMLPath_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(120, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Additional API Link Commands";
            // 
            // SetImageFolder
            // 
            this.SetImageFolder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SetImageFolder.Location = new System.Drawing.Point(6, 72);
            this.SetImageFolder.Name = "SetImageFolder";
            this.SetImageFolder.Size = new System.Drawing.Size(166, 23);
            this.SetImageFolder.TabIndex = 7;
            this.SetImageFolder.Text = "Set Image Folder";
            this.SetImageFolder.UseVisualStyleBackColor = true;
            this.SetImageFolder.Click += new System.EventHandler(this.SetImageFolder_Click);
            // 
            // ImageFolderPathDisplay
            // 
            this.ImageFolderPathDisplay.AutoSize = true;
            this.ImageFolderPathDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImageFolderPathDisplay.Location = new System.Drawing.Point(3, 108);
            this.ImageFolderPathDisplay.Name = "ImageFolderPathDisplay";
            this.ImageFolderPathDisplay.Size = new System.Drawing.Size(78, 13);
            this.ImageFolderPathDisplay.TabIndex = 8;
            this.ImageFolderPathDisplay.Text = "ImagePath";
            this.ImageFolderPathDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PullStatus
            // 
            this.PullStatus.AutoSize = true;
            this.PullStatus.Location = new System.Drawing.Point(25, 173);
            this.PullStatus.Name = "PullStatus";
            this.PullStatus.Size = new System.Drawing.Size(76, 13);
            this.PullStatus.TabIndex = 9;
            this.PullStatus.Text = "Pull Status";
            // 
            // localFilePathDisplay
            // 
            this.localFilePathDisplay.AutoSize = true;
            this.localFilePathDisplay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.localFilePathDisplay.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.localFilePathDisplay.Location = new System.Drawing.Point(3, 43);
            this.localFilePathDisplay.Name = "localFilePathDisplay";
            this.localFilePathDisplay.Size = new System.Drawing.Size(139, 13);
            this.localFilePathDisplay.TabIndex = 12;
            this.localFilePathDisplay.Text = "localFilePathDisplay";
            // 
            // timeLeftLabel
            // 
            this.timeLeftLabel.AutoSize = true;
            this.timeLeftLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLabel.Location = new System.Drawing.Point(37, 89);
            this.timeLeftLabel.Name = "timeLeftLabel";
            this.timeLeftLabel.Size = new System.Drawing.Size(118, 25);
            this.timeLeftLabel.TabIndex = 13;
            this.timeLeftLabel.Text = "00:05:00";
            this.timeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefreshButton
            // 
            this.timerRefreshButton.Location = new System.Drawing.Point(171, 89);
            this.timerRefreshButton.Name = "timerRefreshButton";
            this.timerRefreshButton.Size = new System.Drawing.Size(137, 25);
            this.timerRefreshButton.TabIndex = 14;
            this.timerRefreshButton.Text = "Refresh Pull Timer";
            this.timerRefreshButton.UseVisualStyleBackColor = true;
            this.timerRefreshButton.Click += new System.EventHandler(this.timerRefreshButton_Click);
            // 
            // mainTab
            // 
            this.mainTab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.mainTab.Controls.Add(this.tabPage1);
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(0, 0);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(480, 251);
            this.mainTab.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage1.Controls.Add(this.StartPullTimerButton);
            this.tabPage1.Controls.Add(this.progressBarTillPull);
            this.tabPage1.Controls.Add(this.pullXML);
            this.tabPage1.Controls.Add(this.FormatXML);
            this.tabPage1.Controls.Add(this.timerRefreshButton);
            this.tabPage1.Controls.Add(this.timeLeftLabel);
            this.tabPage1.Controls.Add(this.PullStatus);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // StartPullTimerButton
            // 
            this.StartPullTimerButton.Location = new System.Drawing.Point(314, 31);
            this.StartPullTimerButton.Name = "StartPullTimerButton";
            this.StartPullTimerButton.Size = new System.Drawing.Size(132, 43);
            this.StartPullTimerButton.TabIndex = 16;
            this.StartPullTimerButton.Text = "Start Pull Timer";
            this.StartPullTimerButton.UseVisualStyleBackColor = true;
            this.StartPullTimerButton.Click += new System.EventHandler(this.StartPullTimerButton_Click);
            // 
            // progressBarTillPull
            // 
            this.progressBarTillPull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarTillPull.Location = new System.Drawing.Point(28, 147);
            this.progressBarTillPull.Name = "progressBarTillPull";
            this.progressBarTillPull.Size = new System.Drawing.Size(417, 23);
            this.progressBarTillPull.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTillPull.TabIndex = 15;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Controls.Add(this.LocalXMLPath);
            this.tabPage2.Controls.Add(this.localFilePathDisplay);
            this.tabPage2.Controls.Add(this.ApiLinkCommands);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ImageFolderPathDisplay);
            this.tabPage2.Controls.Add(this.SetImageFolder);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 222);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(480, 251);
            this.Controls.Add(this.mainTab);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(488, 278);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AP Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pullXML;
        private System.Windows.Forms.TextBox ApiLinkCommands;
        private System.Windows.Forms.Button FormatXML;
        private System.Windows.Forms.Button LocalXMLPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetImageFolder;
        private System.Windows.Forms.Label ImageFolderPathDisplay;
        private System.Windows.Forms.Label PullStatus;
        private System.Windows.Forms.Label localFilePathDisplay;
        private System.Windows.Forms.Label timeLeftLabel;
        private System.Windows.Forms.Button timerRefreshButton;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBarTillPull;
        private System.Windows.Forms.Button StartPullTimerButton;
    }
}

