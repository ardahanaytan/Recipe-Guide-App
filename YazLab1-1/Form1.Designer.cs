namespace YazLab1_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuCubuk = new FlowLayoutPanel();
            panelAnaEkran = new Panel();
            button2 = new Button();
            panelArama = new Panel();
            button7 = new Button();
            panelTarifOnerme = new Panel();
            button3 = new Button();
            panelTarifListesi = new Panel();
            button4 = new Button();
            panelTarifEkleme = new Panel();
            button5 = new Button();
            panelMalzemeListesi = new Panel();
            button6 = new Button();
            panelMalzemeEkle = new Panel();
            button8 = new Button();
            menuCubukTimer = new System.Windows.Forms.Timer(components);
            panelAnaManu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuCubuk.SuspendLayout();
            panelAnaEkran.SuspendLayout();
            panelArama.SuspendLayout();
            panelTarifOnerme.SuspendLayout();
            panelTarifListesi.SuspendLayout();
            panelTarifEkleme.SuspendLayout();
            panelMalzemeListesi.SuspendLayout();
            panelMalzemeEkle.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1169, 5);
            button1.Name = "button1";
            button1.Size = new Size(37, 25);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 21);
            textBox1.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(108, 91, 123);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1231, 40);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(86, 11);
            label1.Name = "label1";
            label1.Size = new Size(228, 19);
            label1.TabIndex = 0;
            label1.Text = "SEFA İLE FİT YEMEKLER";
            // 
            // menuCubuk
            // 
            menuCubuk.BackColor = Color.FromArgb(108, 91, 123);
            menuCubuk.Controls.Add(panelAnaEkran);
            menuCubuk.Controls.Add(panelArama);
            menuCubuk.Controls.Add(panelTarifOnerme);
            menuCubuk.Controls.Add(panelTarifListesi);
            menuCubuk.Controls.Add(panelTarifEkleme);
            menuCubuk.Controls.Add(panelMalzemeListesi);
            menuCubuk.Controls.Add(panelMalzemeEkle);
            menuCubuk.Dock = DockStyle.Left;
            menuCubuk.Location = new Point(0, 40);
            menuCubuk.Name = "menuCubuk";
            menuCubuk.Padding = new Padding(0, 30, 0, 0);
            menuCubuk.Size = new Size(202, 619);
            menuCubuk.TabIndex = 3;
            // 
            // panelAnaEkran
            // 
            panelAnaEkran.Controls.Add(button2);
            panelAnaEkran.Location = new Point(3, 33);
            panelAnaEkran.Name = "panelAnaEkran";
            panelAnaEkran.Size = new Size(197, 43);
            panelAnaEkran.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(108, 91, 123);
            button2.FlatAppearance.BorderColor = Color.IndianRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-11, -29);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(15, 0, 0, 0);
            button2.Size = new Size(224, 99);
            button2.TabIndex = 0;
            button2.Text = "          Ana Ekran";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelArama
            // 
            panelArama.Controls.Add(button7);
            panelArama.Location = new Point(3, 82);
            panelArama.Name = "panelArama";
            panelArama.Size = new Size(197, 43);
            panelArama.TabIndex = 9;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(108, 91, 123);
            button7.FlatAppearance.BorderColor = Color.IndianRed;
            button7.FlatAppearance.BorderSize = 0;
            button7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-11, -29);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(15, 0, 0, 0);
            button7.Size = new Size(224, 99);
            button7.TabIndex = 0;
            button7.Text = "          Arama";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panelTarifOnerme
            // 
            panelTarifOnerme.Controls.Add(button3);
            panelTarifOnerme.Location = new Point(3, 131);
            panelTarifOnerme.Name = "panelTarifOnerme";
            panelTarifOnerme.Size = new Size(197, 43);
            panelTarifOnerme.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(108, 91, 123);
            button3.FlatAppearance.BorderColor = Color.IndianRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-11, -29);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Padding = new Padding(15, 0, 0, 0);
            button3.Size = new Size(224, 99);
            button3.TabIndex = 0;
            button3.Text = "          Tarif Önerme";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panelTarifListesi
            // 
            panelTarifListesi.Controls.Add(button4);
            panelTarifListesi.Location = new Point(3, 180);
            panelTarifListesi.Name = "panelTarifListesi";
            panelTarifListesi.Size = new Size(197, 43);
            panelTarifListesi.TabIndex = 6;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(108, 91, 123);
            button4.FlatAppearance.BorderColor = Color.IndianRed;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-11, -29);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(15, 0, 0, 0);
            button4.Size = new Size(224, 99);
            button4.TabIndex = 0;
            button4.Text = "          Tarif Listesi";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panelTarifEkleme
            // 
            panelTarifEkleme.Controls.Add(button5);
            panelTarifEkleme.Location = new Point(3, 229);
            panelTarifEkleme.Name = "panelTarifEkleme";
            panelTarifEkleme.Size = new Size(197, 43);
            panelTarifEkleme.TabIndex = 7;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(108, 91, 123);
            button5.FlatAppearance.BorderColor = Color.IndianRed;
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-11, -29);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(15, 0, 0, 0);
            button5.Size = new Size(224, 99);
            button5.TabIndex = 0;
            button5.Text = "          Tarif Ekleme";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // panelMalzemeListesi
            // 
            panelMalzemeListesi.Controls.Add(button6);
            panelMalzemeListesi.Location = new Point(3, 278);
            panelMalzemeListesi.Name = "panelMalzemeListesi";
            panelMalzemeListesi.Size = new Size(197, 43);
            panelMalzemeListesi.TabIndex = 8;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(108, 91, 123);
            button6.FlatAppearance.BorderColor = Color.IndianRed;
            button6.FlatAppearance.BorderSize = 0;
            button6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-11, -29);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(15, 0, 0, 0);
            button6.Size = new Size(224, 99);
            button6.TabIndex = 0;
            button6.Text = "          Malzeme Listesi";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panelMalzemeEkle
            // 
            panelMalzemeEkle.Controls.Add(button8);
            panelMalzemeEkle.Location = new Point(3, 327);
            panelMalzemeEkle.Name = "panelMalzemeEkle";
            panelMalzemeEkle.Size = new Size(197, 43);
            panelMalzemeEkle.TabIndex = 10;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(108, 91, 123);
            button8.FlatAppearance.BorderColor = Color.IndianRed;
            button8.FlatAppearance.BorderSize = 0;
            button8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-11, -29);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(15, 0, 0, 0);
            button8.Size = new Size(224, 99);
            button8.TabIndex = 0;
            button8.Text = "          Malzeme Ekle";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // menuCubukTimer
            // 
            menuCubukTimer.Interval = 10;
            menuCubukTimer.Tick += menuCubukTimer_Tick;
            // 
            // panelAnaManu
            // 
            panelAnaManu.Location = new Point(0, 38);
            panelAnaManu.Name = "panelAnaManu";
            panelAnaManu.Size = new Size(1240, 621);
            panelAnaManu.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(148, 132, 179);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1231, 659);
            Controls.Add(menuCubuk);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(panelAnaManu);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuCubuk.ResumeLayout(false);
            panelAnaEkran.ResumeLayout(false);
            panelArama.ResumeLayout(false);
            panelTarifOnerme.ResumeLayout(false);
            panelTarifListesi.ResumeLayout(false);
            panelTarifEkleme.ResumeLayout(false);
            panelMalzemeListesi.ResumeLayout(false);
            panelMalzemeEkle.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel menuCubuk;
        private Panel panelAnaEkran;
        private Button button2;
        private Panel panelTarifOnerme;
        private Button button3;
        private Panel panelTarifListesi;
        private Button button4;
        private Panel panelTarifEkleme;
        private Button button5;
        private Panel panelMalzemeListesi;
        private Button button6;
        private Panel panelArama;
        private Button button7;
        private Panel panelMalzemeEkle;
        private Button button8;
        private System.Windows.Forms.Timer menuCubukTimer;
        private Panel panelAnaManu;
    }
}