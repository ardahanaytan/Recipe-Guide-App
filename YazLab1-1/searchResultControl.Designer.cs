namespace YazLab1_1
{
    partial class searchResultControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            tarifAd = new Label();
            tarifKat = new Label();
            pictureBoxTarif = new PictureBox();
            buttonSayfa1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif).BeginInit();
            SuspendLayout();
            // 
            // tarifAd
            // 
            tarifAd.AutoSize = true;
            tarifAd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tarifAd.Location = new Point(126, 10);
            tarifAd.Name = "tarifAd";
            tarifAd.Size = new Size(74, 21);
            tarifAd.TabIndex = 0;
            tarifAd.Text = "Tarif Adı";
            // 
            // tarifKat
            // 
            tarifKat.AutoSize = true;
            tarifKat.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point);
            tarifKat.Location = new Point(126, 35);
            tarifKat.Name = "tarifKat";
            tarifKat.Size = new Size(70, 21);
            tarifKat.TabIndex = 1;
            tarifKat.Text = "Kategori";
            // 
            // pictureBoxTarif
            // 
            pictureBoxTarif.Location = new Point(27, 10);
            pictureBoxTarif.Name = "pictureBoxTarif";
            pictureBoxTarif.Size = new Size(75, 50);
            pictureBoxTarif.TabIndex = 2;
            pictureBoxTarif.TabStop = false;
            // 
            // buttonSayfa1
            // 
            buttonSayfa1.Location = new Point(274, 31);
            buttonSayfa1.Name = "buttonSayfa1";
            buttonSayfa1.OverrideDefault.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.OverrideDefault.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            buttonSayfa1.Size = new Size(101, 33);
            buttonSayfa1.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.StateCommon.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.StateCommon.Border.Color1 = Color.Thistle;
            buttonSayfa1.StateCommon.Border.Color2 = Color.SlateBlue;
            buttonSayfa1.StateCommon.Border.ColorAngle = 45F;
            buttonSayfa1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSayfa1.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            buttonSayfa1.StateCommon.Border.Rounding = 20F;
            buttonSayfa1.StateCommon.Border.Width = 4;
            buttonSayfa1.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonSayfa1.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonSayfa1.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSayfa1.StatePressed.Back.Color1 = Color.Thistle;
            buttonSayfa1.StatePressed.Back.Color2 = Color.Thistle;
            buttonSayfa1.StatePressed.Border.Color1 = Color.Thistle;
            buttonSayfa1.StatePressed.Border.Color2 = Color.SlateBlue;
            buttonSayfa1.StatePressed.Border.ColorAngle = 45F;
            buttonSayfa1.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonSayfa1.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSayfa1.StatePressed.Border.Rounding = 20F;
            buttonSayfa1.StatePressed.Border.Width = 4;
            buttonSayfa1.StatePressed.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonSayfa1.StatePressed.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonSayfa1.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSayfa1.StateTracking.Back.Color1 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.StateTracking.Back.Color2 = Color.FromArgb(108, 91, 123);
            buttonSayfa1.StateTracking.Border.Color1 = Color.Thistle;
            buttonSayfa1.StateTracking.Border.Color2 = Color.SlateBlue;
            buttonSayfa1.StateTracking.Border.ColorAngle = 45F;
            buttonSayfa1.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            buttonSayfa1.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            buttonSayfa1.StateTracking.Border.Rounding = 20F;
            buttonSayfa1.StateTracking.Border.Width = 4;
            buttonSayfa1.StateTracking.Content.ShortText.Color1 = Color.WhiteSmoke;
            buttonSayfa1.StateTracking.Content.ShortText.Color2 = Color.WhiteSmoke;
            buttonSayfa1.StateTracking.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSayfa1.TabIndex = 67;
            buttonSayfa1.Values.Text = "Tarifi Gör";
            buttonSayfa1.Click += buttonSayfa1_Click;
            // 
            // searchResultControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonSayfa1);
            Controls.Add(pictureBoxTarif);
            Controls.Add(tarifKat);
            Controls.Add(tarifAd);
            Margin = new Padding(0);
            Name = "searchResultControl";
            Size = new Size(424, 67);
            Load += searchResultControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tarifAd;
        private Label tarifKat;
        private PictureBox pictureBoxTarif;
        private Krypton.Toolkit.KryptonButton buttonSayfa1;
    }
}
