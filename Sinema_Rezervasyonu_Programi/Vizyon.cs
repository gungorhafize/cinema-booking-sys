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
    public partial class Vizyon : Form
    {
        public Vizyon()
        {
            InitializeComponent();
            VizyondakileriListele(VeriTabaniErisim.Instance().seciliAvmdekiFilmlerinTaslaklari, panel1, new Point(3, 3), 170);
        }

        private void VizyondakileriListele(Dictionary<int, FilmTaslak> filmler, Panel panel, Point baslangicPozisyonu, int aralardakiBosluk)
        {
            int i = 0;
            foreach (var item in filmler.Values)
            {
                new Vizyon_FilmGorseli(Vizyon_FilmGorseli.PointTopla(baslangicPozisyonu, new Point(0, aralardakiBosluk * i)), item, panel,this);
                i++;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    class Vizyon_FilmGorseli
    {
        FilmTaslak film;
        Panel panel;
        Vizyon vizyon;

        PictureBox afis;
        Label baslik;
        Label imdb;
        Label seanslarBaslik;
        Label seanslarIcerik;
        Button satinAlButonu;

        Point afisPozisyonu = new Point(0, 0);
        Size afisBoyutu = new Size(150, 150);
        Point baslikPozisyonu = new Point(160, 0);
        Point imdbPozisyonu = new Point(160, 40);
        Point seanslarBaslikPozisyonu = new Point(160, 70);
        Point seanslarIcerikPozisyonu = new Point(160, 100);
        Point satinAlButonuPoziysonu = new Point(370, 127);
        Size satinAlButonuBoyutu = new Size(75, 25);
        Font baslikFont = new Font(FontFamily.GenericSansSerif, 15f, FontStyle.Bold);
        Font seanslarBaslikFont = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);
        Color yazilarinArkasininRengi = Color.FromArgb(0, 0, 0, 0);

        public Vizyon_FilmGorseli(Point baslangicPozisyonu, FilmTaslak film, Panel panel,Vizyon vizyon)//Vizyon Paneli Oluşturma
        {
            this.film = film;
            this.panel = panel;
            this.vizyon = vizyon;

            afis = new PictureBox();
            afis.SizeMode = PictureBoxSizeMode.Zoom;
            afis.Image = film.afis;
            panel.Controls.Add(afis);
            afis.Location = PointTopla(afisPozisyonu, baslangicPozisyonu);
            afis.Size = afisBoyutu;

            baslik = new Label();
            panel.Controls.Add(baslik);
            baslik.AutoSize = true;
            baslik.Location = PointTopla(baslikPozisyonu, baslangicPozisyonu);
            baslik.Font = baslikFont;
            baslik.Text = film.ad;
            baslik.BackColor = yazilarinArkasininRengi;

            imdb = new Label();
            panel.Controls.Add(imdb);
            imdb.Location = PointTopla(imdbPozisyonu, baslangicPozisyonu);
            imdb.AutoSize = true;
            imdb.Text = "Imdb: " + film.imdb;
            imdb.BackColor = yazilarinArkasininRengi;

            seanslarBaslik = new Label();
            panel.Controls.Add(seanslarBaslik);
            seanslarBaslik.Location = PointTopla(seanslarBaslikPozisyonu, baslangicPozisyonu);
            seanslarBaslik.AutoSize = true;
            seanslarBaslik.Font = seanslarBaslikFont;
            seanslarBaslik.Text = "Seanslar";
            seanslarBaslik.BackColor = yazilarinArkasininRengi;

            seanslarIcerik = new Label();
            panel.Controls.Add(seanslarIcerik);
            seanslarIcerik.Location = PointTopla(seanslarIcerikPozisyonu, baslangicPozisyonu);
            seanslarIcerik.AutoSize = true;
            seanslarIcerik.Text = SeansSaatleriniOlustur();
            seanslarIcerik.BackColor = yazilarinArkasininRengi;

            satinAlButonu = new Button();
            panel.Controls.Add(satinAlButonu);
            satinAlButonu.Location = PointTopla(satinAlButonuPoziysonu, baslangicPozisyonu);
            satinAlButonu.Size = satinAlButonuBoyutu;
            satinAlButonu.Text = "Filme git";
            satinAlButonu.Click += (a, b) => { SecilenFilmeGit(film); };

        }
        private void SecilenFilmeGit(FilmTaslak filmTaslak)
        {
            SecilenFilm filmBilgiEkrani = new SecilenFilm(filmTaslak);
            vizyon.Hide();
            filmBilgiEkrani.Show();
            filmBilgiEkrani.Location = new Point(vizyon.Location.X + 32, vizyon.Location.Y + 32);

            filmBilgiEkrani.FormClosed += (a,b) => { vizyon.Show(); };
            
        }
        public static Point PointTopla(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        private string SeansSaatleriniOlustur()
        {
            List<DateTime> saatler = new List<DateTime>();

            foreach (var item in VeriTabaniErisim.Instance().seciliAvmdekiFilmler)//Filmin saatlerini listeye koyma
            {
                if (item.taslakID == film.ID)
                {
                    saatler.Add(item.tarih);
                }
            }

            saatler.Sort();

            string saatlerString = string.Empty;

            for (int i = 0; i < saatler.Count; i++)//Saatleri stringe çevirme
            {
                saatlerString += saatler[i].ToString("HH:mm");
                if (i < saatler.Count - 1)
                {
                    saatlerString += " - ";
                }
            }

            return saatlerString;
        }
    }

}
