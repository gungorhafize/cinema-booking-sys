namespace Sinema_Rezervasyonu_Programi
{
    partial class Avmler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avmler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Avm = new System.Windows.Forms.Button();
            this.l_AuyeAd = new System.Windows.Forms.Label();
            this.c_Avm = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(17, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Avm Seciniz: ";
            // 
            // b_Avm
            // 
            this.b_Avm.BackColor = System.Drawing.Color.Transparent;
            this.b_Avm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_Avm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_Avm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_Avm.ForeColor = System.Drawing.Color.Transparent;
            this.b_Avm.Image = ((System.Drawing.Image)(resources.GetObject("b_Avm.Image")));
            this.b_Avm.Location = new System.Drawing.Point(351, 552);
            this.b_Avm.Margin = new System.Windows.Forms.Padding(2);
            this.b_Avm.Name = "b_Avm";
            this.b_Avm.Size = new System.Drawing.Size(90, 37);
            this.b_Avm.TabIndex = 14;
            this.b_Avm.Text = "Git";
            this.b_Avm.UseVisualStyleBackColor = false;
            this.b_Avm.Click += new System.EventHandler(this.b_Avm_Click);
            // 
            // l_AuyeAd
            // 
            this.l_AuyeAd.AutoSize = true;
            this.l_AuyeAd.BackColor = System.Drawing.Color.Transparent;
            this.l_AuyeAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_AuyeAd.ForeColor = System.Drawing.Color.Maroon;
            this.l_AuyeAd.Location = new System.Drawing.Point(27, 21);
            this.l_AuyeAd.Name = "l_AuyeAd";
            this.l_AuyeAd.Size = new System.Drawing.Size(0, 24);
            this.l_AuyeAd.TabIndex = 15;
            // 
            // c_Avm
            // 
            this.c_Avm.FormattingEnabled = true;
            this.c_Avm.ItemHeight = 13;
            this.c_Avm.Location = new System.Drawing.Point(22, 466);
            this.c_Avm.Name = "c_Avm";
            this.c_Avm.Size = new System.Drawing.Size(419, 21);
            this.c_Avm.TabIndex = 16;
            // 
            // Avmler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(481, 776);
            this.Controls.Add(this.c_Avm);
            this.Controls.Add(this.l_AuyeAd);
            this.Controls.Add(this.b_Avm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Avmler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Avmler";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Avm;
        private System.Windows.Forms.Label l_AuyeAd;
        private System.Windows.Forms.ComboBox c_Avm;
    }
}