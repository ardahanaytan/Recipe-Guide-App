namespace YazLab1_1
{
    partial class FormMalzemeListesi
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
            dataGridViewMalzeme = new DataGridView();
            MalzemeID = new DataGridViewTextBoxColumn();
            MalzemeAdi = new DataGridViewTextBoxColumn();
            malzemeToplamMiktar = new DataGridViewTextBoxColumn();
            malzemeBirim = new DataGridViewTextBoxColumn();
            malzemeBirimFiyat = new DataGridViewTextBoxColumn();
            Düzenle = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalzeme).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMalzeme
            // 
            dataGridViewMalzeme.AllowUserToAddRows = false;
            dataGridViewMalzeme.AllowUserToDeleteRows = false;
            dataGridViewMalzeme.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewMalzeme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMalzeme.Columns.AddRange(new DataGridViewColumn[] { MalzemeID, MalzemeAdi, malzemeToplamMiktar, malzemeBirim, malzemeBirimFiyat, Düzenle, Sil });
            dataGridViewMalzeme.Location = new Point(140, 107);
            dataGridViewMalzeme.Name = "dataGridViewMalzeme";
            dataGridViewMalzeme.ReadOnly = true;
            dataGridViewMalzeme.RowHeadersVisible = false;
            dataGridViewMalzeme.RowTemplate.Height = 25;
            dataGridViewMalzeme.Size = new Size(704, 373);
            dataGridViewMalzeme.TabIndex = 0;
            dataGridViewMalzeme.CellContentClick += dataGridViewMalzeme_CellContentClick;
            dataGridViewMalzeme.CellPainting += dataGridViewMalzeme_CellPainting;
            // 
            // MalzemeID
            // 
            MalzemeID.HeaderText = "Malzeme ID";
            MalzemeID.Name = "MalzemeID";
            MalzemeID.ReadOnly = true;
            // 
            // MalzemeAdi
            // 
            MalzemeAdi.HeaderText = "Malzeme Adı";
            MalzemeAdi.Name = "MalzemeAdi";
            MalzemeAdi.ReadOnly = true;
            // 
            // malzemeToplamMiktar
            // 
            malzemeToplamMiktar.HeaderText = "Malzeme Toplam Miktar";
            malzemeToplamMiktar.Name = "malzemeToplamMiktar";
            malzemeToplamMiktar.ReadOnly = true;
            // 
            // malzemeBirim
            // 
            malzemeBirim.HeaderText = "Malzeme Birimi";
            malzemeBirim.Name = "malzemeBirim";
            malzemeBirim.ReadOnly = true;
            // 
            // malzemeBirimFiyat
            // 
            malzemeBirimFiyat.HeaderText = "Malzeme Birim Fiyatı";
            malzemeBirimFiyat.Name = "malzemeBirimFiyat";
            malzemeBirimFiyat.ReadOnly = true;
            // 
            // Düzenle
            // 
            Düzenle.HeaderText = "Düzenle";
            Düzenle.Name = "Düzenle";
            Düzenle.ReadOnly = true;
            Düzenle.Resizable = DataGridViewTriState.True;
            Düzenle.SortMode = DataGridViewColumnSortMode.Automatic;
            Düzenle.Text = "Düzenle";
            Düzenle.ToolTipText = "Düzenle";
            Düzenle.UseColumnTextForButtonValue = true;
            // 
            // Sil
            // 
            Sil.HeaderText = "Sil";
            Sil.Name = "Sil";
            Sil.ReadOnly = true;
            Sil.Resizable = DataGridViewTriState.True;
            Sil.SortMode = DataGridViewColumnSortMode.Automatic;
            Sil.Text = "Sil";
            Sil.ToolTipText = "Sil";
            Sil.UseColumnTextForButtonValue = true;
            // 
            // FormMalzemeListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 624);
            Controls.Add(dataGridViewMalzeme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeListesi";
            Text = "FormMalzemeListesi";
            Load += FormMalzemeListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalzeme).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewMalzeme;
        private DataGridViewTextBoxColumn MalzemeID;
        private DataGridViewTextBoxColumn MalzemeAdi;
        private DataGridViewTextBoxColumn malzemeToplamMiktar;
        private DataGridViewTextBoxColumn malzemeBirim;
        private DataGridViewTextBoxColumn malzemeBirimFiyat;
        private DataGridViewButtonColumn Düzenle;
        private DataGridViewButtonColumn Sil;
    }
}