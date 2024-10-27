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
using Krypton.Toolkit;

namespace YazLab1_1
{
    public partial class FormTarifOnerme : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");

        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        TarifEkrani tarifEkrani;
        Form1 form1_;
        Dictionary<int, float> dict_;

        public FormTarifOnerme()
        {
            InitializeComponent();
        }

        public FormTarifOnerme(Form1 form1)
        {
            InitializeComponent();
            this.form1_ = form1;
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

                //eslesmeYuzdesi 
                //string yuzde_ = sayi.ToString("F2") + '%';
                float temp_yuzde = 0f;
                string eslesmeYuzdesiName = "labelEslesmeYuzdesi" + num.ToString();
                Label lbl_eslesmeYuzde = this.Controls.Find(eslesmeYuzdesiName, true).FirstOrDefault() as Label;
                if (lbl_eslesmeYuzde != null)
                {
                    float yuzde = float.Parse(row["EslesmeYuzdesi"].ToString());
                    temp_yuzde = yuzde;
                    string raw_yuzde = yuzde.ToString("F2");
                    lbl_eslesmeYuzde.Text = raw_yuzde;
                }
                else
                {
                    MessageBox.Show("label eslesme yuzdesi hatasi!");
                }

                labelName = "labelName" + num.ToString();
                lbl_name = this.Controls.Find(labelName, true).FirstOrDefault() as Label;
                if (lbl_name != null)
                {
                    if (temp_yuzde == 100.0f)
                    {
                        lbl_name.ForeColor = Color.Green;
                    }
                    else if (temp_yuzde < 100.0f && temp_yuzde > 0f)
                    {
                        lbl_name.ForeColor = Color.FromArgb(255, 165, 0);
                    }
                    else
                    {
                        lbl_name.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("label name hatasi!");

                }



                num++;
            }
        }

        public void sayfayiDoldur(DataTable table)
        {
            int len_tarif = table.Rows.Count;
            int sayfa_sayisi = (int)Math.Ceiling((double)len_tarif / 3);

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

            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            dt_tarif.Columns.Add("EslesmeYuzdesi", typeof(float));
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
                        int.Parse(table.Rows[i]["MalzemeSayisi"].ToString()),
                        float.Parse(table.Rows[i]["EslesmeYuzdesi"].ToString())
                        );
                }


                this.elementDoldurma(dt_tarif);


            }
            catch (Exception ex1)
            {
                MessageBox.Show("2Sayfa doldurma hatası: " + ex1.Message);
            }

        }

        private void FormTarifOnerme_Load(object sender, EventArgs e)
        {
            //dict oluştur tum malzemeli
            try
            {
                DataTable tarifler = new DataTable();
                con.Open();
                string query_tarifleriAl = "select * from tarifler";
                adapter = new MySqlDataAdapter(query_tarifleriAl, con);
                adapter.Fill(tarifler);
                con.Close();

                Dictionary<int, float> tarif_iliski = new Dictionary<int, float>();
                Dictionary<int, float> tarif_maliyet = new Dictionary<int, float>();


                if (tarifler.Rows.Count <= 0)
                {
                    MessageBox.Show("Tarifler alinamadi");
                    return;
                }

                foreach (DataRow row3 in tarifler.Rows)
                {
                    int malzeme_sayisi = 0;
                    int tam_sayisi = 0;

                    int tarif_id = int.Parse(row3["TarifID"].ToString());
                    float tarif_maliyet_ = float.Parse(row3["Maliyet"].ToString());
                    DataTable iliskiler = new DataTable();
                    con.Open();
                    string query_getIliskiler = "select * from iliski where TarifIDr=@TarifIDr";
                    adapter = new MySqlDataAdapter(query_getIliskiler, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", tarif_id);
                    iliskiler.Clear();
                    adapter.Fill(iliskiler);
                    con.Close();

                    if (iliskiler.Rows.Count <= 0)
                    {
                        MessageBox.Show("İlişkiler alinamadi");
                        return;
                    }
                    malzeme_sayisi = iliskiler.Rows.Count;

                    foreach (DataRow row4 in iliskiler.Rows)
                    {
                        int malzeme_id = int.Parse(row4["MalzemeIDr"].ToString());
                        float gerekli_miktar = float.Parse(row4["MalzemeMiktar"].ToString());
                        DataTable malzeme = new DataTable();
                        con.Open();
                        string query_getMalzemeler = "select * from malzemeler where MalzemeID=@MalzemeID";
                        adapter = new MySqlDataAdapter(query_getMalzemeler, con);
                        adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", malzeme_id);
                        malzeme.Clear();
                        adapter.Fill(malzeme);
                        con.Close();

                        if (malzeme.Rows.Count <= 0)
                        {
                            MessageBox.Show("Malzemeler alinamadi");
                            return;
                        }

                        foreach (DataRow row5 in malzeme.Rows)
                        {
                            float sahipMiktar = float.Parse(row5["ToplamMiktar"].ToString());
                            if (sahipMiktar >= gerekli_miktar)
                            {
                                tam_sayisi += 1;
                            }
                        }

                    }


                    tarif_iliski.Add(tarif_id, tam_sayisi * 100 / (float)malzeme_sayisi);
                    tarif_maliyet.Add(tarif_id, tarif_maliyet_);

                }

                Dictionary<int, float> sortedTarifIliski = tarif_iliski
                    .OrderByDescending(x => x.Value) // yuzdelere gore coktan aza
                    .ThenBy(x => tarif_maliyet[x.Key]) //value'ler ayni ise maliyetleri azdan coga
                    .ToDictionary(x => x.Key, x => x.Value);

                this.dict_ = sortedTarifIliski;


            }
            catch (Exception ex1)
            {
                MessageBox.Show("tarifleri alma hatasi: " + ex1.Message);
            }



            //sonra devam
            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            dt_tarif.Columns.Add("EslesmeYuzdesi", typeof(float));

            foreach (int key in this.dict_.Keys)
            {
                DataTable tempTable = new DataTable();
                con.Open();
                string query_getTarif = "select * from tarifler where TarifID = @TarifID";
                adapter = new MySqlDataAdapter(query_getTarif, con);
                adapter.SelectCommand.Parameters.AddWithValue("@TarifID", key);
                tempTable.Clear();
                adapter.Fill(tempTable);
                con.Close();

                if (tempTable.Rows.Count != 1)
                {
                    MessageBox.Show("tarif bulunamadi");
                    return;
                }
                foreach (DataRow row in tempTable.Rows)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(row["TarifID"].ToString()),
                        row["TarifAdi"].ToString(),
                        row["Kategori"].ToString(),
                        int.Parse(row["HazirlamaSuresi"].ToString()),
                        row["Talimatlar"].ToString(),
                        float.Parse(row["Maliyet"].ToString()),
                        row["Path"].ToString(),
                        int.Parse(row["MalzemeSayisi"].ToString()),
                        this.dict_[key]
                        );


                }
            }
            this.dt = dt_tarif;
            sayfayiDoldur(dt_tarif);
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

                tarifEkrani = new TarifEkrani(this.form1_, id);
                tarifEkrani.FormClosed += tarifEkrani_FormClosed;
                tarifEkrani.MdiParent = this.form1_;
                tarifEkrani.Dock = DockStyle.Fill;
                tarifEkrani.Show();


                //panelAnaManu.Visible = false;



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

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            //en sol mu kontrol - return
            int ComboBoxNum = comboBoxSayfa1.SelectedIndex + 1;
            if (ComboBoxNum <= 1)
            {
                return;
            }

            //bir azaltma
            comboBoxSayfa1.SelectedIndex -= 1;

            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            dt_tarif.Columns.Add("EslesmeYuzdesi", typeof(float));


            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < this.dt.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(this.dt.Rows[i]["TarifID"].ToString()),
                        this.dt.Rows[i]["TarifAdi"].ToString(),
                        this.dt.Rows[i]["Kategori"].ToString(),
                        int.Parse(this.dt.Rows[i]["HazirlamaSuresi"].ToString()),
                        this.dt.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(this.dt.Rows[i]["Maliyet"].ToString()),
                        this.dt.Rows[i]["Path"].ToString(),
                        int.Parse(this.dt.Rows[i]["MalzemeSayisi"].ToString()),
                        float.Parse(this.dt.Rows[i]["EslesmeYuzdesi"].ToString())
                        );
                }
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("5Sayfa doldurma hatası: " + ex1.Message);
            }

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
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
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            dt_tarif.Columns.Add("EslesmeYuzdesi", typeof(float));


            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < this.dt.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(this.dt.Rows[i]["TarifID"].ToString()),
                        this.dt.Rows[i]["TarifAdi"].ToString(),
                        this.dt.Rows[i]["Kategori"].ToString(),
                        int.Parse(this.dt.Rows[i]["HazirlamaSuresi"].ToString()),
                        this.dt.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(this.dt.Rows[i]["Maliyet"].ToString()),
                        this.dt.Rows[i]["Path"].ToString(),
                        int.Parse(this.dt.Rows[i]["MalzemeSayisi"].ToString()),
                        float.Parse(this.dt.Rows[i]["EslesmeYuzdesi"].ToString())
                        );
                }
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("5Sayfa doldurma hatası: " + ex1.Message);
            }

        }

        private void buttonSayfa1_Click_1(object sender, EventArgs e)
        {
            DataTable dt_tarif = new DataTable();
            dt_tarif.Columns.Add("TarifID", typeof(int));
            dt_tarif.Columns.Add("TarifAdi", typeof(string));
            dt_tarif.Columns.Add("Kategori", typeof(string));
            dt_tarif.Columns.Add("HazirlamaSuresi", typeof(int));
            dt_tarif.Columns.Add("Talimatlar", typeof(string));
            dt_tarif.Columns.Add("Maliyet", typeof(float));
            dt_tarif.Columns.Add("Path", typeof(string));
            dt_tarif.Columns.Add("MalzemeSayisi", typeof(int));
            dt_tarif.Columns.Add("EslesmeYuzdesi", typeof(float));


            try
            {
                int sayfaBasinaTarif = 3;
                int ComboBoxNum_ = comboBoxSayfa1.SelectedIndex + 1;
                int bas = (ComboBoxNum_ - 1) * sayfaBasinaTarif;
                int son = bas + sayfaBasinaTarif - 1;
                for (int i = bas; i <= son && i < this.dt.Rows.Count; i++)
                {
                    dt_tarif.Rows.Add(
                        int.Parse(this.dt.Rows[i]["TarifID"].ToString()),
                        this.dt.Rows[i]["TarifAdi"].ToString(),
                        this.dt.Rows[i]["Kategori"].ToString(),
                        int.Parse(this.dt.Rows[i]["HazirlamaSuresi"].ToString()),
                        this.dt.Rows[i]["Talimatlar"].ToString(),
                        float.Parse(this.dt.Rows[i]["Maliyet"].ToString()),
                        this.dt.Rows[i]["Path"].ToString(),
                        int.Parse(this.dt.Rows[i]["MalzemeSayisi"].ToString()),
                        float.Parse(this.dt.Rows[i]["EslesmeYuzdesi"].ToString())
                        );
                }
                this.elementDoldurma(dt_tarif);
            }
            catch (Exception ex1)
            {
                MessageBox.Show("5Sayfa doldurma hatası: " + ex1.Message);
            }
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
