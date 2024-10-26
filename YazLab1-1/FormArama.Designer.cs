namespace YazLab1_1
{
    partial class FormArama
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
            checkedListBoxMalzemeler = new CheckedListBox();
            kryptonButton3 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // checkedListBoxMalzemeler
            // 
            checkedListBoxMalzemeler.CheckOnClick = true;
            checkedListBoxMalzemeler.FormattingEnabled = true;
            checkedListBoxMalzemeler.Location = new Point(236, 77);
            checkedListBoxMalzemeler.Name = "checkedListBoxMalzemeler";
            checkedListBoxMalzemeler.Size = new Size(246, 418);
            checkedListBoxMalzemeler.TabIndex = 0;
            // 
            // kryptonButton3
            // 
            kryptonButton3.Location = new Point(524, 283);
            kryptonButton3.Name = "kryptonButton3";
            kryptonButton3.OverrideDefault.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonButton3.OverrideDefault.Back.Color2 = Color.FromArgb(108, 91, 123);
            kryptonButton3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonButton3.Size = new Size(79, 33);
            kryptonButton3.StateCommon.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonButton3.StateCommon.Back.Color2 = Color.FromArgb(108, 91, 123);
            kryptonButton3.StateCommon.Border.Color1 = Color.Thistle;
            kryptonButton3.StateCommon.Border.Color2 = Color.SlateBlue;
            kryptonButton3.StateCommon.Border.ColorAngle = 45F;
            kryptonButton3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            kryptonButton3.StateCommon.Border.Rounding = 20F;
            kryptonButton3.StateCommon.Border.Width = 4;
            kryptonButton3.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton3.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            kryptonButton3.StateCommon.Content.ShortText.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton3.StatePressed.Back.Color1 = Color.Thistle;
            kryptonButton3.StatePressed.Back.Color2 = Color.Thistle;
            kryptonButton3.StatePressed.Border.Color1 = Color.Thistle;
            kryptonButton3.StatePressed.Border.Color2 = Color.SlateBlue;
            kryptonButton3.StatePressed.Border.ColorAngle = 45F;
            kryptonButton3.StatePressed.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            kryptonButton3.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StatePressed.Border.Rounding = 20F;
            kryptonButton3.StatePressed.Border.Width = 4;
            kryptonButton3.StatePressed.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton3.StatePressed.Content.ShortText.Color2 = Color.WhiteSmoke;
            kryptonButton3.StatePressed.Content.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton3.StateTracking.Back.Color1 = Color.FromArgb(108, 91, 123);
            kryptonButton3.StateTracking.Back.Color2 = Color.FromArgb(108, 91, 123);
            kryptonButton3.StateTracking.Border.Color1 = Color.Thistle;
            kryptonButton3.StateTracking.Border.Color2 = Color.SlateBlue;
            kryptonButton3.StateTracking.Border.ColorAngle = 45F;
            kryptonButton3.StateTracking.Border.ColorStyle = Krypton.Toolkit.PaletteColorStyle.RoundedTopLight;
            kryptonButton3.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            kryptonButton3.StateTracking.Border.Rounding = 20F;
            kryptonButton3.StateTracking.Border.Width = 4;
            kryptonButton3.StateTracking.Content.ShortText.Color1 = Color.WhiteSmoke;
            kryptonButton3.StateTracking.Content.ShortText.Color2 = Color.WhiteSmoke;
            kryptonButton3.StateTracking.Content.ShortText.Font = new Font("Poppins Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonButton3.TabIndex = 78;
            kryptonButton3.Values.Text = "Filtrele";
            kryptonButton3.Click += kryptonButton3_Click;
            // 
            // FormArama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            ClientSize = new Size(1024, 615);
            Controls.Add(kryptonButton3);
            Controls.Add(checkedListBoxMalzemeler);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormArama";
            Text = "Form2";
            Load += FormArama_Load;
            ResumeLayout(false);
        }

        #endregion

        private CheckedListBox checkedListBoxMalzemeler;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
    }
}