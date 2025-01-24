using MySql.Data.MySqlClient;
using Otel_Rezervasyon_Sistemi_Proje.DAL;
using Otel_Rezervasyon_Sistemi_Proje.DOMAİN;
using Otel_Rezervasyon_Sistemi_Proje.SERVİCE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi_Proje
{
    public partial class FormRezervasyonYapma : Form
    {
        

        public List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();
        public FormRezervasyonYapma()
        {
            InitializeComponent();

            for (int i = 101; i <= 150; i++)
            {
                rezervasyonlar.Add(new Rezervasyon
                {
                    OdaNumarasi = i,
                    Tip = (i % 2 == 0) ? "Çift Kişilik" : "Tek Kişilik",
                    Durum = false 
                });
            }
        }

        public void odalariGuncelle(List<Rezervasyon> odalar)
        {
              RezervasyonDAO dao = new RezervasyonDAO();
              ArrayList rezervasyonluOdalar = dao.rezervasyonlariOku();

            
            foreach (Rezervasyon rezervasyon in rezervasyonluOdalar)
            {
                var oda = rezervasyonlar.FirstOrDefault(o => o.OdaNumarasi == rezervasyon.OdaNumarasi);
                if (oda != null)
                {
                    oda.Durum = true; 
                }
            }

            odalariOku("Çift Kişilik");
            odalariOku("Tek Kişilik");
        }
        private void txtAd_TextChanged(object sender, EventArgs e)
        {
            txtAd.Text = txtAd.Text.Trim();
        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {
            txtSoyad.Text = txtSoyad.Text.Trim();   
        }

        private void comboCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboCinsiyet.Select();
        }

        private void dateTimeDogum_ValueChanged(object sender, EventArgs e)
        {
            dateTimeDogum.Select();

            
        }

        private void maskedTextBoxMusteriID_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBoxMusteriID.Text = maskedTextBoxMusteriID.Text.Trim();

        }

        private void dateTimePickergiris_ValueChanged(object sender, EventArgs e)
        { 
            dateTimePickergiris.Select();
            dateTimePickergiris.CustomFormat = "dd.MM.yyyy";

        }

        private void dateTimePickercikis_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickercikis.Select();
            dateTimePickercikis.CustomFormat = "dd.MM.yyyy";
        }

        public void FormRezervasyonYapma_Load(object sender, EventArgs e)
        {
            odalariOku("Çift Kişilik");
            odalariOku("Tek kişilik");
            rezervasyonlariOku();
            odalariGuncelle(rezervasyonlar);
        }
     

        void rezervasyonlariOku()
        {
            List<Rezervasyon> rezervasyonlar = new List<Rezervasyon>();

            foreach (Rezervasyon rezervasyon in rezervasyonlar)
            {
                var oda = rezervasyonlar.FirstOrDefault(o => o.OdaNumarasi == rezervasyon.OdaNumarasi);

                if (oda != null)
                {
                    if ((rezervasyon.GirisTarihi <= dateTimePickergiris.Value && rezervasyon.CikisTarihi >= dateTimePickergiris.Value) ||
                        (rezervasyon.GirisTarihi <= dateTimePickercikis.Value && rezervasyon.CikisTarihi >= dateTimePickercikis.Value) ||
                        (rezervasyon.GirisTarihi >= dateTimePickergiris.Value && rezervasyon.CikisTarihi <= dateTimePickercikis.Value))
                    {
                        oda.Durum = true; 
                    }
                    else
                    {
                        oda.Durum = false; 
                    }
                }
            }
        }

            
        
        void odalariOku(string Tip)
        {
            tableLayoutPanelOdaNumarası.Controls.Clear();

            rezervasyonlariOku();
           
            var filtrelenmisOdalar = rezervasyonlar.Where(gTip => gTip.Tip == Tip).ToList();

            int index = 0;

            foreach (var oda in filtrelenmisOdalar)
            {
                

                Button odaButton = new Button();
                odaButton.Text = oda.OdaNumarasi.ToString(); 
                odaButton.Width = 60;
                odaButton.Height = 60;

                
                odaButton.BackColor = oda.Durum ? Color.Red : Color.Green; 

                
                odaButton.Click += (s,e) =>
                {
                    if (!oda.Durum)
                    {
                        
                        var confirmResult = MessageBox.Show($"Seçilen Oda: {oda.OdaNumarasi} Bu odayı rezerve etmek istiyor musunuz?", "Oda Seçimi", MessageBoxButtons.YesNo);
                        if (confirmResult == DialogResult.Yes)
                        {
                            

                            Rezervasyon r = new Rezervasyon
                            {  
                                MusteriKimlik = int.Parse(maskedTextBoxMusteriID.Text), 
                                OdaNumarasi = oda.OdaNumarasi, 
                                GirisTarihi = dateTimePickergiris.Value, 
                                CikisTarihi = dateTimePickercikis.Value, 
                                MusteriAdSoyad = $"{txtAd.Text} {txtSoyad.Text}", 
                                Tip = comboBoxOdaSecimi.Text,
                                Durum = true 
                            };

                            
                            RezervasyonDAO.rezervasyonKaydet(r);
                            oda.Durum = true;
                            odaButton.BackColor = Color.Red;
                            RezervasyonDAO.odalariGuncelle(oda.OdaNumarasi, true);                            
                            MessageBox.Show("Oda başarıyla rezerve edildi.", "Bilgi", MessageBoxButtons.OK);
                            return;

                        }
                    }
                    if(oda.Durum == true)
                    {
                        odaButton.BackColor = Color.Red;
                        MessageBox.Show("Bu oda zaten dolu!", "Bilgi", MessageBoxButtons.OK);
                        return;
                    }


                    if(dateTimeDogum.Value > DateTime.Now.AddYears(-18))
                    {
                       MessageBox.Show("18 yaşından küçüklere rezervasyon yapılamaz.");
                       return;
                    }
                    else if(dateTimeDogum.Value > DateTime.Now)
                    {
                      MessageBox.Show("Geçerli bir tarih seçiniz.");
                      return;
                    }
                    if(dateTimePickergiris.Value < DateTime.Now)
                    {
                        MessageBox.Show("Geçerli bir tarih seçiniz.");
                        return;
                    }
                    if(dateTimePickergiris.Value > dateTimePickercikis.Value)
                    {
                        MessageBox.Show("Çıkış tarihi giriş tarihinden önce olamaz.");
                        return;
                    }

                    if (txtAd.Text == "" || txtSoyad.Text == "" || maskedTextBoxMusteriID.Text == "" || comboCinsiyet.Text == "" || comboBoxOdaSecimi.Text == "")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                        return;
                    }



                };

                
                tableLayoutPanelOdaNumarası.Controls.Add(odaButton, index % tableLayoutPanelOdaNumarası.ColumnCount, index / tableLayoutPanelOdaNumarası.ColumnCount);
                index++;

            }
        
        }


        private void comboBoxOdaSecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenOdaTipi = comboBoxOdaSecimi.Text;
            odalariOku(secilenOdaTipi);
        }

        private void btnanasayfa_Click(object sender, EventArgs e)
        {
            Form FormGiris = new FormGiris();
            FormGiris.Show();
            this.Hide();
        }

        
    
    }
}
