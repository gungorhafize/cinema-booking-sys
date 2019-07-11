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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
            VeriTabaniErisim.Instance().AvmGetirme();
            VeriTabaniErisim.Instance().TumTaslaklariYukle();
            VeriTabaniErisim.Instance().TumFilmObjeleriniYukle();
            TaslaklariListele();
            SeanslariListele();

            //AVMleri combobox'a ekle
            c_YavmSec.Items.Clear();
            foreach (var item in VeriTabaniErisim.Instance().avmListesi)
            {
                c_YavmSec.Items.Add(item.ad);
            }

        }

        private void button1_Click(object sender, EventArgs e)//Listeden film silme 
        {
            if (li_YfilmListesi.SelectedIndex != -1)
            {
                bool sonuc = VeriTabaniErisim.Instance().FilmTaslakSil(VeriTabaniErisim.Instance().tumTaslaklar.ElementAt(li_YfilmListesi.SelectedIndex).Value.ID);
                if (sonuc == true)
                {
                    li_YfilmListesi.Items.RemoveAt(li_YfilmListesi.SelectedIndex);
                    VeriTabaniErisim.Instance().TumFilmObjeleriniYukle();
                    SeanslariListele();
                }
                else
                {
                    MessageBox.Show("Film silme başarısız.");
                }
            }
        }

        private void b_YfilmEkle_Click(object sender, EventArgs e)//Sisteme film ekleme 
        {
            if (t_YfilmAdi.Text != string.Empty &&
                p_afis.Image != null &&
                t_Yimbd.Text != string.Empty &&
                t_Ykonu.Text != string.Empty &&
                t_Yoyuncular.Text != string.Empty &&
                t_Ysure.Text != string.Empty &&
                t_Ytur.Text != string.Empty &&
                t_Yyonetmen.Text != string.Empty)
            {
                bool sonuc = VeriTabaniErisim.Instance().FilmTaslakEkle(t_YfilmAdi.Text,
                    t_Yimbd.Text,
                    d_YvizyonTarihi.Value,
                    t_Yyonetmen.Text,
                    t_Yoyuncular.Text,
                    t_Ysure.Text,
                    t_Ytur.Text,
                    t_Ykonu.Text,
                    p_afis.Image);
                if (sonuc == true)
                {
                    VeriTabaniErisim.Instance().TumTaslaklariYukle();
                    TaslaklariListele();

                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
            }
        }

        private void b_YseansSil_Click(object sender, EventArgs e)//Listeden seans silme 
        {
            if (li_YseansListesi.SelectedIndex != -1)
            {
                bool sonuc = VeriTabaniErisim.Instance().FilmObjesiSil(VeriTabaniErisim.Instance().tumFilmler[li_YseansListesi.SelectedIndex].ID);
                if (sonuc == true)
                {
                    li_YseansListesi.Items.RemoveAt(li_YseansListesi.SelectedIndex);
                }
                else
                {
                    MessageBox.Show("Seans silme başarısız.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)//Sisteme seçilen filmin seans-salon bilgilerini ekleme 
        {
            if (c_YfilmSec.SelectedIndex != -1 &&
                c_YavmSec.SelectedIndex != -1 &&
                c_YsalonNoSec.SelectedIndex != -1)
            {
                bool sonuc = VeriTabaniErisim.Instance().FilmObjesiEkle(
                    VeriTabaniErisim.Instance().avmListesi[c_YavmSec.SelectedIndex].ID,
                    VeriTabaniErisim.Instance().tumTaslaklar.ElementAt(c_YfilmSec.SelectedIndex).Value.ID,
                    dateTimePicker1.Value.Add(dateTimePicker2.Value.TimeOfDay).Subtract(dateTimePicker1.Value.TimeOfDay),
                    c_YsalonNoSec.SelectedIndex + 1);
                if (sonuc == true)
                {
                    VeriTabaniErisim.Instance().TumFilmObjeleriniYukle();
                    SeanslariListele();
                }
            }
        }
        private void SeanslariListele()//Seansları liseye ekleme 
        {
            li_YseansListesi.Items.Clear();
            foreach (var item in VeriTabaniErisim.Instance().tumFilmler)
            {
                li_YseansListesi.Items.Add("İsim: " + VeriTabaniErisim.Instance().tumTaslaklar[item.taslakID].ad + " Avm:" + VeriTabaniErisim.Instance().avmListesi.First(x => x.ID == item.avmID).ad + " Tarih&Saat:" + item.tarih.ToString());
            }
        }
        private void TaslaklariListele()//Taslakları listeye ekleme
        {
            li_YfilmListesi.Items.Clear();
            c_YfilmSec.Items.Clear();
            foreach (var item in VeriTabaniErisim.Instance().tumTaslaklar)
            {
                li_YfilmListesi.Items.Add(item.Value.ad);
                c_YfilmSec.Items.Add(item.Value.ad);
            }
        }

        private void button3_Click(object sender, EventArgs e)//Afiş seçme 
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Afiş Seç";
            dlg.Filter = "bmp files (*.jpg)|*.jpg";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                p_afis.Image = Image.FromFile(dlg.FileName);
            }

            dlg.Dispose();
        }
    }
}
