using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Rezervasyonu_Programi
{
    public class FilmObjesi
    {
        public int ID;
        public int avmID;
        public int taslakID;
        public Salon salon;
        public DateTime tarih;

        public FilmObjesi(int ID, int avmID, int taslakID, Salon salon, DateTime tarih)
        {
            this.ID = ID;
            this.avmID = avmID;
            this.taslakID = taslakID;
            this.salon = salon;
            this.tarih = tarih;
        }
    }
}
