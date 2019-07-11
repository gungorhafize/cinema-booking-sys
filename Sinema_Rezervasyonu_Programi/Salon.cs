using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Rezervasyonu_Programi
{
    public class Salon
    {
        public int salonNo;
        public List<bool> koltuklar;
        public Salon(int salonNo, List<bool> koltuklar)
        {
            this.salonNo = salonNo;
            this.koltuklar = koltuklar;
        }
    }
}
