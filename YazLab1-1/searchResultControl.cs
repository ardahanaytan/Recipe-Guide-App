using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab1_1
{
    public partial class searchResultControl : UserControl
    {
        public searchResultControl()
        {
            InitializeComponent();
        }
        string temp_id;
        public static string id;

        TarifEkrani tarifEkrani;
        Form1 form1;
        Panel manu;


        public searchResultControl(Form1 f, Panel manu)
        {
            InitializeComponent();
            this.form1 = f;
            this.manu = manu;
        }

        private void searchResultControl_Load(object sender, EventArgs e)
        {

        }

        public void details(Data d)
        {
            tarifAd.Text = d.name;
            tarifKat.Text = d.kat;
            pictureBoxTarif.ImageLocation = d.image;
            temp_id = d.id;
        }
        public void searchResult(string key)
        {
            Data get = new Data();
            get.search(key);
            tarifAd.Text = get.name;
            tarifKat.Text = get.kat;
            pictureBoxTarif.ImageLocation = get.image;
        }

        private void buttonSayfa1_Click(object sender, EventArgs e)
        {
            tarifEkrani = new TarifEkrani(this.form1, int.Parse(temp_id));
            tarifEkrani.FormClosed += tarifEkrani_FormClosed;
            tarifEkrani.MdiParent = this.form1;
            tarifEkrani.Dock = DockStyle.Fill;
            tarifEkrani.Show();
            this.manu.Visible = false;
        }
        private void tarifEkrani_FormClosed(object? sender, FormClosedEventArgs e)
        {
            tarifEkrani = null;
        }
    }
}
