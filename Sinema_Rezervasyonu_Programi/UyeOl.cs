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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }

        private void b_UyeOl_Click(object sender, EventArgs e)
        {
            VeriTabaniErisim.KaydolmaSonucu kaydolmaSonucu =  VeriTabaniErisim.Instance().KayitOl(t_UkullaniciAdi.Text, t_UAd.Text, t_Usoyad.Text, t_Usifre.Text);
            if (kaydolmaSonucu == VeriTabaniErisim.KaydolmaSonucu.kullaniciAdiKullaniliyor)
            {
                MessageBox.Show("Kullanıcı adı kullanılmaktadır.");
            }
            else if (kaydolmaSonucu == VeriTabaniErisim.KaydolmaSonucu.basarili)
            {
                Avmler avm = new Avmler(true);
                avm.Show();
                avm.Location = new Point(Location.X + 32, Location.Y + 32);
                Hide();
                avm.FormClosed += (a, b) => { Close(); };
                
            }
            else if (kaydolmaSonucu == VeriTabaniErisim.KaydolmaSonucu.bilinmeyenHata)
            {
                MessageBox.Show("Bilinmeyen hata.");
            }
        }
    }
}
