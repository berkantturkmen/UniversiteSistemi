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
    public partial class FrmOgrenciAnasayfa : Form
    {
        public FrmOgrenciAnasayfa()
        {
            InitializeComponent();
        }

        private void FrmOgrenciAnasayfa_Load(object sender, EventArgs e)
        {

        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            FrmDersKayit frm = new FrmDersKayit();
            frm.Tag = this.Tag; // Öğrenci ID'sini taşı
            frm.Show();
            this.Hide();
        }

        private void btnNotGoruntule_Click(object sender, EventArgs e)
        {
            FrmNotGoruntule frm = new FrmNotGoruntule();
            frm.Tag = this.Tag;
            frm.Show();
            this.Hide();
        }

        private void btnDevamsizlik_Click(object sender, EventArgs e)
        {
            FrmDevamsizlik frm = new FrmDevamsizlik();
            frm.Tag = this.Tag;
            frm.Show();
            this.Hide();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            FrmTranskript frm = new FrmTranskript();
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
