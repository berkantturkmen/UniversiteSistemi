namespace UniversiteSistemi
{
    partial class FrmOgretmenAnasayfa
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
            this.btnDersTanimla = new System.Windows.Forms.Button();
            this.btnYoklamaGir = new System.Windows.Forms.Button();
            this.btnNotGir = new System.Windows.Forms.Button();
            this.btnOgrenciListe = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğretim Görevlisi Ana Sayfa";
            // 
            // btnDersTanimla
            // 
            this.btnDersTanimla.Location = new System.Drawing.Point(21, 167);
            this.btnDersTanimla.Name = "btnDersTanimla";
            this.btnDersTanimla.Size = new System.Drawing.Size(115, 50);
            this.btnDersTanimla.TabIndex = 1;
            this.btnDersTanimla.Text = "Ders Tanımla";
            this.btnDersTanimla.UseVisualStyleBackColor = true;
            this.btnDersTanimla.Click += new System.EventHandler(this.btnDersTanimla_Click);
            // 
            // btnYoklamaGir
            // 
            this.btnYoklamaGir.Location = new System.Drawing.Point(153, 167);
            this.btnYoklamaGir.Name = "btnYoklamaGir";
            this.btnYoklamaGir.Size = new System.Drawing.Size(115, 50);
            this.btnYoklamaGir.TabIndex = 2;
            this.btnYoklamaGir.Text = "Yoklama Girişi";
            this.btnYoklamaGir.UseVisualStyleBackColor = true;
            this.btnYoklamaGir.Click += new System.EventHandler(this.btnYoklamaGir_Click);
            // 
            // btnNotGir
            // 
            this.btnNotGir.Location = new System.Drawing.Point(286, 167);
            this.btnNotGir.Name = "btnNotGir";
            this.btnNotGir.Size = new System.Drawing.Size(115, 50);
            this.btnNotGir.TabIndex = 3;
            this.btnNotGir.Text = "Not Girişi";
            this.btnNotGir.UseVisualStyleBackColor = true;
            this.btnNotGir.Click += new System.EventHandler(this.btnNotGir_Click);
            // 
            // btnOgrenciListe
            // 
            this.btnOgrenciListe.Location = new System.Drawing.Point(417, 167);
            this.btnOgrenciListe.Name = "btnOgrenciListe";
            this.btnOgrenciListe.Size = new System.Drawing.Size(115, 50);
            this.btnOgrenciListe.TabIndex = 4;
            this.btnOgrenciListe.Text = "Öğrenci Listesi";
            this.btnOgrenciListe.UseVisualStyleBackColor = true;
            this.btnOgrenciListe.Click += new System.EventHandler(this.btnOgrenciListe_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(434, 321);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(109, 43);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmOgretmenAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnOgrenciListe);
            this.Controls.Add(this.btnNotGir);
            this.Controls.Add(this.btnYoklamaGir);
            this.Controls.Add(this.btnDersTanimla);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgretmenAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğretim Görevlisi Paneli";
            this.Load += new System.EventHandler(this.FrmOgretmenAnasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDersTanimla;
        private System.Windows.Forms.Button btnYoklamaGir;
        private System.Windows.Forms.Button btnNotGir;
        private System.Windows.Forms.Button btnOgrenciListe;
        private System.Windows.Forms.Button btnCikis;
    }
}