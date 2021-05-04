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

                string readSql = "SELECT Name, HeadOfState FROM Country WHERE Continent = 'Oceania'";
                MySqlCommand cmd = new MySqlCommand(readSql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read()) {
                    Console.WriteLine(rdr[0] + " -- " + rdr[1]);
                }
                rdr.Close();

                string insertSql = "INSERT INTO Country (Name, HeadOfState, Continent) VALUES ('Disneyland', 'Mickey Mouse', 'North America')";
                cmd = new MySqlCommand(insertSql, conn);
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
