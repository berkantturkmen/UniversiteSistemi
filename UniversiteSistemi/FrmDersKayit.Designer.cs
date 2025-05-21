namespace UniversiteSistemi
{
    partial class FrmDersKayit
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.btnDersKayit = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kayıt Sayfası";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(37, 37);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 1;
            // 
            // dgvDersler
            // 
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(12, 70);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowHeadersWidth = 51;
            this.dgvDersler.RowTemplate.Height = 24;
            this.dgvDersler.Size = new System.Drawing.Size(758, 384);
            this.dgvDersler.TabIndex = 2;
            // 
            // btnDersKayit
            // 
            this.btnDersKayit.Location = new System.Drawing.Point(53, 475);
            this.btnDersKayit.Name = "btnDersKayit";
            this.btnDersKayit.Size = new System.Drawing.Size(129, 50);
            this.btnDersKayit.TabIndex = 3;
            this.btnDersKayit.Text = "Dersi Kaydet";
            this.btnDersKayit.UseVisualStyleBackColor = true;
            this.btnDersKayit.Click += new System.EventHandler(this.btnDersKayit_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(299, 475);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(129, 50);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "PDF Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(572, 475);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(129, 50);
            this.btnGeri.TabIndex = 5;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmDersKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnDersKayit);
            this.Controls.Add(this.dgvDersler);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDersKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Kayıt Sayfası";
            this.Load += new System.EventHandler(this.FrmDersKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnDersKayit;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnGeri;
    }
}