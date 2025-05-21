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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace UniversiteSistemi
{
    public partial class FrmDersKayit : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogrenciId;
        public FrmDersKayit()
        {
            InitializeComponent();
        }

        private void FrmDersKayit_Load(object sender, EventArgs e)
        {
            ogrenciId = this.Tag.ToString();
            DersleriGetir();
        }
        private void DersleriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT d.id, d.ders_adi, d.kredi, CONCAT(o.ad, ' ', o.soyad) AS ogretmen 
                FROM dersler d
                JOIN ogretim_gorevlileri o ON d.ogretmen_id = o.id";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDersler.DataSource = dt;
                dgvDersler.Columns["id"].Visible = false;
            }
        }

        private void btnDersKayit_Click(object sender, EventArgs e)
        {
            if (dgvDersler.SelectedRows.Count == 0)
            {
                lblDurum.Text = "Lütfen bir ders seçin.";
                return;
            }

            int dersId = Convert.ToInt32(dgvDersler.SelectedRows[0].Cells["id"].Value);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO ders_kayitlari (ogrenci_id, ders_id) VALUES (@ogrenci_id, @ders_id)", conn);
                cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);
                cmd.Parameters.AddWithValue("@ders_id", dersId);

                try
                {
                    cmd.ExecuteNonQuery();
                    lblDurum.Text = "Ders başarıyla kaydedildi.";
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        lblDurum.Text = "Bu derse zaten kayıtlısınız.";
                    else
                        lblDurum.Text = "Hata: " + ex.Message;
                }
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT ders_adi, kredi 
            FROM dersler 
            WHERE id IN (
                SELECT ders_id FROM ders_kayitlari WHERE ogrenci_id = @ogrenci_id
            )";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);

                MySqlDataReader reader = cmd.ExecuteReader();

                // Kullanıcıdan PDF'in nereye kaydedileceğini sormak için:
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "PDF Dosyasını Kaydet";
                saveFileDialog.Filter = "PDF Dosyası|*.pdf";
                saveFileDialog.FileName = "DersKayit_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                // PDF oluştur
                Document pdf = new Document(PageSize.A4, 50, 50, 50, 50);
                PdfWriter.GetInstance(pdf, new FileStream(saveFileDialog.FileName, FileMode.Create));
                pdf.Open();

                // Başlık
                Paragraph baslik = new Paragraph("DERS KAYIT LİSTESİ");
                baslik.Alignment = Element.ALIGN_CENTER;
                baslik.SpacingAfter = 20;
                pdf.Add(baslik);

                // Tarih
                Paragraph tarih = new Paragraph("Tarih: " + DateTime.Now.ToShortDateString());
                tarih.Alignment = Element.ALIGN_RIGHT;
                tarih.SpacingAfter = 10;
                pdf.Add(tarih);

                // Tablo
                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 4f, 1f });

                // Başlık satırı
                PdfPCell cell1 = new PdfPCell(new Phrase("Ders Adı", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                PdfPCell cell2 = new PdfPCell(new Phrase("Kredi", FontFactory.GetFont(FontFactory.HELVETICA_BOLD)));
                cell1.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell2.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell1);
                table.AddCell(cell2);

                // İçerik
                while (reader.Read())
                {
                    table.AddCell(reader["ders_adi"].ToString());
                    table.AddCell(reader["kredi"].ToString());
                }

                pdf.Add(table);
                pdf.Close();

                MessageBox.Show("PDF başarıyla oluşturuldu:\n" + saveFileDialog.FileName, "PDF Oluşturuldu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
