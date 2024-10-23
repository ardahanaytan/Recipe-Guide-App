namespace YazLab1_1
{
    partial class FormTarifListesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewTarifler = new DataGridView();
            label1 = new Label();
            tarifID = new DataGridViewTextBoxColumn();
            tarifAdi = new DataGridViewTextBoxColumn();
            tarifKategori = new DataGridViewTextBoxColumn();
            tarifHazirlamaSuresi = new DataGridViewTextBoxColumn();
            Malzemeler = new DataGridViewTextBoxColumn();
            YetersizMalzemeler = new DataGridViewTextBoxColumn();
            malzemeYuzde = new DataGridViewTextBoxColumn();
            talimatlar = new DataGridViewTextBoxColumn();
            Maliyet = new DataGridViewTextBoxColumn();
            GerekenFiyat = new DataGridViewTextBoxColumn();
            Düzenle = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTarifler
            // 
            dataGridViewTarifler.AllowUserToAddRows = false;
            dataGridViewTarifler.AllowUserToDeleteRows = false;
            dataGridViewTarifler.BackgroundColor = Color.FromArgb(148, 132, 179);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle1.Font = new Font("Poppins Light", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle1.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarifler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifler.Columns.AddRange(new DataGridViewColumn[] { tarifID, tarifAdi, tarifKategori, tarifHazirlamaSuresi, Malzemeler, YetersizMalzemeler, malzemeYuzde, talimatlar, Maliyet, GerekenFiyat, Düzenle, Sil });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTarifler.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarifler.Location = new Point(23, 118);
            dataGridViewTarifler.Name = "dataGridViewTarifler";
            dataGridViewTarifler.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle3.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTarifler.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle4.Font = new Font("Poppins Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewTarifler.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTarifler.RowTemplate.Height = 25;
            dataGridViewTarifler.Size = new Size(973, 419);
            dataGridViewTarifler.TabIndex = 0;
            dataGridViewTarifler.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewTarifler.CellPainting += dataGridViewTarifler_CellPainting;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(148, 132, 179);
            label1.Font = new Font("Poppins Light", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(346, 31);
            label1.Name = "label1";
            label1.Size = new Size(286, 84);
            label1.TabIndex = 2;
            label1.Text = "Tarif Listesi";
            // 
            // tarifID
            // 
            tarifID.HeaderText = "Tarif ID";
            tarifID.Name = "tarifID";
            tarifID.ReadOnly = true;
            tarifID.Width = 50;
            // 
            // tarifAdi
            // 
            tarifAdi.HeaderText = "Tarif Adı";
            tarifAdi.Name = "tarifAdi";
            tarifAdi.ReadOnly = true;
            // 
            // tarifKategori
            // 
            tarifKategori.HeaderText = "Kategori";
            tarifKategori.Name = "tarifKategori";
            tarifKategori.ReadOnly = true;
            tarifKategori.Width = 75;
            // 
            // tarifHazirlamaSuresi
            // 
            tarifHazirlamaSuresi.HeaderText = "Hazırlama Süresi";
            tarifHazirlamaSuresi.Name = "tarifHazirlamaSuresi";
            tarifHazirlamaSuresi.ReadOnly = true;
            tarifHazirlamaSuresi.Width = 82;
            // 
            // Malzemeler
            // 
            Malzemeler.HeaderText = "Yeterli Malzemeler";
            Malzemeler.Name = "Malzemeler";
            Malzemeler.ReadOnly = true;
            // 
            // YetersizMalzemeler
            // 
            YetersizMalzemeler.HeaderText = "Yetersiz Malzemeler";
            YetersizMalzemeler.Name = "YetersizMalzemeler";
            YetersizMalzemeler.ReadOnly = true;
            // 
            // malzemeYuzde
            // 
            malzemeYuzde.HeaderText = "Yüzde";
            malzemeYuzde.Name = "malzemeYuzde";
            malzemeYuzde.ReadOnly = true;
            malzemeYuzde.Width = 57;
            // 
            // talimatlar
            // 
            talimatlar.HeaderText = "Talimatlar";
            talimatlar.Name = "talimatlar";
            talimatlar.ReadOnly = true;
            // 
            // Maliyet
            // 
            Maliyet.HeaderText = "Maliyet";
            Maliyet.Name = "Maliyet";
            Maliyet.ReadOnly = true;
            Maliyet.ToolTipText = "Maliyet";
            Maliyet.Width = 65;
            // 
            // GerekenFiyat
            // 
            GerekenFiyat.HeaderText = "Gereken Fiyat";
            GerekenFiyat.Name = "GerekenFiyat";
            GerekenFiyat.ReadOnly = true;
            GerekenFiyat.Width = 70;
            // 
            // Düzenle
            // 
            Düzenle.HeaderText = "Düzenle";
            Düzenle.Name = "Düzenle";
            Düzenle.ReadOnly = true;
            Düzenle.SortMode = DataGridViewColumnSortMode.Automatic;
            Düzenle.Text = "Düzenle";
            Düzenle.ToolTipText = "Düzenle";
            Düzenle.UseColumnTextForButtonValue = true;
            Düzenle.Width = 85;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.ToolTipText = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            Sil.Width = 85;
            // 
            // FormTarifListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1020, 624);
            Controls.Add(dataGridViewTarifler);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTarifListesi";
            Text = "FormTarifListesi";
            Load += FormTarifListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTarifler;
        private Label label1;
        private DataGridViewTextBoxColumn tarifID;
        private DataGridViewTextBoxColumn tarifAdi;
        private DataGridViewTextBoxColumn tarifKategori;
        private DataGridViewTextBoxColumn tarifHazirlamaSuresi;
        private DataGridViewTextBoxColumn Malzemeler;
        private DataGridViewTextBoxColumn YetersizMalzemeler;
        private DataGridViewTextBoxColumn malzemeYuzde;
        private DataGridViewTextBoxColumn talimatlar;
        private DataGridViewTextBoxColumn Maliyet;
        private DataGridViewTextBoxColumn GerekenFiyat;
        private DataGridViewButtonColumn Düzenle;
        private DataGridViewButtonColumn Sil;
    }
}