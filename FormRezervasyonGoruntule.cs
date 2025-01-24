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
    public partial class FormRezervasyonGoruntule : Form
    {
        public FormRezervasyonGoruntule()
        {
            InitializeComponent();
        }

        void rezervasyonlariOku()
        {
            
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
            listBoxRezervasyonlar.Items.Clear();
            foreach (Rezervasyon r in (new RezervasyonSERVİCE()).rezervasyonlariOku())
            {
                listBoxRezervasyonlar.Items.Add(r);
            }
        }
        
        private void FormRezervasyonGoruntule_Load(object sender, EventArgs e)
        {
           
            foreach (Rezervasyon r in (new RezervasyonSERVİCE()).rezervasyonlariOku())
            {
                listBoxRezervasyonlar.Items.Add(r);
            }
        }

        

        
        public void btnanasayfa_Click(object sender, EventArgs e)
        {
            Form FormGiris = new FormGiris();
            FormGiris.Show();
            this.Hide();
        }

        private void btnDetayGoster_Click(object sender, EventArgs e)
        {
            rezervasyonlariOku();
        }

        

        private void listBoxRezervasyonlar_SelectedIndexChanged(object sender, EventArgs e)
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

        private void FormRezervasyonGoruntule_Load_1(object sender, EventArgs e)
        {

        }
    }
}
