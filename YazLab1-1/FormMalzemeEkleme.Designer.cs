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
            textBoxMalzemeAdi1 = new Krypton.Toolkit.KryptonTextBox();
            label5 = new Label();
            textBoxToplamMiktar1 = new Krypton.Toolkit.KryptonTextBox();
            label6 = new Label();
            label7 = new Label();
            textBoxBirimFiyat1 = new Krypton.Toolkit.KryptonTextBox();
            comboBoxMalzemeBirimi1 = new Krypton.Toolkit.KryptonComboBox();
            buttonMalzemeEkle1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)comboBoxMalzemeBirimi1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Light", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(336, 100);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 1;
            label1.Text = "Malzeme Adı";
            // 
            // textBoxMalzemeAdi1
            // 
            textBoxMalzemeAdi1.CornerRoundingRadius = 25F;
            textBoxMalzemeAdi1.Location = new Point(326, 124);
            textBoxMalzemeAdi1.Name = "textBoxMalzemeAdi1";
            textBoxMalzemeAdi1.Size = new Size(362, 49);
            textBoxMalzemeAdi1.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            textBoxMalzemeAdi1.StateCommon.Border.Color1 = Color.Thistle;
            textBoxMalzemeAdi1.StateCommon.Border.Color2 = Color.SlateBlue;
            textBoxMalzemeAdi1.StateCommon.Border.ColorAngle = 45F;
            textBoxMalzemeAdi1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            textBoxMalzemeAdi1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBoxMalzemeAdi1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            textBoxMalzemeAdi1.StateCommon.Border.Rounding = 20F;
            textBoxMalzemeAdi1.StateCommon.Border.Width = 4;
            textBoxMalzemeAdi1.StateCommon.Content.Color1 = Color.WhiteSmoke;
            textBoxMalzemeAdi1.StateCommon.Content.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMalzemeAdi1.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins Light", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(336, 184);
            label5.Name = "label5";
            label5.Size = new Size(124, 28);
            label5.TabIndex = 12;
            label5.Text = "Toplam Miktar";
            // 
            // textBoxToplamMiktar1
            // 
            textBoxToplamMiktar1.CornerRoundingRadius = 25F;
            textBoxToplamMiktar1.Location = new Point(326, 208);
            textBoxToplamMiktar1.Name = "textBoxToplamMiktar1";
            textBoxToplamMiktar1.Size = new Size(362, 49);
            textBoxToplamMiktar1.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            textBoxToplamMiktar1.StateCommon.Border.Color1 = Color.Thistle;
            textBoxToplamMiktar1.StateCommon.Border.Color2 = Color.SlateBlue;
            textBoxToplamMiktar1.StateCommon.Border.ColorAngle = 45F;
            textBoxToplamMiktar1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            textBoxToplamMiktar1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBoxToplamMiktar1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            textBoxToplamMiktar1.StateCommon.Border.Rounding = 20F;
            textBoxToplamMiktar1.StateCommon.Border.Width = 4;
            textBoxToplamMiktar1.StateCommon.Content.Color1 = Color.WhiteSmoke;
            textBoxToplamMiktar1.StateCommon.Content.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxToplamMiktar1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins Light", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(336, 268);
            label6.Name = "label6";
            label6.Size = new Size(131, 28);
            label6.TabIndex = 14;
            label6.Text = "Malzeme Birimi";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins Light", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(336, 352);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 15;
            label7.Text = "Birim Fiyat (TL)";
            // 
            // textBoxBirimFiyat1
            // 
            textBoxBirimFiyat1.CornerRoundingRadius = 25F;
            textBoxBirimFiyat1.Location = new Point(326, 376);
            textBoxBirimFiyat1.Name = "textBoxBirimFiyat1";
            textBoxBirimFiyat1.Size = new Size(362, 49);
            textBoxBirimFiyat1.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            textBoxBirimFiyat1.StateCommon.Border.Color1 = Color.Thistle;
            textBoxBirimFiyat1.StateCommon.Border.Color2 = Color.SlateBlue;
            textBoxBirimFiyat1.StateCommon.Border.ColorAngle = 45F;
            textBoxBirimFiyat1.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            textBoxBirimFiyat1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            textBoxBirimFiyat1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            textBoxBirimFiyat1.StateCommon.Border.Rounding = 20F;
            textBoxBirimFiyat1.StateCommon.Border.Width = 4;
            textBoxBirimFiyat1.StateCommon.Content.Color1 = Color.WhiteSmoke;
            textBoxBirimFiyat1.StateCommon.Content.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBirimFiyat1.TabIndex = 16;
            // 
            // comboBoxMalzemeBirimi1
            // 
            comboBoxMalzemeBirimi1.CornerRoundingRadius = 20F;
            comboBoxMalzemeBirimi1.DropDownWidth = 362;
            comboBoxMalzemeBirimi1.IntegralHeight = false;
            comboBoxMalzemeBirimi1.Items.AddRange(new object[] { "Kilogram", "Gram", "Litre", "Mililitre", "Tane" });
            comboBoxMalzemeBirimi1.Location = new Point(326, 292);
            comboBoxMalzemeBirimi1.Name = "comboBoxMalzemeBirimi1";
            comboBoxMalzemeBirimi1.Size = new Size(362, 48);
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(108, 91, 123);
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.Color1 = Color.Thistle;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.Color2 = Color.SlateBlue;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.ColorAngle = 45F;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.Rounding = 20F;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Border.Width = 4;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Content.Color1 = Color.WhiteSmoke;
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Content.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            comboBoxMalzemeBirimi1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxMalzemeBirimi1.StateCommon.DropBack.Color1 = Color.FromArgb(108, 91, 123);
            comboBoxMalzemeBirimi1.StateCommon.Item.Border.Color1 = Color.Thistle;
            comboBoxMalzemeBirimi1.StateCommon.Item.Border.Color2 = Color.SlateBlue;
            comboBoxMalzemeBirimi1.StateCommon.Item.Border.ColorAngle = 45F;
            comboBoxMalzemeBirimi1.StateCommon.Item.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            comboBoxMalzemeBirimi1.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxMalzemeBirimi1.StateCommon.Item.Content.ShortText.Color1 = Color.WhiteSmoke;
            comboBoxMalzemeBirimi1.StateCommon.Item.Content.ShortText.Font = new Font("Poppins Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxMalzemeBirimi1.StateTracking.Item.Back.Color1 = Color.SlateBlue;
            comboBoxMalzemeBirimi1.TabIndex = 17;
            // 
            // buttonMalzemeEkle1
            // 
            buttonMalzemeEkle1.Location = new Point(435, 454);
            buttonMalzemeEkle1.Name = "buttonMalzemeEkle1";
            buttonMalzemeEkle1.OverrideDefault.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.OverrideDefault.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonMalzemeEkle1.Size = new Size(140, 33);
            buttonMalzemeEkle1.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.StateCommon.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.StateCommon.Border.Color1 = Color.Thistle;
            buttonMalzemeEkle1.StateCommon.Border.Color2 = Color.SlateBlue;
            buttonMalzemeEkle1.StateCommon.Border.ColorAngle = 45F;
            buttonMalzemeEkle1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonMalzemeEkle1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonMalzemeEkle1.StateCommon.Border.Rounding = 20F;
            buttonMalzemeEkle1.StateCommon.Border.Width = 4;
            buttonMalzemeEkle1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StateCommon.Content.ShortText.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMalzemeEkle1.StatePressed.Back.Color1 = Color.Thistle;
            buttonMalzemeEkle1.StatePressed.Back.Color2 = Color.Thistle;
            buttonMalzemeEkle1.StatePressed.Border.Color1 = Color.Thistle;
            buttonMalzemeEkle1.StatePressed.Border.Color2 = Color.SlateBlue;
            buttonMalzemeEkle1.StatePressed.Border.ColorAngle = 45F;
            buttonMalzemeEkle1.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonMalzemeEkle1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonMalzemeEkle1.StatePressed.Border.Rounding = 20F;
            buttonMalzemeEkle1.StatePressed.Border.Width = 4;
            buttonMalzemeEkle1.StatePressed.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StatePressed.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StatePressed.Content.ShortText.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMalzemeEkle1.StateTracking.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.StateTracking.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonMalzemeEkle1.StateTracking.Border.Color1 = Color.Thistle;
            buttonMalzemeEkle1.StateTracking.Border.Color2 = Color.SlateBlue;
            buttonMalzemeEkle1.StateTracking.Border.ColorAngle = 45F;
            buttonMalzemeEkle1.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonMalzemeEkle1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonMalzemeEkle1.StateTracking.Border.Rounding = 20F;
            buttonMalzemeEkle1.StateTracking.Border.Width = 4;
            buttonMalzemeEkle1.StateTracking.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StateTracking.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonMalzemeEkle1.StateTracking.Content.ShortText.Font = new Font("Poppins Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMalzemeEkle1.TabIndex = 19;
            buttonMalzemeEkle1.Values.Text = "Ekle";
            buttonMalzemeEkle1.Click += buttonMalzemeEkle1_Click;
            // 
            // FormMalzemeEkleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1012, 620);
            Controls.Add(buttonMalzemeEkle1);
            Controls.Add(comboBoxMalzemeBirimi1);
            Controls.Add(textBoxBirimFiyat1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBoxToplamMiktar1);
            Controls.Add(label5);
            Controls.Add(textBoxMalzemeAdi1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeEkleme";
            Text = "FormMalzemeEkleme";
            ((System.ComponentModel.ISupportInitialize)comboBoxMalzemeBirimi1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private System.CodeDom.CodeTypeReference guna2TextBox1;
        private Krypton.Toolkit.KryptonTextBox textBoxMalzemeAdi1;
        private Label label5;
        private Krypton.Toolkit.KryptonTextBox textBoxToplamMiktar1;
        private Label label6;
        private Label label7;
        private Krypton.Toolkit.KryptonTextBox textBoxBirimFiyat1;
        private Krypton.Toolkit.KryptonComboBox comboBoxMalzemeBirimi1;
        private Krypton.Toolkit.KryptonButton buttonMalzemeEkle1;
    }
}