﻿using System;
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
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public int tarifID;
        public FormTarifDuzenle()
        {
            InitializeComponent();
        }

        public void formuDoldur(string name)
        {
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

                //duzenle formunu doldurma

                string default_path = "C:/Users/ardah/Desktop/proje22/images/404.png";
                //string default_path = "C:\\Users\\sefat\\OneDrive\\Masaüstü\\Recipe-Guide-App\\images/404.png";

                foreach (DataRow row in tarif.Rows)
                {
                    //id'yi al
                    this.tarifID = int.Parse(row["TarifID"].ToString());
                    kryptonLabel1.Text = "Tarif ID: " + this.tarifID.ToString();

                    //resim
                    string path = row["Path"].ToString();
                    if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                    {
                        kryptonPictureBox1.Image = Image.FromFile(path);
                    }
                    else
                    {
                        kryptonPictureBox1.Image = Image.FromFile(default_path);
                        path = default_path;
                    }

                    //path
                    kryptonTextBoxPath.Text = path;
                    kryptonTextBoxPath.ReadOnly = true;

                    //name
                    kryptonTextBox1.Text = row["TarifAdi"].ToString();

                    //kategoriler
                    kryptonComboBoxKategori.Items.Clear();
                    kryptonComboBoxKategori.Items.Add("Kahvaltı");
                    kryptonComboBoxKategori.Items.Add("Yemek");
                    kryptonComboBoxKategori.Items.Add("Çorba");
                    kryptonComboBoxKategori.Items.Add("Tatlı");
                    kryptonComboBoxKategori.Items.Add("İçecek");
                    //kryptonComboBoxKategori
                    string kategori = row["Kategori"].ToString();
                    if (kryptonComboBoxKategori.Items.Contains(kategori))
                    {
                        kryptonComboBoxKategori.SelectedItem = kategori;
                    }
                    else
                    {
                        MessageBox.Show("kategori alınırken hata oluştu!");
                        return;
                    }

                    //sure
                    kryptonNumericUpDown1.Value = int.Parse(row["HazirlamaSuresi"].ToString());

                    //talimatlar
                    richTextBoxTalimatlar.Text = row["Talimatlar"].ToString();

                    //tarif malzeme combobox
                    //temizle
                    kryptonComboBox1.Items.Clear();

                    DataTable malzemeler_id = new DataTable();
                    try
                    {
                        //malzeme idlerini al
                        con.Open();
                        string query_tarifinMalzemeleri = @"select * from iliski where TarifIDr = @TarifIDr";
                        adapter = new MySqlDataAdapter(query_tarifinMalzemeleri, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", this.tarifID);
                        malzemeler_id.Clear();
                        adapter.Fill(malzemeler_id);
                        con.Close();

                        DataTable malzemeler = new DataTable();
                        foreach (DataRow row2 in malzemeler_id.Rows)
                        {
                            con.Open();
                            string query_malzemeBilgileri = @"select * from malzemeler where MalzemeID = @MalzemeID";
                            adapter = new MySqlDataAdapter(query_malzemeBilgileri, con);
                            adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", row2["MalzemeIDr"].ToString());
                            malzemeler.Clear();
                            adapter.Fill(malzemeler);
                            con.Close();

                            if (malzemeler.Rows.Count != 1)
                            {
                                MessageBox.Show("Malzeme bulunamadı");
                                return;
                            }
                            foreach (DataRow row3 in malzemeler.Rows)
                            {
                                kryptonComboBox1.Items.Add(row3["MalzemeAdi"].ToString());
                            }
                        }


                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show("tarif doldurma hatasi: ", ex1.Message);
                    }


                    //tum malzeme combobox
                    kryptonComboBoxMalzemeler2.Items.Clear();

                    DataTable tum_malzemeler = new DataTable();
                    DataTable secilmis_malzemeler = new DataTable();
                    List<string> malzemeList = new List<string>();
                    try
                    {
                        con.Open();
                        string query_tumMalzeme = @"select * from malzemeler";
                        adapter = new MySqlDataAdapter(query_tumMalzeme, con);
                        tum_malzemeler.Clear();
                        adapter.Fill(tum_malzemeler);
                        con.Close();

                        foreach (DataRow row4 in tum_malzemeler.Rows)
                        {
                            malzemeList.Add(row4["MalzemeAdi"].ToString());
                        }

                        con.Open();
                        string query_zatenOlan = @"select * from iliski where TarifIDr = @TarifIDr";
                        adapter = new MySqlDataAdapter(query_zatenOlan, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", this.tarifID);
                        secilmis_malzemeler.Clear();
                        adapter.Fill(secilmis_malzemeler);
                        con.Close();

                        DataTable malzeme_adini_al = new DataTable();
                        foreach (DataRow row5 in secilmis_malzemeler.Rows)
                        {
                            con.Open();
                            string query_malzemeAdiAl = @"select MalzemeAdi from malzemeler where MalzemeID = @MalzemeID";
                            adapter = new MySqlDataAdapter(query_malzemeAdiAl, con);
                            adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", row5["MalzemeIDr"].ToString());
                            malzeme_adini_al.Clear();
                            adapter.Fill(malzeme_adini_al);
                            con.Close();

                            foreach (DataRow row6 in malzeme_adini_al.Rows)
                            {
                                string malzeme_name = row6["MalzemeAdi"].ToString();
                                if (malzemeList.Contains(malzeme_name))
                                {
                                    malzemeList.Remove(malzeme_name);
                                }
                            }

                        }

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("tarif doldurma hatasi: ", ex2.Message);
                    }


                    //tabloyu doldur
                    foreach (string name_ in malzemeList)
                    {
                        kryptonComboBoxMalzemeler2.Items.Add(name_);
                    }



                }

            }
            catch (Exception e)
            {
                MessageBox.Show("tarif doldurma hatasi: ", e.Message);
            }
        }

        public FormTarifDuzenle(string name)
        {

            InitializeComponent();
            this.formuDoldur(name);

            //MessageBox.Show("girdi! " + name);

            //gerekli yerlerin doldurulması


        }

        private void kryptonButtonFotoGuncelle_Click(object sender, EventArgs e)
        {
            string default_path = "C:/Users/ardah/Desktop/proje22/images/404.png";
            //string default_path = "C:\\Users\\sefat\\OneDrive\\Masaüstü\\Recipe-Guide-App\\images/404.png";

            string path = "";
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            openFileDiaglog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {

                path = openFileDiaglog.FileName;
                //path = photoPath.ToString();
                MessageBox.Show("Resim Başarıyla seçildi!");
            }
            //path guncelle

            try
            {
                con.Open();
                string query_photoUpdate = @"UPDATE tarifler SET path= @newPath where TarifID= @TarifID";
                MySqlCommand cmd = new MySqlCommand(query_photoUpdate, con);
                cmd.Parameters.AddWithValue("@newPath", path);
                cmd.Parameters.AddWithValue("@TarifID", this.tarifID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    MessageBox.Show("güncelleme hatasi");
                }
                con.Close();

                // guncellemeler
                //resim
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    kryptonPictureBox1.Image = Image.FromFile(path);
                }
                else
                {
                    kryptonPictureBox1.Image = Image.FromFile(default_path);
                    path = default_path;
                }

                //path
                kryptonTextBoxPath.Text = path;
                kryptonTextBoxPath.ReadOnly = true;


            }
            catch (Exception e1)
            {
                MessageBox.Show("foto guncelleme hatasi: ", e1.Message);
            }
        }

        private void buttonDüzenle_Click(object sender, EventArgs e)
        {
            string ad = kryptonTextBox1.Text; //isme kontrol lazim

            DataTable tarif = new DataTable();
            try
            {
                con.Open();
                string query_tarifVarMi = @"SELECT * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", ad);
                adapter.Fill(tarif);
                con.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("tarif isim kontrol hatasi: ", ex1.Message);
            }

            if (tarif.Rows.Count != 1)
            {
                MessageBox.Show("Tarif ismi zaten bulunmakta!");
                return;
            }

            string str_kategori = kryptonComboBoxKategori.Items[kryptonComboBoxKategori.SelectedIndex].ToString();
            string talimatlar = richTextBoxTalimatlar.Text;
            int sure = (int)kryptonNumericUpDown1.Value;
            try
            {
                con.Open();
                string query_tarifGuncelle = @"UPDATE tarifler SET TarifAdi=@TarifAdi, Kategori=@Kategori, HazirlamaSuresi=@HazirlamaSuresi, Talimatlar=@Talimatlar where TarifID= @TarifID";
                MySqlCommand cmd = new MySqlCommand(query_tarifGuncelle, con);
                cmd.Parameters.AddWithValue("@TarifAdi", ad);
                cmd.Parameters.AddWithValue("@Kategori", str_kategori);
                cmd.Parameters.AddWithValue("@HazirlamaSuresi", sure);
                cmd.Parameters.AddWithValue("@Talimatlar", talimatlar);
                cmd.Parameters.AddWithValue("@TarifID", this.tarifID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    MessageBox.Show("güncelleme hatasi");
                }
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("tarif isim kontrol hatasi: ", ex2.Message);
            }

        }

        private void kryptonButtonMalzemeSil_Click(object sender, EventArgs e)
        {
            string str_malzeme = kryptonComboBox1.Items[kryptonComboBox1.SelectedIndex].ToString();
            if (str_malzeme == "")
            {
                MessageBox.Show("Lütfen seçim yapınız");
                return;
            }
            DataTable malzeme = new DataTable();
            try
            {
                //malzeme id alma
                con.Open();
                string query_idAlma = @"select * from malzemeler where MalzemeAdi=@MalzemeAdi";
                adapter = new MySqlDataAdapter(query_idAlma, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", str_malzeme);
                adapter.Fill(malzeme);
                con.Close();

                if(malzeme.Rows.Count != 1)
                {
                    MessageBox.Show("Malzeme alinamadi");
                    return;
                }

                //silme
                foreach(DataRow row in malzeme.Rows)
                {
                    con.Open();
                    string query_malzemeIliskiSil = @"DELETE from iliski where MalzemeIDr = @MalzemeIDr AND TarifIDr=@TarifIDr";
                    cmd = new MySqlCommand(query_malzemeIliskiSil, con);
                    cmd.Parameters.AddWithValue("@MalzemeIDr", row["MalzemeID"].ToString());
                    cmd.Parameters.AddWithValue("@TarifIDr", this.tarifID);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected != 1)
                    {
                        MessageBox.Show("güncelleme hatasi");
                    }
                    con.Close();
                }

                
                




            }
            catch(Exception ex1)
            {
                MessageBox.Show("ilişiki malzeme silme hatasi: ", ex1.Message);
            }

        }

        private void kryptonButtonMalzemeMiktarDuzenleme_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButtonMalzemeEkle_Click(object sender, EventArgs e)
        {

        }

        private void kryptonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
