namespace UniversiteSistemi
{
    partial class FrmDersTanimla
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
            this.lblDersAdi = new System.Windows.Forms.Label();
            this.lblKredi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.nudKredi = new System.Windows.Forms.NumericUpDown();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(82, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(285, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ders Tanımlama Ekranı";
            // 
            // lblDersAdi
            // 
            this.lblDersAdi.AutoSize = true;
            this.lblDersAdi.Location = new System.Drawing.Point(12, 82);
            this.lblDersAdi.Name = "lblDersAdi";
            this.lblDersAdi.Size = new System.Drawing.Size(80, 20);
            this.lblDersAdi.TabIndex = 1;
            this.lblDersAdi.Text = "Ders Adı:";
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.Location = new System.Drawing.Point(39, 145);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(53, 20);
            this.lblKredi.TabIndex = 2;
            this.lblKredi.Text = "Kredi:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(27, 314);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 20);
            this.lblDurum.TabIndex = 3;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(98, 75);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(212, 27);
            this.txtDersAdi.TabIndex = 4;
            // 
            // nudKredi
            // 
            this.nudKredi.Location = new System.Drawing.Point(98, 138);
            this.nudKredi.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudKredi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKredi.Name = "nudKredi";
            this.nudKredi.Size = new System.Drawing.Size(71, 27);
            this.nudKredi.TabIndex = 5;
            this.nudKredi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(160, 210);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(123, 49);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Dersi Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(326, 285);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(116, 34);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmDersTanimla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.nudKredi);
            this.Controls.Add(this.txtDersAdi);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.lblDersAdi);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDersTanimla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ders Tanımlama";
            this.Load += new System.EventHandler(this.FrmDersTanimla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKredi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblDersAdi;
        private System.Windows.Forms.Label lblKredi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.NumericUpDown nudKredi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGeri;
    }
}