namespace YazLab1_1
{
    partial class FormTarifEkleme
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
            textBoxTarifAdi = new TextBox();
            buttonTarifEkle = new Button();
            label1 = new Label();
            comboBoxKategori = new ComboBox();
            label2 = new Label();
            numericUpDownSure = new NumericUpDown();
            label3 = new Label();
            richTextBoxTalimatlar = new RichTextBox();
            Talimatlar = new Label();
            comboBoxMalzemeSecimi = new ComboBox();
            label4 = new Label();
            textBoxMiktar = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panelMalzemeler = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSure).BeginInit();
            panelMalzemeler.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxTarifAdi
            // 
            textBoxTarifAdi.Location = new Point(194, 51);
            textBoxTarifAdi.Name = "textBoxTarifAdi";
            textBoxTarifAdi.Size = new Size(164, 23);
            textBoxTarifAdi.TabIndex = 0;
            // 
            // buttonTarifEkle
            // 
            buttonTarifEkle.Location = new Point(283, 549);
            buttonTarifEkle.Name = "buttonTarifEkle";
            buttonTarifEkle.Size = new Size(75, 23);
            buttonTarifEkle.TabIndex = 1;
            buttonTarifEkle.Text = "Ekle";
            buttonTarifEkle.UseVisualStyleBackColor = true;
            buttonTarifEkle.Click += buttonTarifEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(194, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Tarif Adı";
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Items.AddRange(new object[] { "Kahvaltı", "Yemek", "Tatlı", "İçecek" });
            comboBoxKategori.Location = new Point(194, 114);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(164, 23);
            comboBoxKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(194, 96);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Kategori";
            // 
            // numericUpDownSure
            // 
            numericUpDownSure.Location = new Point(194, 181);
            numericUpDownSure.Name = "numericUpDownSure";
            numericUpDownSure.Size = new Size(164, 23);
            numericUpDownSure.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(194, 163);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 6;
            label3.Text = "Hazırlama Süresi (Dakika)";
            // 
            // richTextBoxTalimatlar
            // 
            richTextBoxTalimatlar.Location = new Point(194, 245);
            richTextBoxTalimatlar.Name = "richTextBoxTalimatlar";
            richTextBoxTalimatlar.Size = new Size(164, 287);
            richTextBoxTalimatlar.TabIndex = 7;
            richTextBoxTalimatlar.Text = "";
            // 
            // Talimatlar
            // 
            Talimatlar.AutoSize = true;
            Talimatlar.Location = new Point(194, 227);
            Talimatlar.Name = "Talimatlar";
            Talimatlar.Size = new Size(58, 15);
            Talimatlar.TabIndex = 8;
            Talimatlar.Text = "Talimatlar";
            // 
            // comboBoxMalzemeSecimi
            // 
            comboBoxMalzemeSecimi.FormattingEnabled = true;
            comboBoxMalzemeSecimi.Location = new Point(3, 84);
            comboBoxMalzemeSecimi.Name = "comboBoxMalzemeSecimi";
            comboBoxMalzemeSecimi.Size = new Size(121, 23);
            comboBoxMalzemeSecimi.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 66);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Malzeme";
            // 
            // textBoxMiktar
            // 
            textBoxMiktar.Location = new Point(167, 84);
            textBoxMiktar.Name = "textBoxMiktar";
            textBoxMiktar.Size = new Size(113, 23);
            textBoxMiktar.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 66);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Miktar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 21);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 13;
            label6.Text = "TARİFİN ADI";
            // 
            // panelMalzemeler
            // 
            panelMalzemeler.Controls.Add(button3);
            panelMalzemeler.Controls.Add(button2);
            panelMalzemeler.Controls.Add(button1);
            panelMalzemeler.Controls.Add(label6);
            panelMalzemeler.Controls.Add(comboBoxMalzemeSecimi);
            panelMalzemeler.Controls.Add(label5);
            panelMalzemeler.Controls.Add(label4);
            panelMalzemeler.Controls.Add(textBoxMiktar);
            panelMalzemeler.Location = new Point(551, 227);
            panelMalzemeler.Name = "panelMalzemeler";
            panelMalzemeler.Size = new Size(293, 183);
            panelMalzemeler.TabIndex = 14;
            panelMalzemeler.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(175, 14);
            button3.Name = "button3";
            button3.Size = new Size(105, 23);
            button3.TabIndex = 16;
            button3.Text = "Malzeme Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(205, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "Bitir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(3, 142);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 14;
            button1.Text = "Sonraki Malzeme";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormTarifEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 620);
            Controls.Add(panelMalzemeler);
            Controls.Add(Talimatlar);
            Controls.Add(richTextBoxTalimatlar);
            Controls.Add(label3);
            Controls.Add(numericUpDownSure);
            Controls.Add(label2);
            Controls.Add(comboBoxKategori);
            Controls.Add(label1);
            Controls.Add(buttonTarifEkle);
            Controls.Add(textBoxTarifAdi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormTarifEkleme";
            Text = "FormTarifEkleme";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSure).EndInit();
            panelMalzemeler.ResumeLayout(false);
            panelMalzemeler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTarifAdi;
        private Button buttonTarifEkle;
        private Label label1;
        private ComboBox comboBoxKategori;
        private Label label2;
        private NumericUpDown numericUpDownSure;
        private Label label3;
        private RichTextBox richTextBoxTalimatlar;
        private Label Talimatlar;
        private ComboBox comboBoxMalzemeSecimi;
        private Label label4;
        private TextBox textBoxMiktar;
        private Label label5;
        private Label label6;
        private Panel panelMalzemeler;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}