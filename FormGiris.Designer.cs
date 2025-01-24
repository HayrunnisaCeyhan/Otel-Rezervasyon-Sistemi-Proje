namespace Otel_Rezervasyon_Sistemi_Proje
{
    partial class FormGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxYoneticiSifre = new System.Windows.Forms.MaskedTextBox();
            this.textBoxYoneticiKimlik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRezervasyonGoruntule = new System.Windows.Forms.Button();
            this.btnRezervasyonYap = new System.Windows.Forms.Button();
            this.btnRezervasyonSilme = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGirisYap.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(328, 247);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(92, 41);
            this.btnGirisYap.TabIndex = 0;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = false;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Broadway", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOŞ GELDİNİZ";
            // 
            // maskedTextBoxYoneticiSifre
            // 
            this.maskedTextBoxYoneticiSifre.BackColor = System.Drawing.SystemColors.Window;
            this.maskedTextBoxYoneticiSifre.Location = new System.Drawing.Point(344, 179);
            this.maskedTextBoxYoneticiSifre.Name = "maskedTextBoxYoneticiSifre";
            this.maskedTextBoxYoneticiSifre.Size = new System.Drawing.Size(159, 22);
            this.maskedTextBoxYoneticiSifre.TabIndex = 2;
            this.maskedTextBoxYoneticiSifre.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxYoneticiSifre_MaskInputRejected);
            // 
            // textBoxYoneticiKimlik
            // 
            this.textBoxYoneticiKimlik.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxYoneticiKimlik.Location = new System.Drawing.Point(344, 141);
            this.textBoxYoneticiKimlik.Name = "textBoxYoneticiKimlik";
            this.textBoxYoneticiKimlik.Size = new System.Drawing.Size(159, 22);
            this.textBoxYoneticiKimlik.TabIndex = 3;
            this.textBoxYoneticiKimlik.TextChanged += new System.EventHandler(this.textBoxYoneticiKimlik_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(197, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Yönetici Kimlik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(197, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Yönetici  Şifre";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Linen;
            this.groupBox1.Controls.Add(this.btnRezervasyonGoruntule);
            this.groupBox1.Controls.Add(this.btnRezervasyonYap);
            this.groupBox1.Controls.Add(this.btnRezervasyonSilme);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(210, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 148);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapılmak İstenilen İşlem";
            // 
            // btnRezervasyonGoruntule
            // 
            this.btnRezervasyonGoruntule.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRezervasyonGoruntule.Location = new System.Drawing.Point(6, 104);
            this.btnRezervasyonGoruntule.Name = "btnRezervasyonGoruntule";
            this.btnRezervasyonGoruntule.Size = new System.Drawing.Size(241, 34);
            this.btnRezervasyonGoruntule.TabIndex = 9;
            this.btnRezervasyonGoruntule.Text = "Rezervasyon Görüntüle";
            this.btnRezervasyonGoruntule.UseVisualStyleBackColor = false;
            this.btnRezervasyonGoruntule.Click += new System.EventHandler(this.btnRezervasyonGoruntule_Click);
            // 
            // btnRezervasyonYap
            // 
            this.btnRezervasyonYap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRezervasyonYap.Location = new System.Drawing.Point(6, 24);
            this.btnRezervasyonYap.Name = "btnRezervasyonYap";
            this.btnRezervasyonYap.Size = new System.Drawing.Size(241, 34);
            this.btnRezervasyonYap.TabIndex = 7;
            this.btnRezervasyonYap.Text = "Rezervasyon Yapma";
            this.btnRezervasyonYap.UseVisualStyleBackColor = false;
            this.btnRezervasyonYap.Click += new System.EventHandler(this.btnRezervasyonYap_Click);
            // 
            // btnRezervasyonSilme
            // 
            this.btnRezervasyonSilme.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRezervasyonSilme.Location = new System.Drawing.Point(6, 64);
            this.btnRezervasyonSilme.Name = "btnRezervasyonSilme";
            this.btnRezervasyonSilme.Size = new System.Drawing.Size(241, 34);
            this.btnRezervasyonSilme.TabIndex = 8;
            this.btnRezervasyonSilme.Text = "Rezervasyon Silme";
            this.btnRezervasyonSilme.UseVisualStyleBackColor = false;
            this.btnRezervasyonSilme.Click += new System.EventHandler(this.btnRezervasyonSilme_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(509, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "//admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(509, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "//1234";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxYoneticiKimlik);
            this.Controls.Add(this.maskedTextBoxYoneticiSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxYoneticiSifre;
        private System.Windows.Forms.TextBox textBoxYoneticiKimlik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRezervasyonGoruntule;
        private System.Windows.Forms.Button btnRezervasyonSilme;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

