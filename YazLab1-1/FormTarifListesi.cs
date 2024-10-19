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
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
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
                    float maliyet = 0f;
                    float gereken = 0f;
                    string id = row["TarifID"].ToString();
                    //MessageBox.Show("id:" + id.ToString());

                    DataTable malzemeler = new DataTable();
                    try
                    {
                        con.Open();
                        string query_malzemeleriAl = @"select MalzemeIDr from iliski where TarifIDr = @TarifIDr";
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
                            string query_MalzemeİsmiAl = @"SELECT * from malzemeler where MalzemeID = @MalzemeID";
                            adapter = new MySqlDataAdapter(query_MalzemeİsmiAl, con);
                            adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", malzeme_id_);
                            adapter.Fill(malzeme_name);
                            con.Close();
                        }
                        catch (Exception ex3)
                        {
                            MessageBox.Show("Malzeme İsmi Alinirken Hata Oluştu:", ex3.Message);
                        }
                        DataTable miktar_table = new DataTable();
                        if (malzeme_name.Rows.Count == 1)
                        {
                            con.Open();
                            string query_getMiktar = @"SELECT MalzemeMiktar from iliski where TarifIDR = @TarifIDR AND MalzemeIDr = @MalzemeIDr";
                            adapter = new MySqlDataAdapter(query_getMiktar, con);
                            adapter.SelectCommand.Parameters.AddWithValue("@MalzemeIDr", malzeme_id_);
                            adapter.SelectCommand.Parameters.AddWithValue("@TarifIDR", int.Parse(id));
                            adapter.Fill(miktar_table);
                            con.Close();

                            if (miktar_table.Rows.Count == 1)
                            {
                                foreach (DataRow row3 in miktar_table.Rows)
                                {
                                    str_malzemeler += row3["MalzemeMiktar"].ToString() + " ";
                                }
                            }
                            else
                            {
                                MessageBox.Show("Birden fazla aynı idli malzeme bulundu");
                            }

                            foreach (DataRow row2 in malzeme_name.Rows)
                            {
                                str_malzemeler += row2["MalzemeBirim"].ToString() + " " + row2["MalzemeAdi"].ToString() + ", ";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Birden fazla ayni isimde malzeme bulundu!");
                            return;
                        }
                    }

                    if (row["TarifAdi"] != DBNull.Value && row["Kategori"] != DBNull.Value && row["HazirlamaSuresi"] != DBNull.Value && row["Talimatlar"] != DBNull.Value)
                    {
                        string ad = row["TarifAdi"]?.ToString() ?? string.Empty;
                        string kategori = row["Kategori"]?.ToString() ?? string.Empty;
                        string sure = row["HazirlamaSuresi"]?.ToString() ?? string.Empty;
                        string talimatlar = row["Talimatlar"]?.ToString() ?? string.Empty;
                        //MessageBox.Show("Kontrol:" + str_malzemeler + "-");
                        //MessageBox.Show("Kontrol2:" + str_malzemeler.Substring(0, str_malzemeler.Length - 2) + "-");

                        if (str_malzemeler.Length > 2)
                        {
                            string[] malzemeler_arr = str_malzemeler.Substring(0, str_malzemeler.Length - 2).Split(",").ToArray();
                            string yeterli_malzemeler = "";
                            string yetersiz_malzemeler = "";
                            foreach (string malzeme in malzemeler_arr)
                            {
                                //MessageBox.Show("-" + malzeme + "-");
                                string malzeme_trim = malzeme.Trim();
                                string[] malzeme_kelime = malzeme_trim.Split(" ").Select(part => part.Trim()).ToArray();
                                float malzeme_miktar = float.Parse(malzeme_kelime[0]);
                                string malzeme_isim = "";
                                int gezen = 2;
                                while (gezen < malzeme_kelime.Length)
                                {
                                    if (gezen == 2)
                                    {
                                        malzeme_isim += malzeme_kelime[gezen];
                                    }
                                    else
                                    {
                                        malzeme_isim += " " + malzeme_kelime[gezen];
                                    }

                                    gezen++;
                                }
                                //malzeme_isim = malzeme_isim.Substring(0, malzeme_isim.Length - 1);
                                //MessageBox.Show("malzeme kontrol:" + malzeme_isim);
                                DataTable dt_mik = new DataTable();
                                try
                                {
                                    con.Open();
                                    string query_sahipOlunaniAlma = @"select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                                    adapter = new MySqlDataAdapter(query_sahipOlunaniAlma, con);
                                    adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", malzeme_isim);
                                    adapter.Fill(dt_mik);
                                    con.Close();

                                }
                                catch (Exception ex1)
                                {
                                    MessageBox.Show("Renklendirme hatası: " + ex1.Message);
                                    return;

                                }




                                if (dt_mik.Rows.Count == 1)
                                {
                                    float neKadarVar = -1f;
                                    float birimFiyat = -1f;
                                    foreach (DataRow row_ in dt_mik.Rows)
                                    {
                                        neKadarVar = float.Parse(row_["ToplamMiktar"]?.ToString() ?? string.Empty);
                                        birimFiyat = float.Parse(row_["BirimFiyat"]?.ToString() ?? string.Empty);
                                        maliyet += birimFiyat * malzeme_miktar;
                                    }
                                    if (neKadarVar >= malzeme_miktar)
                                    {
                                        if (yeterli_malzemeler == "")
                                        {
                                            yeterli_malzemeler += malzeme;
                                        }
                                        else
                                        {
                                            yeterli_malzemeler += "," + malzeme;



                                        }

                                    }
                                    else
                                    {
                                        gereken -= (malzeme_miktar - neKadarVar) * birimFiyat;
                                        gezen = 1;
                                        string eklenecek = "";
                                        if (yetersiz_malzemeler == "")
                                        {
                                            eklenecek += (malzeme_miktar - neKadarVar).ToString();
                                            while (gezen < malzeme_kelime.Length)
                                            {
                                                eklenecek += " " + malzeme_kelime[gezen];
                                                gezen++;
                                            }
                                            yetersiz_malzemeler += eklenecek;
                                        }
                                        else
                                        {
                                            eklenecek += (malzeme_miktar - neKadarVar).ToString();
                                            while (gezen < malzeme_kelime.Length)
                                            {
                                                eklenecek += " " + malzeme_kelime[gezen];
                                                gezen++;
                                            }

                                            yetersiz_malzemeler += "," + eklenecek;
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Malzeme bulma hatasi!");
                                    return;
                                }

                            }

                            if (yeterli_malzemeler == "")
                            {
                                yeterli_malzemeler = "Yok";
                            }
                            if (yetersiz_malzemeler == "")
                            {
                                yetersiz_malzemeler = "Yok";
                            }




                            int row_num = dataGridViewTarifler.Rows.Add(id, ad, kategori, sure, yeterli_malzemeler, yetersiz_malzemeler, talimatlar, maliyet, gereken);
                            if (yetersiz_malzemeler == "Yok")
                            {
                                dataGridViewTarifler.Rows[row_num].DefaultCellStyle.BackColor = Color.Green;
                                dataGridViewTarifler.Rows[row_num].DefaultCellStyle.ForeColor = Color.White; // İsteğe bağlı yazı rengi
                            }
                            else
                            {
                                dataGridViewTarifler.Rows[row_num].DefaultCellStyle.BackColor = Color.Red;
                                dataGridViewTarifler.Rows[row_num].DefaultCellStyle.ForeColor = Color.White; // İsteğe bağlı yazı rengi
                            }
                        }
                    }

                    

                    


                    //dataGridViewTarifler.Invalidate(); // tekrar boyama?????????
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Tablo Güncellemede Hata:", ex1.Message);
                return;
            }

            this.ayirma_methodu();

        }

        public void FormTarifListesi_Load(object sender, EventArgs e)
        {
            this.tabloGuncelle("select * from tarifler");
        }

        public void tarifSil(string id)
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

        public void ayirma_methodu()
        {

        }


        private void dataGridViewTarifler_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
