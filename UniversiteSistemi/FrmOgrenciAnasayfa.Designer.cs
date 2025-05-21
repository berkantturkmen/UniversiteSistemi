namespace UniversiteSistemi
{
    partial class FrmOgrenciAnasayfa
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
            this.btnDersKayit = new System.Windows.Forms.Button();
            this.btnNotGoruntule = new System.Windows.Forms.Button();
            this.btnDevamsizlik = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(164, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ana Sayfa";
            // 
            // btnDersKayit
            // 
            this.btnDersKayit.Location = new System.Drawing.Point(27, 178);
            this.btnDersKayit.Name = "btnDersKayit";
            this.btnDersKayit.Size = new System.Drawing.Size(123, 52);
            this.btnDersKayit.TabIndex = 1;
            this.btnDersKayit.Text = "Ders Kayıt";
            this.btnDersKayit.UseVisualStyleBackColor = true;
            this.btnDersKayit.Click += new System.EventHandler(this.btnDersKayit_Click);
            // 
            // btnNotGoruntule
            // 
            this.btnNotGoruntule.Location = new System.Drawing.Point(156, 178);
            this.btnNotGoruntule.Name = "btnNotGoruntule";
            this.btnNotGoruntule.Size = new System.Drawing.Size(123, 52);
            this.btnNotGoruntule.TabIndex = 2;
            this.btnNotGoruntule.Text = "Not Görüntüle";
            this.btnNotGoruntule.UseVisualStyleBackColor = true;
            this.btnNotGoruntule.Click += new System.EventHandler(this.btnNotGoruntule_Click);
            // 
            // btnDevamsizlik
            // 
            this.btnDevamsizlik.Location = new System.Drawing.Point(285, 178);
            this.btnDevamsizlik.Name = "btnDevamsizlik";
            this.btnDevamsizlik.Size = new System.Drawing.Size(123, 52);
            this.btnDevamsizlik.TabIndex = 3;
            this.btnDevamsizlik.Text = "Devamsızlık Görüntüle";
            this.btnDevamsizlik.UseVisualStyleBackColor = true;
            this.btnDevamsizlik.Click += new System.EventHandler(this.btnDevamsizlik_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.Location = new System.Drawing.Point(414, 178);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(123, 52);
            this.btnTranskript.TabIndex = 4;
            this.btnTranskript.Text = "Transkript";
            this.btnTranskript.UseVisualStyleBackColor = true;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(421, 313);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(107, 40);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmOgrenciAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 403);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnDevamsizlik);
            this.Controls.Add(this.btnNotGoruntule);
            this.Controls.Add(this.btnDersKayit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOgrenciAnasayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Paneli";
            this.Load += new System.EventHandler(this.FrmOgrenciAnasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDersKayit;
        private System.Windows.Forms.Button btnNotGoruntule;
        private System.Windows.Forms.Button btnDevamsizlik;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Button btnCikis;
    }
}