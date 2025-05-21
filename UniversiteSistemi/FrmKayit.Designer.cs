namespace UniversiteSistemi
{
    partial class FrmKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.rdbOgretmen = new System.Windows.Forms.RadioButton();
            this.btnKayitOl = new System.Windows.Forms.Button();
            this.btnGirisSayfasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üniversite Kayıt Sayfası";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(83, 88);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(34, 20);
            this.lblAd.TabIndex = 1;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(57, 130);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(60, 20);
            this.lblSoyad.TabIndex = 2;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(5, 174);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(112, 20);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC Kimlik No:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(6, 213);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(111, 20);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "Okul/Sicil No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(68, 254);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 20);
            this.lblSifre.TabIndex = 5;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(57, 414);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(124, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(167, 27);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(124, 123);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(167, 27);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(124, 167);
            this.txtTc.MaxLength = 11;
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(167, 27);
            this.txtTc.TabIndex = 9;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(124, 206);
            this.txtNo.MaxLength = 6;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(167, 27);
            this.txtNo.TabIndex = 10;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(124, 247);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(167, 27);
            this.txtSifre.TabIndex = 11;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.Location = new System.Drawing.Point(309, 123);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(89, 24);
            this.rdbOgrenci.TabIndex = 12;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci";
            this.rdbOgrenci.UseVisualStyleBackColor = true;
            // 
            // rdbOgretmen
            // 
            this.rdbOgretmen.AutoSize = true;
            this.rdbOgretmen.Location = new System.Drawing.Point(309, 167);
            this.rdbOgretmen.Name = "rdbOgretmen";
            this.rdbOgretmen.Size = new System.Drawing.Size(161, 24);
            this.rdbOgretmen.TabIndex = 13;
            this.rdbOgretmen.TabStop = true;
            this.rdbOgretmen.Text = "Öğretim Görevlisi";
            this.rdbOgretmen.UseVisualStyleBackColor = true;
            // 
            // btnKayitOl
            // 
            this.btnKayitOl.Location = new System.Drawing.Point(87, 315);
            this.btnKayitOl.Name = "btnKayitOl";
            this.btnKayitOl.Size = new System.Drawing.Size(120, 72);
            this.btnKayitOl.TabIndex = 14;
            this.btnKayitOl.Text = "Kayıt Ol";
            this.btnKayitOl.UseVisualStyleBackColor = true;
            this.btnKayitOl.Click += new System.EventHandler(this.btnKayitOl_Click);
            // 
            // btnGirisSayfasi
            // 
            this.btnGirisSayfasi.Location = new System.Drawing.Point(245, 315);
            this.btnGirisSayfasi.Name = "btnGirisSayfasi";
            this.btnGirisSayfasi.Size = new System.Drawing.Size(120, 72);
            this.btnGirisSayfasi.TabIndex = 15;
            this.btnGirisSayfasi.Text = "Zaten Kayıtlıysan Giriş Yap";
            this.btnGirisSayfasi.UseVisualStyleBackColor = true;
            this.btnGirisSayfasi.Click += new System.EventHandler(this.btnGirisSayfasi_Click);
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.btnGirisSayfasi);
            this.Controls.Add(this.btnKayitOl);
            this.Controls.Add(this.rdbOgretmen);
            this.Controls.Add(this.rdbOgrenci);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üniversite Kayıt Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.RadioButton rdbOgrenci;
        private System.Windows.Forms.RadioButton rdbOgretmen;
        private System.Windows.Forms.Button btnKayitOl;
        private System.Windows.Forms.Button btnGirisSayfasi;
    }
}

