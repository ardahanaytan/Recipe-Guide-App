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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dataGridViewMalzeme = new DataGridView();
            MalzemeID = new DataGridViewTextBoxColumn();
            MalzemeAdi = new DataGridViewTextBoxColumn();
            malzemeToplamMiktar = new DataGridViewTextBoxColumn();
            malzemeBirim = new DataGridViewTextBoxColumn();
            malzemeBirimFiyat = new DataGridViewTextBoxColumn();
            Düzenle = new DataGridViewButtonColumn();
            Sil = new DataGridViewButtonColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalzeme).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMalzeme
            // 
            dataGridViewMalzeme.AllowUserToAddRows = false;
            dataGridViewMalzeme.AllowUserToDeleteRows = false;
            dataGridViewMalzeme.BackgroundColor = Color.FromArgb(148, 132, 179);
            dataGridViewMalzeme.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMalzeme.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMalzeme.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMalzeme.Columns.AddRange(new DataGridViewColumn[] { MalzemeID, MalzemeAdi, malzemeToplamMiktar, malzemeBirim, malzemeBirimFiyat, Düzenle, Sil });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle2.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMalzeme.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMalzeme.GridColor = Color.DimGray;
            dataGridViewMalzeme.Location = new Point(165, 138);
            dataGridViewMalzeme.Name = "dataGridViewMalzeme";
            dataGridViewMalzeme.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle3.Font = new Font("Poppins Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle3.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMalzeme.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMalzeme.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewCellStyle4.Font = new Font("Poppins Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = Color.Thistle;
            dataGridViewCellStyle4.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewMalzeme.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewMalzeme.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(108, 91, 123);
            dataGridViewMalzeme.RowTemplate.DefaultCellStyle.Font = new Font("Poppins Light", 12F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewMalzeme.RowTemplate.Height = 25;
            dataGridViewMalzeme.Size = new Size(703, 373);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 36F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(286, 41);
            label1.Name = "label1";
            label1.Size = new Size(398, 84);
            label1.TabIndex = 1;
            label1.Text = "Malzeme Listesi";
            // 
            // FormMalzemeListesi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1020, 624);
            Controls.Add(label1);
            Controls.Add(dataGridViewMalzeme);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeListesi";
            Text = "FormMalzemeListesi";
            Load += FormMalzemeListesi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMalzeme).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMalzeme;
        private Label label1;
        private DataGridViewTextBoxColumn MalzemeID;
        private DataGridViewTextBoxColumn MalzemeAdi;
        private DataGridViewTextBoxColumn malzemeToplamMiktar;
        private DataGridViewTextBoxColumn malzemeBirim;
        private DataGridViewTextBoxColumn malzemeBirimFiyat;
        private DataGridViewButtonColumn Düzenle;
        private DataGridViewButtonColumn Sil;
    }
}