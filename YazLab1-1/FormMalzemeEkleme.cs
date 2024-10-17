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
using System.Text.RegularExpressions;

namespace YazLab1_1
{
    public partial class FormMalzemeEkleme : Form
    {
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public FormMalzemeEkleme()
        {
            InitializeComponent();
        }

        private void buttonMalzemeEkle_Click(object sender, EventArgs e)
        {
            string str_malzemeAdi = textBoxMalzemeAdi.Text;
            str_malzemeAdi = Regex.Replace(str_malzemeAdi, @"\s+", " ").Trim(); //birden fazla boşluğu temizleme


            string str_toplamMiktar = textBoxToplamMiktar.Text;
            int index_malzemeBirim = comboBoxMalzemeBirimi.SelectedIndex;
            string str_birimFiyat = textBoxBirimFiyat.Text;
            float miktar = 0.0f;
            float fiyat = 0.0f;
            //MessageBox.Show(str_malzemeAdi + " " + str_toplamMiktar + " " + str_malzemeBirim + " " + str_birimFiyat);

            //kontroller - returnluler en son hata mesajı olarak döndürülüp ayarlanacak
            if ((str_malzemeAdi.Length <= 0 && str_malzemeAdi.Length > 255) || str_malzemeAdi == "")
            {
                MessageBox.Show("Malzeme ismi uzunluğu 0'dan büyük 256'dan küçük olmalı!");
                return;
            }
            if ((str_toplamMiktar.Length <= 0 && str_toplamMiktar.Length > 255) || str_toplamMiktar == "")
            {
                MessageBox.Show("Toplam miktar uzunluğu 0'dan büyük 256'dan küçük olmalı!");
                return;
            }
            try
            {
                miktar = float.Parse(str_toplamMiktar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen toplam miktar olarak float'a dönüştürülebilecek bir değer giriniz");
                return; // float donmezse exception fırlatır
            }
            if (index_malzemeBirim == -1)
            {
                MessageBox.Show("Lütfen uygun bir malzeme seçiniz.");
                return;
            }
            string str_malzemeBirim = comboBoxMalzemeBirimi.Items[index_malzemeBirim].ToString();
            if ((str_birimFiyat.Length <= 0 && str_birimFiyat.Length > 255) || str_birimFiyat == "")
            {
                MessageBox.Show("Birim Fiyat uzunluğu 0'dan büyük 256'dan küçük olmalı!");
                return;
            }
            try
            {
                fiyat = float.Parse(str_birimFiyat);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Lütfen birim fiyat olarak float'a dönüştürülebilecek bir değer giriniz");
                return; // float donmezse exception fırlatır
            }

            //MessageBox.Show(str_malzemeAdi + " " + miktar + " " + str_malzemeBirim + " " + fiyat);


            //duplicate kontrolü
            DataTable dt_malzemeKontrol = new DataTable();
            try
            {
                con.Open();
                string query_malzemeVarMi = @"select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_malzemeVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", str_malzemeAdi);
                adapter.Fill(dt_malzemeKontrol);
                con.Close();
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Duplicate malzeme kontrol hatası: " + ex3.Message);
            }

            if (dt_malzemeKontrol.Rows.Count > 0)
            {
                MessageBox.Show("Zaten bu isimde bir malzeme bulunmakta!");
                return;
            }

            try
            {
                con.Open();
                string query_malzemeekleme = @"INSERT INTO malzemeler (MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat) VALUES (@str_malzemeAdi, @str_toplamMiktar, @str_malzemeBirim, @fiyat);";
                cmd = new MySqlCommand(query_malzemeekleme, con);
                cmd.Parameters.AddWithValue("@str_malzemeAdi", str_malzemeAdi);
                cmd.Parameters.AddWithValue("@str_toplamMiktar", str_toplamMiktar);
                cmd.Parameters.AddWithValue("@str_malzemeBirim", str_malzemeBirim);
                cmd.Parameters.AddWithValue("@fiyat", fiyat);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Malzeme ekleme hatası: " + ex2.Message);
            }

            textBoxBirimFiyat.Text = null;
            textBoxMalzemeAdi.Text = null;
            textBoxToplamMiktar.Text = null;
            comboBoxMalzemeBirimi.SelectedItem = null;
            MessageBox.Show("Malzeme Başarıyla Eklendi.");
        }
    }
}
