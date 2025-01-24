using MySql.Data.MySqlClient;
using Otel_Rezervasyon_Sistemi_Proje.DOMAİN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon_Sistemi_Proje.DAL
{
    internal class RezervasyonDAO
    {
        internal System.Collections.ArrayList rezervasyonlariOku()
        {
            ArrayList rezervasyonlar = new ArrayList();
            MySqlCommand komutum = new MySqlCommand("select * from rezervasyon", (new dbBaglanti()).baglantiGetir());
            MySqlDataReader okunan = (new MySqlCommand("select * from rezervasyon", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                Rezervasyon rezervasyon = new Rezervasyon
                {
                    MusteriAdSoyad = okunan.GetString("MusteriAdSoyad"),
                    OdaNumarasi = okunan.GetInt32("OdaNumarasi"),
                    MusteriKimlik = okunan.GetInt32("MusteriKimlik"),
                    GirisTarihi = okunan.GetDateTime("GirisTarihi"),
                    CikisTarihi = okunan.GetDateTime("CikisTarihi"),
                    Durum = true, 
                    Tip = okunan.GetString("Tip")
                };
                rezervasyonlar.Add(rezervasyon);
            }
            return rezervasyonlar;
        }


        public static void rezervasyonKaydet(Rezervasyon rezervasyon)
        {


            int newRezervasyonID = GetNextRezervasyonID();
            string query = "INSERT INTO rezervasyon (rezervasyonid, musteriKimlik, musteriadsoyad, odanumarasi, giristarihi, cikistarihi, tip, durum) " +
                           "VALUES (@rezervasyonid, @musteriKimlik, @musteriAdSoyad, @odaNumarasi, @girisTarihi, @cikisTarihi, @tip, @durum)";

            using (MySqlConnection connection = (new dbBaglanti()).baglantiGetir())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@rezervasyonid", newRezervasyonID);
                cmd.Parameters.AddWithValue("@musteriKimlik", rezervasyon.MusteriKimlik);
                cmd.Parameters.AddWithValue("@musteriAdSoyad", rezervasyon.MusteriAdSoyad);
                cmd.Parameters.AddWithValue("@odaNumarasi", rezervasyon.OdaNumarasi);
                cmd.Parameters.AddWithValue("@girisTarihi", rezervasyon.GirisTarihi.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@cikisTarihi", rezervasyon.CikisTarihi.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@tip", rezervasyon.Tip);
                cmd.Parameters.AddWithValue("@durum", rezervasyon.Durum);
               
                cmd.ExecuteNonQuery();
            }
        }

        

        internal void rezervasyonSil(int r)
        {
            string query = "DELETE FROM rezervasyon WHERE rezervasyonid = @rezervasyonid";

            using (MySqlConnection connection = (new dbBaglanti()).baglantiGetir())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                
                cmd.Parameters.AddWithValue("@rezervasyonid", r);

               
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

       
        public static void odalariGuncelle(int odaNumarasi, bool durum)
        {
            using (MySqlConnection baglanti = (new dbBaglanti()).baglantiGetir())
            {
                string sorgu = "UPDATE rezervasyon SET Durum = @Durum WHERE OdaNumarasi = @OdaNumarasi";
                using (MySqlCommand komut = new MySqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@Durum", durum);
                    komut.Parameters.AddWithValue("@OdaNumarasi", odaNumarasi);
                    komut.ExecuteNonQuery();
                }
            }
        }

        public static int GetNextRezervasyonID()
        {
            using (MySqlConnection connection = (new dbBaglanti()).baglantiGetir())
            {
               
                string query = "SELECT IFNULL(MAX(rezervasyonid), 0) + 1 FROM rezervasyon";
                MySqlCommand command = new MySqlCommand(query, connection);

                object result = command.ExecuteScalar();
                return Convert.ToInt32(result);
            }
        }

    }
}

