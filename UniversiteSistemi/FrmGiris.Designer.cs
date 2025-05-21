namespace UniversiteSistemi
{
    partial class FrmGiris
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
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.rdbOgrenci = new System.Windows.Forms.RadioButton();
            this.rdbOgretmen = new System.Windows.Forms.RadioButton();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Sayfası";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(12, 65);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(111, 20);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "Okul/Sicil No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(74, 102);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(49, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(41, 311);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 3;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(129, 58);
            this.txtNo.MaxLength = 6;
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(157, 27);
            this.txtNo.TabIndex = 4;
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(129, 95);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(157, 27);
            this.txtSifre.TabIndex = 5;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // rdbOgrenci
            // 
            this.rdbOgrenci.AutoSize = true;
            this.rdbOgrenci.Location = new System.Drawing.Point(129, 139);
            this.rdbOgrenci.Name = "rdbOgrenci";
            this.rdbOgrenci.Size = new System.Drawing.Size(134, 24);
            this.rdbOgrenci.TabIndex = 6;
            this.rdbOgrenci.TabStop = true;
            this.rdbOgrenci.Text = "Öğrenci Girişi";
            this.rdbOgrenci.UseVisualStyleBackColor = true;
            // 
            // rdbOgretmen
            // 
            this.rdbOgretmen.AutoSize = true;
            this.rdbOgretmen.Location = new System.Drawing.Point(129, 180);
            this.rdbOgretmen.Name = "rdbOgretmen";
            this.rdbOgretmen.Size = new System.Drawing.Size(206, 24);
            this.rdbOgretmen.TabIndex = 7;
            this.rdbOgretmen.TabStop = true;
            this.rdbOgretmen.Text = "Öğretim Görevlisi Girişi";
            this.rdbOgretmen.UseVisualStyleBackColor = true;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(67, 231);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(142, 57);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(241, 231);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(142, 57);
            this.btnKayit.TabIndex = 9;
            this.btnKayit.Text = "Kayıt Sayfasına Git";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.rdbOgretmen);
            this.Controls.Add(this.rdbOgrenci);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.RadioButton rdbOgrenci;
        private System.Windows.Forms.RadioButton rdbOgretmen;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayit;
    }
}