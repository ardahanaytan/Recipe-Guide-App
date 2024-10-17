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
            dataGridViewTarifler = new DataGridView();
            Sil = new DataGridViewButtonColumn();
            Düzenle = new DataGridViewButtonColumn();
            GerekenFiyat = new DataGridViewTextBoxColumn();
            Maliyet = new DataGridViewTextBoxColumn();
            talimatlar = new DataGridViewTextBoxColumn();
            YetersizMalzemeler = new DataGridViewTextBoxColumn();
            Malzemeler = new DataGridViewTextBoxColumn();
            tarifHazirlamaSuresi = new DataGridViewTextBoxColumn();
            tarifKategori = new DataGridViewTextBoxColumn();
            tarifAdi = new DataGridViewTextBoxColumn();
            tarifID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTarifler
            // 
            dataGridViewTarifler.AllowUserToAddRows = false;
            dataGridViewTarifler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifler.Columns.AddRange(new DataGridViewColumn[] { tarifID, tarifAdi, tarifKategori, tarifHazirlamaSuresi, Malzemeler, YetersizMalzemeler, talimatlar, Maliyet, GerekenFiyat, Düzenle, Sil });
            dataGridViewTarifler.Location = new Point(-40, 88);
            dataGridViewTarifler.Name = "dataGridViewTarifler";
            dataGridViewTarifler.RowTemplate.Height = 25;
            dataGridViewTarifler.Size = new Size(1048, 372);
            dataGridViewTarifler.TabIndex = 0;
            dataGridViewTarifler.CellContentClick += dataGridView1_CellContentClick;
            dataGridViewTarifler.CellPainting += dataGridViewTarifler_CellPainting;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.Name = "Sil";
            Sil.Text = "Sil";
            Sil.ToolTipText = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // Düzenle
            // 
            Düzenle.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Düzenle.HeaderText = "Düzenle";
            Düzenle.Name = "Düzenle";
            Düzenle.Text = "Düzenle";
            Düzenle.ToolTipText = "Düzenle";
            Düzenle.UseColumnTextForButtonValue = true;
            Düzenle.Width = 55;
            // 
            // GerekenFiyat
            // 
            GerekenFiyat.HeaderText = "Gereken Fiyat";
            GerekenFiyat.Name = "GerekenFiyat";
            // 
            // Maliyet
            // 
            Maliyet.HeaderText = "Maliyet";
            Maliyet.Name = "Maliyet";
            Maliyet.ToolTipText = "Maliyet";
            // 
            // talimatlar
            // 
            talimatlar.HeaderText = "Talimatlar";
            talimatlar.Name = "talimatlar";
            // 
            // YetersizMalzemeler
            // 
            YetersizMalzemeler.HeaderText = "Yetersiz Malzemeler";
            YetersizMalzemeler.Name = "YetersizMalzemeler";
            // 
            // Malzemeler
            // 
            Malzemeler.HeaderText = "Yeterli Malzemeler";
            Malzemeler.Name = "Malzemeler";
            // 
            // tarifHazirlamaSuresi
            // 
            tarifHazirlamaSuresi.HeaderText = "Hazırlama Süresi";
            tarifHazirlamaSuresi.Name = "tarifHazirlamaSuresi";
            // 
            // tarifKategori
            // 
            tarifKategori.HeaderText = "Kategori";
            tarifKategori.Name = "tarifKategori";
            // 
            // tarifAdi
            // 
            tarifAdi.HeaderText = "Tarif Adı";
            tarifAdi.Name = "tarifAdi";
            // 
            // tarifID
            // 
            tarifID.HeaderText = "Tarif ID";
            tarifID.Name = "tarifID";
            // 
            // FormTarifListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 624);
            Controls.Add(dataGridViewTarifler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTarifListesi";
            Text = "FormTarifListesi";
            Load += FormTarifListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewTarifler;
        private DataGridViewTextBoxColumn tarifID;
        private DataGridViewTextBoxColumn tarifAdi;
        private DataGridViewTextBoxColumn tarifKategori;
        private DataGridViewTextBoxColumn tarifHazirlamaSuresi;
        private DataGridViewTextBoxColumn Malzemeler;
        private DataGridViewTextBoxColumn YetersizMalzemeler;
        private DataGridViewTextBoxColumn talimatlar;
        private DataGridViewTextBoxColumn Maliyet;
        private DataGridViewTextBoxColumn GerekenFiyat;
        private DataGridViewButtonColumn Düzenle;
        private DataGridViewButtonColumn Sil;
    }
}