// Base code from:
// https://dev.to/rachelsoderberg/create-a-simple-web-scraper-in-c-1l1m
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;

namespace WebScraper {
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private string Title { get; set; }
        private string Url { get; set; }
        private string siteUrl = "https://www.oceannetworks.ca/news/stories";
        private string[] QueryTerms { get; } = { "Ocean", "Nature", "Pollution" };
        private Connector connector = new Connector();
        
        internal async void ScrapeWebsite() {
            CancellationTokenSource cancellationToken = new CancellationTokenSource();
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage request = await httpClient.GetAsync(siteUrl);
            cancellationToken.Token.ThrowIfCancellationRequested();

            Stream response = await request.Content.ReadAsStreamAsync();
            cancellationToken.Token.ThrowIfCancellationRequested();

            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(response);

            GetScrapeResults(document);
        }

        private void GetScrapeResults(IHtmlDocument document) {
            IEnumerable<IElement> articleLink;

            foreach (var term in QueryTerms) {
                articleLink = document.All.Where(x => x.ClassName == "views-field views-field-nothing"
                && (x.ParentElement.InnerHtml.Contains(term)
                || x.ParentElement.InnerHtml.Contains(term.ToLower()))).Skip(1);

                if (articleLink.Any()) {
                    PrintResults(articleLink);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            ScrapeWebsite();
        }

        private void button2_Click(object sender, EventArgs e) {
            connector.Read();
        }

        private void button3_Click(object sender, EventArgs e) {
            connector.Read();
        }

        private void button4_Click(object sender, EventArgs e) {
            connector.Read();
        }

        public void PrintResults(IEnumerable<IElement> articleLink) {
            foreach (var element in articleLink) {
                CleanUpResults(element);
                rtb_debugDisplay.AppendText($"{Title} - {Url}{Environment.NewLine}");
                connector.Insert(Title, Url);
            }
        }

        private void CleanUpResults(IElement results) {
            string htmlResult = results.InnerHtml.ReplaceFirst("    <span class=\"field-content\"><div><a href=\"", "https://www.oceannetworks.ca");
            htmlResult = htmlResult.ReplaceFirst("\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a></div>\n<div class=\"article-title-top\">", "-");
            htmlResult = htmlResult.ReplaceFirst("</div>\n<hr></span> ", "");

            SplitResults(htmlResult);
        }

        private void SplitResults(string htmlResult) {
            string[] splitResults = htmlResult.Split('*');
            Url = splitResults[0];
            Title = splitResults[1];
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
}
