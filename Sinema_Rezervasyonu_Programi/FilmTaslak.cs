using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Rezervasyonu_Programi
{
   public class FilmTaslak
    {
        public int ID;
        //public Bitmap afis;
        public string ad;
        public string imdb;
        public DateTime vizyonTarihi;
        public string yonetmen;
        public string oyuncular;
        public string sure;
        public string tur;
        public string konu;
        public Image afis;

        public FilmTaslak(int ID, /*Bitmap afis,*/ string ad, string imdb,DateTime vizyonTarihi, string yonetmen, string oyuncular, string sure, string tur, string konu, Image afis)
        {
            this.ID = ID;
            //this.afis = afis;
            this.ad = ad;
            this.imdb = imdb;
            this.vizyonTarihi = vizyonTarihi;
            this.yonetmen = yonetmen;
            this.oyuncular = oyuncular;
            this.sure = sure;
            this.tur = tur;
            this.konu = konu;
            this.afis = afis;
        }

        public List<FilmObjesi> FilmObjesiListesi()
        {
            List<FilmObjesi> filmObjeleriListesi = new List<FilmObjesi>();

            foreach(var item in VeriTabaniErisim.Instance().seciliAvmdekiFilmler)
            {
                if(item.taslakID == ID)
                {
                    filmObjeleriListesi.Add(item);
                }
            }
            return filmObjeleriListesi;

        } 

    }
}
