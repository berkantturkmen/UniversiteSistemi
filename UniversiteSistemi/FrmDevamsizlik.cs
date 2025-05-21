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
    public partial class FrmDevamsizlik : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogrenciId;
        public FrmDevamsizlik()
        {
            InitializeComponent();
        }

        private void FrmDevamsizlik_Load(object sender, EventArgs e)
        {
            ogrenciId = this.Tag.ToString();
            DevamsizlikGetir();
        }

        private void DevamsizlikGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        d.ders_adi AS 'Ders Adı',
                        v.tarih AS 'Tarih',
                        v.saat AS 'Saat',
                        v.durum AS 'Durum'
                    FROM devamsizlik v
                    JOIN dersler d ON d.id = v.ders_id
                    WHERE v.ogrenci_id = @ogrenci_id
                    ORDER BY v.tarih DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDevamsizlik.DataSource = dt;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            FrmOgrenciAnasayfa frm = new FrmOgrenciAnasayfa();
            frm.Tag = ogrenciId;
            frm.Show();
            this.Hide();
        }
    }
}
