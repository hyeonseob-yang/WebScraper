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
                scraper = new Scraper(siteUrl, classname);
                await scraper.ScrapeWebsite();
                List<Entry> entries = scraper.entries;
                foreach (var entry in entries) {
                    rtb_debugDisplay.AppendText($"{entry.Title} - {entry.Url}{Environment.NewLine}");
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
            connector.Read();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            connector.Delete();
        }
    }
}
