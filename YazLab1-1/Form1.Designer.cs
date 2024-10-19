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
            buttonSayfa = new Button();
            comboBoxSayfa = new ComboBox();
            labelGereken3 = new Label();
            labelGereken2 = new Label();
            labelGereken1 = new Label();
            labelMaliyet3 = new Label();
            labelMaliyet2 = new Label();
            labelMaliyet1 = new Label();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox1 = new RichTextBox();
            labelTalimat3 = new Label();
            labelTalimat2 = new Label();
            labelTalimat1 = new Label();
            labelSure3 = new Label();
            labelSure2 = new Label();
            labelSure1 = new Label();
            labelKategori3 = new Label();
            labelKategori2 = new Label();
            labelKategori1 = new Label();
            label5 = new Label();
            labelName3 = new Label();
            labelName2 = new Label();
            labelName1 = new Label();
            pictureBoxTarif3 = new PictureBox();
            pictureBoxTarif2 = new PictureBox();
            pictureBoxTarif1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif1).BeginInit();
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
            panelAnaManu.Controls.Add(buttonSayfa);
            panelAnaManu.Controls.Add(comboBoxSayfa);
            panelAnaManu.Controls.Add(labelGereken3);
            panelAnaManu.Controls.Add(labelGereken2);
            panelAnaManu.Controls.Add(labelGereken1);
            panelAnaManu.Controls.Add(labelMaliyet3);
            panelAnaManu.Controls.Add(labelMaliyet2);
            panelAnaManu.Controls.Add(labelMaliyet1);
            panelAnaManu.Controls.Add(richTextBox3);
            panelAnaManu.Controls.Add(richTextBox2);
            panelAnaManu.Controls.Add(richTextBox1);
            panelAnaManu.Controls.Add(labelTalimat3);
            panelAnaManu.Controls.Add(labelTalimat2);
            panelAnaManu.Controls.Add(labelTalimat1);
            panelAnaManu.Controls.Add(labelSure3);
            panelAnaManu.Controls.Add(labelSure2);
            panelAnaManu.Controls.Add(labelSure1);
            panelAnaManu.Controls.Add(labelKategori3);
            panelAnaManu.Controls.Add(labelKategori2);
            panelAnaManu.Controls.Add(labelKategori1);
            panelAnaManu.Controls.Add(label5);
            panelAnaManu.Controls.Add(labelName3);
            panelAnaManu.Controls.Add(labelName2);
            panelAnaManu.Controls.Add(labelName1);
            panelAnaManu.Controls.Add(pictureBoxTarif3);
            panelAnaManu.Controls.Add(pictureBoxTarif2);
            panelAnaManu.Controls.Add(pictureBoxTarif1);
            panelAnaManu.Location = new Point(0, 38);
            panelAnaManu.Name = "panelAnaManu";
            panelAnaManu.Size = new Size(1240, 621);
            panelAnaManu.TabIndex = 6;
            // 
            // buttonSayfa
            // 
            buttonSayfa.Location = new Point(762, 540);
            buttonSayfa.Name = "buttonSayfa";
            buttonSayfa.Size = new Size(75, 23);
            buttonSayfa.TabIndex = 25;
            buttonSayfa.Text = "button9";
            buttonSayfa.UseVisualStyleBackColor = true;
            buttonSayfa.Click += button9_Click;
            // 
            // comboBoxSayfa
            // 
            comboBoxSayfa.FormattingEnabled = true;
            comboBoxSayfa.Location = new Point(619, 541);
            comboBoxSayfa.Name = "comboBoxSayfa";
            comboBoxSayfa.Size = new Size(121, 23);
            comboBoxSayfa.TabIndex = 24;
            // 
            // labelGereken3
            // 
            labelGereken3.AutoSize = true;
            labelGereken3.Location = new Point(1069, 231);
            labelGereken3.Name = "labelGereken3";
            labelGereken3.Size = new Size(41, 15);
            labelGereken3.TabIndex = 23;
            labelGereken3.Text = "label9";
            // 
            // labelGereken2
            // 
            labelGereken2.AutoSize = true;
            labelGereken2.Location = new Point(688, 225);
            labelGereken2.Name = "labelGereken2";
            labelGereken2.Size = new Size(41, 15);
            labelGereken2.TabIndex = 22;
            labelGereken2.Text = "label8";
            // 
            // labelGereken1
            // 
            labelGereken1.AutoSize = true;
            labelGereken1.Location = new Point(362, 225);
            labelGereken1.Name = "labelGereken1";
            labelGereken1.Size = new Size(41, 15);
            labelGereken1.TabIndex = 21;
            labelGereken1.Text = "label6";
            // 
            // labelMaliyet3
            // 
            labelMaliyet3.AutoSize = true;
            labelMaliyet3.Location = new Point(1005, 231);
            labelMaliyet3.Name = "labelMaliyet3";
            labelMaliyet3.Size = new Size(41, 15);
            labelMaliyet3.TabIndex = 20;
            labelMaliyet3.Text = "label4";
            // 
            // labelMaliyet2
            // 
            labelMaliyet2.AutoSize = true;
            labelMaliyet2.Location = new Point(633, 225);
            labelMaliyet2.Name = "labelMaliyet2";
            labelMaliyet2.Size = new Size(41, 15);
            labelMaliyet2.TabIndex = 19;
            labelMaliyet2.Text = "label3";
            // 
            // labelMaliyet1
            // 
            labelMaliyet1.AutoSize = true;
            labelMaliyet1.Location = new Point(288, 225);
            labelMaliyet1.Name = "labelMaliyet1";
            labelMaliyet1.Size = new Size(41, 15);
            labelMaliyet1.TabIndex = 18;
            labelMaliyet1.Text = "label2";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(998, 366);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(100, 96);
            richTextBox3.TabIndex = 17;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(624, 366);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(100, 96);
            richTextBox2.TabIndex = 16;
            richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(288, 366);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 96);
            richTextBox1.TabIndex = 15;
            richTextBox1.Text = "";
            // 
            // labelTalimat3
            // 
            labelTalimat3.AutoSize = true;
            labelTalimat3.BorderStyle = BorderStyle.FixedSingle;
            labelTalimat3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTalimat3.ForeColor = SystemColors.ControlLightLight;
            labelTalimat3.Location = new Point(998, 487);
            labelTalimat3.Name = "labelTalimat3";
            labelTalimat3.Size = new Size(91, 24);
            labelTalimat3.TabIndex = 14;
            labelTalimat3.Text = "Talimatlar";
            labelTalimat3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTalimat2
            // 
            labelTalimat2.AutoSize = true;
            labelTalimat2.BorderStyle = BorderStyle.FixedSingle;
            labelTalimat2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTalimat2.ForeColor = SystemColors.ControlLightLight;
            labelTalimat2.Location = new Point(624, 487);
            labelTalimat2.Name = "labelTalimat2";
            labelTalimat2.Size = new Size(91, 24);
            labelTalimat2.TabIndex = 13;
            labelTalimat2.Text = "Talimatlar";
            labelTalimat2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTalimat1
            // 
            labelTalimat1.AutoSize = true;
            labelTalimat1.BorderStyle = BorderStyle.FixedSingle;
            labelTalimat1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTalimat1.ForeColor = SystemColors.ControlLightLight;
            labelTalimat1.Location = new Point(288, 487);
            labelTalimat1.Name = "labelTalimat1";
            labelTalimat1.Size = new Size(91, 24);
            labelTalimat1.TabIndex = 12;
            labelTalimat1.Text = "Talimatlar";
            labelTalimat1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSure3
            // 
            labelSure3.AutoSize = true;
            labelSure3.BorderStyle = BorderStyle.FixedSingle;
            labelSure3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelSure3.ForeColor = SystemColors.ControlLightLight;
            labelSure3.Location = new Point(998, 329);
            labelSure3.Name = "labelSure3";
            labelSure3.Size = new Size(157, 24);
            labelSure3.TabIndex = 11;
            labelSure3.Text = "Hazırlanma Süresi";
            labelSure3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSure2
            // 
            labelSure2.AutoSize = true;
            labelSure2.BorderStyle = BorderStyle.FixedSingle;
            labelSure2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelSure2.ForeColor = SystemColors.ControlLightLight;
            labelSure2.Location = new Point(619, 329);
            labelSure2.Name = "labelSure2";
            labelSure2.Size = new Size(157, 24);
            labelSure2.TabIndex = 10;
            labelSure2.Text = "Hazırlanma Süresi";
            labelSure2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSure1
            // 
            labelSure1.AutoSize = true;
            labelSure1.BorderStyle = BorderStyle.FixedSingle;
            labelSure1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelSure1.ForeColor = SystemColors.ControlLightLight;
            labelSure1.Location = new Point(288, 326);
            labelSure1.Name = "labelSure1";
            labelSure1.Size = new Size(157, 24);
            labelSure1.TabIndex = 9;
            labelSure1.Text = "Hazırlanma Süresi";
            labelSure1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelKategori3
            // 
            labelKategori3.AutoSize = true;
            labelKategori3.BorderStyle = BorderStyle.FixedSingle;
            labelKategori3.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelKategori3.ForeColor = SystemColors.ControlLightLight;
            labelKategori3.Location = new Point(998, 277);
            labelKategori3.Name = "labelKategori3";
            labelKategori3.Size = new Size(79, 24);
            labelKategori3.TabIndex = 8;
            labelKategori3.Text = "Kategori";
            labelKategori3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelKategori2
            // 
            labelKategori2.AutoSize = true;
            labelKategori2.BorderStyle = BorderStyle.FixedSingle;
            labelKategori2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelKategori2.ForeColor = SystemColors.ControlLightLight;
            labelKategori2.Location = new Point(619, 280);
            labelKategori2.Name = "labelKategori2";
            labelKategori2.Size = new Size(79, 24);
            labelKategori2.TabIndex = 7;
            labelKategori2.Text = "Kategori";
            labelKategori2.TextAlign = ContentAlignment.MiddleCenter;
            labelKategori2.Click += label7_Click;
            // 
            // labelKategori1
            // 
            labelKategori1.AutoSize = true;
            labelKategori1.BorderStyle = BorderStyle.FixedSingle;
            labelKategori1.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelKategori1.ForeColor = SystemColors.ControlLightLight;
            labelKategori1.Location = new Point(288, 280);
            labelKategori1.Name = "labelKategori1";
            labelKategori1.Size = new Size(79, 24);
            labelKategori1.TabIndex = 6;
            labelKategori1.Text = "Kategori";
            labelKategori1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // labelName3
            // 
            labelName3.AutoSize = true;
            labelName3.BorderStyle = BorderStyle.FixedSingle;
            labelName3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelName3.ForeColor = SystemColors.ControlLightLight;
            labelName3.Location = new Point(1005, 174);
            labelName3.Name = "labelName3";
            labelName3.Size = new Size(105, 31);
            labelName3.TabIndex = 5;
            labelName3.Text = "Tarif Adı";
            labelName3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName2
            // 
            labelName2.AutoSize = true;
            labelName2.BorderStyle = BorderStyle.FixedSingle;
            labelName2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelName2.ForeColor = SystemColors.ControlLightLight;
            labelName2.Location = new Point(624, 172);
            labelName2.Name = "labelName2";
            labelName2.Size = new Size(105, 31);
            labelName2.TabIndex = 4;
            labelName2.Text = "Tarif Adı";
            labelName2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName1
            // 
            labelName1.AutoSize = true;
            labelName1.BorderStyle = BorderStyle.FixedSingle;
            labelName1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelName1.ForeColor = SystemColors.ControlLightLight;
            labelName1.Location = new Point(276, 174);
            labelName1.Name = "labelName1";
            labelName1.Size = new Size(105, 31);
            labelName1.TabIndex = 3;
            labelName1.Text = "Tarif Adı";
            labelName1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxTarif3
            // 
            pictureBoxTarif3.Location = new Point(944, 35);
            pictureBoxTarif3.Name = "pictureBoxTarif3";
            pictureBoxTarif3.Size = new Size(223, 127);
            pictureBoxTarif3.TabIndex = 2;
            pictureBoxTarif3.TabStop = false;
            // 
            // pictureBoxTarif2
            // 
            pictureBoxTarif2.Location = new Point(599, 35);
            pictureBoxTarif2.Name = "pictureBoxTarif2";
            pictureBoxTarif2.Size = new Size(223, 127);
            pictureBoxTarif2.TabIndex = 1;
            pictureBoxTarif2.TabStop = false;
            // 
            // pictureBoxTarif1
            // 
            pictureBoxTarif1.Location = new Point(254, 35);
            pictureBoxTarif1.Name = "pictureBoxTarif1";
            pictureBoxTarif1.Size = new Size(223, 127);
            pictureBoxTarif1.TabIndex = 0;
            pictureBoxTarif1.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTarif1).EndInit();
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
        private PictureBox pictureBoxTarif3;
        private PictureBox pictureBoxTarif2;
        private PictureBox pictureBoxTarif1;
        private Label label5;
        private Label labelName3;
        private Label labelName2;
        private Label labelName1;
        private Label labelSure3;
        private Label labelSure2;
        private Label labelSure1;
        private Label labelKategori3;
        private Label labelKategori2;
        private Label labelKategori1;
        private Label labelTalimat3;
        private Label labelTalimat2;
        private Label labelTalimat1;
        private Label labelMaliyet2;
        private Label labelMaliyet1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox1;
        private Label labelGereken3;
        private Label labelGereken2;
        private Label labelGereken1;
        private Label labelMaliyet3;
        private Button buttonSayfa;
        private ComboBox comboBoxSayfa;
    }
}