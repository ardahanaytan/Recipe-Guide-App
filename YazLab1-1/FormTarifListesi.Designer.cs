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
            tarifID = new DataGridViewTextBoxColumn();
            tarifAdi = new DataGridViewTextBoxColumn();
            tarifKategori = new DataGridViewTextBoxColumn();
            tarifHazirlamaSuresi = new DataGridViewTextBoxColumn();
            Malzemeler = new DataGridViewTextBoxColumn();
            talimatlar = new DataGridViewTextBoxColumn();
            Düzenle = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTarifler
            // 
            dataGridViewTarifler.AllowUserToAddRows = false;
            dataGridViewTarifler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifler.Columns.AddRange(new DataGridViewColumn[] { tarifID, tarifAdi, tarifKategori, tarifHazirlamaSuresi, Malzemeler, talimatlar, Düzenle, Sil });
            dataGridViewTarifler.Location = new Point(41, 112);
            dataGridViewTarifler.Name = "dataGridViewTarifler";
            dataGridViewTarifler.RowTemplate.Height = 25;
            dataGridViewTarifler.Size = new Size(844, 372);
            dataGridViewTarifler.TabIndex = 0;
            dataGridViewTarifler.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tarifID
            // 
            tarifID.HeaderText = "Tarif ID";
            tarifID.Name = "tarifID";
            tarifID.ReadOnly = true;
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
            // 
            // tarifHazirlamaSuresi
            // 
            tarifHazirlamaSuresi.HeaderText = "Hazırlama Süresi";
            tarifHazirlamaSuresi.Name = "tarifHazirlamaSuresi";
            tarifHazirlamaSuresi.ReadOnly = true;
            // 
            // Malzemeler
            // 
            Malzemeler.HeaderText = "Malzemeler";
            Malzemeler.Name = "Malzemeler";
            Malzemeler.ReadOnly = true;
            // 
            // talimatlar
            // 
            talimatlar.HeaderText = "Talimatlar";
            talimatlar.Name = "talimatlar";
            talimatlar.ReadOnly = true;
            // 
            // Düzenle
            // 
            Düzenle.HeaderText = "Düzenle";
            Düzenle.Name = "Düzenle";
            Düzenle.ReadOnly = true;
            Düzenle.Text = "Düzenle";
            Düzenle.ToolTipText = "Düzenle";
            Düzenle.UseColumnTextForButtonValue = true;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Text = "Sil";
            Sil.ToolTipText = "Sil";
            Sil.UseColumnTextForButtonValue = true;
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
        private DataGridViewTextBoxColumn talimatlar;
        private DataGridViewButtonColumn Düzenle;
        private DataGridViewButtonColumn Sil;
    }
}