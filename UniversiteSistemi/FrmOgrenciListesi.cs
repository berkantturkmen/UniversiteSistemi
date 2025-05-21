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
    public partial class FrmOgrenciListesi : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogretmenId;
        public FrmOgrenciListesi()
        {
            InitializeComponent();
        }

        private void FrmOgrenciListesi_Load(object sender, EventArgs e)
        {
            ogretmenId = this.Tag.ToString();
            DersleriGetir();
        }

        private void DersleriGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT id, ders_adi FROM dersler WHERE ogretmen_id = @ogretmen_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogretmen_id", ogretmenId);

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
                    SELECT o.okul_no AS 'Okul No', o.ad AS 'Ad', o.soyad AS 'Soyad'
                    FROM ders_kayitlari dk
                    JOIN ogrenciler o ON dk.ogrenci_id = o.id
                    WHERE dk.ders_id = @ders_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ders_id", dersId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOgrenciler.DataSource = dt;
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dgvOgrenciler.Rows.Count == 0)
            {
                lblDurum.Text = "Liste boş.";
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Öğrenci Listesi PDF'ini Kaydet";
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            saveFileDialog.FileName = "OgrenciListesi_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // Türkçe karakter destekli Helvetica + Cp1254
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, "Cp1254", BaseFont.NOT_EMBEDDED);
            

            Document pdf = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(pdf, new FileStream(saveFileDialog.FileName, FileMode.Create));
            pdf.Open();

            // Başlık
            Paragraph baslik = new Paragraph("DERSE KAYITLI ÖĞRENCİ LİSTESİ");
            baslik.Alignment = Element.ALIGN_CENTER;
            baslik.SpacingAfter = 20;
            pdf.Add(baslik);

            // Tarih
            Paragraph tarih = new Paragraph("Tarih: " + DateTime.Now.ToShortDateString());
            tarih.Alignment = Element.ALIGN_RIGHT;
            tarih.SpacingAfter = 10;
            pdf.Add(tarih);

            // Tablo
            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 2f, 3f, 3f });

            string[] headers = { "Okul No", "Ad", "Soyad" };
            foreach (string h in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(h));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvOgrenciler.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        string value = row.Cells[i].Value?.ToString() ?? "";
                        PdfPCell cell = new PdfPCell(new Phrase(value   ));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
            }

            pdf.Add(table);
            pdf.Close();

            MessageBox.Show("PDF başarıyla oluşturuldu:\n" + saveFileDialog.FileName, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
