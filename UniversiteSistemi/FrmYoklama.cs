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
    public partial class FrmYoklama : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogretmenId;
        public FrmYoklama()
        {
            InitializeComponent();
        }

        private void FrmYoklama_Load(object sender, EventArgs e)
        {
            ogretmenId = this.Tag.ToString();
            cmbSaat.Items.AddRange(new string[] { "08:00", "10:00", "12:00", "14:00", "16:00" });
            DersleriYukle();
        }

        private void DersleriYukle()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT id, ders_adi FROM dersler WHERE ogretmen_id=@id", conn);
                cmd.Parameters.AddWithValue("@id", ogretmenId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbDersler.DisplayMember = "ders_adi";
                cmbDersler.ValueMember = "id";
                cmbDersler.DataSource = dt;
            }
        }

        private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDersler.SelectedValue == null) return;
            OgrencileriYukle(Convert.ToInt32(cmbDersler.SelectedValue));
        }

        private void OgrencileriYukle(int dersId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT o.id, CONCAT(o.ad, ' ', o.soyad) AS ogrenci
                    FROM ders_kayitlari dk
                    JOIN ogrenciler o ON dk.ogrenci_id = o.id
                    WHERE dk.ders_id = @dersId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dersId", dersId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOgrenciler.DataSource = dt;
                if (!dgvOgrenciler.Columns.Contains("Durum"))
                {
                    DataGridViewComboBoxColumn durumColumn = new DataGridViewComboBoxColumn();
                    durumColumn.Name = "Durum";
                    durumColumn.HeaderText = "Durum";
                    durumColumn.Items.AddRange("var", "yok");
                    dgvOgrenciler.Columns.Add(durumColumn);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDersler.SelectedValue == null || cmbSaat.SelectedItem == null)
            {
                lblDurum.Text = "Ders ve saat seçiniz.";
                return;
            }

            int dersId = Convert.ToInt32(cmbDersler.SelectedValue);
            string saat = cmbSaat.SelectedItem.ToString();
            DateTime tarih = dtpTarih.Value.Date;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvOgrenciler.Rows)
                {
                    if (row.IsNewRow) continue;

                    int ogrenciId = Convert.ToInt32(row.Cells["id"].Value);
                    string durum = row.Cells["Durum"].Value?.ToString();

                    if (string.IsNullOrEmpty(durum)) continue;

                    MySqlCommand cmd = new MySqlCommand("INSERT INTO devamsizlik (ogrenci_id, ders_id, tarih, saat, durum) VALUES (@ogrenci, @ders, @tarih, @saat, @durum)", conn);
                    cmd.Parameters.AddWithValue("@ogrenci", ogrenciId);
                    cmd.Parameters.AddWithValue("@ders", dersId);
                    cmd.Parameters.AddWithValue("@tarih", tarih);
                    cmd.Parameters.AddWithValue("@saat", saat);
                    cmd.Parameters.AddWithValue("@durum", durum);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Yoklama başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
