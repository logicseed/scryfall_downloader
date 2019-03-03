namespace ScryfallDownloader
{
    partial class MainForm
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
            this.loadCardsButton = new System.Windows.Forms.Button();
            this.downloadCardsButton = new System.Windows.Forms.Button();
            this.loadedCardsLabel = new System.Windows.Forms.Label();
            this.downloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.downloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.parseBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.imageDirectoryButton = new System.Windows.Forms.Button();
            this.imageDirectoryLabel = new System.Windows.Forms.Label();
            this.cancelDownloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadCardsButton
            // 
            this.loadCardsButton.Location = new System.Drawing.Point(12, 45);
            this.loadCardsButton.Name = "loadCardsButton";
            this.loadCardsButton.Size = new System.Drawing.Size(112, 23);
            this.loadCardsButton.TabIndex = 0;
            this.loadCardsButton.Text = "Load Cards";
            this.loadCardsButton.UseVisualStyleBackColor = true;
            this.loadCardsButton.Click += new System.EventHandler(this.LoadCardsButton_Click);
            // 
            // downloadCardsButton
            // 
            this.downloadCardsButton.Enabled = false;
            this.downloadCardsButton.Location = new System.Drawing.Point(12, 75);
            this.downloadCardsButton.Name = "downloadCardsButton";
            this.downloadCardsButton.Size = new System.Drawing.Size(112, 23);
            this.downloadCardsButton.TabIndex = 1;
            this.downloadCardsButton.Text = "Download Cards";
            this.downloadCardsButton.UseVisualStyleBackColor = true;
            this.downloadCardsButton.Click += new System.EventHandler(this.DownloadCardsButton_Click);
            // 
            // loadedCardsLabel
            // 
            this.loadedCardsLabel.AutoSize = true;
            this.loadedCardsLabel.Location = new System.Drawing.Point(130, 50);
            this.loadedCardsLabel.Name = "loadedCardsLabel";
            this.loadedCardsLabel.Size = new System.Drawing.Size(88, 13);
            this.loadedCardsLabel.TabIndex = 2;
            this.loadedCardsLabel.Text = "No cards loaded.";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 105);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(518, 23);
            this.downloadProgressBar.TabIndex = 3;
            // 
            // downloadBackgroundWorker
            // 
            this.downloadBackgroundWorker.WorkerReportsProgress = true;
            this.downloadBackgroundWorker.WorkerSupportsCancellation = true;
            this.downloadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadBackgroundWorker_DoWork);
            this.downloadBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.DownloadBackgroundWorker_ProgressChanged);
            this.downloadBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DownloadBackgroundWorker_RunWorkerCompleted);
            // 
            // parseBackgroundWorker
            // 
            this.parseBackgroundWorker.WorkerReportsProgress = true;
            this.parseBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ParseBackgroundWorker_DoWork);
            this.parseBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ParseBackgroundWorker_ProgressChanged);
            this.parseBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ParseBackgroundWorker_RunWorkerCompleted);
            // 
            // imageDirectoryButton
            // 
            this.imageDirectoryButton.Location = new System.Drawing.Point(12, 16);
            this.imageDirectoryButton.Name = "imageDirectoryButton";
            this.imageDirectoryButton.Size = new System.Drawing.Size(112, 23);
            this.imageDirectoryButton.TabIndex = 4;
            this.imageDirectoryButton.Text = "Choose Folder";
            this.imageDirectoryButton.UseVisualStyleBackColor = true;
            this.imageDirectoryButton.Click += new System.EventHandler(this.ImageDirectoryButton_Click);
            // 
            // imageDirectoryLabel
            // 
            this.imageDirectoryLabel.AutoSize = true;
            this.imageDirectoryLabel.Location = new System.Drawing.Point(130, 21);
            this.imageDirectoryLabel.Name = "imageDirectoryLabel";
            this.imageDirectoryLabel.Size = new System.Drawing.Size(125, 13);
            this.imageDirectoryLabel.TabIndex = 5;
            this.imageDirectoryLabel.Text = "No image folder chosen..";
            // 
            // cancelDownloadButton
            // 
            this.cancelDownloadButton.Enabled = false;
            this.cancelDownloadButton.Location = new System.Drawing.Point(418, 75);
            this.cancelDownloadButton.Name = "cancelDownloadButton";
            this.cancelDownloadButton.Size = new System.Drawing.Size(112, 23);
            this.cancelDownloadButton.TabIndex = 6;
            this.cancelDownloadButton.Text = "Cancel Download";
            this.cancelDownloadButton.UseVisualStyleBackColor = true;
            this.cancelDownloadButton.Click += new System.EventHandler(this.CancelDownloadButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 141);
            this.Controls.Add(this.cancelDownloadButton);
            this.Controls.Add(this.imageDirectoryLabel);
            this.Controls.Add(this.imageDirectoryButton);
            this.Controls.Add(this.downloadProgressBar);
            this.Controls.Add(this.loadedCardsLabel);
            this.Controls.Add(this.downloadCardsButton);
            this.Controls.Add(this.loadCardsButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scryfall Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadCardsButton;
        private System.Windows.Forms.Button downloadCardsButton;
        private System.Windows.Forms.Label loadedCardsLabel;
        private System.Windows.Forms.ProgressBar downloadProgressBar;
        private System.ComponentModel.BackgroundWorker downloadBackgroundWorker;
        private System.ComponentModel.BackgroundWorker parseBackgroundWorker;
        private System.Windows.Forms.Button imageDirectoryButton;
        private System.Windows.Forms.Label imageDirectoryLabel;
        private System.Windows.Forms.Button cancelDownloadButton;
    }
}

