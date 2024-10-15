namespace YazLab1_1
{
    partial class FormMalzemeEkleme
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
            label1 = new Label();
            buttonMalzemeEkle = new Button();
            textBoxToplamMiktar = new TextBox();
            label2 = new Label();
            comboBoxMalzemeBirimi = new ComboBox();
            label3 = new Label();
            textBoxBirimFiyat = new TextBox();
            label4 = new Label();
            textBoxMalzemeAdi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 183);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Malzeme Adı";
            // 
            // buttonMalzemeEkle
            // 
            buttonMalzemeEkle.Location = new Point(261, 411);
            buttonMalzemeEkle.Name = "buttonMalzemeEkle";
            buttonMalzemeEkle.Size = new Size(70, 22);
            buttonMalzemeEkle.TabIndex = 2;
            buttonMalzemeEkle.Text = "Ekle";
            buttonMalzemeEkle.UseVisualStyleBackColor = true;
            buttonMalzemeEkle.Click += buttonMalzemeEkle_Click;
            // 
            // textBoxToplamMiktar
            // 
            textBoxToplamMiktar.Location = new Point(155, 250);
            textBoxToplamMiktar.Name = "textBoxToplamMiktar";
            textBoxToplamMiktar.Size = new Size(176, 23);
            textBoxToplamMiktar.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 232);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 5;
            label2.Text = "Toplam Miktar";
            // 
            // comboBoxMalzemeBirimi
            // 
            comboBoxMalzemeBirimi.FormattingEnabled = true;
            comboBoxMalzemeBirimi.Items.AddRange(new object[] { "Kilogram", "Gram", "Litre", "Mililitre", "Tane" });
            comboBoxMalzemeBirimi.Location = new Point(155, 311);
            comboBoxMalzemeBirimi.Name = "comboBoxMalzemeBirimi";
            comboBoxMalzemeBirimi.Size = new Size(176, 23);
            comboBoxMalzemeBirimi.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(155, 293);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 7;
            label3.Text = "Malzeme Birimi";
            // 
            // textBoxBirimFiyat
            // 
            textBoxBirimFiyat.Location = new Point(155, 371);
            textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            textBoxBirimFiyat.Size = new Size(176, 23);
            textBoxBirimFiyat.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 353);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 9;
            label4.Text = "Birim Fiyat (TL)";
            // 
            // textBoxMalzemeAdi
            // 
            textBoxMalzemeAdi.Location = new Point(155, 201);
            textBoxMalzemeAdi.Multiline = true;
            textBoxMalzemeAdi.Name = "textBoxMalzemeAdi";
            textBoxMalzemeAdi.Size = new Size(176, 23);
            textBoxMalzemeAdi.TabIndex = 10;
            // 
            // FormMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1012, 620);
            Controls.Add(textBoxMalzemeAdi);
            Controls.Add(label4);
            Controls.Add(textBoxBirimFiyat);
            Controls.Add(label3);
            Controls.Add(comboBoxMalzemeBirimi);
            Controls.Add(label2);
            Controls.Add(textBoxToplamMiktar);
            Controls.Add(buttonMalzemeEkle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeEkleme";
            Text = "FormMalzemeEkleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonMalzemeEkle;
        private TextBox textBoxToplamMiktar;
        private Label label2;
        private ComboBox comboBoxMalzemeBirimi;
        private Label label3;
        private TextBox textBoxBirimFiyat;
        private Label label4;
        private TextBox textBoxMalzemeAdi;
        private System.CodeDom.CodeTypeReference guna2TextBox1;
    }
}