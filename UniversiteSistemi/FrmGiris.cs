using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UniversiteSistemi
{
    public partial class FrmGiris : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        public FrmGiris()
        {
            InitializeComponent();
        }
        private void FrmGiris_Load(object sender, EventArgs e)
        {
            rdbOgrenci.Checked = true;
            rdbOgretmen.Checked = true;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string no = txtNo.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (no.Length != 6 || sifre == "")
            {
                lblDurum.Text = "Bilgileri doğru girin.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (rdbOgrenci.Checked)
                {
                    cmd.CommandText = "SELECT id FROM ogrenciler WHERE okul_no=@no AND sifre=@sifre";
                }
                else if (rdbOgretmen.Checked)
                {
                    cmd.CommandText = "SELECT id FROM ogretim_gorevlileri WHERE sicil_no=@no AND sifre=@sifre";
                }

                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int kullaniciId = Convert.ToInt32(result);
                    if (rdbOgrenci.Checked)
                    {
                        FrmOgrenciAnasayfa frm = new FrmOgrenciAnasayfa();
                        frm.Tag = kullaniciId.ToString();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmOgretmenAnasayfa frm = new FrmOgretmenAnasayfa();
                        frm.Tag = kullaniciId.ToString();
                        frm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    lblDurum.Text = "Giriş başarısız. Bilgileri kontrol edin.";
                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            FrmKayit frm = new FrmKayit();
            frm.Show();
            this.Hide();
        }
    }
}
