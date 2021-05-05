// Base code from:
// https://dev.to/rachelsoderberg/create-a-simple-web-scraper-in-c-1l1m
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WebScraper {
    public partial class MainWindow : Form {
        private readonly Scraper scraper = new Scraper();
        private readonly Connector connector = new Connector();

        public MainWindow() {
            InitializeComponent();
        }

        private void scrapeButton_Click(object sender, EventArgs e) {
            scraper.ScrapeWebsite();
            List<Entry> entries = scraper.entries;
            foreach (var entry in entries) {
                rtb_debugDisplay.AppendText($"{entry.Title} - {entry.Url}{Environment.NewLine}");
            }
        }
        private void insertButton_Click(object sender, EventArgs e) {
            connector.Read();
        }

        private void pullButton_Click(object sender, EventArgs e) {
            connector.Read();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            connector.Delete();
        }
    }
}
