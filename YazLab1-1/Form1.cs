using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
//using ComponentFactory.Krypton.Toolkit;

namespace YazLab1_1
{


    public partial class Form1 : Form
    {
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        FormArama arama;
        FormTarifOnerme tarifOnerme;
        FormTarifListesi tarifListesi;
        FormTarifEkleme tarifEkleme;
        FormMalzemeListesi malzemeListesi;
        FormMalzemeEkleme malzemeEkleme;

        public void iliski_ekle(int malzemeID, int tarifID, float miktar_)
        {
            try
            {
                //kontrol
                DataTable dt = new DataTable();
                con.Open();
                string query_iliskiVarMi = @"select * from iliski where MalzemeIDr = @MalzemeIDr AND TarifIDr = @TarifIDr";
                adapter = new MySqlDataAdapter(query_iliskiVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeIDr", malzemeID);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", tarifID);
                adapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Bu iliski zaten var!");
                    return;
                }

                //ekle
                con.Open();
                string query_iliskiEkle = @"INSERT INTO iliski (MalzemeIDr, TarifIDr, MalzemeMiktar) VALUES (@MalzemeIDr, @TarifIDr, @MalzemeMiktar)";
                cmd = new MySqlCommand(query_iliskiEkle, con);
                cmd.Parameters.AddWithValue("@MalzemeIDr", malzemeID);
                cmd.Parameters.AddWithValue("@TarifIDr", tarifID);
                cmd.Parameters.AddWithValue("@MalzemeMiktar", miktar_);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ýliski ekleme hatasý: " + ex.Message);
            }

        }

        public void malzeme_ekle(string malzeme_adi, string toplam_miktar, string malzeme_birim, float birimFiyat)
        {
            try
            {
                DataTable dt = new DataTable();
                con.Open();
                string query_tarifVarMi = @"select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_tarifVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", malzeme_adi);
                adapter.Fill(dt);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Bu malzeme zaten var!");
                    return;
                }
                con.Open();
                string query_malzemeekleme = @"INSERT INTO malzemeler (MalzemeAdi, ToplamMiktar, MalzemeBirim, BirimFiyat) VALUES (@str_malzemeAdi, @str_toplamMiktar, @str_malzemeBirim, @fiyat);";
                cmd = new MySqlCommand(query_malzemeekleme, con);
                cmd.Parameters.AddWithValue("@str_malzemeAdi", malzeme_adi);
                cmd.Parameters.AddWithValue("@str_toplamMiktar", toplam_miktar);
                cmd.Parameters.AddWithValue("@str_malzemeBirim", malzeme_birim);
                cmd.Parameters.AddWithValue("@fiyat", birimFiyat);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Malzeme ekleme hatasý: " + ex.Message);
            }

        }

        public void tarif_ekle(string tarif_adi, string kategori, int hazirlamaSuresi, string talimatlar)
        {
            try
            {
                DataTable dt = new DataTable();
                //var mi yok mu kontrol et
                con.Open();
                string query_tarifVarMi = @"select * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", tarif_adi);
                adapter.Fill(dt);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Bu tarif zaten var!");
                    return;
                }
                //tarif ekle
                con.Open();
                string query_tarifEkle = @"insert into tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar) values (@TarifAdi, @Kategori, @HazirlamaSuresi, @Talimatlar)";
                cmd = new MySqlCommand(query_tarifEkle, con);
                cmd.Parameters.AddWithValue("@TarifAdi", tarif_adi);
                cmd.Parameters.AddWithValue("@Kategori", kategori);
                cmd.Parameters.AddWithValue("@HazirlamaSuresi", hazirlamaSuresi);
                cmd.Parameters.AddWithValue("@Talimatlar", talimatlar);
                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarif ekleme hatasý: " + ex.Message);
            }
        }

        public void databaseDoldur()
        {
            try
            {
                tarif_ekle("tarif1", "Yemek", 21, "asdkhjnadsjkhnajsdkhnasdh");
                tarif_ekle("tarif2", "Çorba", 21241, "asdkhjnadsjasdhasdhkhnajsdkhnasdh");
                tarif_ekle("tarif3", "Tatlý", 22141, "asdkhjnadasdhasdsjkhnajsdkhnasdh");
                tarif_ekle("tarif4", "Çorba", 21241, "asdkhjnadsasdhasdhjkhnajsdkhnasdh");
                tarif_ekle("tarif5", "Tatlý", 211, "asdkhjnadsjkasdhasdhhnajsdkhnasdh");

                malzeme_ekle("malzeme1", "4212", "Gram", 1f);
                malzeme_ekle("malzeme2", "4212", "Gram", 100f);
                malzeme_ekle("malzeme3", "4212", "Gram", 1f);
                malzeme_ekle("malzeme4", "4212", "Gram", 1f);

                iliski_ekle(1, 1, 10);
                iliski_ekle(2, 1, 10);
                iliski_ekle(1, 3, 5);
                iliski_ekle(1, 4, 3);
                iliski_ekle(2, 4, 200);
                iliski_ekle(3, 4, 4312);
                iliski_ekle(1, 5, 7);
                iliski_ekle(1, 2, 1110);
                iliski_ekle(3, 1, 10);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Database doldurma hatasý: " + ex.Message);
            }
        }

        public void initDatabase()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                //adapter = new MySqlDataAdapter(""); 
                //adapter.Fill(dt); //DataAdapter, SQL sorgusunu çalýþtýrýr ve sonuçlarý DataTable'a doldurur.


                string query1 = @"CREATE TABLE IF NOT EXISTS `yazlab1`.`tarifler` (
                                    `TarifID` INT NOT NULL AUTO_INCREMENT,
                                    `TarifAdi` VARCHAR(255) NOT NULL,
                                    `Kategori` VARCHAR(255) NOT NULL,
                                    `HazirlamaSuresi` INT NOT NULL,
                                    `Talimatlar` TEXT(5000) NOT NULL,
                                    PRIMARY KEY (`TarifID`),
                                    UNIQUE INDEX `TarifID_UNIQUE` (`TarifID` ASC) VISIBLE);";

                cmd = new MySqlCommand(query1, con);
                cmd.ExecuteNonQuery();

                //textBox1.Text = "basarili";

                string query2 = @"CREATE TABLE IF NOT EXISTS `yazlab1`.`malzemeler` (
                                `MalzemeID` INT NOT NULL AUTO_INCREMENT,
                                `MalzemeAdi` VARCHAR(255) NOT NULL,
                                `ToplamMiktar` VARCHAR(255) NOT NULL,
                                `MalzemeBirim` VARCHAR(255) NOT NULL,
                                `BirimFiyat` FLOAT NOT NULL,
                                 PRIMARY KEY (`MalzemeID`),
                                 UNIQUE INDEX `MalzemeID_UNIQUE` (`MalzemeID` ASC) VISIBLE);";

                cmd = new MySqlCommand(query2, con);
                cmd.ExecuteNonQuery();
                //textBox1.Text = "basarili2";


                string query3 = @"CREATE TABLE  IF NOT EXISTS `yazlab1`.`iliski` (
                                  `MalzemeIDr` INT NOT NULL,
                                  `TarifIDr` INT NOT NULL,
                                  `MalzemeMiktar` float NOT NULL,
                                  KEY `MalzemeID_idx` (`MalzemeIDr`),
                                  KEY `TarifID_idx` (`TarifIDr`),
                                  CONSTRAINT `MalzemeID` FOREIGN KEY (`MalzemeIDr`) REFERENCES `malzemeler` (`MalzemeID`) ON DELETE CASCADE ON UPDATE CASCADE,
                                  CONSTRAINT `TarifID` FOREIGN KEY (`TarifIDr`) REFERENCES `tarifler` (`TarifID`) ON DELETE CASCADE ON UPDATE CASCADE
                                )";

                cmd = new MySqlCommand(query3, con);
                cmd.ExecuteNonQuery();
                textBox1.Text = "basarili3";
                //MessageBox.Show("Tablolar Baþarýyla Oluþturuldu!");



                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo oluþturma hatasý: " + ex.Message);
            }
        }

        public Form1()
        {
            InitializeComponent();

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void Form1_Load(object sender, EventArgs e)
        {
            initDatabase();
            databaseDoldur();
        }

       

        bool menuCubukAktifMi = true;

        private void menuCubukTimer_Tick(object sender, EventArgs e)
        {
            if (menuCubukAktifMi)
            {
                menuCubuk.Width -= 6;
                if (menuCubuk.Width <= 55)
                {
                    menuCubukAktifMi = false;
                    menuCubukTimer.Stop();
                }
            }
            else
            {
                menuCubuk.Width += 6;
                if (menuCubuk.Width >= 202)
                {
                    menuCubukAktifMi = true;
                    menuCubukTimer.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            menuCubukTimer.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (arama == null)
            {
                arama = new FormArama();
                arama.FormClosed += Arama_FormClosed;
                arama.MdiParent = this;
                arama.Show();
            }
            else
            {
                arama.Activate();
            }
            panelAnaManu.Visible = false;
        }

        private void Arama_FormClosed(object? sender, FormClosedEventArgs e)
        {
            arama = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tarifOnerme == null)
            {
                tarifOnerme = new FormTarifOnerme();
                tarifOnerme.FormClosed += TarifOnerme_FormClosed;
                tarifOnerme.MdiParent = this;
                tarifOnerme.Dock = DockStyle.Fill;
                tarifOnerme.Show();
            }
            else
            {
                tarifOnerme.Activate();
            }
            panelAnaManu.Visible = false;
        }

        private void TarifOnerme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifOnerme = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tarifListesi == null)
            {
                tarifListesi = new FormTarifListesi();
                
                tarifListesi.FormClosed += TarifListesi_FormClosed;
                tarifListesi.MdiParent = this;
                tarifListesi.Dock = DockStyle.Fill;
                tarifListesi.Show();
            }
            else
            {
                tarifListesi.tabloGuncelle("select * from tarifler");
                tarifListesi.Activate();
            }
            panelAnaManu.Visible = false;
        }

        private void TarifListesi_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifListesi = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tarifEkleme == null)
            {
                tarifEkleme = new FormTarifEkleme(this);
                tarifEkleme.FormClosed += TarifEkleme_FormClosed;
                tarifEkleme.MdiParent = this;
                tarifEkleme.Dock = DockStyle.Fill;
                tarifEkleme.Show();
            }
            else
            {
                tarifEkleme.Activate();
            }
            tarifEkleme.panelMalzemeler.Visible = false;
        }

        private void TarifEkleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifEkleme = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (malzemeListesi == null)
            {
                malzemeListesi = new FormMalzemeListesi();
                malzemeListesi.FormClosed += malzemeListesi_FormClosed;
                malzemeListesi.MdiParent = this;
                malzemeListesi.Dock = DockStyle.Fill;
                malzemeListesi.Show();
            }
            else
            {
                malzemeListesi.Activate();
                malzemeListesi.tabloGuncelle("select * from malzemeler");
            }
            panelAnaManu.Visible = false;
        }

        private void malzemeListesi_FormClosed(object? sender, FormClosedEventArgs e)
        {
            malzemeListesi = null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (malzemeEkleme == null)
            {
                malzemeEkleme = new FormMalzemeEkleme();
                malzemeEkleme.FormClosed += malzemeEkleme_FormClosed;
                malzemeEkleme.MdiParent = this;
                malzemeEkleme.Dock = DockStyle.Fill;
                malzemeEkleme.Show();
            }
            else
            {
                malzemeEkleme.Activate();
            }
            panelAnaManu.Visible = false;
        }

        private void malzemeEkleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            malzemeEkleme = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }





}