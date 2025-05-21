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
    public partial class FrmKayit : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        public FrmKayit()
        {
            InitializeComponent();
        }
        private void FrmKayit_Load(object sender, EventArgs e)
        {
            rdbOgrenci.Checked = true;
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();
            string tc = txtTc.Text.Trim();
            string no = txtNo.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (ad == "" || soyad == "" || tc.Length != 11 || no.Length != 6 || sifre == "")
            {
                lblDurum.Text = "Tüm alanları doğru şekilde doldurun!";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;

                if (rdbOgrenci.Checked)
                {
                    cmd.CommandText = "INSERT INTO ogrenciler (tc_kimlik_no, okul_no, ad, soyad, sifre) VALUES (@tc, @no, @ad, @soyad, @sifre)";
                }
                else if (rdbOgretmen.Checked)
                {
                    cmd.CommandText = "INSERT INTO ogretim_gorevlileri (tc_kimlik_no, sicil_no, ad, soyad, sifre) VALUES (@tc, @no, @ad, @soyad, @sifre)";
                }

                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.Parameters.AddWithValue("@no", no);
                cmd.Parameters.AddWithValue("@ad", ad);
                cmd.Parameters.AddWithValue("@soyad", soyad);
                cmd.Parameters.AddWithValue("@sifre", sifre);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarıyla yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        lblDurum.Text = "Bu TC veya numara zaten kayıtlı.";
                    else
                        lblDurum.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void btnGirisSayfasi_Click(object sender, EventArgs e)
        {
            FrmGiris giris = new FrmGiris();
            giris.Show();
            this.Hide();
        }
    }
}
