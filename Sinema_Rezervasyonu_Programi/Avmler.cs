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
    public partial class Avmler : Form
    {

        public Avmler(bool yeniUyeMi)
        {
            InitializeComponent();

            if (yeniUyeMi == false)//
            {
                if (VeriTabaniErisim.Instance().uyeBilgisi != null)//Eğer üye girişi yapıldıysa üyenin adını yaz
                {
                    l_AuyeAd.Text = " Hoşgeldiniz :)  " + VeriTabaniErisim.Instance().uyeBilgisi.adi + " " + VeriTabaniErisim.Instance().uyeBilgisi.soyadi;
                }
                else
                {
                    Console.WriteLine("eror");
                }
            }
            else
            {
                if (VeriTabaniErisim.Instance().uyeBilgisi != null)//Eğer üye girişi yapıldıysa üyenin adını yaz
                {
                    l_AuyeAd.Text = " Hoşgeldiniz :) Üye Olduğunuz İçin Teşekkürler!" + VeriTabaniErisim.Instance().uyeBilgisi.adi + " " + VeriTabaniErisim.Instance().uyeBilgisi.soyadi;
                }
                else
                {
                    Console.WriteLine("eror");
                }
            }

            VeriTabaniErisim.Instance().AvmGetirme();//Combobox'a Avm ekleme
            c_Avm.Items.Clear();
            for (int i = 0; i < VeriTabaniErisim.Instance().avmListesi.Count; i++)
            {
                c_Avm.Items.Add(VeriTabaniErisim.Instance().avmListesi[i].ad);
            }

        }

        private void b_Avm_Click(object sender, EventArgs e)//Comboboxdan Avm seçme
        {
            VeriTabaniErisim.Instance().AvmSec(c_Avm.SelectedIndex);
            VeriTabaniErisim.Instance().FilmleriYükle();
            Vizyon _vizyon = new Vizyon();
            _vizyon.Show();
            _vizyon.Location = new Point(this.Location.X + 32, this.Location.Y + 32);

            _vizyon.FormClosed += (a,b) => { this.Show(); };
        }
    }
}
