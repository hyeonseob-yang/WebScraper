using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using AngleSharp.Text;

namespace WebScraper {
    class Scraper {
        public List<Entry> entries { get; } = new List<Entry>();
        private readonly string siteUrl;
        private readonly string baseUrl;
        private readonly string classname;
        private readonly string keyword1;

        private string Getkeyword() {
            return keyword1;
        }

        public Scraper(string siteUrl, string baseUrl, string classname, string keyword) {
            this.siteUrl = siteUrl;
            this.baseUrl = baseUrl;
            this.classname = classname;
            this.keyword1 = keyword;
        }

        public async Task ScrapeWebsite() {
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

            articleLink = document.All.Where(x => x.ClassName == classname
                && (x.ParentElement.InnerHtml.Contains(Getkeyword())
                || x.ParentElement.InnerHtml.Contains(Getkeyword().ToLower())));

            if (articleLink.Any()) {
                StoreResults(articleLink);
            }
        }

        public void StoreResults(IEnumerable<IElement> articleLink) {
            foreach (var element in articleLink) {
                Entry entry = CleanUpResults(element);
                entries.Add(entry);
            }
        }

        private Entry CleanUpResults(IElement results) {
            string htmlResult = results.InnerHtml;
            string searchValue = "href=\"";
            htmlResult = htmlResult.Substring(htmlResult.IndexOf(searchValue) + searchValue.Length);
            htmlResult = htmlResult.Insert(0, baseUrl);
            htmlResult = htmlResult.ReplaceFirst("\">", "*");
            searchValue = "</a>";
            if (htmlResult.IndexOf(searchValue) > 0) {
                htmlResult = htmlResult.Substring(0, htmlResult.IndexOf(searchValue));
            }

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
