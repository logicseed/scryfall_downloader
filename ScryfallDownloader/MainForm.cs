using ScryfallJsonParser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScryfallDownloader
{
    public partial class MainForm : Form
    {
        private List<CardDTO> Cards { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadCardsButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var parser = new Parser();
                parser.ParseCards(openFileDialog.FileName);
                Cards = parser.Cards;
                loadedCardsLabel.Text = $"{Cards.Count} cards loaded..";
            }
        }

        private void DownloadCardsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
