namespace Sinema_Rezervasyonu_Programi
{
    partial class YoneticiPaneli
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.li_YfilmListesi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_YfilmEkle = new System.Windows.Forms.Button();
            this.t_YfilmAdi = new System.Windows.Forms.TextBox();
            this.t_Ykonu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.t_Yimbd = new System.Windows.Forms.TextBox();
            this.t_Ytur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.d_YvizyonTarihi = new System.Windows.Forms.DateTimePicker();
            this.t_Ysure = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_Yyonetmen = new System.Windows.Forms.TextBox();
            this.t_Yoyuncular = new System.Windows.Forms.TextBox();
            this.l_Yotuncular = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.b_YseansSil = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.li_YseansListesi = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.c_YfilmSec = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.c_YavmSec = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.c_YsalonNoSec = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.p_afis = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_afis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(781, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(773, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film Taslağı Ekle/Çıkar";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.li_YfilmListesi);
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 610);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Film Silme Paneli";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Location = new System.Drawing.Point(7, 552);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seçili Filmi Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // li_YfilmListesi
            // 
            this.li_YfilmListesi.FormattingEnabled = true;
            this.li_YfilmListesi.Location = new System.Drawing.Point(6, 19);
            this.li_YfilmListesi.Name = "li_YfilmListesi";
            this.li_YfilmListesi.Size = new System.Drawing.Size(271, 524);
            this.li_YfilmListesi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.p_afis);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_YfilmEkle);
            this.groupBox1.Controls.Add(this.t_YfilmAdi);
            this.groupBox1.Controls.Add(this.t_Ykonu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.t_Yimbd);
            this.groupBox1.Controls.Add(this.t_Ytur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.d_YvizyonTarihi);
            this.groupBox1.Controls.Add(this.t_Ysure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_Yyonetmen);
            this.groupBox1.Controls.Add(this.t_Yoyuncular);
            this.groupBox1.Controls.Add(this.l_Yotuncular);
            this.groupBox1.Location = new System.Drawing.Point(296, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 611);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Ekleme Paneli";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // b_YfilmEkle
            // 
            this.b_YfilmEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.b_YfilmEkle.Location = new System.Drawing.Point(358, 575);
            this.b_YfilmEkle.Name = "b_YfilmEkle";
            this.b_YfilmEkle.Size = new System.Drawing.Size(92, 33);
            this.b_YfilmEkle.TabIndex = 16;
            this.b_YfilmEkle.Text = "Filmi Ekle";
            this.b_YfilmEkle.UseVisualStyleBackColor = false;
            this.b_YfilmEkle.Click += new System.EventHandler(this.b_YfilmEkle_Click);
            // 
            // t_YfilmAdi
            // 
            this.t_YfilmAdi.Location = new System.Drawing.Point(145, 174);
            this.t_YfilmAdi.Name = "t_YfilmAdi";
            this.t_YfilmAdi.Size = new System.Drawing.Size(305, 20);
            this.t_YfilmAdi.TabIndex = 1;
            // 
            // t_Ykonu
            // 
            this.t_Ykonu.Location = new System.Drawing.Point(145, 474);
            this.t_Ykonu.Multiline = true;
            this.t_Ykonu.Name = "t_Ykonu";
            this.t_Ykonu.Size = new System.Drawing.Size(305, 95);
            this.t_Ykonu.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "İmdb:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(72, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Konu:";
            // 
            // t_Yimbd
            // 
            this.t_Yimbd.Location = new System.Drawing.Point(145, 226);
            this.t_Yimbd.Name = "t_Yimbd";
            this.t_Yimbd.Size = new System.Drawing.Size(47, 20);
            this.t_Yimbd.TabIndex = 3;
            // 
            // t_Ytur
            // 
            this.t_Ytur.Location = new System.Drawing.Point(145, 435);
            this.t_Ytur.Name = "t_Ytur";
            this.t_Ytur.Size = new System.Drawing.Size(140, 20);
            this.t_Ytur.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vizyon Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(87, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tür:";
            // 
            // d_YvizyonTarihi
            // 
            this.d_YvizyonTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.d_YvizyonTarihi.Location = new System.Drawing.Point(145, 267);
            this.d_YvizyonTarihi.Name = "d_YvizyonTarihi";
            this.d_YvizyonTarihi.Size = new System.Drawing.Size(100, 20);
            this.d_YvizyonTarihi.TabIndex = 5;
            // 
            // t_Ysure
            // 
            this.t_Ysure.Location = new System.Drawing.Point(145, 390);
            this.t_Ysure.Name = "t_Ysure";
            this.t_Ysure.Size = new System.Drawing.Size(111, 20);
            this.t_Ysure.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Yönetmen:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 390);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Süre:";
            // 
            // t_Yyonetmen
            // 
            this.t_Yyonetmen.Location = new System.Drawing.Point(145, 310);
            this.t_Yyonetmen.Name = "t_Yyonetmen";
            this.t_Yyonetmen.Size = new System.Drawing.Size(305, 20);
            this.t_Yyonetmen.TabIndex = 7;
            // 
            // t_Yoyuncular
            // 
            this.t_Yoyuncular.Location = new System.Drawing.Point(145, 350);
            this.t_Yoyuncular.Name = "t_Yoyuncular";
            this.t_Yoyuncular.Size = new System.Drawing.Size(305, 20);
            this.t_Yoyuncular.TabIndex = 9;
            // 
            // l_Yotuncular
            // 
            this.l_Yotuncular.AutoSize = true;
            this.l_Yotuncular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_Yotuncular.Location = new System.Drawing.Point(33, 350);
            this.l_Yotuncular.Name = "l_Yotuncular";
            this.l_Yotuncular.Size = new System.Drawing.Size(94, 20);
            this.l_Yotuncular.TabIndex = 8;
            this.l_Yotuncular.Text = "Oyuncular:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(773, 623);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seans Ekle/Çıkar";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.b_YseansSil);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.li_YseansListesi);
            this.groupBox4.Location = new System.Drawing.Point(407, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 611);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seans Çıkarma";
            // 
            // b_YseansSil
            // 
            this.b_YseansSil.BackColor = System.Drawing.Color.SteelBlue;
            this.b_YseansSil.Location = new System.Drawing.Point(10, 557);
            this.b_YseansSil.Name = "b_YseansSil";
            this.b_YseansSil.Size = new System.Drawing.Size(340, 48);
            this.b_YseansSil.TabIndex = 14;
            this.b_YseansSil.Text = "Seans Sil";
            this.b_YseansSil.UseVisualStyleBackColor = false;
            this.b_YseansSil.Click += new System.EventHandler(this.b_YseansSil_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(6, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Seanslar:";
            // 
            // li_YseansListesi
            // 
            this.li_YseansListesi.FormattingEnabled = true;
            this.li_YseansListesi.Location = new System.Drawing.Point(10, 43);
            this.li_YseansListesi.Name = "li_YseansListesi";
            this.li_YseansListesi.Size = new System.Drawing.Size(340, 511);
            this.li_YseansListesi.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.c_YfilmSec);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Controls.Add(this.c_YavmSec);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.c_YsalonNoSec);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(388, 611);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Seans Ekleme";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Film Adı:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.Location = new System.Drawing.Point(279, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Avm Adı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(19, 247);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Seans:";
            // 
            // c_YfilmSec
            // 
            this.c_YfilmSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_YfilmSec.FormattingEnabled = true;
            this.c_YfilmSec.Location = new System.Drawing.Point(99, 23);
            this.c_YfilmSec.Name = "c_YfilmSec";
            this.c_YfilmSec.Size = new System.Drawing.Size(274, 21);
            this.c_YfilmSec.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(99, 247);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // c_YavmSec
            // 
            this.c_YavmSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_YavmSec.FormattingEnabled = true;
            this.c_YavmSec.Location = new System.Drawing.Point(99, 73);
            this.c_YavmSec.Name = "c_YavmSec";
            this.c_YavmSec.Size = new System.Drawing.Size(274, 21);
            this.c_YavmSec.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(36, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gün:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(6, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Salon No:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 190);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // c_YsalonNoSec
            // 
            this.c_YsalonNoSec.FormattingEnabled = true;
            this.c_YsalonNoSec.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.c_YsalonNoSec.Location = new System.Drawing.Point(99, 130);
            this.c_YsalonNoSec.Name = "c_YsalonNoSec";
            this.c_YsalonNoSec.Size = new System.Drawing.Size(93, 21);
            this.c_YsalonNoSec.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SteelBlue;
            this.button3.Location = new System.Drawing.Point(225, 144);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 24);
            this.button3.TabIndex = 17;
            this.button3.Text = "Afiş Seç:";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // p_afis
            // 
            this.p_afis.BackColor = System.Drawing.Color.White;
            this.p_afis.Location = new System.Drawing.Point(225, 20);
            this.p_afis.Name = "p_afis";
            this.p_afis.Size = new System.Drawing.Size(120, 120);
            this.p_afis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_afis.TabIndex = 18;
            this.p_afis.TabStop = false;
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 673);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YoneticiPaneli";
            this.Text = "YoneticiPaneli";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_afis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox li_YfilmListesi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_YfilmEkle;
        private System.Windows.Forms.TextBox t_YfilmAdi;
        private System.Windows.Forms.TextBox t_Ykonu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox t_Yimbd;
        private System.Windows.Forms.TextBox t_Ytur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker d_YvizyonTarihi;
        private System.Windows.Forms.TextBox t_Ysure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_Yyonetmen;
        private System.Windows.Forms.TextBox t_Yoyuncular;
        private System.Windows.Forms.Label l_Yotuncular;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button b_YseansSil;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox li_YseansListesi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox c_YfilmSec;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox c_YsalonNoSec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox c_YavmSec;
        private System.Windows.Forms.PictureBox p_afis;
        private System.Windows.Forms.Button button3;
    }
}