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
using Krypton.Toolkit;

namespace YazLab1_1
{
    public partial class FormTarifEkleme : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");

        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        FormMalzemeEkleme malzemeEkleme;
        Form1 form1_;

        string photoPath = "";

        public FormTarifEkleme(Form1 form1)
        {
            InitializeComponent();
            form1_ = form1;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (malzemeEkleme == null)
            {
                malzemeEkleme = new FormMalzemeEkleme();
                malzemeEkleme.FormClosed += malzemeEkleme_FormClosed;
                malzemeEkleme.MdiParent = form1_;
                malzemeEkleme.Dock = DockStyle.Fill;
                malzemeEkleme.Show();
            }
            else
            {
                malzemeEkleme.Activate();
            }
            panel1.Width = 530;
        }

        private void malzemeEkleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            malzemeEkleme = null;
        }

        public void tarifOlusmaKontrol()
        {
            string str_tarifAdi = textBoxTarifAdi1.Text;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query_tarifVarMi = @"SELECT * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", str_tarifAdi);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex4)
            {
                MessageBox.Show("Tarif arama hatası: " + ex4.Message);
            }

            if (dt.Rows.Count <= 0)
            {

                string str_kategori = comboBoxKategori1.Items[comboBoxKategori1.SelectedIndex].ToString();
                string talimatlar = richTextBoxTalimatlar1.Text;
                try
                {
                    con.Open();
                    string query_tarifekle = @"INSERT INTO tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar, Path, Maliyet, MalzemeSayisi) VALUES (@str_tarifAdi, @str_kategori, @sure_int, @talimatlar, @path, @Maliyet, @MalzemeSayisi)";
                    cmd = new MySqlCommand(query_tarifekle, con);
                    cmd.Parameters.AddWithValue("@str_tarifAdi", str_tarifAdi);
                    cmd.Parameters.AddWithValue("@str_kategori", str_kategori);
                    cmd.Parameters.AddWithValue("@sure_int", (int)numericUpDownSure1.Value);
                    cmd.Parameters.AddWithValue("@talimatlar", talimatlar);
                    cmd.Parameters.AddWithValue("@path", photoPath);
                    cmd.Parameters.AddWithValue("@Maliyet", 0f);
                    cmd.Parameters.AddWithValue("@MalzemeSayisi", 0);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex3)
                {
                    MessageBox.Show("Tarif oluşturma hatası: " + ex3.Message);
                }

            }
            else
            {
                //MessageBox.Show("Zaten bu isimde bir tarif bulunmakta!");
            }
        }

        public int iliskiEkleme()
        {
            int tarifID = -1;
            int malzemeID = -1;

            string str_tarifAdi = textBoxTarifAdi1.Text;
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string query_tarifIdAlma = @"SELECT TarifID from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifIdAlma, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", str_tarifAdi);
                adapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count <= 0)
                {
                    return -1;
                }
                tarifID = (int)dt.Rows[0]["TarifID"];

            }
            catch (Exception ex5)
            {
                MessageBox.Show("Tarif arama hatası: " + ex5.Message);
                return -41;
            }

            int malzeme_index = comboBoxMalzemeSecimi1.SelectedIndex;
            if (malzeme_index == -1)
            {
                return -2;
            }

            string str_malzeme = comboBoxMalzemeSecimi1.Items[malzeme_index].ToString();
            try
            {
                DataTable dt1 = new DataTable();
                con.Open();
                string query_malzemeIdAlma = @"SELECT MalzemeID from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_malzemeIdAlma, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", str_malzeme);
                adapter.Fill(dt1);
                con.Close();
                if (dt1.Rows.Count <= 0)
                {
                    return -3;
                }
                malzemeID = (int)dt1.Rows[0]["MalzemeID"];
            }
            catch (Exception ex6)
            {
                MessageBox.Show("Malzeme arama hatası: " + ex6.Message);
                return -41;
            }

            //MessageBox.Show(tarifID.ToString());
            //MessageBox.Show(malzemeID.ToString());

            //miktari al
            string str_miktar = textBoxMiktar1.Text;
            if (str_miktar == "") // boş ise
            {
                return -4;
            }
            float miktar_ = -1f;
            try
            {
                miktar_ = float.Parse(str_miktar);
                if (miktar_ <= 0f)
                {
                    MessageBox.Show("Miktar 0 veya negatif olamaz.");
                    return -41;
                }
            }
            catch (Exception ex8)
            {
                return -4;
            }

            DataTable dt_iliskiKontrol = new DataTable();
            try
            {
                con.Open();
                string query_iliskiVarMi = @"select * from iliski where MalzemeIDr = @MalzemeIDr AND TarifIDr = @TarifIDr";
                adapter = new MySqlDataAdapter(query_iliskiVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeIDr", malzemeID);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", tarifID);
                adapter.Fill(dt_iliskiKontrol);
                con.Close();
            }
            catch (Exception ex9)
            {
                MessageBox.Show("İlişki kontrol hatası: " + ex9.Message);
                return -41;
            }

            if (dt_iliskiKontrol.Rows.Count > 0)
            {
                MessageBox.Show("Zaten bu ilişki bulunmakta.");
                return -41;
            }

            try
            {
                con.Open();
                string query_iliskiEkle = @"INSERT INTO iliski (MalzemeIDr, TarifIDr, MalzemeMiktar) VALUES (@MalzemeIDr, @TarifIDr, @MalzemeMiktar)";
                cmd = new MySqlCommand(query_iliskiEkle, con);
                cmd.Parameters.AddWithValue("@MalzemeIDr", malzemeID);
                cmd.Parameters.AddWithValue("@TarifIDr", tarifID);
                cmd.Parameters.AddWithValue("@MalzemeMiktar", miktar_);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex7)
            {
                MessageBox.Show("İlişki ekleme hatası: " + ex7.Message);
                return -41;
            }
            return 41;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.tarifOlusmaKontrol();

            //iliski ekleme olayi
            int ret = this.iliskiEkleme();
            if (ret == -1)
            {
                MessageBox.Show("Tarif bulunamadı.");
            }
            else if (ret == -2)
            {
                MessageBox.Show("Lütfen malzeme seçiniz.");
            }
            else if (ret == -3)
            {
                MessageBox.Show("Malzeme bulunamadı.");
            }
            else if (ret == -4)
            {
                MessageBox.Show("Miktar alınamadı.");
            }

            comboBoxMalzemeSecimi1.SelectedItem = null;
            textBoxMiktar1.Text = null;
        }
        private void button21_Click(object sender, EventArgs e)
        {
            this.tarifOlusmaKontrol();


            //iliski ekleme olayi
            int ret = this.iliskiEkleme();
            if (ret == -1)
            {
                MessageBox.Show("Tarif bulunamadı.");
            }
            else if (ret == -2)
            {
                MessageBox.Show("Lütfen malzeme seçiniz.");
            }
            else if (ret == -3)
            {
                MessageBox.Show("Malzeme bulunamadı.");
            }
            else if (ret == -4)
            {
                MessageBox.Show("Miktar alınamadı.");
            }

            //ana ekrana donus
            textBoxMiktar1.Text = null;
            textBoxTarifAdi1.Text = null;
            comboBoxKategori1.SelectedItem = null;
            comboBoxMalzemeSecimi1.SelectedItem = null;
            numericUpDownSure1.Value = 0;
            richTextBoxTalimatlar1.Text = null;
            MessageBox.Show("Tarif Başarıyla Eklendi.");
        }

        private void FormTarifEkleme_Load(object sender, EventArgs e)
        {
            //panelMalzemeler.Visible = false;
        }

        private void resimEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            openFileDiaglog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDiaglog.FileName;
                MessageBox.Show("Resim Başarıyla seçildi!");
            }
        }

        private void buttonMalzemeEkle1_Click(object sender, EventArgs e)
        {
            string str_tarifAdi = textBoxTarifAdi1.Text;
            int kategori_index = comboBoxKategori1.SelectedIndex;
            KryptonNumericUpDown sure = numericUpDownSure1;
            int sure_int = 0;
            string talimatlar = richTextBoxTalimatlar1.Text;

            if ((str_tarifAdi.Length <= 0 && str_tarifAdi.Length > 255) || str_tarifAdi == "")
            {
                MessageBox.Show("Tarif adı uzunluğu 0'dan büyük 256'dan küçük olmalı!");
                return;
            }
            if (kategori_index == -1)
            {
                MessageBox.Show("Lütfen uygun bir kategori seçiniz.");
                return;
            }
            string str_kategori = comboBoxKategori1.Items[kategori_index].ToString();
            if (((int)sure.Value) > 0)
            {
                sure_int = (int)sure.Value;
            }
            else
            {
                MessageBox.Show("Süre negatif veya 0 olamaz.");
                return;
            }
            if ((talimatlar.Length <= 0 && talimatlar.Length > 5000) || talimatlar == "")
            {
                MessageBox.Show("Talimatlar uzunluğu 0'dan büyük 5001'den küçük olmalı!");
                return;
            }

            //dup kontrol
            try
            {
                DataTable dt_kontrol = new DataTable();
                con.Open();
                string query_comboDoldur = @"SELECT * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_comboDoldur, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", str_tarifAdi);
                adapter.Fill(dt_kontrol);
                con.Close();

                if (dt_kontrol.Rows.Count > 0)
                {
                    MessageBox.Show("Bu isimde bir tarif bulunmakta");
                    return;
                }

            }
            catch (Exception ex3)
            {
                MessageBox.Show("tarif dup kontrol hatası: " + ex3.Message);
            }

            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string query_comboDoldur = @"SELECT MalzemeAdi from malzemeler";
                adapter = new MySqlDataAdapter(query_comboDoldur, con);
                adapter.Fill(dt);
                con.Close();

                comboBoxMalzemeSecimi1.Items.Clear(); //temizleme
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxMalzemeSecimi1.Items.Add(row["MalzemeAdi"].ToString());
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Combobox malzeme ekleme hatası: " + ex2.Message);
            }
            timerMalzeme.Start();
            labelMalzemeAdi.Text = str_tarifAdi;
        }

        private void buttonFotografEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            openFileDiaglog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                photoPath = openFileDiaglog.FileName;
                MessageBox.Show("Resim Başarıyla seçildi!");
            }

            checkBoxFotograf.Text = photoPath;
            checkBoxFotograf.Checked = true;
        }

        bool malzemeExpand = true;
        private void timerMalzeme_Tick(object sender, EventArgs e)
        {
            if (malzemeExpand)
            {
                panel1.Width -= 10;
                if (panel1.Width <= 530)
                {
                    malzemeExpand = false;
                    timerMalzeme.Stop();
                }
            }
        }

    }
}
