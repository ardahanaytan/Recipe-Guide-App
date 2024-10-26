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
            kryptonLabelMalzemeId = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxBirim = new Krypton.Toolkit.KryptonComboBox();
            buttonDuzenle = new Krypton.Toolkit.KryptonButton();
            kryptonTextBoxMalzemeAdi = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxToplamMiktar = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBoxBirimFiyat = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)comboBoxBirim).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabelMalzemeId
            // 
            kryptonLabelMalzemeId.AutoSize = true;
            kryptonLabelMalzemeId.BorderStyle = BorderStyle.FixedSingle;
            kryptonLabelMalzemeId.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonLabelMalzemeId.ForeColor = SystemColors.ControlLightLight;
            kryptonLabelMalzemeId.Location = new Point(52, 41);
            kryptonLabelMalzemeId.Name = "kryptonLabelMalzemeId";
            kryptonLabelMalzemeId.Size = new Size(160, 33);
            kryptonLabelMalzemeId.TabIndex = 56;
            kryptonLabelMalzemeId.Text = "Malzeme ID";
            kryptonLabelMalzemeId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(338, 86);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 59;
            label7.Text = "Malzeme Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(338, 179);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 61;
            label1.Text = "ToplamMiktar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(338, 365);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 63;
            label2.Text = "Birim Fiyat (TL)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(338, 272);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 65;
            label3.Text = "Malzeme Birim";
            // 
            // comboBoxBirim
            // 
            comboBoxBirim.CornerRoundingRadius = 20F;
            comboBoxBirim.DropDownWidth = 362;
            comboBoxBirim.IntegralHeight = false;
            comboBoxBirim.Items.AddRange(new object[] { "Kilogram", "Gram", "Litre", "Mililitre", "Tane" });
            comboBoxBirim.Location = new Point(338, 303);
            comboBoxBirim.Name = "comboBoxBirim";
            comboBoxBirim.Size = new Size(362, 43);
            comboBoxBirim.StateCommon.ComboBox.Back.Color1 = Color.FromArgb(108, 91, 123);
            comboBoxBirim.StateCommon.ComboBox.Border.Color1 = Color.Thistle;
            comboBoxBirim.StateCommon.ComboBox.Border.Color2 = Color.SlateBlue;
            comboBoxBirim.StateCommon.ComboBox.Border.ColorAngle = 45F;
            comboBoxBirim.StateCommon.ComboBox.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            comboBoxBirim.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxBirim.StateCommon.ComboBox.Border.Rounding = 20F;
            comboBoxBirim.StateCommon.ComboBox.Border.Width = 4;
            comboBoxBirim.StateCommon.ComboBox.Content.Color1 = Color.WhiteSmoke;
            comboBoxBirim.StateCommon.ComboBox.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBirim.StateCommon.ComboBox.Content.Padding = new Padding(10, 0, 10, 0);
            comboBoxBirim.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxBirim.StateCommon.DropBack.Color1 = Color.FromArgb(108, 91, 123);
            comboBoxBirim.StateCommon.Item.Border.Color1 = Color.Thistle;
            comboBoxBirim.StateCommon.Item.Border.Color2 = Color.SlateBlue;
            comboBoxBirim.StateCommon.Item.Border.ColorAngle = 45F;
            comboBoxBirim.StateCommon.Item.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            comboBoxBirim.StateCommon.Item.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            comboBoxBirim.StateCommon.Item.Content.ShortText.Color1 = Color.WhiteSmoke;
            comboBoxBirim.StateCommon.Item.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxBirim.StateTracking.Item.Back.Color1 = Color.SlateBlue;
            comboBoxBirim.TabIndex = 66;
            // 
            // buttonDuzenle
            // 
            buttonDuzenle.Location = new Point(443, 489);
            buttonDuzenle.Name = "buttonDuzenle";
            buttonDuzenle.OverrideDefault.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.OverrideDefault.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonDuzenle.Size = new Size(140, 33);
            buttonDuzenle.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.StateCommon.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.StateCommon.Border.Color1 = Color.Thistle;
            buttonDuzenle.StateCommon.Border.Color2 = Color.SlateBlue;
            buttonDuzenle.StateCommon.Border.ColorAngle = 45F;
            buttonDuzenle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDuzenle.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonDuzenle.StateCommon.Border.Rounding = 20F;
            buttonDuzenle.StateCommon.Border.Width = 4;
            buttonDuzenle.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonDuzenle.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonDuzenle.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDuzenle.StatePressed.Back.Color1 = Color.Thistle;
            buttonDuzenle.StatePressed.Back.Color2 = Color.Thistle;
            buttonDuzenle.StatePressed.Border.Color1 = Color.Thistle;
            buttonDuzenle.StatePressed.Border.Color2 = Color.SlateBlue;
            buttonDuzenle.StatePressed.Border.ColorAngle = 45F;
            buttonDuzenle.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonDuzenle.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDuzenle.StatePressed.Border.Rounding = 20F;
            buttonDuzenle.StatePressed.Border.Width = 4;
            buttonDuzenle.StatePressed.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonDuzenle.StatePressed.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonDuzenle.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDuzenle.StateTracking.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.StateTracking.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonDuzenle.StateTracking.Border.Color1 = Color.Thistle;
            buttonDuzenle.StateTracking.Border.Color2 = Color.SlateBlue;
            buttonDuzenle.StateTracking.Border.ColorAngle = 45F;
            buttonDuzenle.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonDuzenle.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonDuzenle.StateTracking.Border.Rounding = 20F;
            buttonDuzenle.StateTracking.Border.Width = 4;
            buttonDuzenle.StateTracking.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonDuzenle.StateTracking.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonDuzenle.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDuzenle.TabIndex = 67;
            buttonDuzenle.Values.Text = "Düzenle";
            buttonDuzenle.Click += buttonDuzenle_Click;
            // 
            // kryptonTextBoxMalzemeAdi
            // 
            kryptonTextBoxMalzemeAdi.CornerRoundingRadius = 25F;
            kryptonTextBoxMalzemeAdi.Location = new Point(338, 117);
            kryptonTextBoxMalzemeAdi.Name = "kryptonTextBoxMalzemeAdi";
            kryptonTextBoxMalzemeAdi.Size = new Size(362, 44);
            kryptonTextBoxMalzemeAdi.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonTextBoxMalzemeAdi.StateCommon.Border.Color1 = Color.Thistle;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.Color2 = Color.SlateBlue;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.ColorAngle = 45F;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxMalzemeAdi.StateCommon.Border.Width = 4;
            kryptonTextBoxMalzemeAdi.StateCommon.Content.Color1 = Color.WhiteSmoke;
            kryptonTextBoxMalzemeAdi.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBoxMalzemeAdi.TabIndex = 68;
            // 
            // kryptonTextBoxToplamMiktar
            // 
            kryptonTextBoxToplamMiktar.CornerRoundingRadius = 25F;
            kryptonTextBoxToplamMiktar.Location = new Point(338, 210);
            kryptonTextBoxToplamMiktar.Name = "kryptonTextBoxToplamMiktar";
            kryptonTextBoxToplamMiktar.Size = new Size(362, 44);
            kryptonTextBoxToplamMiktar.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonTextBoxToplamMiktar.StateCommon.Border.Color1 = Color.Thistle;
            kryptonTextBoxToplamMiktar.StateCommon.Border.Color2 = Color.SlateBlue;
            kryptonTextBoxToplamMiktar.StateCommon.Border.ColorAngle = 45F;
            kryptonTextBoxToplamMiktar.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            kryptonTextBoxToplamMiktar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBoxToplamMiktar.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxToplamMiktar.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxToplamMiktar.StateCommon.Border.Width = 4;
            kryptonTextBoxToplamMiktar.StateCommon.Content.Color1 = Color.WhiteSmoke;
            kryptonTextBoxToplamMiktar.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBoxToplamMiktar.TabIndex = 69;
            // 
            // kryptonTextBoxBirimFiyat
            // 
            kryptonTextBoxBirimFiyat.CornerRoundingRadius = 25F;
            kryptonTextBoxBirimFiyat.Location = new Point(338, 396);
            kryptonTextBoxBirimFiyat.Name = "kryptonTextBoxBirimFiyat";
            kryptonTextBoxBirimFiyat.Size = new Size(362, 44);
            kryptonTextBoxBirimFiyat.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonTextBoxBirimFiyat.StateCommon.Border.Color1 = Color.Thistle;
            kryptonTextBoxBirimFiyat.StateCommon.Border.Color2 = Color.SlateBlue;
            kryptonTextBoxBirimFiyat.StateCommon.Border.ColorAngle = 45F;
            kryptonTextBoxBirimFiyat.StateCommon.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            kryptonTextBoxBirimFiyat.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonTextBoxBirimFiyat.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonTextBoxBirimFiyat.StateCommon.Border.Rounding = 20F;
            kryptonTextBoxBirimFiyat.StateCommon.Border.Width = 4;
            kryptonTextBoxBirimFiyat.StateCommon.Content.Color1 = Color.WhiteSmoke;
            kryptonTextBoxBirimFiyat.StateCommon.Content.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonTextBoxBirimFiyat.TabIndex = 70;
            // 
            // FormMalzemeDuzenle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1024, 615);
            Controls.Add(kryptonTextBoxBirimFiyat);
            Controls.Add(kryptonTextBoxToplamMiktar);
            Controls.Add(kryptonTextBoxMalzemeAdi);
            Controls.Add(buttonDuzenle);
            Controls.Add(comboBoxBirim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(kryptonLabelMalzemeId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMalzemeDuzenle";
            Text = "FormMalzemeDuzenle";
            ((System.ComponentModel.ISupportInitialize)comboBoxBirim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxMalzemeAdı;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxMiktar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBoxMalzemeBirim;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Label kryptonLabelMalzemeId;
        private Krypton.Toolkit.KryptonTextBox textBoxTarifAdi1;
        private Label label7;
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Label label2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Label label3;
        private Krypton.Toolkit.KryptonComboBox comboBoxBirim;
        private Krypton.Toolkit.KryptonButton buttonDuzenle;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxMalzemeAdi;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxToplamMiktar;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBoxBirimFiyat;
    }
}