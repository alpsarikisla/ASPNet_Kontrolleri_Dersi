using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPKontrolleri.Model
{
    public class VeriKaynagi
    {
        public VeriKaynagi() { }

        public List<Ogrenci> OgrenciGetir()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci() { No = 510, IsimSoyisim = "Poyraz Salih" });
            ogrenciler.Add(new Ogrenci() { No = 517, IsimSoyisim = "Armağan Tambova" });
            ogrenciler.Add(new Ogrenci() { No = 515, IsimSoyisim = "Cemrenaz Türkanoğlu" });
            ogrenciler.Add(new Ogrenci() { No = 522, IsimSoyisim = "Nisa Nur Uçar" });
            ogrenciler.Add(new Ogrenci() { No = 514, IsimSoyisim = "Burhan Kaan Aydıngör" });
            ogrenciler.Add(new Ogrenci() { No = 568, IsimSoyisim = "Arda Çırak" });
            ogrenciler.Add(new Ogrenci() { No = 516, IsimSoyisim = "Alişan Çakır" });

            return ogrenciler;
        }
    }
}