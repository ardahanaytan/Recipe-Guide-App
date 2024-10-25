using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace YazLab1_1
{
    public class Data
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");

        TarifEkrani tarifEkrani;
        Form1 form1;

        public Data()
        {

        }

        public Data(Form1 f)
        {
            this.form1 = f;
        }

        public string name { get; set; }
        public string kat { get; set; }
        public string image { get; set; }
        public string id { get; set; }

        public static List<Data> list = new List<Data>();

        public void search(string key)
        {
            con.Open();
            string sql = "SELECT * FROM tarifler WHERE TarifAdi LIKE ?";
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("TarifAdi", key + "%");
            MySqlDataReader reader = cmd.ExecuteReader();
            list.Clear();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Data data = new Data
                    {
                        name = reader["TarifAdi"].ToString(),
                        kat = reader["Kategori"].ToString(),
                        image = reader["Path"].ToString(),
                        id = reader["TarifID"].ToString()
                    };
                    list.Add(data);
                }
            }
            reader.Dispose();
            cmd.Dispose();
            con.Close();
        }
    }
}
