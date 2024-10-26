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
    public partial class FormArama : Form
    {

        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");

        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        Form1 form1_;
        FormAramaListeleme formAramaListeleme;

        public FormArama()
        {
            InitializeComponent();
        }

        public FormArama(Form1 form1)
        {
            InitializeComponent();
            this.form1_ = form1;
        }

        private void FormArama_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable malzemeler = new DataTable();
                con.Open();
                string query_malzemeleriAl = "select * from malzemeler";
                adapter = new MySqlDataAdapter(query_malzemeleriAl, con);
                adapter.Fill(malzemeler);
                con.Close();


                if (malzemeler.Rows.Count <= 0)
                {
                    MessageBox.Show("Malzeme bulunamadi!");
                    return;
                }

                foreach (DataRow row in malzemeler.Rows)
                {
                    string malzeme_adi = row["MalzemeAdi"].ToString();
                    checkedListBoxMalzemeler.Items.Add(malzeme_adi);
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show("malzemeleri yükleme hatasi: " + ex1.Message);
            }
        }

        private void FormAramaListeleme_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formAramaListeleme = null;
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMalzemeler.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Filtreleyeceğiniz malzemeleri seçin.");
            }
            int secili_sayisi = checkedListBoxMalzemeler.CheckedItems.Count;

            List<string> seciliMalzemeler = new List<string>();
            foreach (var item in checkedListBoxMalzemeler.CheckedItems)
            {
                seciliMalzemeler.Add(item.ToString());
            }
            try
            {

                List<int> seciliMalzemeID = new List<int>();
                DataTable malzemeler = new DataTable();
                foreach (string ad in seciliMalzemeler)
                {
                    con.Open();
                    string query_malzemeleriAl = "select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                    adapter = new MySqlDataAdapter(query_malzemeleriAl, con);
                    adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", ad);
                    malzemeler.Clear();
                    adapter.Fill(malzemeler);
                    con.Close();

                    if (malzemeler.Rows.Count != 1)
                    {
                        MessageBox.Show("Malzemeler alinamadi");
                        return;
                    }

                    foreach (DataRow row1 in malzemeler.Rows)
                    {
                        seciliMalzemeID.Add(int.Parse(row1["MalzemeID"].ToString()));
                    }
                }

                //kontrol
                /*
                foreach (int no in seciliMalzemeID)
                {
                    MessageBox.Show("no:" + no.ToString());
                }
                */


                DataTable tarifler = new DataTable();
                con.Open();
                string query_tarifleriAl = "select * from tarifler";
                adapter = new MySqlDataAdapter(query_tarifleriAl, con);
                adapter.Fill(tarifler);
                con.Close();

                Dictionary<int, int> tarif_iliski = new Dictionary<int, int>();

                if (tarifler.Rows.Count <= 0)
                {
                    MessageBox.Show("Tarifler alinamadi");
                    return;
                }

                foreach (DataRow row3 in tarifler.Rows)
                {
                    int tarif_id = int.Parse(row3["TarifID"].ToString());
                    int iliski_sayisi = 0;
                    foreach (int no in seciliMalzemeID)
                    {
                        DataTable iliski_al = new DataTable();
                        con.Open();
                        string query_iliskiKontrol = "select * from iliski where MalzemeIDr = @MalzemeIDr AND TarifIDr=@TarifIDr";
                        adapter = new MySqlDataAdapter(query_iliskiKontrol, con);
                        //MessageBox.Show("tarif:" + tarif_id.ToString() + "-" + "malzeme:" + no.ToString());
                        adapter.SelectCommand.Parameters.AddWithValue("@MalzemeIDr", no);
                        adapter.SelectCommand.Parameters.AddWithValue("@TarifIDr", tarif_id);
                        iliski_al.Clear();
                        adapter.Fill(iliski_al);
                        con.Close();

                        if (iliski_al.Rows.Count > 0)
                        {
                            iliski_sayisi += 1;
                        }
                    }
                    
                     tarif_iliski.Add(tarif_id, iliski_sayisi);

                }

                //kontrol
                /*
                MessageBox.Show("kontrol dict:");
                foreach (KeyValuePair<int, int> tarif in tarif_iliski)
                {
                    MessageBox.Show($"Anahtar: {tarif.Key}, Değer: {tarif.Value}");
                }
                */

                Dictionary<int, float> sortedTarifIliski = tarif_iliski
                    .OrderByDescending(x => x.Value * 100 / (float)secili_sayisi) 
                    .ToDictionary(x => x.Key, x => x.Value * 100 / (float)secili_sayisi); 

                // Sıralanmış sözlüğü yazdırma
                /*
                foreach (KeyValuePair<int, float> item in sortedTarifIliski)
                {
                    Console.WriteLine($"Tarif ID: {item.Key}, İşlenmiş Değer: {item.Value}");
                }
                */

                formAramaListeleme = new FormAramaListeleme(sortedTarifIliski, this.form1_ );
                formAramaListeleme.FormClosed += FormAramaListeleme_FormClosed;
                formAramaListeleme.MdiParent = this.form1_;
                formAramaListeleme.Dock = DockStyle.Fill;
                formAramaListeleme.Show();

            }

            catch (Exception ex1)
            {
                MessageBox.Show("tarifleri alma hatasi: " + ex1.Message);
            }

        }
    }
}
