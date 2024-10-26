using System.Data;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Krypton.Toolkit;
using Org.BouncyCastle.Asn1.Smime;
//using ComponentFactory.Krypton.Toolkit;

namespace YazLab1_1
{


    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");

        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
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


        string anaQuery = @"select * from tarifler ORDER BY TarifAdi ASC";

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

        public void tarif_ekle(string tarif_adi, string kategori, int hazirlamaSuresi, string talimatlar, float maliyet, string path, int malzemeSayisi)
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
                string query_tarifEkle = @"insert into tarifler (TarifAdi, Kategori, HazirlamaSuresi, Talimatlar, Maliyet, Path, MalzemeSayisi) values (@TarifAdi, @Kategori, @HazirlamaSuresi, @Talimatlar, @Maliyet, @Path, @MalzemeSayisi)";
                cmd = new MySqlCommand(query_tarifEkle, con);
                cmd.Parameters.AddWithValue("@TarifAdi", tarif_adi);
                cmd.Parameters.AddWithValue("@Kategori", kategori);
                cmd.Parameters.AddWithValue("@HazirlamaSuresi", hazirlamaSuresi);
                cmd.Parameters.AddWithValue("@Talimatlar", talimatlar);
                cmd.Parameters.AddWithValue("@Maliyet", 0f);
                cmd.Parameters.AddWithValue("@Path", path);
                cmd.Parameters.AddWithValue("@MalzemeSayisi", 0);

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
                //Kahvaltı
                //1-10
                tarif_ekle("Kahveli Yulaf Lapası", "Kahvaltı", 20, "1. Küçük bir tencereye yulaf ezmesini ve sütü ekliyoruz.\r\n2. Altını açarak kaynayana kadar ara ara karıştırarak pişiriyoruz.\r\n3. Kaynadıktan sonra altını kapatarak üzerine kahve ve tarçını ekliyoruz.\r\n4. Kahve eriyip yulaf lapasına iyice karışana kadar karıştırıyoruz.\r\n5. Üzerine muz dilimleri veya kuruyemiş ekleyebilirsiniz. \r\n(Bu eklemeler kalori değerini arttıracaktır!)\r\n", 0f, "", 0);
                tarif_ekle("Unsuz Muzlu Pankek", "Kahvaltı", 12, "1. Muzu çatal yardımıyla ezerek püre kıvamına getiriyoruz.\r\n2. Yumurtaları muz püresinin üzerine kırarak iyice çırpıyoruz.\r\n3. Tavayı yağladıktan sonra harcımızdan her seferinde birer \r\nyemek kaşığı alarak tavaya ekliyoruz.\r\n4. Üst kısmında kabarcıklar oluştuğunda çevirip diğer \r\nyüzünü de pişiriyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Kahveli Pankek", "Kahvaltı", 15, "1. Yulaf ezmesini blender yardımıyla un haline getiriyoruz.\r\n2. Tüm malzemeleri karıştırıp iyice çırparak homojen bir \r\nkıvama getiriyoruz.\r\n3. Yapışmaz yüzeyli tavayı ısıttıktan sonra harcımızı birer \r\nkaşık birer kaşık olarak tavaya ekliyoruz.\r\n4. Üst kısmında kabarcıklar çıktığında pankekleri çevirerek \r\ndiğer yüzlerini de pişiriyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Lor Tava", "Kahvaltı", 8, "1. Tavada tereyağını eritiyoruz.\r\n2. Üzerine lor peynirini ekleyip 1 dakika kadar pişiriyoruz.\r\n3. Domates püresini ekleyip birkaç dakika karıştırarak pişiriyoruz.\r\n4. Son olarak üzerine istediğimiz baharatları ekleyerek lezzetlendiriyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Ev Yapımı Notella", "Kahvaltı", 15, "1. Fındıkları bir tavaya alarak birkaç dakika kavuruyoruz.\r\n2. Hurmaları 15 dakika kadar sıcak suda bekletip çekirdeklerini ayırıyoruz.\r\n3. Fındıkların üzerine 1 yemek kaşığı kadar hurma suyundan ekleyip blenderdan geçiriyoruz.\r\n4. Hurmaları, balı ve kakaoyu da blender kabına ekleyip tekrar blenderdan geçiriyoruz. Bu aşamada hurma suyundan ekleyerek fındık kremanızı istediğiniz kıvama getirebilirsiniz.\r\n", 0f, "", 0);
                tarif_ekle("Mantarlı Fit Omlet", "Kahvaltı", 13, "1. Mantarların zarlarını soyup dilimliyoruz.\r\n2. Tavanın altını ısıtıp zeytinyağını da koyduktan sonra mantarları bir kaşık yardımıyla çevirerek birkaç dakika pişiriyoruz.\r\n3. Yumurtaları çırpıp mantarların üzerine döküyoruz ve tavanın üzerini kapatıyoruz.\r\n4. Tavadaki karışımın alt tabanı piştikten sonra üzerine lor peynirlerini de ekleyip kapağını tekrar kapatıyoruz ve üst kısmının da pişmesini sağlıyoruz.\r\n5. Son olarak üzerine pul biber veya istediğiniz farklı baharatları ekleyerek servis edebilirsiniz.\r\n", 0f, "", 0);
                tarif_ekle("Ispanaklı ve Peynirli Omlet", "Kahvaltı", 13, "1. Ispanakları iyice yıkayıp ince ince doğruyoruz.\r\n2. Beyaz peyniri de küçük parçalar halinde doğrayıp ıspanakla karıştırıyoruz.\r\n3. Yapışmaz yüzeyli tavayı ısıttıktan sonra ıspanak ve peynir karışımını peynirler yumuşayana kadar pişiriyoruz. (Tereyağı kullanacaksanız bu aşamada ekleyebilirsiniz.)\r\n4. Üzerine yumurtaları da ekleyip karıştırarak pişiriyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Muzlu Yulaf Lapası", "Kahvaltı", 7, "1. Yulaf ezmesini bir kaseye alıp üzerine yulafları kaplayacak kadar sıcak su ekliyoruz. 5 dakika kadar yulafın yumuşamasını bekliyoruz. (Süreci hızlandırmak için kasenin üzerini bir tabak yardımıyla kapatabilirsiniz.)\r\n2. Yulaflar yumuşadıktan sonra üzerine tarçın ve keçiboynuzu unu (veya bal) ekliyoruz. İyice karıştırıyoruz.\r\n3. Muzları dilimleyerek kaseye alıyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Fıstık Ezmesi", "Kahvaltı", 15, "1. Fıstıkların kabukları soyulur ve tavada 5 dakika kadar kavrulur.\r\n2. Rondo veya blender yardımıyla iyice parçalanır.\r\n3. İsteğe göre bal ekleyerek tatlandırılır ve yağ ekleyerek akışkan kıvama getirilir.\r\n4. İyice karıştırılır, afiyet olsun!\r\n", 0f, "", 0);
                tarif_ekle("Tahinli Unsuz Pankek", "Kahvaltı", 15, "1. Susamları tavada birkaç dakika ısıtıyoruz, rengi biraz karardıktan sonra ateşten alıp kenara koyuyoruz.\r\n2. Muzu çatal yardımıyla ezerek püre haline getiriyoruz.\r\n3. Muz püresinin üzerine yumurtaları kırıyoruz ve iyice çırpıyoruz. İyice çırptıktan sonra tarçın ve tahini de karışımın üzerine ekliyoruz.\r\n4. Tavayı yağlayıp biraz ısıtıyoruz. Daha sonra harcımızı tavaya alarak pişiriyoruz. (Tüm harcı tek pankek olarak pişirmeye çalışmayın, çevirmesi zor olacaktır. Bir yemek kaşıklık boyutlarda alarak pişirebilirsiniz.)\r\n5. Pişirirken pankeklerin üst kısmında kabarcıklar oluştuğunda çevirebilirsiniz.\r\n6. Pişen pankekleri tabağımıza aldıktan sonra üzerine bal ve kavurduğumuz susamları da ekliyoruz.\r\n", 0f, "", 0);
                //11-20
                tarif_ekle("Protein Bohçası", "Kahvaltı", 13, "1. Lor peynirini ufalıyoruz ve üzerine domates püresini de ekleyip karıştırıyoruz.\r\n2. Yumurtaları başka bir kabın içine kırarak iyice çırpıyoruz.\r\n3. Tavamızı ısıttıktan sonra yağı ekliyoruz ve çırptığımız yumurtaları tavaya döküyoruz.\r\n4. Yumurtaların altı piştikten sonra üzerinin orta kısmına lor karışımını ekliyoruz.\r\n5. Ardından yumurtanın sağ ve sol kısmını içe doğru, yani lor karışımının üzerine doğru katlıyoruz.\r\n6. İç kısmı da piştikten sonra tabağımıza alıp üzerine kekik serpiyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Tok Tutan Protein Tostu", "Kahvaltı", 8, "1. Kaşarları küçük küçük doğruyoruz.\r\n2. Lor peynirini domates suyuyla veya domates püresiyle biraz sulandırarak karıştırıyoruz.\r\n3. Ekmeği kestikten sonra alt ve üst katmana kaşarları, aralarına da lor peynirini koyuyoruz.\r\n4. Tost makinesinde pişirdikten sonra dilimliyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Akşamdan Hazırlamalık Kahvaltı", "Kahvaltı", 3, "1. Yulaf ve sütü bir kaba ekleyerek 15 dakika kadar buzdolabında bekletiyoruz.\r\n2. Meyveleri dilimliyoruz, isteğe bağlı eklenecek diğer malzemelerle birlikte (fıstık ezmesi, hindistan cevizi, bal) yulaf karışımına ekliyoruz.\r\n3. Üzerini kapatarak akşamdan buzdolabına atıyoruz. Sabah dolaptan çıkarıp karıştırıyoruz.\r\n", 0f, "", 0);
                tarif_ekle("Fit Fransız Tostu", "Kahvaltı", 20, "1. Yumurtaları geniş bir kabın içine kırarak çırpıyoruz.\r\n2. Whey proteini sütle beraber iyice karıştırıyoruz.\r\n3. Tüm malzemeleri çırptığımız yumurtaların üzerine ekleyerek çırpıyoruz. (Bu aşamada blender da kullanabilirsiniz.)\r\n4. Tavayı ısıtıp yağlıyoruz.\r\n5. Tost ekmeklerini az önce hazırladığımız karışımın içine atarak ıslatıp iyice emdiriyoruz.\r\n6. Daha sonra tavaya alıyoruz ve çevirerek iki tarafını da kızartıyoruz.\r\n", 0f, "", 0);







                //string malzeme_adi, string toplam_miktar, string malzeme_birim, float birimFiyat
                //1-10
                malzeme_ekle("Yulaf Ezmesi", "10", "Gram", 0.05f);
                malzeme_ekle("Süt", "20.2", "Mililitre", 0.03f);
                malzeme_ekle("Tarçın", "0", "Gram", 0.9f);
                malzeme_ekle("Türk Kahvesi", "0", "Gram", 0.55f);
                malzeme_ekle("Muz", "0", "Tane", 11.0f);
                malzeme_ekle("Yumurta", "0", "Tane", 4.85f);
                malzeme_ekle("Yoğurt", "0", "Gram", 0.9f);
                malzeme_ekle("Kabartma Tozu", "0", "Tane", 0.25f);
                malzeme_ekle("Hindistan Cevizi", "0", "Gram", 0.6f);
                malzeme_ekle("Lor Peyniri", "0", "Gram", 0.85f);
                //11-20
                malzeme_ekle("Tereyağı", "0", "Gram", 0.35f);
                malzeme_ekle("Domates Püresi", "0", "Gram", 0.75f);
                malzeme_ekle("Fındık", "0", "Gram", 0.4f);
                malzeme_ekle("Kakao", "0", "Gram", 0.35f);
                malzeme_ekle("Hurma", "0", "Adet", 6.3f);
                malzeme_ekle("Bal", "0", "Gram", 0.65f);
                malzeme_ekle("Kültür Mantarı", "0", "Gram", 0.15f);
                malzeme_ekle("Pul Biber", "0", "Gram", 0.7f);
                malzeme_ekle("Zeytinyağı", "0", "Mililitre", 0.3f);
                malzeme_ekle("Ispanak", "0", "Gram", 0.15f);
                //21-30
                malzeme_ekle("Beyaz Peynir", "0", "Gram", 0.3f);
                malzeme_ekle("Un", "0", "Gram", 0.02f);
                malzeme_ekle("Fıstık", "0", "Gram", 0.3f);
                malzeme_ekle("Hindistan Cevizi Yağı", "0", "Mililitre", 0.7f);
                malzeme_ekle("Susam", "0", "Gram", 0.4f);
                malzeme_ekle("Tahin", "0", "Gram", 0.3f);
                malzeme_ekle("Kaşar Peyniri", "0", "Gram", 0.3f);
                malzeme_ekle("Tam Tahıllı Ekmek Dilimi", "0", "Adet", 3.0f);
                malzeme_ekle("Domates Suyu", "0", "Mililitre", 0.07f);
                malzeme_ekle("Fıstık Ezmesi", "0", "Gram", 0.45f);
                //31-40
                malzeme_ekle("Whey Protein", "0", "Ölçek", 1.15f);





                // ilki malzeme id, 2. tarif id, 3. miktar
                iliski_ekle(1, 1, 200);
                iliski_ekle(2, 1, 200);
                iliski_ekle(3, 1, 6);
                iliski_ekle(4, 1, 13);
                iliski_ekle(5, 2, 1);
                iliski_ekle(6, 2, 2);
                iliski_ekle(24, 2, 6);
                iliski_ekle(1, 3, 100);
                iliski_ekle(7, 3, 20);
                iliski_ekle(4, 3, 13);
                iliski_ekle(8, 3, 1);
                iliski_ekle(6, 3, 2);
                iliski_ekle(9, 3, 13);
                iliski_ekle(10, 4, 200);
                iliski_ekle(11, 4, 20);
                iliski_ekle(12, 4, 20);
                iliski_ekle(13, 5, 200);
                iliski_ekle(14, 5, 20);
                iliski_ekle(15, 5, 12);
                iliski_ekle(16, 5, 13);
                iliski_ekle(10, 6, 60);
                iliski_ekle(6, 6, 2);
                iliski_ekle(17, 6, 250);
                iliski_ekle(18, 6, 6);
                iliski_ekle(19, 6, 6);
                iliski_ekle(20, 7, 250);
                iliski_ekle(21, 7, 50);
                iliski_ekle(6, 7, 2);
                iliski_ekle(11, 7, 13);
                iliski_ekle(1, 8, 100);
                iliski_ekle(5, 8, 1);
                iliski_ekle(3, 8, 6);
                iliski_ekle(22, 8, 13);
                iliski_ekle(16, 8, 6);
                iliski_ekle(23, 9, 160);
                iliski_ekle(24, 9, 20);
                iliski_ekle(16, 9, 13);
                iliski_ekle(25, 10, 13);
                iliski_ekle(5, 10, 1);
                iliski_ekle(6, 10, 2);
                iliski_ekle(3, 10, 6);
                iliski_ekle(26, 10, 20);
                iliski_ekle(24, 10, 6);
                iliski_ekle(26, 10, 6);
                iliski_ekle(6, 11, 2);
                iliski_ekle(10, 11, 50);
                iliski_ekle(11, 11, 10);
                iliski_ekle(12, 11, 20);
                iliski_ekle(10, 12, 100);
                iliski_ekle(27, 12, 40);
                iliski_ekle(28, 12, 2);
                iliski_ekle(29, 12, 50);
                iliski_ekle(1, 13, 60);
                iliski_ekle(2, 13, 200);
                iliski_ekle(5, 13, 1);
                iliski_ekle(30, 13, 20);
                iliski_ekle(9, 13, 6);
                iliski_ekle(3, 13, 6);
                iliski_ekle(6, 14, 1);
                iliski_ekle(2, 14, 100);
                iliski_ekle(28, 14, 4);
                iliski_ekle(24, 14, 20);
                iliski_ekle(31, 14, 20);
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
                                    `Maliyet` FLOAT NOT NULL,
                                    `MalzemeSayisi` INT NOT NULL,
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
                //textBox1.Text = "basarili3";
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

        private void AdjustFontSize(Label label)
        {
            Font font = label.Font;
            float fontSize = font.Size;

            //MessageBox.Show(label.PreferredWidth.ToString());
            while (254 < label.Width && fontSize > 1)
            {
                fontSize -= 0.5f; // Boyutu küçült
                label.Font = new Font(font.FontFamily, fontSize, font.Style);
            }

        }


        public void elementDoldurma(DataTable table)
        {

            this.panelGorunurlukAyarlama(table);
            int num = 1;
            foreach (DataRow row in table.Rows)
            {
                //resim
                string default_path = "C:/Users/ardah/Desktop/proje24/images/404.png";
                //string default_path = "C:\\Users\\sefat\\OneDrive\\Masaüstü\\Recipe-Guide-App\\images/404.png";
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
                this.AdjustFontSize(lbl_name);
                //maliyet - eksik varsa miktar - malzemeler

                float maliyet = 0f;
                float gereken = 0f;
                string id = row["TarifID"].ToString();
                float tum_miktar = 0f;
                float sahip_olunanlar = 0f;
                int malzeme_sayisi = 0;

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
                    malzeme_sayisi += 1;
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
                                    tum_miktar += malzeme_miktar;
                                    sahip_olunanlar += malzeme_miktar;

                                }
                                else
                                {
                                    tum_miktar += malzeme_miktar;
                                    sahip_olunanlar += neKadarVar;
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

                        //maliyet guncellemesi
                        try
                        {
                            con.Open();
                            string query_maliyetUpdate = @"UPDATE tarifler SET Maliyet= @Maliyet where TarifID= @TarifID";
                            MySqlCommand cmd = new MySqlCommand(query_maliyetUpdate, con);
                            cmd.Parameters.AddWithValue("@Maliyet", maliyet);
                            cmd.Parameters.AddWithValue("@TarifID", int.Parse(row["TarifID"].ToString()));
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected != 1)
                            {
                                MessageBox.Show("güncelleme hatasi");
                            }

                            con.Close();
                        }
                        catch (Exception ex6)
                        {
                            MessageBox.Show("maliyet guncelleme hatasi: " + ex6.Message);
                        }

                        //malzeme sayisi guncellemesi
                        try
                        {
                            con.Open();
                            string query_malzemeSayisiUpdate = @"UPDATE tarifler SET MalzemeSayisi= @MalzemeSayisi where TarifID= @TarifID";
                            MySqlCommand cmd = new MySqlCommand(query_malzemeSayisiUpdate, con);
                            cmd.Parameters.AddWithValue("@MalzemeSayisi", malzeme_sayisi);
                            cmd.Parameters.AddWithValue("@TarifID", int.Parse(row["TarifID"].ToString()));
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected != 1)
                            {
                                MessageBox.Show("güncelleme hatasi");
                            }

                            con.Close();
                        }
                        catch (Exception ex7)
                        {
                            MessageBox.Show("malzeme sayisi guncelleme hatasi: " + ex7.Message);
                        }

                        if (gereken < 0)
                        {
                            gereken *= -1;
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


                        //yuzde
                        string labelYuzde = "labelYuzde" + num.ToString();
                        Label yuzdeLabel = this.Controls.Find(labelYuzde, true).FirstOrDefault() as Label;
                        float sayi = (100 * sahip_olunanlar) / tum_miktar;
                        string yuzde_ = sayi.ToString("F2") + '%';
                        if (yuzdeLabel != null)
                        {
                            yuzdeLabel.Text = yuzde_;
                            if (sayi <= 100.0f)
                            {
                                yuzdeLabel.ForeColor = Color.Red;
                            }
                            else
                            {
                                yuzdeLabel.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            MessageBox.Show("yuzde label hatasi!");
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

        public void table_ile_doldurma(DataTable table)
        {
            try
            {

                int len_tarif = table.Rows.Count;
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
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < table.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(table.Rows[i]["TarifID"].ToString()),
                        table.Rows[i]["TarifAdi"].ToString(),
                        table.Rows[i]["Kategori"].ToString(),
                        int.Parse(table.Rows[i]["HazirlamaSuresi"].ToString()),
                        table.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(table.Rows[i]["Maliyet"].ToString()),
                        table.Rows[i]["Path"].ToString(),
                        int.Parse(table.Rows[i]["MalzemeSayisi"].ToString())
                 );
                }

                //MessageBox.Show("sayi:" + dt_tarif.Rows.Count);

                //panel gözükme olayı burada ayarlanacak


                this.elementDoldurma(dt_tarif);


            }
            catch (Exception ex1)
            {
                MessageBox.Show("1Sayfa doldurma hatası: " + ex1.Message);
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
                MessageBox.Show("2Sayfa doldurma hatası: " + ex1.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initDatabase();
            databaseDoldur();
            sayfayiDoldur(@"select * from tarifler ORDER BY TarifAdi ASC");
            this.anaQuery = @"select * from tarifler ORDER BY TarifAdi ASC";
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
                arama = new FormArama(this);
                arama.FormClosed += Arama_FormClosed;
                arama.MdiParent = this;
                arama.Show();
            }
            else
            {
                arama.Activate();
            }
            panelAnaManu.Visible = false;
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
        }

        private void Arama_FormClosed(object? sender, FormClosedEventArgs e)
        {
            arama = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tarifOnerme == null)
            {
                tarifOnerme = new FormTarifOnerme(this);
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
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
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
                tarifListesi.tabloGuncelle("select * from tarifler ORDER BY TarifAdi ASC");
                tarifListesi.Activate();
            }
            panelAnaManu.Visible = false;
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
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

                //malzemeler içini güncelle

                try
                {

                    DataTable dt = new DataTable();
                    con.Open();
                    string query_comboDoldur = @"SELECT MalzemeAdi from malzemeler";
                    adapter = new MySqlDataAdapter(query_comboDoldur, con);
                    adapter.Fill(dt);
                    con.Close();

                    tarifEkleme.comboBoxMalzemeSecimi1.Items.Clear(); //temizleme
                    foreach (DataRow row in dt.Rows)
                    {
                        tarifEkleme.comboBoxMalzemeSecimi1.Items.Add(row["MalzemeAdi"].ToString());
                    }
                }
                catch (Exception ex1)
                {
                    MessageBox.Show("malzeme combobox guncelleme hatası: " + ex1.Message);
                }

            }
            panelAnaManu.Visible = false;
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
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
                malzemeListesi.tabloGuncelle("select * from malzemeler ORDER BY MalzemeAdi ASC");
            }
            panelAnaManu.Visible = false;
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
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
            panel2.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
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
                MessageBox.Show("3Sayfa doldurma hatası: " + ex1.Message);
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
            DataTable table = new DataTable();
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(this.anaQuery, con);
                adapter.Fill(table);
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("table db doldurma hatası: " + ex2.Message);
            }


            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));

            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < table.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(table.Rows[i]["TarifID"].ToString()),
                        table.Rows[i]["TarifAdi"].ToString(),
                        table.Rows[i]["Kategori"].ToString(),
                        int.Parse(table.Rows[i]["HazirlamaSuresi"].ToString()),
                        table.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(table.Rows[i]["Maliyet"].ToString()),
                        table.Rows[i]["Path"].ToString(),
                        int.Parse(table.Rows[i]["MalzemeSayisi"].ToString())
                        );
                }
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("5Sayfa doldurma hatası: " + ex1.Message);
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
            DataTable table = new DataTable();
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(this.anaQuery, con);
                adapter.Fill(table);
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("table db doldurma hatası: " + ex2.Message);
            }

            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < table.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(table.Rows[i]["TarifID"].ToString()),
                        table.Rows[i]["TarifAdi"].ToString(),
                        table.Rows[i]["Kategori"].ToString(),
                        int.Parse(table.Rows[i]["HazirlamaSuresi"].ToString()),
                        table.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(table.Rows[i]["Maliyet"].ToString()),
                        table.Rows[i]["Path"].ToString(),
                        int.Parse(table.Rows[i]["MalzemeSayisi"].ToString())
                        );
                }
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("5Sayfa doldurma hatası: " + ex1.Message);
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
            sayfayiDoldur(@"select * from tarifler ORDER BY TarifAdi ASC");

            this.anaQuery = @"select * from tarifler ORDER BY TarifAdi ASC";
            panel2.Visible = true;
            pictureBox22.Visible = true;
            pictureBox23.Visible = true;
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
                this.anaQuery = @"select * from tarifler ORDER BY TarifAdi ASC";
                this.sayfayiDoldur(this.anaQuery);


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

            DataTable table = new DataTable();
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(this.anaQuery, con);
                adapter.Fill(table);
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("table db doldurma hatası: " + ex2.Message);
            }

            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < table.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(table.Rows[i]["TarifID"].ToString()),
                        table.Rows[i]["TarifAdi"].ToString(),
                        table.Rows[i]["Kategori"].ToString(),
                        int.Parse(table.Rows[i]["HazirlamaSuresi"].ToString()),
                        table.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(table.Rows[i]["Maliyet"].ToString()),
                        table.Rows[i]["Path"].ToString(),
                        int.Parse(table.Rows[i]["MalzemeSayisi"].ToString())
                        );
                }
                //MessageBox.Show("sayi:" + dt_tarif.Rows.Count);

                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("6Sayfa doldurma hatası: " + ex1.Message);
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

        private void pictureBox22_Click(object sender, EventArgs e)
        {

        }


        public void deneme1_SureAzCok()
        {
            DataTable sureAzCok = new DataTable();
            try
            {
                con.Open();
                string query_sureAzCok = "select * from tarifler ORDER BY HazirlamaSuresi  ASC";
                this.anaQuery = @"select * from tarifler ORDER BY HazirlamaSuresi ASC";
                adapter = new MySqlDataAdapter(anaQuery, con);
                adapter.Fill(sureAzCok);
                con.Close();

                this.table_ile_doldurma(sureAzCok);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }
        }

        public void deneme1_SureCokAz()
        {
            DataTable sureCokAz = new DataTable();
            try
            {
                con.Open();
                string query_sureCokAz = "select * from tarifler ORDER BY HazirlamaSuresi DESC";
                this.anaQuery = @"select * from tarifler ORDER BY HazirlamaSuresi DESC";
                adapter = new MySqlDataAdapter(query_sureCokAz, con);
                adapter.Fill(sureCokAz);
                con.Close();

                this.table_ile_doldurma(sureCokAz);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }
        }

        public void deneme2_MaliyetCokAz()
        {
            DataTable maliyetCokAz = new DataTable();
            try
            {
                con.Open();
                string query_maliyetCokAz = "select * from tarifler ORDER BY Maliyet DESC";
                this.anaQuery = @"select * from tarifler ORDER BY Maliyet DESC";
                adapter = new MySqlDataAdapter(query_maliyetCokAz, con);
                adapter.Fill(maliyetCokAz);
                con.Close();

                this.table_ile_doldurma(maliyetCokAz);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }


        }

        public void deneme2_MaliyetAzCok()
        {
            DataTable maliyetAzCok = new DataTable();
            try
            {
                con.Open();
                string query_maliyetAzCok = "select * from tarifler ORDER BY Maliyet  ASC";
                this.anaQuery = @"select * from tarifler ORDER BY Maliyet ASC";
                adapter = new MySqlDataAdapter(query_maliyetAzCok, con);
                adapter.Fill(maliyetAzCok);
                con.Close();

                this.table_ile_doldurma(maliyetAzCok);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }

        }
        private void loadDetails()
        {
            foreach (Data data in Data.list)
            {
                searchResultControl res = new searchResultControl(this, panelAnaManu);
                res.details(data);
                resultContainer.Controls.Add(res);
            }
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            if (textBoxArama.TextLength >= 1)
            {
                resultContainer.Controls.Clear();
                searchResultControl res = new searchResultControl(this, panelAnaManu);
                res.searchResult(textBoxArama.Text);
                loadDetails();
                resultContainer.Height = resultContainer.Controls.Count * 67;
            }
            else
            {
                resultContainer.Height = 0;
            }
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (panelFiltre.Visible)
            {
                panelFiltre.Visible = false;
            }
            else
            {
                panelFiltre.Visible = true;
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            //Artan (Süre)
            this.deneme1_SureAzCok();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            //Azalan (Süre)
            this.deneme1_SureCokAz();
        }

        private void kryptonButtonMaliyetArtan_Click(object sender, EventArgs e)
        {
            this.deneme2_MaliyetAzCok();
        }

        private void kryptonButtonMaliyetAzalan_Click(object sender, EventArgs e)
        {
            this.deneme2_MaliyetCokAz();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            //Malzeme
            string minMalzemeSayisi = textBoxMalzemeMin.Text;
            string maxMalzemeSayisi = textBoxMalzemeMax.Text;

            int minMalzemeSayi_int = 0;
            int maxMalzemeSayi_int = 0;

            if (!int.TryParse(minMalzemeSayisi, out minMalzemeSayi_int))
            {
                Console.WriteLine("min malzeme geçerli bir int değil!");
                return;
            }

            if (!int.TryParse(maxMalzemeSayisi, out maxMalzemeSayi_int))
            {
                Console.WriteLine("max malzeme geçerli bir int değil!");
                return;
            }

            if (minMalzemeSayi_int <= 0)
            {
                Console.WriteLine("min malzeme sayisi 0 ve 0'dan küçük olmamali");
                return;
            }

            if (maxMalzemeSayi_int <= 0)
            {
                Console.WriteLine("max malzeme sayisi 0 ve 0'dan küçük olmamali");
                return;
            }

            if (minMalzemeSayi_int > maxMalzemeSayi_int)
            {
                Console.WriteLine("min maxdan büyük olmamai");
                return;
            }

            DataTable malzemeSayisiTable = new DataTable();
            try
            {

                con.Open();
                string query_maliyetAzCok = "SELECT * FROM tarifler WHERE MalzemeSayisi BETWEEN " + minMalzemeSayi_int + " AND " + maxMalzemeSayi_int + " ORDER BY MalzemeSayisi ASC";
                adapter = new MySqlDataAdapter(query_maliyetAzCok, con);
                adapter.Fill(malzemeSayisiTable);
                con.Close();

                if (malzemeSayisiTable.Rows.Count > 0)
                {
                    this.table_ile_doldurma(malzemeSayisiTable);
                    this.anaQuery = query_maliyetAzCok;
                }
                else
                {
                    MessageBox.Show("Uygun tarifler bulunamadı!");
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }



        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            //Kategori
            if (checkedListBoxKategori.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Filtreleyeceğiniz kategorileri seçin.");
            }

            try
            {
                DataTable kategoriTable = new DataTable();

                List<string> selectedCategories = new List<string>();
                foreach (var item in checkedListBoxKategori.CheckedItems)
                {
                    selectedCategories.Add("'" + item.ToString() + "'"); // Kategorileri tek tırnak içinde ekliyoruz
                }
                string categories = string.Join(", ", selectedCategories);
                //SELECT * FROM tarifler WHERE Kategori IN ('x1', 'x2', 'x3');
                con.Open();
                string query_kategoriCheckList = "SELECT * FROM tarifler WHERE Kategori IN (" + categories + ")";
                adapter = new MySqlDataAdapter(query_kategoriCheckList, con);
                adapter.Fill(kategoriTable);
                con.Close();

                if (kategoriTable.Rows.Count > 0)
                {
                    this.table_ile_doldurma(kategoriTable);
                    this.anaQuery = query_kategoriCheckList;
                }
                else
                {
                    MessageBox.Show("Uygun tarifler bulunamadı!");
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }



        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            //Maliyet

            string minMaliyetSayisi = textBoxMaliyetMin.Text;
            string maxMaliyetSayisi = textBoxMaliyetMax.Text;

            int minMaliyetSayi_int = 0;
            int maxMaliyetSayi_int = 0;

            if (!int.TryParse(minMaliyetSayisi, out minMaliyetSayi_int))
            {
                Console.WriteLine("min maliyet geçerli bir int değil!");
                return;
            }

            if (!int.TryParse(maxMaliyetSayisi, out maxMaliyetSayi_int))
            {
                Console.WriteLine("max maliyet geçerli bir int değil!");
                return;
            }

            if (minMaliyetSayi_int <= 0)
            {
                Console.WriteLine("min maliyet sayisi 0 ve 0'dan küçük olmamali");
                return;
            }

            if (maxMaliyetSayi_int <= 0)
            {
                Console.WriteLine("max maliyet sayisi 0 ve 0'dan küçük olmamali");
                return;
            }

            if (minMaliyetSayi_int > maxMaliyetSayi_int)
            {
                Console.WriteLine("min maxdan büyük olmamai");
                return;
            }

            DataTable maliyetSayisiTable = new DataTable();
            try
            {

                con.Open();
                string query_maliyetAzCok = "SELECT * FROM tarifler WHERE Maliyet BETWEEN " + minMaliyetSayi_int + " AND " + maxMaliyetSayi_int + " ORDER BY Maliyet ASC";
                adapter = new MySqlDataAdapter(query_maliyetAzCok, con);
                adapter.Fill(maliyetSayisiTable);
                con.Close();

                if (maliyetSayisiTable.Rows.Count > 0)
                {
                    this.table_ile_doldurma(maliyetSayisiTable);
                    this.anaQuery = query_maliyetAzCok;
                }
                else
                {
                    MessageBox.Show("Uygun tarifler bulunamadı!");
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show("sure azcok hatasi: " + ex1.Message);
            }
        }
    }
}