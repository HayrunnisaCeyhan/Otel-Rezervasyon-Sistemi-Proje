using Otel_Rezervasyon_Sistemi_Proje.DAL;
using Otel_Rezervasyon_Sistemi_Proje.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi_Proje.SERVİCE
{
    public class RezervasyonSERVİCE
    {
        internal System.Collections.ArrayList rezervasyonlariOku()
        {
            return (new RezervasyonDAO()).rezervasyonlariOku();
        }

        public static void rezervasyonKaydet(string musteriadsoyad, int musterikimlik , int rezervasyonid,int odanumarasi,string tip, bool durum,DateTime giristarihi, DateTime cikistarihi)
        {
            Rezervasyon rezervasyon = new Rezervasyon(musteriadsoyad, musterikimlik, odanumarasi, giristarihi, cikistarihi, rezervasyonid, tip, durum);
            RezervasyonDAO.rezervasyonKaydet(rezervasyon); 
        }

        internal void rezervasyonSil(int r)
        {
            (new RezervasyonDAO()).rezervasyonSil(r);
        }
    }
}
