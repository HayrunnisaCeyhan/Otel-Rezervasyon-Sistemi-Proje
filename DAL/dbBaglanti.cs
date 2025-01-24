using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Otel_Rezervasyon_Sistemi_Proje.DAL
{
    public class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253; Database=25_132330059; Uid=25_132330059; Pwd=!nif.ogr59CE");
            baglanti.Open();
            return baglanti;
        }
    }
}

