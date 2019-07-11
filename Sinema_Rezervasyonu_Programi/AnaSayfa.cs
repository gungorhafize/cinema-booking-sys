using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Rezervasyonu_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_Girisi_Enter(object sender, EventArgs e)
        {

        }

        private void b_GuyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uyeOl = new UyeOl();
            uyeOl.Show();
            uyeOl.Location = new Point(this.Location.X + 32, this.Location.Y + 32);
            this.Hide();
            uyeOl.FormClosed += (a,b)=> { Close(); };
        }


        private void b_Ggiris_Click(object sender, EventArgs e)
        {
          VeriTabaniErisim.GirisYapmaSonucu sonuc =  VeriTabaniErisim.Instance().GirisYap(t_GkullaniciAdi.Text, t_GKullaniciSifre.Text);
            if(sonuc == VeriTabaniErisim.GirisYapmaSonucu.basarili)
            {
                Avmler avm = new Avmler(false);


                avm.Show();
                avm.Location = new Point(this.Location.X + 32, this.Location.Y + 32);
                this.Hide();
                avm.FormClosed += (a, b) => { this.Close(); };
            }
            else if(sonuc == VeriTabaniErisim.GirisYapmaSonucu.yoneticiGirisi)//Eğer yönetici ise yönetici panelini aç
            {
                YoneticiPaneli yoneticiPaneli = new YoneticiPaneli();
                yoneticiPaneli.Show();
                yoneticiPaneli.Location = new Point(this.Location.X + 32, this.Location.Y + 32);

                this.Hide();
                yoneticiPaneli.FormClosed += (a, b) => { this.Close(); };
            }

            else if(sonuc == VeriTabaniErisim.GirisYapmaSonucu.kullaniciAdiVeyaSifreHatasi)
            {
                MessageBox.Show("Kullanıcı Adınız veya Sifreniz Hatalı!");
            }
            else if(sonuc == VeriTabaniErisim.GirisYapmaSonucu.baglantiHatasi)
            {
                MessageBox.Show("Sunucuya Baglanılamadı!");
            }
            else if (sonuc == VeriTabaniErisim.GirisYapmaSonucu.bilinmeyenHata)
            {
                MessageBox.Show("Bilinmeyen Hata!");
            }
        }
    }
}
