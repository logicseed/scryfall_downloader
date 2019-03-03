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
            this.SuspendLayout();
            // 
            // loadCardsButton
            // 
            this.loadCardsButton.Location = new System.Drawing.Point(12, 12);
            this.loadCardsButton.Name = "loadCardsButton";
            this.loadCardsButton.Size = new System.Drawing.Size(112, 23);
            this.loadCardsButton.TabIndex = 0;
            this.loadCardsButton.Text = "Load Cards";
            this.loadCardsButton.UseVisualStyleBackColor = true;
            this.loadCardsButton.Click += new System.EventHandler(this.LoadCardsButton_Click);
            // 
            // downloadCardsButton
            // 
            this.downloadCardsButton.Location = new System.Drawing.Point(12, 42);
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
            this.loadedCardsLabel.Location = new System.Drawing.Point(130, 17);
            this.loadedCardsLabel.Name = "loadedCardsLabel";
            this.loadedCardsLabel.Size = new System.Drawing.Size(88, 13);
            this.loadedCardsLabel.TabIndex = 2;
            this.loadedCardsLabel.Text = "No cards loaded.";
            // 
            // downloadProgressBar
            // 
            this.downloadProgressBar.Location = new System.Drawing.Point(12, 72);
            this.downloadProgressBar.Name = "downloadProgressBar";
            this.downloadProgressBar.Size = new System.Drawing.Size(228, 23);
            this.downloadProgressBar.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 105);
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
    }
}

