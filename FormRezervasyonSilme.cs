using MySql.Data.MySqlClient;
using Otel_Rezervasyon_Sistemi_Proje.DAL;
using Otel_Rezervasyon_Sistemi_Proje.DOMAİN;
using Otel_Rezervasyon_Sistemi_Proje.SERVİCE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi_Proje
{
    public partial class FormRezervasyonSilme : Form
    {
        public FormRezervasyonSilme()
        {
            InitializeComponent(); 
        }

        void rezervasyonlariOku()
        {
           
            listBoxRezervasyonlar.Items.Clear();
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>(); 
            foreach (Rezervasyon r in (new RezervasyonSERVİCE()).rezervasyonlariOku())
            {
                listBoxRezervasyonlar.Items.Add(r);
            }
            
        }
       
        
   
        private void FormRezervasyonSilme_Load(object sender, EventArgs e)
        {
            foreach (Rezervasyon r in (new RezervasyonSERVİCE()).rezervasyonlariOku())
            {
                listBoxRezervasyonlar.Items.Add(r);
            }

        }

      
        private void btnRezervasyonuSil_Click(object sender, EventArgs e)
        {
            rezervasyonSil();
        }

        void rezervasyonSil()
        {

            
            if (listBoxRezervasyonlar.SelectedItem != null)
            {
                
                Rezervasyon secilenRezervasyon = (Rezervasyon)listBoxRezervasyonlar.SelectedItem;

                
                int rezervasyonId = secilenRezervasyon.RezervasyonID;

                
                string query = "DELETE FROM rezervasyon WHERE rezervasyonid = @rezervasyonid";

                using (MySqlConnection connection = (new dbBaglanti()).baglantiGetir())
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    
                    cmd.Parameters.AddWithValue("@rezervasyonid", rezervasyonId);
                    cmd.ExecuteNonQuery();
                }

                
                listBoxRezervasyonlar.Items.Remove(secilenRezervasyon);
                MessageBox.Show("Rezervasyon başarıyla silindi.");

                
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz rezervasyonu seçin.");
            }
        }
        

        private void btnrezervasyongetir_Click(object sender, EventArgs e)
        {
            rezervasyonlariOku();
            
        }

        private void listBoxRezervasyonlar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listBoxRezervasyonlar.SelectedItem != null)
            {
                
                Rezervasyon selectedRezervasyon = (Rezervasyon)listBoxRezervasyonlar.SelectedItem;

                
                string detaylar = $"Müşteri Ad Soyad: {selectedRezervasyon.MusteriAdSoyad}\n" +
                                   $"Giriş Tarihi: {selectedRezervasyon.GirisTarihi:yyyy-MM-dd}\n" +
                                   $"Çıkış Tarihi: {selectedRezervasyon.CikisTarihi:yyyy-MM-dd}\n" +
                                   $"Oda Numarası: {selectedRezervasyon.OdaNumarasi}\n" +
                                   $"Durum: {(selectedRezervasyon.Durum ? "Dolu" : "Boş")}\n" +
                                   $"Tip: {selectedRezervasyon.Tip}";

                MessageBox.Show(detaylar, "Rezervasyon Detayları", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormRezervasyonSilme_Load_1(object sender, EventArgs e)
        {

        }
    }
}
