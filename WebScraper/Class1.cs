using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebScraper {
    public struct Entry {
        public Entry(string Url, string Title) {
            this.Url = Url;
            this.Title = Title;
        }

        public string Url { get; }
        public string Title { get; }
    }
}
