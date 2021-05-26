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

        public static ArrayList ReadRecipes()
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "SELECT * FROM recipes";
            using var cmd = new MySqlCommand(sql, con);

            using MySqlDataReader rdr = cmd.ExecuteReader();

            ArrayList records = new ArrayList();
            while (rdr.Read())
            {
                records.Add(Tuple.Create(rdr.GetString(0), new string [3,3]
                {{rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)},
                {rdr.GetString(4), rdr.GetString(5), rdr.GetString(6)},
                {rdr.GetString(7), rdr.GetString(8), rdr.GetString(9)}}));
            }

            return records;
        }

        public static void AddRecipe(Recipe input)
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "INSERT INTO recipes (result, slot1, slot2, slot3, slot4, slot5, slot6, slot7, slot8, slot9} VALUES (@result,@i1,@i2,@i3,@i4,@i5,@i6,@i7,@i8,@i9)";
            using var cmd = new MySqlCommand(sql,con);

            cmd.Parameters.AddWithValue("@result", input.Result.BlockType);
            cmd.Parameters.AddWithValue("@i1", input.Inputs[0,0] == null?"":input.Inputs[0,0].BlockType);
            cmd.Parameters.AddWithValue("@i2", input.Inputs[0,1] == null?"":input.Inputs[0,1].BlockType);
            cmd.Parameters.AddWithValue("@i3", input.Inputs[0,2] == null?"":input.Inputs[0,2].BlockType);
            cmd.Parameters.AddWithValue("@i4", input.Inputs[1,0] == null?"":input.Inputs[1,0].BlockType);
            cmd.Parameters.AddWithValue("@i5", input.Inputs[1,1] == null?"":input.Inputs[1,1].BlockType);
            cmd.Parameters.AddWithValue("@i6", input.Inputs[1,2] == null?"":input.Inputs[1,2].BlockType);
            cmd.Parameters.AddWithValue("@i7", input.Inputs[2,0] == null?"":input.Inputs[2,0].BlockType);
            cmd.Parameters.AddWithValue("@i8", input.Inputs[2,1] == null?"":input.Inputs[2,1].BlockType);
            cmd.Parameters.AddWithValue("@i9", input.Inputs[2,2] == null?"":input.Inputs[2,2].BlockType);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        public static void UpdateBlockCount(string blockType, int count)
        {
            using var con = new MySqlConnection(serverConfiguration);
            con.Open();

            string sql = "UPDATE items SET count = @count WHERE blocktype = @blockType";
            using var cmd = new MySqlCommand(sql,con);

            cmd.Parameters.AddWithValue("@blockType", blockType);
            cmd.Parameters.AddWithValue("@count", count);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }


}