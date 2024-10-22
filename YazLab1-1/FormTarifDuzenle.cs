using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YazLab1_1
{
    public partial class FormTarifDuzenle : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public FormTarifDuzenle()
        {
            InitializeComponent();
        }

        public FormTarifDuzenle(string name)
        {
            InitializeComponent();
            //MessageBox.Show("girdi! " + name);

            //gerekli yerlerin doldurulması
            DataTable tarif = new DataTable();
            try
            {
                // tarif bilgilerini al
                con.Open();
                string query_tarifKontrol = @"select * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", name);
                adapter.Fill(tarif);
                con.Close();

                //
            }
            catch (Exception e)
            {
                MessageBox.Show("tarif doldurma hatasi: ", e.Message);
            }

        }
    }
}
