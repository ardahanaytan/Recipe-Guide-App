using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Krypton.Toolkit;
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
        TarifEkrani tarifEkrani;
        FormTarifDuzenle formTarifDuzenle;

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
                MessageBox.Show("İliski ekleme hatası: " + ex.Message);
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
                MessageBox.Show("Malzeme ekleme hatası: " + ex.Message);
            }

        }

        public void tarif_ekle(string tarif_adi, string kategori, int hazirlamaSuresi, string talimatlar, string path)
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
                string query_tarifEkle = @"insert into tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar, Path) values (@TarifAdi, @Kategori, @HazirlamaSuresi, @Talimatlar, @Path)";
                cmd = new MySqlCommand(query_tarifEkle, con);
                cmd.Parameters.AddWithValue("@TarifAdi", tarif_adi);
                cmd.Parameters.AddWithValue("@Kategori", kategori);
                cmd.Parameters.AddWithValue("@HazirlamaSuresi", hazirlamaSuresi);
                cmd.Parameters.AddWithValue("@Talimatlar", talimatlar);
                cmd.Parameters.AddWithValue("@Path", path);
                cmd.ExecuteNonQuery();
                con.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Tarif ekleme hatası: " + ex.Message);
            }
        }

        public void databaseDoldur()
        {
            try
            {
                //string tarif_adi, string kategori, int hazirlamaSuresi, string talimatlar
                tarif_ekle("tarif1", "Yemek", 21, "asdkhjnadsjkhnajsdkhnasdh", "");
                tarif_ekle("tarif2", "Çorba", 21241, "asdkhjnadsjasdhasdhkhnajsdkhnasdh", "");
                tarif_ekle("tarif3", "Tatlı", 22141, "asdkhjnadasdhasdsjkhnajsdkhnasdh", "");
                tarif_ekle("tarif4", "Çorba", 21241, "asdkhjnadsasdhasdhjkhnajsdkhnasdh", "");
                tarif_ekle("tarif5", "Tatlı", 211, "asdkhjnadsjkasdhasdhhnajsdkhnasdh", "");

                //string malzeme_adi, string toplam_miktar, string malzeme_birim, float birimFiyat
                malzeme_ekle("malzeme1", "4212", "Gram", 1f);
                malzeme_ekle("malzeme2", "4212", "Gram", 100f);
                malzeme_ekle("malzeme3", "4212", "Gram", 1f);
                malzeme_ekle("malzeme4", "4212", "Gram", 1f);

                // ilki malzeme id, 2. tarif id, 3. miktar
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
                MessageBox.Show("Database doldurma hatası: " + ex.Message);
            }
        }

        public void initDatabase()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                //adapter = new MySqlDataAdapter(""); 
                //adapter.Fill(dt); //DataAdapter, SQL sorgusunu çalıştırır ve sonuçları DataTable'a doldurur.


                string query1 = @"CREATE TABLE IF NOT EXISTS `yazlab1`.`tarifler` (
                                    `TarifID` INT NOT NULL AUTO_INCREMENT,
                                    `TarifAdi` VARCHAR(255) NOT NULL,
                                    `Kategori` VARCHAR(255) NOT NULL,
                                    `HazirlamaSuresi` INT NOT NULL,
                                    `Talimatlar` TEXT(5000) NOT NULL,
                                    `Path` TEXT(5000) NOT NULL,
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
                //MessageBox.Show("Tablolar Başarıyla Oluşturuldu!");



                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Tablo oluşturma hatası: " + ex.Message);
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

        public DataTable queryTarif()
        {
            DataTable dt_tarif = new DataTable();
            int sayfaBasinaTarif = 3;
            int ComboBoxNum = comboBoxSayfa1.SelectedIndex + 1;
            /*
            if (ComboBoxNum < 1)
            {
                ComboBoxNum = 1;
            }
            */
            int offset = (ComboBoxNum - 1) * sayfaBasinaTarif;
            try
            {
                con.Open();
                string query_tarif = @"select * from tarifler limit @offset, @sayfaBasinaTarif";
                adapter = new MySqlDataAdapter(query_tarif, con);
                adapter.SelectCommand.Parameters.AddWithValue("@offset", offset);
                adapter.SelectCommand.Parameters.AddWithValue("@sayfaBasinaTarif", sayfaBasinaTarif);
                adapter.Fill(dt_tarif);
                con.Close();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma query hatası: " + ex1.Message);
            }

            return dt_tarif;
        }

        public void panelGorunurlukAyarlama(DataTable tarif)
        {
            int len = tarif.Rows.Count;
            //MessageBox.Show("len" + len.ToString());
            if (len == 1)
            {
                panel11.Visible = true;

                panel12.Visible = false;
                panel13.Visible = false;

            }
            else if (len == 2)
            {
                panel11.Visible = true;
                panel12.Visible = true;

                panel13.Visible = false;

                //3. paneli unvisable yap
            }
            else if (len == 3)
            {
                panel11.Visible = true;
                panel12.Visible = true;
                panel13.Visible = true;
            }
        }


        public void elementDoldurma(DataTable table)
        {

            this.panelGorunurlukAyarlama(table);
            int num = 1;
            foreach (DataRow row in table.Rows)
            {
                //resim
                //string default_path = "C:/Users/ardah/Desktop/proje22/images/404.png";
                string default_path = "C:\\Users\\sefat\\OneDrive\\Masaüstü\\Recipe-Guide-App\\images/404.png";

                string pictureBoxName = "pictureBoxTarif" + num.ToString();
                PictureBox pic_name = this.Controls.Find(pictureBoxName, true).FirstOrDefault() as PictureBox;
                pic_name.SizeMode = PictureBoxSizeMode.StretchImage;
                if (pic_name != null)
                {
                    string path = row["Path"].ToString();
                    if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                    {
                        pic_name.Image = Image.FromFile(path);
                    }
                    else
                    {
                        pic_name.Image = Image.FromFile(default_path);
                    }
                }
                else
                {
                    MessageBox.Show("picturebox name hatasi!");
                }




                //name
                string labelName = "labelName" + num.ToString();
                Label lbl_name = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (lbl_name != null)
                {
                    lbl_name.Text = row["TarifAdi"].ToString();
                }
                else
                {
                    MessageBox.Show("label name hatasi!");

                }

                //maliyet - eksik varsa miktar - malzemeler

                float maliyet = 0f;
                float gereken = 0f;
                string id = row["TarifID"].ToString();

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


                        //richboxes
                        string richLeftName = "richTextBoxTam1" + num.ToString();
                        KryptonRichTextBox rich_left = this.Controls.Find(richLeftName, true).FirstOrDefault() as KryptonRichTextBox;
                        if (rich_left != null)
                        {
                            rich_left.Text = yeterli_malzemeler;
                            rich_left.SelectAll();
                            //rich_left.BorderStyle = BorderStyle.None;
                        }
                        else
                        {
                            MessageBox.Show("left richtextbox hatasi!");
                        }

                        string richRightName = "richTextBoxEksik1" + num.ToString();
                        KryptonRichTextBox rich_right = this.Controls.Find(richRightName, true).FirstOrDefault() as KryptonRichTextBox;
                        if (rich_right != null)
                        {
                            rich_right.Text = yetersiz_malzemeler;
                            rich_right.SelectAll();

                        }
                        else
                        {
                            MessageBox.Show("left richtextbox hatasi!");
                        }


                        //maliyet
                        string labelMaliyetName = "labelMaliyet" + num.ToString();
                        Label maliyetLabel = this.Controls.Find(labelMaliyetName, true).FirstOrDefault() as Label;
                        if (maliyetLabel != null)
                        {
                            maliyetLabel.Text = maliyet.ToString() + "₺";
                        }
                        else
                        {
                            MessageBox.Show("Maliyet label hatasi!");
                        }


                        //eksik
                        string labelEksikName = "labelGereken" + num.ToString();
                        Label eksikLabel = this.Controls.Find(labelEksikName, true).FirstOrDefault() as Label;
                        if (eksikLabel != null)
                        {
                            eksikLabel.Text = "Gerekli Fiyat: " + gereken.ToString() + "₺";
                        }
                        else
                        {
                            MessageBox.Show("eksik bilgi label hatasi!");
                        }




                    }

                }







                //kategori
                string kategoriLabelName = "labelKategori" + num.ToString();
                Label lbl_kategori = this.Controls.Find(kategoriLabelName, true).FirstOrDefault() as Label;
                if (lbl_kategori != null)
                {
                    lbl_kategori.Text = row["Kategori"].ToString();
                }
                else
                {
                    MessageBox.Show("label kategori hatasi!");
                }

                //hazirlanma suresi
                string sureLabelName = "labelSure" + num.ToString();
                Label lbl_sure = this.Controls.Find(sureLabelName, true).FirstOrDefault() as Label;
                if (lbl_sure != null)
                {
                    lbl_sure.Text = row["HazirlamaSuresi"].ToString() + " Dakika";
                }
                else
                {
                    MessageBox.Show("label hazirlanma suresi hatasi!");
                }






                //talimatlar
                string talimatlarRTBName = "richTextBoxTalimat1" + num.ToString();
                //Label lbl_talimatlar = this.Controls.Find(talimatlarLabelName, true).FirstOrDefault() as Label;
                KryptonRichTextBox richTextBox_talimatlar = this.Controls.Find(talimatlarRTBName, true).FirstOrDefault() as KryptonRichTextBox;
                //lbl_talimatlar.AutoSize = true;
                //lbl_talimatlar.MaximumSize = new Size(250, 0);
                //lbl_talimatlar.Font = new Font(lbl_talimatlar.Font.FontFamily, 8);


                if (richTextBox_talimatlar != null)
                {
                    richTextBox_talimatlar.Text = row["Talimatlar"].ToString();
                }
                else
                {
                    MessageBox.Show("label talimatlar hatasi!");
                }


                num++;
            }
        }

        public void sayfayiDoldur(string query)
        {
            DataTable dt_tarif_num = new DataTable();
            //combobox'ı doldur
            try
            {
                con.Open();
                //string query_tarif = @"select * from tarifler";
                adapter = new MySqlDataAdapter(query, con);
                adapter.Fill(dt_tarif_num);
                con.Close();

                int len_tarif = dt_tarif_num.Rows.Count;
                int sayfa_sayisi = (int)Math.Ceiling((double)len_tarif / 3);

                //combobox temizle
                comboBoxSayfa1.Items.Clear();

                for (int i = 1; i <= sayfa_sayisi; i++)
                {
                    comboBoxSayfa1.Items.Add(i.ToString());
                }
                //default 1 secili olsun
                if (comboBoxSayfa1.Items.Count > 0)
                {
                    comboBoxSayfa1.SelectedIndex = 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ComboBox doldurma hatası: " + ex.Message);
            }

            DataTable dt_tarif = new DataTable();
            try
            {
                dt_tarif = queryTarif();
                //MessageBox.Show("sayi:" + dt_tarif.Rows.Count);

                //panel gözükme olayı burada ayarlanacak


                this.elementDoldurma(dt_tarif);


            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma hatası: " + ex1.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initDatabase();
            databaseDoldur();
            sayfayiDoldur(@"select * from tarifler");
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
                tarifListesi = new FormTarifListesi(this);

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
            panelAnaManu.Visible = false;
        }

        private void TarifEkleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifEkleme = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (malzemeListesi == null)
            {
                malzemeListesi = new FormMalzemeListesi(this);
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

        private void button9_Click(object sender, EventArgs e)
        {
            //sayfa sec
            DataTable dt_tarif = new DataTable();
            try
            {
                dt_tarif = queryTarif();
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma hatası: " + ex1.Message);
            }

        }

        private void labelGereken1_Click(object sender, EventArgs e)
        {

        }

        private void labelGereken2_Click(object sender, EventArgs e)
        {

        }

        private void labelMaliyet3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //sol


            //en sol mu kontrol - return
            int ComboBoxNum = comboBoxSayfa1.SelectedIndex + 1;
            if (ComboBoxNum <= 1)
            {
                return;
            }

            //bir azaltma
            comboBoxSayfa1.SelectedIndex -= 1;

            DataTable dt_tarif = new DataTable();
            try
            {
                dt_tarif = queryTarif();
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma hatası: " + ex1.Message);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //sag

            //en sag mi kontrol - return
            int ComboBoxNum = comboBoxSayfa1.SelectedIndex + 1;
            int combo_lenEleman = comboBoxSayfa1.Items.Count;
            if (ComboBoxNum == combo_lenEleman)
            {
                return;
            }


            //bir arttirma
            comboBoxSayfa1.SelectedIndex += 1;

            DataTable dt_tarif = new DataTable();
            try
            {
                dt_tarif = queryTarif();
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma hatası: " + ex1.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelAnaManu.Visible = true;
            arama = null;
            tarifOnerme = null;
            tarifListesi = null;
            tarifEkleme = null;
            malzemeListesi = null;
            malzemeEkleme = null;
            tarifEkrani = null;
            sayfayiDoldur(@"select * from tarifler");
        }

        public void nameToForm(string name)
        {
            DataTable tarif = new DataTable();
            int id = -1;
            try
            {
                //MessageBox.Show(name.ToString());
                con.Open();
                string query_nameToTarif = @"select * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_nameToTarif, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", name);
                adapter.Fill(tarif);
                con.Close();



                if (tarif.Rows.Count != 1)
                {
                    MessageBox.Show("tarif bulunurken hata!");
                    return;
                }

                foreach (DataRow row in tarif.Rows)
                {
                    id = int.Parse(row["TarifID"].ToString());
                }

                tarifEkrani = new TarifEkrani(this, id);
                tarifEkrani.FormClosed += tarifEkrani_FormClosed;
                tarifEkrani.MdiParent = this;
                tarifEkrani.Dock = DockStyle.Fill;
                tarifEkrani.Show();

                
                panelAnaManu.Visible = false;



            }
            catch (Exception ex)
            {
                MessageBox.Show("İsimden forma geçilirken hata: ", ex.Message);
            }
        }

        private void tarifEkrani_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifEkrani = null;
        }

        public void tarifTemizle(string name)
        {
            //tarif kontrol
            DataTable tarif = new DataTable();
            try
            {
                con.Open();
                string query_tarifKontrol = @"select * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", name);
                adapter.Fill(tarif);
                con.Close();

                if (tarif.Rows.Count != 1)
                {
                    MessageBox.Show("İstenilen tarif bulunamadi");
                    return;
                }

                //tarifi sil
                con.Open();
                string query_tarifSil = @"DELETE from tarifler where TarifAdi = @TarifAdi";
                cmd = new MySqlCommand(query_tarifSil, con);
                cmd.Parameters.AddWithValue("@TarifAdi", name);
                cmd.ExecuteNonQuery();
                con.Close();

                //sayfayi tekrar doldur
                this.sayfayiDoldur(@"select * from tarifler");


            }
            catch (Exception e)
            {
                MessageBox.Show("tarif silme hatasi: ", e.Message);
            }
        }

        public void tarifDuzenleEkraniGecis(string name)
        {
            DataTable tarif = new DataTable();
            try
            {
                //tarif var mi kontrol
                con.Open();
                string query_tarifKontrol = @"select * from tarifler where TarifAdi = @TarifAdi";
                adapter = new MySqlDataAdapter(query_tarifKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifAdi", name);
                adapter.Fill(tarif);
                con.Close();

                if (tarif.Rows.Count != 1)
                {
                    MessageBox.Show("İstenilen tarif bulunamadi");
                    return;
                }

                formTarifDuzenle = new FormTarifDuzenle(name);
                formTarifDuzenle.FormClosed += FormTarifDuzenle_FormClosed;
                formTarifDuzenle.MdiParent = this;
                formTarifDuzenle.Dock = DockStyle.Fill;
                formTarifDuzenle.Show();
                /*
                //sayfaya gecis
                if (formTarifDuzenle == null)
                {
                    formTarifDuzenle = new FormTarifDuzenle(name);
                    formTarifDuzenle.FormClosed += FormTarifDuzenle_FormClosed;
                    formTarifDuzenle.MdiParent = this;
                    formTarifDuzenle.Dock = DockStyle.Fill;
                    formTarifDuzenle.Show();
                }
                else
                {
                    formTarifDuzenle.Activate();
                }
                */
                panelAnaManu.Visible = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("tarif güncelleme hatasi: ", e.Message);
            }



        }

        private void FormTarifDuzenle_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formTarifDuzenle = null;
        }

        private void buttonSayfa1_Click(object sender, EventArgs e)
        {
            DataTable dt_tarif = new DataTable();
            try
            {
                dt_tarif = queryTarif();
                //MessageBox.Show("sayi:" + dt_tarif.Rows.Count);

                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Sayfa doldurma hatası: " + ex1.Message);
            }
        }

        private void pictureBox13_Click_1(object sender, EventArgs e)
        {
            string name = labelName1.Text;
            this.tarifDuzenleEkraniGecis(name);
        }

        private void pictureBox16_Click_1(object sender, EventArgs e)
        {
            string name = labelName2.Text;
            this.tarifDuzenleEkraniGecis(name);
        }

        private void pictureBox18_Click_1(object sender, EventArgs e)
        {
            string name = labelName3.Text;
            this.tarifDuzenleEkraniGecis(name);
        }

        private void pictureBox14_Click_1(object sender, EventArgs e)
        {
            string name = labelName1.Text;
            this.tarifTemizle(name);
        }

        private void pictureBox15_Click_1(object sender, EventArgs e)
        {
            string name = labelName2.Text;
            this.tarifTemizle(name);
        }

        private void pictureBox17_Click_1(object sender, EventArgs e)
        {
            string name = labelName3.Text;
            this.tarifTemizle(name);
        }

        private void pictureBoxTarif1_Click_1(object sender, EventArgs e)
        {
            string name = labelName1.Text;
            this.nameToForm(name);
        }

        private void pictureBoxTarif2_Click_1(object sender, EventArgs e)
        {
            string name = labelName2.Text;
            this.nameToForm(name);
        }

        private void pictureBoxTarif3_Click_1(object sender, EventArgs e)
        {
            string name = labelName3.Text;
            this.nameToForm(name);
        }

        private void labelName1_Click_1(object sender, EventArgs e)
        {
            string name = labelName1.Text;
            this.nameToForm(name);
        }

        private void labelName2_Click_1(object sender, EventArgs e)
        {
            string name = labelName2.Text;
            this.nameToForm(name);
        }

        private void labelName3_Click_1(object sender, EventArgs e)
        {
            string name = labelName3.Text;
            this.nameToForm(name);
        }
    }





}