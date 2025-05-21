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
    public partial class FrmDersTanimla : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogretmenId;
        public FrmDersTanimla()
        {
            InitializeComponent();
        }

        private void FrmDersTanimla_Load(object sender, EventArgs e)
        {
            ogretmenId = this.Tag.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string dersAdi = txtDersAdi.Text.Trim();
            int kredi = (int)nudKredi.Value;

            if (dersAdi == "")
            {
                lblDurum.Text = "Ders adı boş bırakılamaz.";
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO dersler (ders_adi, kredi, ogretmen_id) VALUES (@adi, @kredi, @ogretmen_id)", conn);
                cmd.Parameters.AddWithValue("@adi", dersAdi);
                cmd.Parameters.AddWithValue("@kredi", kredi);
                cmd.Parameters.AddWithValue("@ogretmen_id", ogretmenId);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ders başarıyla tanımlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDersAdi.Clear();
                    nudKredi.Value = 1;
                    lblDurum.Text = "";
                }
                catch (Exception ex)
                {
                    lblDurum.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmOgretmenAnasayfa frm = new FrmOgretmenAnasayfa();
            frm.Tag = ogretmenId;
            frm.Show();
            this.Hide();
        }
    }
}
