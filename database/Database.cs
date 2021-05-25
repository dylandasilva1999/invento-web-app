using System;
using System.Collections;
using MySql.Data.MySqlClient;

namespace invento_web_app
{
    class Database
    {
        private static string serverConfiguration = @"server=localhost;userid=root;password=;database=invento";
        public static string GetVersion()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            return con.ServerVersion;
        }

        public static ArrayList ReadItems()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "SELECT * FROM items";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            ArrayList records = new ArrayList();
            while (rdr.Read())
            {
                records.Add(Tuple.Create(rdr.GetString(0), rdr.GetInt32(1), rdr.GetString(0)));
            }

            con.Close();

            return records;
        }

    }
}