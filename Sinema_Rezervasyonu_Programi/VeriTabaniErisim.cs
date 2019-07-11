using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Newtonsoft.Json;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Sinema_Rezervasyonu_Programi
{
    class VeriTabaniErisim
    {
        private static VeriTabaniErisim instance = null;

        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataReader reader;

        private Uye _uyeBilgisi;
        public Uye uyeBilgisi
        {
            get
            {
                return _uyeBilgisi;
            }
        }

        private List<AvmBilgisi> _avmListesi = new List<AvmBilgisi>();
        public List<AvmBilgisi> avmListesi
        {
            get
            {
                return _avmListesi;
            }
        }
        private AvmBilgisi _seciliAvm;
        public AvmBilgisi seciliAvm { get { return _seciliAvm; } }

        private List<FilmObjesi> _seciliAvmdekiFilmler = new List<FilmObjesi>();
        public List<FilmObjesi> seciliAvmdekiFilmler { get { return _seciliAvmdekiFilmler; } }
        private Dictionary<int, FilmTaslak> _seciliAvmdekiFilmlerinTaslaklari = new Dictionary<int, FilmTaslak>();
        public Dictionary<int, FilmTaslak> seciliAvmdekiFilmlerinTaslaklari { get { return _seciliAvmdekiFilmlerinTaslaklari; } }

        #region Yönetici İşlemleri
        private List<AvmBilgisi> _tumAvmler = new List<AvmBilgisi>();
        public List<AvmBilgisi> tumAvmler { get { return _tumAvmler; } }
        private List<FilmObjesi> _tumFilmler = new List<FilmObjesi>();
        public List<FilmObjesi> tumFilmler { get { return _tumFilmler; } }
        private Dictionary<int, FilmTaslak> _tumTaslaklar = new Dictionary<int, FilmTaslak>();
        public Dictionary<int, FilmTaslak> tumTaslaklar { get { return _tumTaslaklar; } }
        #endregion

        public enum KaydolmaSonucu
        {
            basarili,
            kullaniciAdiKullaniliyor,
            bilinmeyenHata
        }
        public enum GirisYapmaSonucu
        {
            basarili,
            kullaniciAdiVeyaSifreHatasi,
            bilinmeyenHata,
            baglantiHatasi,
            yoneticiGirisi
        }
        public enum BiletAlmaSonucu
        {
            basarili,
            biletAlinmis,
            baglantiHatasi
        }
        public enum FilmEklemeSonucu
        {
            basarili,
            bilinmeyenHata
        }

        public static VeriTabaniErisim Instance()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                Console.WriteLine("Veritabanı Erişimi Objesi YoK!");
                return null;
            }
        }

        public VeriTabaniErisim()
        {
            if (instance == null)
            {
                instance = this;

                baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=veritabani.accdb");

            }

        }

        public KaydolmaSonucu KayitOl(string kullaniciAdi, string ad, string soyad, string sifre) 
        {
            if (KullaniciAdiVarMi(kullaniciAdi))
            {
                Console.WriteLine("Bu kullanıcı adı kullanılmaktadır.");
                return KaydolmaSonucu.kullaniciAdiKullaniliyor;
            }
            else
            {
                baglanti.Open();
                string query = "insert into uyeler (ad,soyad,kullaniciAdi,sifre) values('" + ad + "','" + soyad + "','" + kullaniciAdi + "','" + sifre + "')";
                OleDbCommand komut = new OleDbCommand(query, baglanti);

                int sonuc = komut.ExecuteNonQuery();
                baglanti.Close();
                if (sonuc == 0)
                {
                    Console.WriteLine("Kayıt olmada bilinmeyen hata.");
                    return KaydolmaSonucu.bilinmeyenHata;
                }
                else if (sonuc == 1)
                {
                    Console.WriteLine("Kayıt Olundu.");
                    _uyeBilgisi = new Uye(ad, soyad, kullaniciAdi, sifre);
                    return KaydolmaSonucu.basarili;
                }
                else
                {
                    Console.WriteLine("İşlem Hatası.");
                    return KaydolmaSonucu.bilinmeyenHata;
                }
            }

        }

        public GirisYapmaSonucu GirisYap(string kullaniciAdi, string sifre)
        {
            GirisYapmaSonucu sonuc;

            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "select ad, soyad, yoneticiMi from Uyeler where kullaniciAdi='" + kullaniciAdi + "' AND sifre='" + sifre + "';";
                komut = new OleDbCommand(query, baglanti);
                reader = komut.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    if ((bool)reader["yoneticiMi"])
                    {
                        sonuc = GirisYapmaSonucu.yoneticiGirisi;
                    }
                    else
                    {
                        _uyeBilgisi = new Uye((string)reader["ad"], (string)reader["soyad"], kullaniciAdi, sifre);
                        sonuc = GirisYapmaSonucu.basarili;
                    }

                }
                else
                {
                    sonuc = GirisYapmaSonucu.kullaniciAdiVeyaSifreHatasi;
                }
            }
            else
            {
                sonuc = GirisYapmaSonucu.baglantiHatasi;
            }
            baglanti.Close();
            return sonuc;
        }

        private bool KullaniciAdiVarMi(string kullaniciAdi)
        {
            baglanti.Open();
            bool sonuc;

            
            string query = "select * from uyeler where kullaniciAdi='" + kullaniciAdi + "';";
            komut = new OleDbCommand(query, baglanti);
            reader = komut.ExecuteReader();
            if (reader.HasRows)
                sonuc = true;
            else
                sonuc = false;
            baglanti.Close();
            return sonuc;

        }

        public bool AvmGetirme()//Avm secme paneli - Avm listeleme
        {
            bool sonuc;
            _avmListesi.Clear();
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "select * from Avmler";
                komut = new OleDbCommand(query, baglanti);
                reader = komut.ExecuteReader();
                _avmListesi.Clear();
                while (reader.Read())
                {
                    _avmListesi.Add(new AvmBilgisi((int)reader["ID"], (string)reader["ad"]));
                }
                sonuc = true;
            }
            else
            {
                sonuc = false;
            }
            baglanti.Close();
            return sonuc;
        }

        public void AvmSec(int index)
        {
            _seciliAvm = avmListesi[index];
        }

        public void FilmleriYükle()//Seçilen film Paneli - Film bilgisi yükleme
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string query = "select * from FilmObjeleri where avmID=" + seciliAvm.ID + "";
                    komut = new OleDbCommand(query, baglanti);
                    reader = komut.ExecuteReader();
                    _seciliAvmdekiFilmler.Clear();
                    while (reader.Read())
                    {
                        Salon tempSalon = JsonConvert.DeserializeObject<Salon>((string)reader["salonJSON"]);
                        int ID = (int)reader["ID"];
                        int avmID = (int)reader["avmID"];
                        int filmID = (int)reader["filmID"];
                        DateTime.Parse((string)reader["saat"]);
                        _seciliAvmdekiFilmler.Add(new FilmObjesi(ID,
                            avmID,
                            filmID,
                            tempSalon,
                            DateTime.Parse((string)reader["saat"])
                            //DateTime.Now
                            ));
                    }

                    if (_seciliAvmdekiFilmler.Count > 0)
                    {
                        query = filmTaslakQueryOlustur();
                        komut = new OleDbCommand(query, baglanti);
                        reader = komut.ExecuteReader();
                        _seciliAvmdekiFilmlerinTaslaklari.Clear();
                        while (reader.Read())
                        {
                            _seciliAvmdekiFilmlerinTaslaklari.Add((int)reader["ID"], new FilmTaslak(
                                (int)reader["ID"],
                                (string)reader["ad"],
                                (string)reader["imdb"],
                                DateTime.Parse((string)reader["vizyonTarihi"]),
                                (string)reader["yonetmen"],
                                (string)reader["oyuncular"],
                                (string)reader["sure"],
                                (string)reader["tur"],
                                (string)reader["konu"],
                                ByteArrayToImage((byte[])reader["afis"])
                                ));
                        }
                    }
                    baglanti.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        public BiletAlmaSonucu KoltukAl(FilmObjesi filmObjesi, List<int> koltuklarIndex)//Bilet alma Paneli - Koltuk seçme
        {
            try
            {
                baglanti.Open();
                if (baglanti.State == ConnectionState.Open)
                {
                    string query = "select salonJSON from FilmObjeleri where ID=" + filmObjesi.ID + ";";
                    komut = new OleDbCommand(query, baglanti);
                    reader = komut.ExecuteReader();
                    reader.Read();
                    Salon tempSalon = JsonConvert.DeserializeObject<Salon>((string)reader["salonJSON"]);

                    foreach (var item in koltuklarIndex)
                    {
                        if (tempSalon.koltuklar[item] == true)
                        {
                            baglanti.Close();
                            filmObjesi.salon = tempSalon;
                            return BiletAlmaSonucu.biletAlinmis;
                        }
                        else
                            tempSalon.koltuklar[item] = true;
                    }

                    string JSONData = JsonConvert.SerializeObject(tempSalon);

                    query = "update FilmObjeleri SET salonJSON = '" + JSONData + "' WHERE ID = " + filmObjesi.ID;
                    komut = new OleDbCommand(query, baglanti);
                    komut.ExecuteNonQuery();


                    baglanti.Close();

                    filmObjesi.salon = tempSalon;

                    return BiletAlmaSonucu.basarili;
                }
                else
                    return BiletAlmaSonucu.baglantiHatasi;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return BiletAlmaSonucu.baglantiHatasi;
        }

        private string filmTaslakQueryOlustur()
        {
            List<int> filmIDs = new List<int>();
            foreach (FilmObjesi film in seciliAvmdekiFilmler)
            {
                if (!filmIDs.Contains(film.taslakID))
                {
                    filmIDs.Add(film.taslakID);
                }
            }
            string query = "select * from FilmTaslaklar where ";
            for (int i = 0; i < filmIDs.Count; i++)
            {
                query += "ID=" + filmIDs[i];
                if (i < filmIDs.Count - 1)
                {
                    query += " OR ";
                }
            }
            return query;

        }

        public bool TumTaslaklariYukle()
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "select * from FilmTaslaklar";
                komut = new OleDbCommand(query, baglanti);
                reader = komut.ExecuteReader();
                _tumTaslaklar.Clear();
                while (reader.Read())
                {
                    _tumTaslaklar.Add((int)reader["ID"],
                        new FilmTaslak(
                        (int)reader["ID"],
                        (string)reader["ad"],
                        (string)reader["imdb"],
                        DateTime.Parse((string)reader["vizyonTarihi"]),
                        (string)reader["yonetmen"],
                        (string)reader["oyuncular"],
                        (string)reader["sure"],
                        (string)reader["tur"],
                        (string)reader["konu"],
                        ByteArrayToImage((byte[])reader["afis"])

                        ));
                }
                baglanti.Close();
                return true;
            }
            else
                return false;
        }
        public bool TumFilmObjeleriniYukle()
        {
            baglanti.Open();
            if (baglanti.State == ConnectionState.Open)
            {
                string query = "select * from FilmObjeleri";
                komut = new OleDbCommand(query, baglanti);
                reader = komut.ExecuteReader();
                _tumFilmler.Clear();
                while (reader.Read())
                {
                    Salon tempSalon = JsonConvert.DeserializeObject<Salon>((string)reader["salonJSON"]);
                    int ID = (int)reader["ID"];
                    int avmID = (int)reader["avmID"];
                    int filmID = (int)reader["filmID"];
                    DateTime.Parse((string)reader["saat"]);
                    _tumFilmler.Add(new FilmObjesi(ID,
                        avmID,
                        filmID,
                        tempSalon,
                        DateTime.Parse((string)reader["saat"])
                        ));
                }
                baglanti.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AvmEkle(string ad)
        {
            return VeriTabaniKomutVer("insert into Avmler (ad) values('" + ad + "')");
        }
        public bool FilmTaslakEkle(string ad, string imdb, DateTime vizyonTarihi, string yonetmen, string oyuncular, string sure, string tur, string konu, Image afis)
        {
            //string query = "insert into FilmTaslaklar (ad,imdb,vizyonTarihi,yonetmen,oyuncular,sure,tur,konu) values('" + ad + "','" + imdb + "','" + vizyonTarihi.ToShortDateString() + "','" + yonetmen + "','" + oyuncular + "','" + sure + "','" + tur + "','" + konu + "')";
            //return VeriTabaniKomutVer(query);
            string query = "insert into FilmTaslaklar (ad,imdb,vizyonTarihi,yonetmen,oyuncular,sure,tur,konu,afis) values(?,?,?,?,?,?,?,?,?)";
            baglanti.Open();
            komut = new OleDbCommand(query, baglanti);
            komut.Parameters.AddWithValue("", ad);
            komut.Parameters.AddWithValue("", imdb);
            komut.Parameters.AddWithValue("", vizyonTarihi.ToShortDateString());
            komut.Parameters.AddWithValue("", yonetmen);
            komut.Parameters.AddWithValue("", oyuncular);
            komut.Parameters.AddWithValue("", sure);
            komut.Parameters.AddWithValue("", tur);
            komut.Parameters.AddWithValue("", konu);
            komut.Parameters.AddWithValue("", ImageToBase64String(afis));

            komut.ExecuteNonQuery();
            baglanti.Close();
            return true;
        }
        public bool FilmObjesiEkle(int avmID, int filmID, DateTime saat, int salonNo)
        {
            string salonJSON = JsonConvert.SerializeObject(SalonObjesiOluştur(salonNo));
            string query = "insert into FilmObjeleri (avmID,filmID,saat,salonJSON) values(" + avmID + "," + filmID + ",'" + saat.ToString() + "','" + salonJSON + "')";
            return VeriTabaniKomutVer(query);
        }
        public bool FilmTaslakSil(int taslakID)
        {
            string query = "delete from FilmObjeleri where filmID=" + taslakID;
            bool sonuc = VeriTabaniKomutVer(query);
            if (sonuc == false)
                return sonuc;
            else
            {
                query = "delete from FilmTaslaklar where ID=" + taslakID;
                sonuc = VeriTabaniKomutVer(query);
                return sonuc;
            }
        }
        public bool FilmObjesiSil(int filmObjesiID)
        {
            string query = "delete from FilmObjeleri where ID=" + filmObjesiID;
            return VeriTabaniKomutVer(query);
        }
        private bool VeriTabaniKomutVer(string query)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    komut = new OleDbCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }
        private bool VeriTabaniKomutVer(OleDbCommand command)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    command.ExecuteNonQuery();
                    baglanti.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }

        private OleDbDataReader VeriTabaniVeriCek(string query)
        {
            OleDbDataReader reader = null;
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                if (baglanti.State == ConnectionState.Open)
                {
                    komut = new OleDbCommand(query, baglanti);
                    reader = komut.ExecuteReader();
                    baglanti.Close();
                }
                return reader;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return reader;
            }
            finally
            {

                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }

            }
        }
        private Salon SalonObjesiOluştur(int salonNo)
        {
            List<bool> tempList = new List<bool>();
            for (int i = 0; i < 80; i++)
            {
                tempList.Add(false);
            }
            return new Salon(salonNo, tempList);


        }

        private byte[] ImageToBase64String(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, image.RawFormat);

                return stream.ToArray();
            }
        }
        private Image ByteArrayToImage(byte[] data)
        {
            return Image.FromStream(new MemoryStream(data));
        }
    }

}
