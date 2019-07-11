using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Rezervasyonu_Programi
{
    class KoltukButonu : Button
    {
        bool doluMu = false;
        bool seciliMi = false;
        public string koltukNo;
        public int koltukIndex;
        Bitmap doluKoltuk, bosKoltuk, seciliKoltuk;
        Action<int, bool> yapilcakislem;
        public KoltukButonu(bool _seciliMi, Bitmap _dolu, Bitmap _bos, Bitmap _secili, string _koltukNo, int _koltukIndex, Action<int, bool> _yapilcakIslem)
        {
            doluMu = _seciliMi;
            doluKoltuk = _dolu;
            koltukIndex = _koltukIndex;
            bosKoltuk = _bos;
            seciliKoltuk = _secili;
            yapilcakislem = _yapilcakIslem;

            koltukNo = _koltukNo;

            Text = koltukNo;

            if (doluMu)
            {
                Image = doluKoltuk;
            }
            else
            {
                Image = bosKoltuk;
            }

            BackColor = System.Drawing.Color.Transparent;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            ForeColor = System.Drawing.Color.Transparent;
            UseVisualStyleBackColor = false;
        }
        protected override void OnClick(EventArgs e)
        {

            if (doluMu)
            {
                //doluMu = false;
                //Image = bosKoltuk;
            }
            else if (!doluMu)
            {
                base.OnClick(e);
                if (seciliMi)
                {


                    Image = bosKoltuk;
                    //Refresh();

                    yapilcakislem(koltukIndex, false);
                }
                else
                {

                    Image = seciliKoltuk;
                    //Refresh();

                    yapilcakislem(koltukIndex, true);
                }
                seciliMi = !seciliMi;

            }
        }
        public void Guncelle(bool _doluMu)
        {
            seciliMi = false;
            yapilcakislem(koltukIndex, false);
            doluMu = _doluMu;
            if(doluMu)
            {
                Image = doluKoltuk;
            }
            else
            {
                Image = bosKoltuk;
            }
        }

    }
}
