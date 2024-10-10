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
    public partial class FormTarifListesi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public FormTarifListesi()
        {
            InitializeComponent();
        }

        public void tabloGuncelle(string query)
        {
            dataGridViewTarifler.Rows.Clear();

            DataTable dt_tarifler = new DataTable();
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(dt_tarifler);
                con.Close();
                foreach (DataRow row in dt_tarifler.Rows)
                {
                    string id = row["TarifID"].ToString();

                    DataTable malzemeler = new DataTable();
                    try
                    {
                        con.Open();
                        string query_malzemeleriAl = @"select MalzemeIDr from iliski where TarifIDR = @TarifIDR";
                        adapter = new MySqlDataAdapter(query_malzemeleriAl, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@TarifIDR", int.Parse(id));
                        adapter.Fill(malzemeler);
                        con.Close();
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("Malzemeleri Idleri Alinirken Hata:", ex2.Message);
                        return;
                    }

                    string str_malzemeler = "";
                    foreach (DataRow row1 in malzemeler.Rows)
                    {
                        string malzeme_id_ = row1["MalzemeIDr"].ToString();
                        DataTable malzeme_name = new DataTable();
                        try
                        {
                            con.Open();
                            string query_MalzemeİsmiAl = @"SELECT MalzemeAdi from malzemeler where MalzemeID = @MalzemeID";
                            adapter = new MySqlDataAdapter(query_MalzemeİsmiAl, con);
                            adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", malzeme_id_);
                            adapter.Fill(malzeme_name);
                            con.Close();
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show("Malzeme İsmi Alinirken Hata Oluştu:", ex3.Message);
                        }
                        if (malzeme_name.Rows.Count == 1)
                        {
                            foreach (DataRow row2 in malzeme_name.Rows)
                            {
                                str_malzemeler += row2["MalzemeAdi"].ToString() + ", ";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Birden fazla ayni isimde malzeme bulundu!");
                            return;
                        }
                    }

                    string ad = row["TarifAdi"].ToString();
                    string kategori = row["Kategori"].ToString();
                    string sure = row["HazirlamaSuresi"].ToString();
                    string talimatlar = row["Talimatlar"].ToString();
                    dataGridViewTarifler.Rows.Add(id, ad, kategori, sure, str_malzemeler.Substring(0, str_malzemeler.Length-2), talimatlar);
                    //dataGridViewTarifler.Rows.Add(id, ad, kategori, sure, str_malzemeler, talimatlar);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Tablo Güncellemede Hata:", ex1.Message);
                return;
            }


        }

        private void FormTarifListesi_Load(object sender, EventArgs e)
        {
            this.tabloGuncelle("select * from tarifler");
        }

        public void tarifSil(string id )
        {
            if (id == "")
            {
                MessageBox.Show("Id Alinamadi.");
                return;
            }
            int id_ = -1;
            try
            {
                id_ = int.Parse(id);
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Id Int'e Çevirilemedi.");
                return;
            }

            //tarif var mi
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query_idKontrol = @"SELECT * from tarifler where TarifID = @TarifID";
                adapter = new MySqlDataAdapter(query_idKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifID", id_);
                adapter.Fill(dt);
                con.Close();

            }
            catch (Exception ex1)
            {
                MessageBox.Show("Malzeme Bulma Hatası:", ex1.Message);
                return;
            }
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Tarif Bulunamadı!");
                return;
            }

            //tarifi sil
            try
            {
                con.Open();
                string query_tarifSil = @"DELETE from tarifler where TarifID = @TarifID";
                cmd = new MySqlCommand(query_tarifSil, con);
                cmd.Parameters.AddWithValue("@TarifID", id_);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Tarif Silme Hatasi:" + ex2.Message);
                return;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewTarifler.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    string buttonVal = dataGridViewTarifler.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string malzemeID_ = dataGridViewTarifler.Rows[e.RowIndex].Cells["TarifID"].Value.ToString();
                    if (malzemeID_ == null || buttonVal == null)
                    {
                        return;
                    }
                    if (buttonVal == "Sil")
                    {
                        this.tarifSil(malzemeID_);
                        this.tabloGuncelle("select * from tarifler");
                    }
                    else
                    {

                    }                   
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Buton Hatası:", ex1.Message);
            }
        }
    }
}
