namespace PhotoDownload
{
    partial class DownloadPhoto
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
            this.NowDownloadingIdLabel = new System.Windows.Forms.Label();
            this.DownloadedIdLabel = new System.Windows.Forms.Label();
            this.NowDownloadingIdBox = new System.Windows.Forms.TextBox();
            this.DownloadedIdBox = new System.Windows.Forms.TextBox();
            this.NowDownloadingFIleLabel = new System.Windows.Forms.Label();
            this.DownLoadedFileLabel = new System.Windows.Forms.Label();
            this.NowDownloadingFileBox = new System.Windows.Forms.TextBox();
            this.DownloadedFileBox = new System.Windows.Forms.TextBox();
            this.DownLoadButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.GetAlbumIdButton = new System.Windows.Forms.Button();
            this.ReadAlbumIdfromFileButton = new System.Windows.Forms.Button();
            this.ContinueDownloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NowDownloadingIdLabel
            // 
            this.NowDownloadingIdLabel.AutoSize = true;
            this.NowDownloadingIdLabel.Location = new System.Drawing.Point(30, 24);
            this.NowDownloadingIdLabel.Name = "NowDownloadingIdLabel";
            this.NowDownloadingIdLabel.Size = new System.Drawing.Size(53, 12);
            this.NowDownloadingIdLabel.TabIndex = 0;
            this.NowDownloadingIdLabel.Text = "正在下载";
            // 
            // DownloadedIdLabel
            // 
            this.DownloadedIdLabel.AutoSize = true;
            this.DownloadedIdLabel.Location = new System.Drawing.Point(30, 84);
            this.DownloadedIdLabel.Name = "DownloadedIdLabel";
            this.DownloadedIdLabel.Size = new System.Drawing.Size(41, 12);
            this.DownloadedIdLabel.TabIndex = 1;
            this.DownloadedIdLabel.Text = "已下载";
            // 
            // NowDownloadingIdBox
            // 
            this.NowDownloadingIdBox.Location = new System.Drawing.Point(32, 51);
            this.NowDownloadingIdBox.Name = "NowDownloadingIdBox";
            this.NowDownloadingIdBox.ReadOnly = true;
            this.NowDownloadingIdBox.Size = new System.Drawing.Size(100, 21);
            this.NowDownloadingIdBox.TabIndex = 2;
            // 
            // DownloadedIdBox
            // 
            this.DownloadedIdBox.Location = new System.Drawing.Point(32, 108);
            this.DownloadedIdBox.Multiline = true;
            this.DownloadedIdBox.Name = "DownloadedIdBox";
            this.DownloadedIdBox.ReadOnly = true;
            this.DownloadedIdBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DownloadedIdBox.Size = new System.Drawing.Size(100, 65);
            this.DownloadedIdBox.TabIndex = 3;
            // 
            // NowDownloadingFIleLabel
            // 
            this.NowDownloadingFIleLabel.AutoSize = true;
            this.NowDownloadingFIleLabel.Location = new System.Drawing.Point(172, 24);
            this.NowDownloadingFIleLabel.Name = "NowDownloadingFIleLabel";
            this.NowDownloadingFIleLabel.Size = new System.Drawing.Size(53, 12);
            this.NowDownloadingFIleLabel.TabIndex = 4;
            this.NowDownloadingFIleLabel.Text = "正在下载";
            // 
            // DownLoadedFileLabel
            // 
            this.DownLoadedFileLabel.AutoSize = true;
            this.DownLoadedFileLabel.Location = new System.Drawing.Point(172, 84);
            this.DownLoadedFileLabel.Name = "DownLoadedFileLabel";
            this.DownLoadedFileLabel.Size = new System.Drawing.Size(41, 12);
            this.DownLoadedFileLabel.TabIndex = 5;
            this.DownLoadedFileLabel.Text = "已下载";
            // 
            // NowDownloadingFileBox
            // 
            this.NowDownloadingFileBox.Location = new System.Drawing.Point(174, 51);
            this.NowDownloadingFileBox.Name = "NowDownloadingFileBox";
            this.NowDownloadingFileBox.ReadOnly = true;
            this.NowDownloadingFileBox.Size = new System.Drawing.Size(335, 21);
            this.NowDownloadingFileBox.TabIndex = 6;
            // 
            // DownloadedFileBox
            // 
            this.DownloadedFileBox.Location = new System.Drawing.Point(174, 108);
            this.DownloadedFileBox.Multiline = true;
            this.DownloadedFileBox.Name = "DownloadedFileBox";
            this.DownloadedFileBox.ReadOnly = true;
            this.DownloadedFileBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DownloadedFileBox.Size = new System.Drawing.Size(335, 65);
            this.DownloadedFileBox.TabIndex = 7;
            // 
            // DownLoadButton
            // 
            this.DownLoadButton.Location = new System.Drawing.Point(222, 214);
            this.DownLoadButton.Name = "DownLoadButton";
            this.DownLoadButton.Size = new System.Drawing.Size(75, 23);
            this.DownLoadButton.TabIndex = 8;
            this.DownLoadButton.Text = "开始下载";
            this.DownLoadButton.UseVisualStyleBackColor = true;
            this.DownLoadButton.Click += new System.EventHandler(this.DownLoadButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(316, 214);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "停止下载";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // GetAlbumIdButton
            // 
            this.GetAlbumIdButton.Location = new System.Drawing.Point(32, 214);
            this.GetAlbumIdButton.Name = "GetAlbumIdButton";
            this.GetAlbumIdButton.Size = new System.Drawing.Size(75, 23);
            this.GetAlbumIdButton.TabIndex = 10;
            this.GetAlbumIdButton.Text = "获取相册ID";
            this.GetAlbumIdButton.UseVisualStyleBackColor = true;
            this.GetAlbumIdButton.Click += new System.EventHandler(this.GetAlbumIdButton_Click);
            // 
            // ReadAlbumIdfromFileButton
            // 
            this.ReadAlbumIdfromFileButton.Location = new System.Drawing.Point(124, 214);
            this.ReadAlbumIdfromFileButton.Name = "ReadAlbumIdfromFileButton";
            this.ReadAlbumIdfromFileButton.Size = new System.Drawing.Size(75, 23);
            this.ReadAlbumIdfromFileButton.TabIndex = 11;
            this.ReadAlbumIdfromFileButton.Text = "读取相册ID";
            this.ReadAlbumIdfromFileButton.UseVisualStyleBackColor = true;
            this.ReadAlbumIdfromFileButton.Click += new System.EventHandler(this.ReadAlbumIdfromFileButton_Click);
            // 
            // ContinueDownloadButton
            // 
            this.ContinueDownloadButton.Location = new System.Drawing.Point(407, 214);
            this.ContinueDownloadButton.Name = "ContinueDownloadButton";
            this.ContinueDownloadButton.Size = new System.Drawing.Size(75, 23);
            this.ContinueDownloadButton.TabIndex = 12;
            this.ContinueDownloadButton.Text = "继续下载";
            this.ContinueDownloadButton.UseVisualStyleBackColor = true;
            this.ContinueDownloadButton.Click += new System.EventHandler(this.ContinueDownloadButton_Click);
            // 
            // DownloadPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 262);
            this.Controls.Add(this.ContinueDownloadButton);
            this.Controls.Add(this.ReadAlbumIdfromFileButton);
            this.Controls.Add(this.GetAlbumIdButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.DownLoadButton);
            this.Controls.Add(this.DownloadedFileBox);
            this.Controls.Add(this.NowDownloadingFileBox);
            this.Controls.Add(this.DownLoadedFileLabel);
            this.Controls.Add(this.NowDownloadingFIleLabel);
            this.Controls.Add(this.DownloadedIdBox);
            this.Controls.Add(this.NowDownloadingIdBox);
            this.Controls.Add(this.DownloadedIdLabel);
            this.Controls.Add(this.NowDownloadingIdLabel);
            this.Name = "DownloadPhoto";
            this.Text = "DownloadPhoto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowDownloadingIdLabel;
        private System.Windows.Forms.Label DownloadedIdLabel;
        private System.Windows.Forms.TextBox NowDownloadingIdBox;
        private System.Windows.Forms.TextBox DownloadedIdBox;
        private System.Windows.Forms.Label NowDownloadingFIleLabel;
        private System.Windows.Forms.Label DownLoadedFileLabel;
        private System.Windows.Forms.TextBox NowDownloadingFileBox;
        private System.Windows.Forms.TextBox DownloadedFileBox;
        private System.Windows.Forms.Button DownLoadButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button GetAlbumIdButton;
        private System.Windows.Forms.Button ReadAlbumIdfromFileButton;
        private System.Windows.Forms.Button ContinueDownloadButton;
    }
}