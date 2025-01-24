namespace Otel_Rezervasyon_Sistemi_Proje
{
    partial class FormRezervasyonSilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRezervasyonSilme));
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRezervasyonlar = new System.Windows.Forms.ListBox();
            this.btnRezervasyonuSil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnrezervasyongetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen silmek istediğiniz rezervasyonu seçiniz.";
            // 
            // listBoxRezervasyonlar
            // 
            this.listBoxRezervasyonlar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listBoxRezervasyonlar.FormattingEnabled = true;
            this.listBoxRezervasyonlar.ItemHeight = 16;
            this.listBoxRezervasyonlar.Location = new System.Drawing.Point(254, 86);
            this.listBoxRezervasyonlar.Name = "listBoxRezervasyonlar";
            this.listBoxRezervasyonlar.Size = new System.Drawing.Size(345, 260);
            this.listBoxRezervasyonlar.TabIndex = 2;
            this.listBoxRezervasyonlar.SelectedIndexChanged += new System.EventHandler(this.listBoxRezervasyonlar_SelectedIndexChanged_1);
            // 
            // btnRezervasyonuSil
            // 
            this.btnRezervasyonuSil.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRezervasyonuSil.Location = new System.Drawing.Point(430, 361);
            this.btnRezervasyonuSil.Name = "btnRezervasyonuSil";
            this.btnRezervasyonuSil.Size = new System.Drawing.Size(169, 40);
            this.btnRezervasyonuSil.TabIndex = 3;
            this.btnRezervasyonuSil.Text = "Rezervasyonu Sil";
            this.btnRezervasyonuSil.UseVisualStyleBackColor = false;
            this.btnRezervasyonuSil.Click += new System.EventHandler(this.btnRezervasyonuSil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnrezervasyongetir
            // 
            this.btnrezervasyongetir.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnrezervasyongetir.Location = new System.Drawing.Point(254, 361);
            this.btnrezervasyongetir.Name = "btnrezervasyongetir";
            this.btnrezervasyongetir.Size = new System.Drawing.Size(170, 40);
            this.btnrezervasyongetir.TabIndex = 5;
            this.btnrezervasyongetir.Text = "Rezervasyonları Getir";
            this.btnrezervasyongetir.UseVisualStyleBackColor = false;
            this.btnrezervasyongetir.Click += new System.EventHandler(this.btnrezervasyongetir_Click);
            // 
            // FormRezervasyonSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrezervasyongetir);
            this.Controls.Add(this.btnRezervasyonuSil);
            this.Controls.Add(this.listBoxRezervasyonlar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormRezervasyonSilme";
            this.Text = "FormRezervasyonSilme";
            this.Load += new System.EventHandler(this.FormRezervasyonSilme_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxRezervasyonlar;
        private System.Windows.Forms.Button btnRezervasyonuSil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnrezervasyongetir;
    }
}