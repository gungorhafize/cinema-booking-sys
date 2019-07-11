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
    public partial class SecilenFilm : Form
    {
        List<FilmObjesi> filmObjeleri;

        public SecilenFilm(FilmTaslak filmTaslak)
        {
            InitializeComponent();

            L_SfilmAdi.Text = filmTaslak.ad;
            p_afis.Image = filmTaslak.afis;
            l_Simdb.Text = filmTaslak.imdb;
            L_Skonu.Text = filmTaslak.konu;
            L_Soyuncular.Text = filmTaslak.oyuncular;
            L_Ssure.Text = filmTaslak.sure;
            L_SvizyonTarihi.Text = filmTaslak.vizyonTarihi.ToShortDateString();
            L_Stur.Text = filmTaslak.tur;
            L_Syonetmen.Text = filmTaslak.yonetmen;

            filmObjeleri = filmTaslak.FilmObjesiListesi();

            Point butonBaslangic = new Point(5, L_Skonu.Location.Y + L_Skonu.Size.Height + 50);

            ButonlariOlustur(butonBaslangic, new Size(75, 25), 25);
        }

        private void ButonlariOlustur(Point baslangicPozisyonu, Size butonBoyutu, int aralardakiBosluk)//Seans butonlarını oluşturma
        {
            filmObjeleri.Sort((x, y) => x.tarih.CompareTo(y.tarih));
            int suAnkiSatir = 0;
            int kacButondaBirAltSatiraGececek = int.MaxValue;
            for (int i = 0, k = 0; i < filmObjeleri.Count; i++,k++)
            {
                if ((baslangicPozisyonu.X + (i % kacButondaBirAltSatiraGececek) * (butonBoyutu.Width + aralardakiBosluk)) > this.Width)
                {
                    kacButondaBirAltSatiraGececek = i;
                    suAnkiSatir++;
                    k = 0;
                }
                Button tempButton = new Button();
                tempButton.Location = new Point(baslangicPozisyonu.X + k*(butonBoyutu.Width + aralardakiBosluk), baslangicPozisyonu.Y + suAnkiSatir * (butonBoyutu.Height + aralardakiBosluk));
                tempButton.Size = butonBoyutu;
                tempButton.Text = filmObjeleri[i].tarih.ToShortTimeString();
                int secilenFilmObjesiIndex = i;
                tempButton.Click += (a, b) => { KoltukSecmeEkraninaGec(filmObjeleri[secilenFilmObjesiIndex]); };
                Controls.Add(tempButton);
            }
        }

        private void KoltukSecmeEkraninaGec(FilmObjesi filmObjesi)
        {
            Koltuklar koltukEkrani = new Koltuklar(filmObjesi);
            this.Hide();
            koltukEkrani.Show();
            koltukEkrani.Location = new Point(this.Location.X + 32, this.Location.Y + 32);

            koltukEkrani.FormClosed += (a, b) => { this.Close(); };
        }

    }
}
