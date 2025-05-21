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
    public partial class FrmNotGir : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogretmenId;
        public FrmNotGir()
        {
            InitializeComponent();
        }

        private void FrmNotGir_Load(object sender, EventArgs e)
        {
            ogretmenId = this.Tag.ToString();
            DersleriGetir();
        }

        private void DersleriGetir()
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
            OgrencileriGetir(Convert.ToInt32(cmbDersler.SelectedValue));
        }

        private void OgrencileriGetir(int dersId)
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

                dt.Columns.Add("Vize", typeof(double));
                dt.Columns.Add("Final", typeof(double));

                dgvOgrenciler.DataSource = dt;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbDersler.SelectedValue == null)
            {
                lblDurum.Text = "Lütfen bir ders seçin.";
                return;
            }

            int dersId = Convert.ToInt32(cmbDersler.SelectedValue);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                foreach (DataGridViewRow row in dgvOgrenciler.Rows)
                {
                    if (row.IsNewRow) continue;

                    int ogrenciId = Convert.ToInt32(row.Cells["id"].Value);
                    object vizeObj = row.Cells["Vize"].Value;
                    object finalObj = row.Cells["Final"].Value;

                    if (vizeObj == null || finalObj == null)
                        continue;

                    double vize = Convert.ToDouble(vizeObj);
                    double final = Convert.ToDouble(finalObj);

                    MySqlCommand cmd = new MySqlCommand(@"
                        INSERT INTO notlar (ogrenci_id, ders_id, vize, final)
                        VALUES (@ogrenci_id, @ders_id, @vize, @final)
                        ON DUPLICATE KEY UPDATE vize=@vize, final=@final", conn);

                    cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);
                    cmd.Parameters.AddWithValue("@ders_id", dersId);
                    cmd.Parameters.AddWithValue("@vize", vize);
                    cmd.Parameters.AddWithValue("@final", final);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Notlar başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
