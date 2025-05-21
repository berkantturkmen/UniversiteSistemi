namespace UniversiteSistemi
{
    partial class FrmOgrenciListesi
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblDersSec = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(165, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(344, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Derse Kayıtlı Öğrenci Listesi";
            // 
            // lblDersSec
            // 
            this.lblDersSec.AutoSize = true;
            this.lblDersSec.Location = new System.Drawing.Point(12, 109);
            this.lblDersSec.Name = "lblDersSec";
            this.lblDersSec.Size = new System.Drawing.Size(111, 20);
            this.lblDersSec.TabIndex = 1;
            this.lblDersSec.Text = "Ders Seçiniz:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(330, 405);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 2;
            // 
            // cmbDersler
            // 
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(119, 101);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(189, 28);
            this.cmbDersler.TabIndex = 3;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDersler_SelectedIndexChanged);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(314, 61);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(456, 316);
            this.dgvOgrenciler.TabIndex = 4;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(108, 222);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(141, 57);
            this.btnYazdir.TabIndex = 5;
            this.btnYazdir.Text = "PDF Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(633, 424);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(118, 51);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmOgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dgvOgrenciler);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblDersSec);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgrenciListesi";
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.FrmOgrenciListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDersSec;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnGeri;
    }
}