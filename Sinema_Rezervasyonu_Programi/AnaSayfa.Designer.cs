namespace Sinema_Rezervasyonu_Programi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.b_GuyeOl = new System.Windows.Forms.Button();
            this.t_GKullaniciSifre = new System.Windows.Forms.TextBox();
            this.t_GkullaniciAdi = new System.Windows.Forms.TextBox();
            this.b_Ggiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 717);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // b_GuyeOl
            // 
            this.b_GuyeOl.BackColor = System.Drawing.Color.Transparent;
            this.b_GuyeOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_GuyeOl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_GuyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_GuyeOl.ForeColor = System.Drawing.Color.Transparent;
            this.b_GuyeOl.Image = ((System.Drawing.Image)(resources.GetObject("b_GuyeOl.Image")));
            this.b_GuyeOl.Location = new System.Drawing.Point(334, 600);
            this.b_GuyeOl.Margin = new System.Windows.Forms.Padding(2);
            this.b_GuyeOl.Name = "b_GuyeOl";
            this.b_GuyeOl.Size = new System.Drawing.Size(90, 37);
            this.b_GuyeOl.TabIndex = 16;
            this.b_GuyeOl.Text = "Uye Ol";
            this.b_GuyeOl.UseVisualStyleBackColor = false;
            this.b_GuyeOl.Click += new System.EventHandler(this.b_GuyeOl_Click);
            // 
            // t_GKullaniciSifre
            // 
            this.t_GKullaniciSifre.BackColor = System.Drawing.Color.LavenderBlush;
            this.t_GKullaniciSifre.Location = new System.Drawing.Point(166, 511);
            this.t_GKullaniciSifre.Margin = new System.Windows.Forms.Padding(2);
            this.t_GKullaniciSifre.Multiline = true;
            this.t_GKullaniciSifre.Name = "t_GKullaniciSifre";
            this.t_GKullaniciSifre.Size = new System.Drawing.Size(259, 31);
            this.t_GKullaniciSifre.TabIndex = 15;
            // 
            // t_GkullaniciAdi
            // 
            this.t_GkullaniciAdi.BackColor = System.Drawing.Color.LavenderBlush;
            this.t_GkullaniciAdi.Location = new System.Drawing.Point(166, 435);
            this.t_GkullaniciAdi.Margin = new System.Windows.Forms.Padding(2);
            this.t_GkullaniciAdi.Multiline = true;
            this.t_GkullaniciAdi.Name = "t_GkullaniciAdi";
            this.t_GkullaniciAdi.Size = new System.Drawing.Size(259, 30);
            this.t_GkullaniciAdi.TabIndex = 14;
            // 
            // b_Ggiris
            // 
            this.b_Ggiris.BackColor = System.Drawing.Color.Transparent;
            this.b_Ggiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Ggiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_Ggiris.ForeColor = System.Drawing.Color.Transparent;
            this.b_Ggiris.Image = ((System.Drawing.Image)(resources.GetObject("b_Ggiris.Image")));
            this.b_Ggiris.Location = new System.Drawing.Point(229, 600);
            this.b_Ggiris.Margin = new System.Windows.Forms.Padding(2);
            this.b_Ggiris.Name = "b_Ggiris";
            this.b_Ggiris.Size = new System.Drawing.Size(91, 37);
            this.b_Ggiris.TabIndex = 11;
            this.b_Ggiris.Text = "Giris Yap";
            this.b_Ggiris.UseVisualStyleBackColor = false;
            this.b_Ggiris.Click += new System.EventHandler(this.b_Ggiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(78, 511);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(8, 435);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanici Adi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 773);
            this.Controls.Add(this.b_GuyeOl);
            this.Controls.Add(this.t_GKullaniciSifre);
            this.Controls.Add(this.t_GkullaniciAdi);
            this.Controls.Add(this.b_Ggiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AnaSayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button b_GuyeOl;
        private System.Windows.Forms.TextBox t_GKullaniciSifre;
        private System.Windows.Forms.TextBox t_GkullaniciAdi;
        private System.Windows.Forms.Button b_Ggiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

