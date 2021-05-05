﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;

namespace WebScraper {
    class Scraper {
        public struct Entry {
            public Entry(string Url, string Title) {
                this.Url = Url;
                this.Title = Title;
            }

            public string Url { get; }
            public string Title { get; }
        }

        private List<Entry> entries = new List<Entry>();
        private string siteUrl = "https://www.oceannetworks.ca/news/stories";
        private string[] QueryTerms { get; } = { "Ocean", "Nature", "Pollution" };
        private readonly Connector connector = new Connector();

        public async void ScrapeWebsite() {
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
                    StoreResults(articleLink);
                }
            }
        }

        public void StoreResults(IEnumerable<IElement> articleLink) {
            foreach (var element in articleLink) {
                Entry entry = CleanUpResults(element);
                entries.Add(entry);
            }
        }

        private Entry CleanUpResults(IElement results) {
            string htmlResult = results.InnerHtml.ReplaceFirst("    <span class=\"field-content\"><div><a href=\"", "https://www.oceannetworks.ca");
            htmlResult = htmlResult.ReplaceFirst("\">", "*");
            htmlResult = htmlResult.ReplaceFirst("</a></div>\n<div class=\"article-title-top\">", "-");
            htmlResult = htmlResult.ReplaceFirst("</div>\n<hr></span> ", "");

            return SplitResults(htmlResult);
        }

        private Entry SplitResults(string htmlResult) {
            string[] splitResults = htmlResult.Split('*');
            string Url = splitResults[0];
            string Title = splitResults[1];
            Entry entry = new Entry(Url, Title);
            return entry;
        }
    }
}
