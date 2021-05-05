using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebScraper {
    class Connector {
        private MySqlConnection conn { get; set; }

        public Connector() {
            string connStr = "server=localhost;user=root;database=web_scraper;port=3306;password=test";
            conn = new MySqlConnection(connStr);
            try {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            
        }

        public void Insert(string title, string url) {
            try {
                string formattedTitle = title.Replace("'", "''");
                string insertSql = $"INSERT INTO articles (title, url) VALUES ('{formattedTitle}', '{url}')";
                MySqlCommand cmd = new MySqlCommand(insertSql, conn);
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public List<Entry> GetEntries() {
            List<Entry> entries = new List<Entry>();
            try {
                string readSql = "SELECT * FROM articles";
                MySqlCommand cmd = new MySqlCommand(readSql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    string title = (string) rdr[1];
                    string url = (string) rdr[2];
                    Entry entry = new Entry(url, title);
                    entries.Add(entry);
                }
                rdr.Close();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            return entries;
        }

        public void Delete() {
            try {
                string deleteSql = "DELETE FROM articles WHERE id > 1";
                MySqlCommand cmd = new MySqlCommand(deleteSql, conn);
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
        }

        public void Close() {
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
