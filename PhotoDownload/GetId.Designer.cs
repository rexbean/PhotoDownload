namespace PhotoDownload
{
    partial class GetIdForm
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
            this.FriendNumberLabel = new System.Windows.Forms.Label();
            this.FriendIDBox = new System.Windows.Forms.TextBox();
            this.GetidButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.AllFriendIdBox = new System.Windows.Forms.TextBox();
            this.ReadIdFromFIleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FriendNumberLabel
            // 
            this.FriendNumberLabel.AutoSize = true;
            this.FriendNumberLabel.Location = new System.Drawing.Point(151, 20);
            this.FriendNumberLabel.Name = "FriendNumberLabel";
            this.FriendNumberLabel.Size = new System.Drawing.Size(77, 12);
            this.FriendNumberLabel.TabIndex = 1;
            this.FriendNumberLabel.Text = "请输入好友id";
            // 
            // FriendIDBox
            // 
            this.FriendIDBox.Location = new System.Drawing.Point(142, 49);
            this.FriendIDBox.Name = "FriendIDBox";
            this.FriendIDBox.Size = new System.Drawing.Size(100, 21);
            this.FriendIDBox.TabIndex = 3;
            // 
            // GetidButton
            // 
            this.GetidButton.Location = new System.Drawing.Point(237, 101);
            this.GetidButton.Name = "GetidButton";
            this.GetidButton.Size = new System.Drawing.Size(75, 23);
            this.GetidButton.TabIndex = 4;
            this.GetidButton.Text = "获取id";
            this.GetidButton.UseVisualStyleBackColor = true;
            this.GetidButton.Click += new System.EventHandler(this.GetidButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(237, 191);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(75, 23);
            this.DownloadButton.TabIndex = 5;
            this.DownloadButton.Text = "下载照片";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // AllFriendIdBox
            // 
            this.AllFriendIdBox.Location = new System.Drawing.Point(42, 85);
            this.AllFriendIdBox.Multiline = true;
            this.AllFriendIdBox.Name = "AllFriendIdBox";
            this.AllFriendIdBox.ReadOnly = true;
            this.AllFriendIdBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AllFriendIdBox.Size = new System.Drawing.Size(171, 147);
            this.AllFriendIdBox.TabIndex = 6;
            // 
            // ReadIdFromFIleButton
            // 
            this.ReadIdFromFIleButton.Location = new System.Drawing.Point(237, 147);
            this.ReadIdFromFIleButton.Name = "ReadIdFromFIleButton";
            this.ReadIdFromFIleButton.Size = new System.Drawing.Size(75, 23);
            this.ReadIdFromFIleButton.TabIndex = 7;
            this.ReadIdFromFIleButton.Text = "读取Id";
            this.ReadIdFromFIleButton.UseVisualStyleBackColor = true;
            this.ReadIdFromFIleButton.Click += new System.EventHandler(this.ReadIdFromFileButton_Click);
            // 
            // GetIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.ReadIdFromFIleButton);
            this.Controls.Add(this.AllFriendIdBox);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.GetidButton);
            this.Controls.Add(this.FriendIDBox);
            this.Controls.Add(this.FriendNumberLabel);
            this.Name = "GetIdForm";
            this.Text = "获取id";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FriendNumberLabel;
        private System.Windows.Forms.TextBox FriendIDBox;
        private System.Windows.Forms.Button GetidButton;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button ReadIdFromFIleButton;
        protected System.Windows.Forms.TextBox AllFriendIdBox;
    }
}