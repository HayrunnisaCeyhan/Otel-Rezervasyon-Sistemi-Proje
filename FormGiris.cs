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
    public partial class FormGiris : Form
    {
        private bool girisDurumu = false; 
        public FormGiris()
        {
            InitializeComponent();
            btnRezervasyonYap.Enabled = false; 
            btnRezervasyonSilme.Enabled = false; 
            btnRezervasyonGoruntule.Enabled = false; 
        }

        private void textBoxYoneticiKimlik_TextChanged(object sender, EventArgs e)
        {
            textBoxYoneticiKimlik.Text = textBoxYoneticiKimlik.Text.Trim(); 
        }

        private void maskedTextBoxYoneticiSifre_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBoxYoneticiSifre.Text = maskedTextBoxYoneticiSifre.Text.Trim();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (textBoxYoneticiKimlik.Text == "admin" && maskedTextBoxYoneticiSifre.Text == "1234")
            {
               MessageBox.Show("Giriş Başarılı!","Bilgi", MessageBoxButtons.OK);
                girisDurumu = true;
                btnRezervasyonYap.Enabled = true; 
                btnRezervasyonSilme.Enabled = true; 
                btnRezervasyonGoruntule.Enabled = true; 
            }
            
            else
            {
                MessageBox.Show("Eksik ya da hatalı bilgi girdiniz!","Bilgi",MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            if(girisDurumu)
            {
                Form frm4 = new FormRezervasyonYapma();
                frm4.Show();
                this.Hide();
            }
        
            else
            {
                MessageBox.Show("Önce giriş yapmanız gerekmektedir!", "Bilgi",MessageBoxButtons.OK);
                return;
            }
        
        
        
        
        }

        private void btnRezervasyonSilme_Click(object sender, EventArgs e)
        {
            if(girisDurumu)
            {
                Form frm5 = new FormRezervasyonSilme();
                frm5.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Önce giriş yapmanız gerekmektedir!", "Bilgi", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnRezervasyonGoruntule_Click(object sender, EventArgs e)
        {
            if (girisDurumu)
            {
                Form frm6 = new FormRezervasyonGoruntule();
                frm6.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Önce giriş yapmanız gerekmektedir!", "Bilgi", MessageBoxButtons.OK);
                return;
            }
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
