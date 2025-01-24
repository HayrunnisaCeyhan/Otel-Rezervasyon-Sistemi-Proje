using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi_Proje.DOMAİN
{
    public class Rezervasyon
    {
        int rezervasyonid, musterikimlik, odanumarasi;
        DateTime giristarihi, cikistarihi;
        string musteriadsoyad,tip;
        bool durum;

        public Rezervasyon()
        {
        }

        

        public Rezervasyon(string MusteriAdSoyad, int MusteriKimlik, int OdaNumarasi, DateTime GirisTarihi, DateTime CikisTarihi, int RezervasyonID, string Tip, bool Durum)
        {
            this.MusteriAdSoyad = musteriadsoyad;
            this.MusteriKimlik = musterikimlik;
            this.OdaNumarasi = odanumarasi;
            this.GirisTarihi = giristarihi;
            this.CikisTarihi = cikistarihi;
            this.RezervasyonID = rezervasyonid;
            this.Tip = tip;
            this.Durum = durum;
        }

        public int RezervasyonID
        { get { return rezervasyonid; } set { rezervasyonid = value; } }

        public int MusteriKimlik
        { get { return musterikimlik; } set { musterikimlik = value; } }

        public DateTime GirisTarihi
        { get { return giristarihi; } set { giristarihi = value; } }

        public DateTime CikisTarihi
        { get { return cikistarihi; } set { cikistarihi = value; } }

        public string MusteriAdSoyad
        { get { return musteriadsoyad; } set { musteriadsoyad = value; } }

        public int OdaNumarasi
        { get { return odanumarasi; } set { odanumarasi = value; } }

        public bool Durum
        { get { return durum; } set { durum = value; } }

        public string Tip
        { get { return tip; } set { tip = value; } }

        public Rezervasyon Oda { get; set; } 

       
        public override string ToString()
        {
            return $"{MusteriAdSoyad} - {GirisTarihi:yyyy-MM-dd} - {CikisTarihi:yyyy-MM-dd}- {OdaNumarasi}";

        }


    }
}

