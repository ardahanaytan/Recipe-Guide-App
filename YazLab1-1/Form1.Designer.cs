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
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
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
            panelAnaManu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.MouseDown += panel1_MouseDown;
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
            panelAnaManu.Controls.Add(label14);
            panelAnaManu.Controls.Add(label13);
            panelAnaManu.Controls.Add(label12);
            panelAnaManu.Controls.Add(label11);
            panelAnaManu.Controls.Add(label10);
            panelAnaManu.Controls.Add(label9);
            panelAnaManu.Controls.Add(label8);
            panelAnaManu.Controls.Add(label7);
            panelAnaManu.Controls.Add(label6);
            panelAnaManu.Controls.Add(label5);
            panelAnaManu.Controls.Add(label4);
            panelAnaManu.Controls.Add(label3);
            panelAnaManu.Controls.Add(label2);
            panelAnaManu.Controls.Add(pictureBox4);
            panelAnaManu.Controls.Add(pictureBox3);
            panelAnaManu.Controls.Add(pictureBox2);
            panelAnaManu.Location = new Point(0, 38);
            panelAnaManu.Name = "panelAnaManu";
            panelAnaManu.Size = new Size(1240, 621);
            panelAnaManu.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BorderStyle = BorderStyle.FixedSingle;
            label11.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(1019, 251);
            label11.Name = "label11";
            label11.Size = new Size(157, 24);
            label11.TabIndex = 11;
            label11.Text = "Hazırlanma Süresi";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(672, 250);
            label10.Name = "label10";
            label10.Size = new Size(157, 24);
            label10.TabIndex = 10;
            label10.Text = "Hazırlanma Süresi";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(326, 251);
            label9.Name = "label9";
            label9.Size = new Size(157, 24);
            label9.TabIndex = 9;
            label9.Text = "Hazırlanma Süresi";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(1019, 216);
            label8.Name = "label8";
            label8.Size = new Size(79, 24);
            label8.TabIndex = 8;
            label8.Text = "Kategori";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BorderStyle = BorderStyle.FixedSingle;
            label7.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(672, 216);
            label7.Name = "label7";
            label7.Size = new Size(79, 24);
            label7.TabIndex = 7;
            label7.Text = "Kategori";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(326, 216);
            label6.Name = "label6";
            label6.Size = new Size(79, 24);
            label6.TabIndex = 6;
            label6.Text = "Kategori";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(1005, 174);
            label4.Name = "label4";
            label4.Size = new Size(105, 31);
            label4.TabIndex = 5;
            label4.Text = "Tarif Adı";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(658, 174);
            label3.Name = "label3";
            label3.Size = new Size(105, 31);
            label3.TabIndex = 4;
            label3.Text = "Tarif Adı";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(312, 174);
            label2.Name = "label2";
            label2.Size = new Size(105, 31);
            label2.TabIndex = 3;
            label2.Text = "Tarif Adı";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(944, 35);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(223, 127);
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(599, 35);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(223, 127);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(254, 35);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 127);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BorderStyle = BorderStyle.FixedSingle;
            label12.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(326, 288);
            label12.Name = "label12";
            label12.Size = new Size(91, 24);
            label12.TabIndex = 12;
            label12.Text = "Talimatlar";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(672, 288);
            label13.Name = "label13";
            label13.Size = new Size(91, 24);
            label13.TabIndex = 13;
            label13.Text = "Talimatlar";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BorderStyle = BorderStyle.FixedSingle;
            label14.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ControlLightLight;
            label14.Location = new Point(1019, 288);
            label14.Name = "label14";
            label14.Size = new Size(91, 24);
            label14.TabIndex = 14;
            label14.Text = "Talimatlar";
            label14.TextAlign = ContentAlignment.MiddleCenter;
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
            panelAnaManu.ResumeLayout(false);
            panelAnaManu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}