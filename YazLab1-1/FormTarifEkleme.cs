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
    public partial class FormTarifEkleme : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=2732.Han2001");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        FormMalzemeEkleme malzemeEkleme;
        Form1 form1_;


        public FormTarifEkleme(Form1 form1)
        {
            InitializeComponent();
            form1_ = form1;
        }

        private void buttonTarifEkle_Click(object sender, EventArgs e)
        {

            string str_tarifAdi = textBoxTarifAdi.Text;
            int kategori_index = comboBoxKategori.SelectedIndex;
            NumericUpDown sure = numericUpDownSure;
            int sure_int = 0;
            string talimatlar = richTextBoxTalimatlar.Text;

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
            string str_kategori = comboBoxKategori.Items[kategori_index].ToString();
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

            //MessageBox.Show(str_tarifAdi + " " + str_kategori + " " + sure_int + " " + talimatlar);
            /*
            try
            {
                con.Open();
                string query_tarifekle = @"INSERT INTO tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar) VALUES (@str_tarifAdi, @str_kategori, @sure_int, @talimatlar)";
                cmd = new MySqlCommand(query_tarifekle, con);
                cmd.Parameters.AddWithValue("@str_tarifAdi", str_tarifAdi);
                cmd.Parameters.AddWithValue("@str_kategori", str_kategori);
                cmd.Parameters.AddWithValue("@sure_int", sure_int);
                cmd.Parameters.AddWithValue("@talimatlar", talimatlar);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception ex2)
            {
                MessageBox.Show("Tarif ekleme hatası: " + ex2.Message);
            }
            */


            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string query_comboDoldur = @"SELECT MalzemeAdi from malzemeler";
                adapter = new MySqlDataAdapter(query_comboDoldur, con);
                adapter.Fill(dt);
                con.Close();

                comboBoxMalzemeSecimi.Items.Clear(); //temizleme
                foreach (DataRow row in dt.Rows)
                {
                    comboBoxMalzemeSecimi.Items.Add(row["MalzemeAdi"].ToString());
                }

            }
            catch (Exception ex2)
            {
                MessageBox.Show("Combobox malzeme ekleme hatası: " + ex2.Message);
            }
            panelMalzemeler.Visible = true;



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (malzemeEkleme == null)
            {
                malzemeEkleme = new FormMalzemeEkleme();
                malzemeEkleme.FormClosed += malzemeEkleme_FormClosed;
                malzemeEkleme.MdiParent = form1_;
                malzemeEkleme.Dock = DockStyle.Fill;
                malzemeEkleme.Show();
                /*
                malzemeEkleme.FormClosed += malzemeEkleme_FormClosed;
                
                malzemeEkleme.Dock = DockStyle.Fill;
                malzemeEkleme.Show();
                */
            }
            else
            {
                malzemeEkleme.Activate();
            }
        }

        private void malzemeEkleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            malzemeEkleme = null;
        }

        public void tarifOlusmaKontrol()
        {

            string str_tarifAdi = textBoxTarifAdi.Text;
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

                string str_kategori = comboBoxKategori.Items[comboBoxKategori.SelectedIndex].ToString();
                string talimatlar = richTextBoxTalimatlar.Text;
                try
                {
                    con.Open();
                    string query_tarifekle = @"INSERT INTO tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar) VALUES (@str_tarifAdi, @str_kategori, @sure_int, @talimatlar)";
                    cmd = new MySqlCommand(query_tarifekle, con);
                    cmd.Parameters.AddWithValue("@str_tarifAdi", str_tarifAdi);
                    cmd.Parameters.AddWithValue("@str_kategori", str_kategori);
                    cmd.Parameters.AddWithValue("@sure_int", (int)numericUpDownSure.Value);
                    cmd.Parameters.AddWithValue("@talimatlar", talimatlar);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex3)
                {
                    MessageBox.Show("Tarif oluşturma hatası: " + ex3.Message);
                }

            }
        }

        public int iliskiEkleme()
        {
            int tarifID = -1;
            int malzemeID = -1;

            string str_tarifAdi = textBoxTarifAdi.Text;
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

            int malzeme_index = comboBoxMalzemeSecimi.SelectedIndex;
            if (malzeme_index == -1)
            {
                return -2;
            }
            string str_malzeme = comboBoxMalzemeSecimi.Items[malzeme_index].ToString();
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
            string str_miktar = textBoxMiktar.Text;
            if(str_miktar == "") // boş ise
            {
                return -4;
            }
            int miktar_ = -1;
            try
            {
                miktar_ = int.Parse(str_miktar);
                if(miktar_ <= 0)
                {
                    MessageBox.Show("Miktar 0 veya negatif olamaz.");
                    return -41;
                }
            }
            catch(Exception ex8)
            {
                return -4;
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

        private void button1_Click(object sender, EventArgs e)
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
            else if(ret == -4)
            {
                MessageBox.Show("Miktar alınamadı.");
            }

            comboBoxMalzemeSecimi.SelectedItem = null;
            textBoxMiktar.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
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

            //ana ekrana donus
        }
    }
}
