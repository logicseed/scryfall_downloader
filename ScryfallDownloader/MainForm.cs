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
        private List<CardDTO> Cards { get; set; }
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
                imageDirectoryButton.Enabled = false;
                loadCardsButton.Enabled = true;
            }
        }

        private void LoadCardsButton_Click(object sender, EventArgs e)
        {
            Cards = new List<CardDTO>();

            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                JsonFileName = openFileDialog.FileName;
                parseBackgroundWorker.RunWorkerAsync();
            }
        }

        private void DownloadCardsButton_Click(object sender, EventArgs e)
        {

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
                        var card = serializer.Deserialize<CardDTO>(reader);
                        Cards.Add(card);
                    }

                    if (Cards.Count % 13 == 0) Thread.Sleep(1);
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
            loadCardsButton.Enabled = false;
            downloadCardsButton.Enabled = true;
        }

        private void DownloadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void DownloadBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void DownloadBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        
    }
}
