// Base code from:
// https://dev.to/rachelsoderberg/create-a-simple-web-scraper-in-c-1l1m
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebScraper {
    public partial class MainWindow : Form {
        private Scraper scraper;
        private readonly Connector connector = new Connector();

        public MainWindow() {
            InitializeComponent();
        }

        private async void ScrapeButton_Click(object sender, EventArgs e) {
            try {
                string siteUrl = urlTextbox.Text;
                string classname = classTextbox.Text;
                string keyword = keywordTextbox.Text;
                scraper = new Scraper(siteUrl, classname, keyword);
                await scraper.ScrapeWebsite();
                List<Entry> entries = scraper.entries;
                resultsBox.Clear();
                foreach (var entry in entries) {
                    resultsBox.AppendText($"{entry.Title} - {entry.Url}{Environment.NewLine}");
                }
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
        }
        private void InsertButton_Click(object sender, EventArgs e) {
            List<Entry> entries = scraper.entries;
            foreach (var entry in entries) {
                connector.Insert(entry.Title, entry.Url);
            }
        }

        private void PullButton_Click(object sender, EventArgs e) {
            List<Entry> entries = connector.Read();
            foreach (var entry in entries) {
                resultsBox.AppendText($"{entry.Title} - {entry.Url}{Environment.NewLine}");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            connector.Delete();
        }
    }
}
