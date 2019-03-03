using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ScryfallDownloader
{
    public partial class MainForm : Form
    {
        private string ImageDirectory { get; set; }
        private string JsonFileName { get; set; }

        private List<Card> Cards { get; set; }
        private int DownloadCount { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ImageDirectoryButton_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                ImageDirectory = folderBrowserDialog.SelectedPath;
                imageDirectoryLabel.Text = ImageDirectory;
                loadCardsButton.Enabled = true;
            }
        }

        private void LoadCardsButton_Click(object sender, EventArgs e)
        {
            Cards = new List<Card>();

            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                JsonFileName = openFileDialog.FileName;
                parseBackgroundWorker.RunWorkerAsync();
            }
        }

        private void DownloadCardsButton_Click(object sender, EventArgs e)
        {
            imageDirectoryButton.Enabled = false;
            loadCardsButton.Enabled = false;
            downloadCardsButton.Enabled = false;
            cancelDownloadButton.Enabled = true;
            downloadBackgroundWorker.RunWorkerAsync();
        }

        private void CancelDownloadButton_Click(object sender, EventArgs e)
        {
            imageDirectoryButton.Enabled = true;
            loadCardsButton.Enabled = true;
            downloadCardsButton.Enabled = true;
            cancelDownloadButton.Enabled = false;
            downloadBackgroundWorker.CancelAsync();
        }

        private void ParseBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var stream = new StreamReader(JsonFileName))
            using (var reader = new JsonTextReader(stream))
            {
                // TODO: implement progress indicator
                var serializer = new JsonSerializer();
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        var cardDTO = serializer.Deserialize<CardDTO>(reader);
                        Cards.Add(new Card(cardDTO));
                    }

                    if (Cards.Count % 21 == 0) Thread.Sleep(1);
                    parseBackgroundWorker.ReportProgress(0);
                }
            }
        }

        private void ParseBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadedCardsLabel.Text = $"{Cards.Count} cards loaded..";
        }

        private void ParseBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            downloadCardsButton.Enabled = true;
        }

        private void DownloadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            foreach (var card in Cards)
            {
                // Determine directory
                // Does directory exist?
                    // No
                        // Create directory

                // Does it have faces?
                    // Yes
                        // For each face
                            // Determine filename
                            // Download image
                    // No
                        // Determine filename
                        // Downlaod image
                // Increment download count
                // Report progress
            }

            for (int i = 0; i < 100; i++)
            {
                if (downloadBackgroundWorker.CancellationPending) break;
                Thread.Sleep(500);
                downloadBackgroundWorker.ReportProgress(i);
            }
        }

        private void DownloadBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            downloadProgressBar.Value = e.ProgressPercentage;
        }

        private void DownloadBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (DownloadCount != Cards.Count)
            {
                downloadProgressBar.Value = 0;
                MessageBox.Show("Your image download was cancelled.", "Download Cancelled", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Your image download is complete.", "Download Complete", MessageBoxButtons.OK);
            }
        }
    }
}
