namespace UniversiteSistemi
{
    partial class FrmNotGir
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
            this.lblDers = new System.Windows.Forms.Label();
            this.cmbDersler = new System.Windows.Forms.ComboBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(343, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(123, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Not Girişi";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(12, 60);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(111, 20);
            this.lblDers.TabIndex = 1;
            this.lblDers.Text = "Ders Seçiniz:";
            // 
            // cmbDersler
            // 
            this.cmbDersler.FormattingEnabled = true;
            this.cmbDersler.Location = new System.Drawing.Point(129, 52);
            this.cmbDersler.Name = "cmbDersler";
            this.cmbDersler.Size = new System.Drawing.Size(188, 28);
            this.cmbDersler.TabIndex = 2;
            this.cmbDersler.SelectedIndexChanged += new System.EventHandler(this.cmbDersler_SelectedIndexChanged);
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(16, 99);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(790, 269);
            this.dgvOgrenciler.TabIndex = 3;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(103, 398);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(122, 62);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Notları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(344, 60);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 5;
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(641, 423);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 48);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmNotGir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 503);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvOgrenciler);
            this.Controls.Add(this.cmbDersler);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNotGir";
            this.Text = "Not Girişi";
            this.Load += new System.EventHandler(this.FrmNotGir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDers;
        private System.Windows.Forms.ComboBox cmbDersler;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnGeri;
    }
}