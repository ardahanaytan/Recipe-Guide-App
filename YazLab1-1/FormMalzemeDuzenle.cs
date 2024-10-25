using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace YazLab1_1
{
    public partial class FormMalzemeDuzenle : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        int malzeme_id;
        public FormMalzemeDuzenle()
        {
            InitializeComponent();
        }



        public FormMalzemeDuzenle(string name)
        {
            InitializeComponent();
            this.formuDoldur(name);
        }

        public void formuDoldur(string name)
        {
            DataTable malzeme = new DataTable();
            try
            {
                //malzeme bilgilerini al
                con.Open();
                string query_malzemeKontrol = @"select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_malzemeKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", name);
                adapter.Fill(malzeme);
                con.Close();

                //duzenle formu doldurma
                foreach (DataRow row in malzeme.Rows)
                {
                    //id
                    this.malzeme_id = int.Parse(row["MalzemeID"].ToString());
                    kryptonLabelMalzemeId.Text = "Malzeme ID: " + this.malzeme_id.ToString();

                    //ad
                    kryptonTextBoxMalzemeAdi.Text = row["MalzemeAdi"].ToString();
                    //miktar
                    kryptonTextBoxToplamMiktar.Text = row["ToplamMiktar"].ToString();
                    //birim
                    comboBoxBirim.Items.Clear();
                    comboBoxBirim.Items.Add("Kilogram");
                    comboBoxBirim.Items.Add("Gram");
                    comboBoxBirim.Items.Add("Litre");
                    comboBoxBirim.Items.Add("Mililitre");
                    comboBoxBirim.Items.Add("Tane");

                    string birim_ = row["MalzemeBirim"].ToString();
                    if (comboBoxBirim.Items.Contains(birim_))
                    {
                        comboBoxBirim.SelectedItem = birim_;
                    }
                    else
                    {
                        MessageBox.Show("malzeme alınırken hata oluştu!");
                        return;
                    }

                    //fiyat
                    kryptonTextBoxBirimFiyat.Text = row["BirimFiyat"].ToString();
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("tarif doldurma hatasi: ", e.Message);
            }
        }

        private void buttonDuzenle_Click(object sender, EventArgs e)
        {
            //ad
            string ad = kryptonTextBoxMalzemeAdi.Text;

            DataTable malzeme = new DataTable();
            try
            {
                con.Open();
                string query_MalzemeVarMi = @"SELECT * from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_MalzemeVarMi, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", ad);
                adapter.Fill(malzeme);
                con.Close();

                if (malzeme.Rows.Count != 1)
                {
                    MessageBox.Show("Tarif ismi zaten bulunmakta!");
                    return;
                }

                //miktar
                string miktar = kryptonTextBoxToplamMiktar.Text;

                //birim
                if(comboBoxBirim.SelectedIndex < 0)
                {
                    MessageBox.Show("Yanlış seçim");
                    return;
                }
                string birim = comboBoxBirim.Items[comboBoxBirim.SelectedIndex].ToString();


                //tl
                string birim_fiyat = kryptonTextBoxBirimFiyat.Text;

                con.Open();
                string query_malzemeGuncelle = @"UPDATE malzemeler SET MalzemeAdi=@MalzemeAdi, ToplamMiktar=@ToplamMiktar, MalzemeBirim=@MalzemeBirim, BirimFiyat=@BirimFiyat where MalzemeID=@MalzemeID";
                MySqlCommand cmd = new MySqlCommand(query_malzemeGuncelle, con);
                cmd.Parameters.AddWithValue("@MalzemeAdi", ad);
                cmd.Parameters.AddWithValue("@ToplamMiktar", miktar);
                cmd.Parameters.AddWithValue("@MalzemeBirim", birim);
                cmd.Parameters.AddWithValue("@BirimFiyat", birim_fiyat);
                cmd.Parameters.AddWithValue("@MalzemeID", this.malzeme_id);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected != 1)
                {
                    MessageBox.Show("güncelleme hatasi");
                }
                con.Close();

                MessageBox.Show("Malzeme Başarıyla Güncellendi");

            }
            catch (Exception ex)
            {
                MessageBox.Show("tarif doldurma hatasi: ", ex.Message);
            }

        }
    }
}
