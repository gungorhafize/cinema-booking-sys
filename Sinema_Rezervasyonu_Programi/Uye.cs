using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Rezervasyonu_Programi
{
    class Uye
    {
        
            private string _adi;
            public string adi { get { return _adi; } }
            private string _soyadi;
            public string soyadi { get { return _soyadi; } }
            private string _kullaniciAdi;
            public string kullaniciAdi { get { return _kullaniciAdi; } }
            private string _sifre;
            public string sifre { get { return _sifre; } }

            public Uye(string _adi, string _soyadi, string _kullaniciAdi, string _sifre)
            {
                this._adi = _adi;
                this._soyadi = _soyadi;
                this._kullaniciAdi = _kullaniciAdi;
                this._sifre = _sifre;
            }
        
    }
}
