using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Rezervasyonu_Programi
{
    class AvmBilgisi
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
        }
        private string _ad;
        public string ad
        {
            get { return _ad; }
        }
        public AvmBilgisi(int ID,string ad)
        {
            _ID = ID;
            _ad = ad;
        }
    }
}
