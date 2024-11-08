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
    public partial class FormMalzemeListesi : Form
    {
        MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=Ardahan.123");
        //MySqlConnection con = new MySqlConnection("Server=localhost;Database=yazlab1;Uid=root;Pwd=123456789Sefa!");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        FormMalzemeDuzenle formMalzemeDuzenle;
        Form1 form1_;
        public FormMalzemeListesi()
        {
            InitializeComponent();
        }
        public FormMalzemeListesi(Form1 form_)
        {
            InitializeComponent();
            this.form1_ = form_;
        }


        public void tabloGuncelle(string query)
        {
            dataGridViewMalzeme.Rows.Clear();
            DataTable dt_malzemeler = new DataTable();
            try
            {
                con.Open();
                string query_malzemeler = query;
                adapter = new MySqlDataAdapter(query_malzemeler, con);
                adapter.Fill(dt_malzemeler);
                con.Close();
                foreach (DataRow row in dt_malzemeler.Rows)
                {
                    string id = row["MalzemeID"].ToString();
                    string isim = row["MalzemeAdi"].ToString();
                    string toplamMiktar = row["ToplamMiktar"].ToString();
                    string malzemeBirim = row["MalzemeBirim"].ToString();
                    string birimFiyat = row["BirimFiyat"].ToString();
                    dataGridViewMalzeme.Rows.Add(id, isim, toplamMiktar, malzemeBirim, birimFiyat);
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Malzeme verileri alinamadi:" + ex1.Message);
            }
        }

        private void FormMalzemeListesi_Load(object sender, EventArgs e)
        {
            //dataGridViewMalzeme

            //database verileri alma
            this.tabloGuncelle("select * from malzemeler");


        }

        public void malzemeSil(string id)
        {
            if (id == "")
            {
                MessageBox.Show("Id Alinamadi.");
                return;
            }
            int id_ = -1;
            try
            {
                id_ = int.Parse(id);
            }
            catch (Exception ex3)
            {
                MessageBox.Show("Id Int'e Çevirilemedi.");
                return;
            }

            //malzeme var mi
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query_idKontrol = @"SELECT * from malzemeler where MalzemeID = @MalzemeID";
                adapter = new MySqlDataAdapter(query_idKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeID", id_);
                adapter.Fill(dt);
                con.Close();

            }
            catch (Exception ex1)
            {
                MessageBox.Show("Malzeme Bulma Hatası:", ex1.Message);
                return;
            }
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Malzeme Bulunamadı!");
                return;
            }

            //malzemeyi sil
            try
            {
                con.Open();
                string query_malzemeSil = @"DELETE from malzemeler where MalzemeID = @MalzemeID";
                cmd = new MySqlCommand(query_malzemeSil, con);
                cmd.Parameters.AddWithValue("@MalzemeID", id_);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show("Malzeme Silme Hatasi:" + ex2.Message);
                return;
            }
        }

        public void MalzemeDuzenleEkraniGecis(string name)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string query_tarifKontrol = @"select * from malzemeler where MalzemeAdi = @MalzemeAdi";
                adapter = new MySqlDataAdapter(query_tarifKontrol, con);
                adapter.SelectCommand.Parameters.AddWithValue("@MalzemeAdi", name);
                adapter.Fill(dt);
                con.Close();

                if (dt.Rows.Count != 1)
                {
                    MessageBox.Show("İstenilen tarif bulunamadi");
                    return;
                }

                formMalzemeDuzenle = new FormMalzemeDuzenle(name);
                formMalzemeDuzenle.FormClosed += FormMalzemeDuzenle_FormClosed;
                formMalzemeDuzenle.MdiParent = this.form1_;
                formMalzemeDuzenle.Dock = DockStyle.Fill;
                formMalzemeDuzenle.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("tarif güncelleme hatasi: ", ex.Message);
            }
        }

        private void FormMalzemeDuzenle_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formMalzemeDuzenle = null;
        }
        private void dataGridViewMalzeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridViewMalzeme.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    string buttonVal = dataGridViewMalzeme.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    string malzemeID_ = dataGridViewMalzeme.Rows[e.RowIndex].Cells["MalzemeID"].Value.ToString();
                    if (malzemeID_ == null || buttonVal == null)
                    {
                        return;
                    }
                    if (buttonVal == "Sil")
                    {
                        this.malzemeSil(malzemeID_);
                        this.tabloGuncelle("select * from malzemeler");
                    }
                    else
                    {
                        this.MalzemeDuzenleEkraniGecis(dataGridViewMalzeme.Rows[e.RowIndex].Cells["MalzemeAdi"].Value.ToString());
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Buton Hatası:", ex1.Message);
            }
        }

        private void dataGridViewMalzeme_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
    }
}
