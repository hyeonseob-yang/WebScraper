using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WebScraper {
    class Connector {
        public static void Connect() {
            string connStr = "server=localhost;user=root;database=world;port=3306;password=test";
            MySqlConnection conn = new MySqlConnection(connStr);
            try {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
