using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversiteSistemi
{
    public partial class FrmOgretmenAnasayfa : Form
    {
        public FrmOgretmenAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmOgretmenAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnDersTanimla_Click(object sender, EventArgs e)
        {
            FrmDersTanimla frm = new FrmDersTanimla();
            frm.Tag = this.Tag; // öğretmen ID'si taşınır
            frm.Show();
            this.Hide();
        }

        private void btnYoklamaGir_Click(object sender, EventArgs e)
        {
            FrmYoklama frm = new FrmYoklama();
            frm.Tag = this.Tag;
            frm.Show();
            this.Hide();
        }

        private void btnNotGir_Click(object sender, EventArgs e)
        {
            FrmNotGir frm = new FrmNotGir();
            frm.Tag = this.Tag;
            frm.Show();
            this.Hide();
        }

        private void btnOgrenciListe_Click(object sender, EventArgs e)
        {
            FrmOgrenciListesi frm = new FrmOgrenciListesi();
            frm.Tag = this.Tag;
            frm.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            FrmGiris frm = new FrmGiris();
            frm.Show();
            this.Close();
        }
    }
}
