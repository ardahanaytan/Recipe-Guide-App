namespace YazLab1_1
{
    partial class FormMalzemeDuzenle
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
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBoxMalzemeAdı = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBoxMiktar = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonComboBoxMalzemeBirim = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonButtonMalzemeDuzenle = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxMalzemeBirim).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(304, 61);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(75, 20);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Malzeme ID";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(304, 101);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(82, 20);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Malzeme Adı";
            kryptonLabel2.Click += this.kryptonLabel2_Click;
            // 
            // kryptonTextBoxMalzemeAdı
            // 
            kryptonTextBoxMalzemeAdı.Location = new Point(304, 127);
            kryptonTextBoxMalzemeAdı.Name = "kryptonTextBoxMalzemeAdı";
            kryptonTextBoxMalzemeAdı.Size = new Size(176, 23);
            kryptonTextBoxMalzemeAdı.TabIndex = 2;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(304, 166);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(90, 20);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Toplam Miktar";
            // 
            // kryptonTextBoxMiktar
            // 
            kryptonTextBoxMiktar.Location = new Point(304, 201);
            kryptonTextBoxMiktar.Name = "kryptonTextBoxMiktar";
            kryptonTextBoxMiktar.Size = new Size(176, 23);
            kryptonTextBoxMiktar.TabIndex = 4;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(304, 243);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(91, 20);
            kryptonLabel4.TabIndex = 5;
            kryptonLabel4.Values.Text = "Malzeme Birim";
            // 
            // kryptonComboBoxMalzemeBirim
            // 
            kryptonComboBoxMalzemeBirim.DropDownWidth = 176;
            kryptonComboBoxMalzemeBirim.IntegralHeight = false;
            kryptonComboBoxMalzemeBirim.Location = new Point(304, 278);
            kryptonComboBoxMalzemeBirim.Name = "kryptonComboBoxMalzemeBirim";
            kryptonComboBoxMalzemeBirim.Size = new Size(176, 22);
            kryptonComboBoxMalzemeBirim.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBoxMalzemeBirim.TabIndex = 6;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(304, 319);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(91, 20);
            kryptonLabel5.TabIndex = 7;
            kryptonLabel5.Values.Text = "Birim Fiyat (TL)";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(304, 356);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(176, 23);
            kryptonTextBox1.TabIndex = 8;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonButtonMalzemeDuzenle
            // 
            kryptonButtonMalzemeDuzenle.Location = new Point(347, 408);
            kryptonButtonMalzemeDuzenle.Name = "kryptonButtonMalzemeDuzenle";
            kryptonButtonMalzemeDuzenle.Size = new Size(90, 25);
            kryptonButtonMalzemeDuzenle.TabIndex = 9;
            kryptonButtonMalzemeDuzenle.Values.Text = "Düzenle";
            // 
            // FormMalzemeDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1020, 624);
            Controls.Add(kryptonButtonMalzemeDuzenle);
            Controls.Add(kryptonTextBox1);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonComboBoxMalzemeBirim);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonTextBoxMiktar);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonTextBoxMalzemeAdı);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeDuzenle";
            Text = "FormMalzemeDuzenle";
            ((System.ComponentModel.ISupportInitialize)kryptonComboBoxMalzemeBirim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxMalzemeAdı;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxMiktar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxMalzemeBirim;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButtonMalzemeDuzenle;
    }
}