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
    public partial class Koltuklar : Form
    {
        KoltukButonu[] butonlar;
        List<int> seciliKoltuklar = new List<int>();
        FilmObjesi film;
        public Koltuklar(FilmObjesi filmObjesi)
        {
            InitializeComponent();
            film = filmObjesi;
            KoltukButonlariniOlustur(new Size(40, 40), 10, 8, new Point(60, 10), 4, KoltukSec);

        }

        private void b_Btamam_Click(object sender, EventArgs e)
        {

        }
        private void KoltukButonlariniOlustur(Size butonBoyutu, int yatayKoltukAdedi, int dikeyKoltukAdedi, Point baslangicNoktasi, int butonlarArasiBosluk, System.Action<int, bool> butonaTiklayincaNolcak)
        {
            butonlar = new KoltukButonu[yatayKoltukAdedi * dikeyKoltukAdedi];
            int index = 0;
            for (int k = 0; k < dikeyKoltukAdedi; k++)
            {
                for (int i = 0; i < yatayKoltukAdedi; i++)
                {
                    int mecvutKoltukIndex = i * yatayKoltukAdedi + k * dikeyKoltukAdedi;
                    KoltukButonu tempButton = new KoltukButonu(film.salon.koltuklar[index], Properties.Resources.dolu, Properties.Resources.bos, Properties.Resources.secili, /*((char)(dikeyKoltukAdedi - k + 64)).ToString() + */(i + 1).ToString(), index, KoltukSec);
                    tempButton.Size = butonBoyutu;
                    tempButton.Location = new Point(baslangicNoktasi.X + i * (butonBoyutu.Width + butonlarArasiBosluk), baslangicNoktasi.Y + k * (butonBoyutu.Height + butonlarArasiBosluk));
                    Controls.Add(tempButton);
                    butonlar[index] = tempButton;

                    index++;
                }
                //index++;
            }
        }
        private void KoltukSec(int koltukIndex, bool secildiMi)
        {
            Console.WriteLine(koltukIndex);

            if (secildiMi)
            {
                if (!seciliKoltuklar.Contains(koltukIndex))
                    seciliKoltuklar.Add(koltukIndex);
            }
            else
            {
                seciliKoltuklar.Remove(koltukIndex);
            }
        }
        private void SeciliKoltuklariAl()
        {
            if (seciliKoltuklar.Count == 0)
            {
                MessageBox.Show("Koltuk seçiniz.");
            }
            else
            {
                VeriTabaniErisim.BiletAlmaSonucu sonuc = VeriTabaniErisim.Instance().KoltukAl(film, seciliKoltuklar);
                if (sonuc == VeriTabaniErisim.BiletAlmaSonucu.basarili)
                {
                    string cevap = film.tarih.ToShortDateString() +
                        " tarihinde ve " +
                        film.tarih.ToShortTimeString() +
                        " saatinde biletiniz oluşturulmuştur. Bizi tercih ettiğiniz için teşekkür ederiz sayın " +
                        VeriTabaniErisim.Instance().uyeBilgisi.adi + " " +
                        VeriTabaniErisim.Instance().uyeBilgisi.soyadi + ".";
                    MessageBox.Show(cevap);
                    this.Close();
                }
                else if (sonuc == VeriTabaniErisim.BiletAlmaSonucu.biletAlinmis)
                {
                    MessageBox.Show("Bilet daha önce alınmış!");
                    KoltuklariGuncelle();
                }
                else if(sonuc == VeriTabaniErisim.BiletAlmaSonucu.baglantiHatasi)
                {
                    MessageBox.Show("Bağlantı hatası...");
                }
            }
        }
        private void KoltuklariGuncelle()
        {
            for(int i = 0;i<butonlar.Length;i++)
            {
                butonlar[i].Guncelle(film.salon.koltuklar[i]);
            }
        }
        private void Koltuklar_Load(object sender, EventArgs e)
        {

        }

        private void b_K_Click(object sender, EventArgs e)
        {
            SeciliKoltuklariAl();
        }
    }
}
