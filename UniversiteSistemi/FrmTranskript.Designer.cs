namespace UniversiteSistemi
{
    partial class FrmTranskript
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
            this.lblGano = new System.Windows.Forms.Label();
            this.dgvTranskript = new System.Windows.Forms.DataGridView();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranskript)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(292, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(131, 29);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Transkript";
            // 
            // lblGano
            // 
            this.lblGano.AutoSize = true;
            this.lblGano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGano.Location = new System.Drawing.Point(15, 356);
            this.lblGano.Name = "lblGano";
            this.lblGano.Size = new System.Drawing.Size(109, 20);
            this.lblGano.TabIndex = 1;
            this.lblGano.Text = "GANO: 0.00";
            // 
            // dgvTranskript
            // 
            this.dgvTranskript.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTranskript.Location = new System.Drawing.Point(3, 49);
            this.dgvTranskript.Name = "dgvTranskript";
            this.dgvTranskript.RowHeadersWidth = 51;
            this.dgvTranskript.RowTemplate.Height = 24;
            this.dgvTranskript.Size = new System.Drawing.Size(773, 294);
            this.dgvTranskript.TabIndex = 2;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(170, 375);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(131, 55);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "PDF Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(613, 391);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(119, 39);
            this.btnGeri.TabIndex = 4;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // FrmTranskript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.dgvTranskript);
            this.Controls.Add(this.lblGano);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmTranskript";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transkript Sayfası";
            this.Load += new System.EventHandler(this.FrmTranskript_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTranskript)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblGano;
        private System.Windows.Forms.DataGridView dgvTranskript;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnGeri;
    }
}