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
    public partial class FrmNotGoruntule : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogrenciId;
        public FrmNotGoruntule()
        {
            InitializeComponent();
        }

        private void FrmNotGoruntule_Load(object sender, EventArgs e)
        {
            ogrenciId = this.Tag.ToString();
            NotlariGetir();
        }

        private void NotlariGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        ot.ders_adi AS 'Ders Adı',
                        ot.kredi AS 'Kredi',
                        ot.vize AS 'Vize',
                        ot.final AS 'Final',
                        ot.ortalama AS 'Ortalama',
                        ot.harf_notu AS 'Harf Notu'
                    FROM ogrenci_transkript ot
                    WHERE ot.ogrenci_id = @ogrenci_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNotlar.DataSource = dt;
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
