namespace Otel_Rezervasyon_Sistemi_Proje
{
    partial class FormRezervasyonGoruntule
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyonGoruntule));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRezervasyonlar = new System.Windows.Forms.ListBox();
            this.btnDetayGoster = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnanasayfa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(260, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detaylar için rezervasyonu seçiniz.";
            // 
            // listBoxRezervasyonlar
            // 
            this.listBoxRezervasyonlar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxRezervasyonlar.FormattingEnabled = true;
            this.listBoxRezervasyonlar.ItemHeight = 16;
            this.listBoxRezervasyonlar.Location = new System.Drawing.Point(219, 68);
            this.listBoxRezervasyonlar.Name = "listBoxRezervasyonlar";
            this.listBoxRezervasyonlar.Size = new System.Drawing.Size(372, 292);
            this.listBoxRezervasyonlar.TabIndex = 1;
            this.listBoxRezervasyonlar.SelectedIndexChanged += new System.EventHandler(this.listBoxRezervasyonlar_SelectedIndexChanged);
            // 
            // btnDetayGoster
            // 
            this.btnDetayGoster.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDetayGoster.Location = new System.Drawing.Point(219, 382);
            this.btnDetayGoster.Name = "btnDetayGoster";
            this.btnDetayGoster.Size = new System.Drawing.Size(189, 34);
            this.btnDetayGoster.TabIndex = 2;
            this.btnDetayGoster.Text = "Rezervasyonları  Göster";
            this.btnDetayGoster.UseVisualStyleBackColor = false;
            this.btnDetayGoster.Click += new System.EventHandler(this.btnDetayGoster_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnanasayfa.Location = new System.Drawing.Point(428, 382);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(163, 34);
            this.btnanasayfa.TabIndex = 4;
            this.btnanasayfa.Text = "Ana Sayfaya Dön";
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // FormRezervasyonGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btnDetayGoster);
            this.Controls.Add(this.listBoxRezervasyonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRezervasyonGoruntule";
            this.Text = "FormRezervasyonGoruntule";
            this.Load += new System.EventHandler(this.FormRezervasyonGoruntule_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRezervasyonlar;
        private System.Windows.Forms.Button btnDetayGoster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnanasayfa;
    }
}