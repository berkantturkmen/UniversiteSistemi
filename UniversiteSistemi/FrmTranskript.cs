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
    public partial class FrmTranskript : Form
    {
        string connectionString = "Server=localhost;Database=ogrenci_sistemi;Uid=root;Pwd=porola12;";
        string ogrenciId;
        public FrmTranskript()
        {
            InitializeComponent();
        }

        private void FrmTranskript_Load(object sender, EventArgs e)
        {
            ogrenciId = this.Tag.ToString();
            TranskriptiGetir();
        }

        private void TranskriptiGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        ders_adi AS 'Ders Adı',
                        kredi AS 'Kredi',
                        vize AS 'Vize',
                        final AS 'Final',
                        ortalama AS 'Ortalama',
                        harf_notu AS 'Harf Notu'
                    FROM ogrenci_transkript
                    WHERE ogrenci_id = @ogrenci_id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ogrenci_id", ogrenciId);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTranskript.DataSource = dt;

                // GANO Hesaplama
                double toplamNot = 0;
                int toplamKredi = 0;

                foreach (DataRow row in dt.Rows)
                {
                    double ortalama = Convert.ToDouble(row["Ortalama"]);
                    int kredi = Convert.ToInt32(row["Kredi"]);

                    toplamNot += ortalama * kredi;
                    toplamKredi += kredi;
                }

                double gano = toplamKredi > 0 ? toplamNot / toplamKredi : 0;
                lblGano.Text = "GANO: " + gano.ToString("0.00");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (dgvTranskript.Rows.Count == 0)
            {
                MessageBox.Show("Yazdırılacak transkript verisi yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kayıt yeri seçimi
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Transkript PDF'ini Kaydet";
            saveFileDialog.Filter = "PDF Dosyası|*.pdf";
            saveFileDialog.FileName = "Transkript_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // PDF ayarları
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, "Cp1254", BaseFont.NOT_EMBEDDED);
            

            Document pdf = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(pdf, new FileStream(saveFileDialog.FileName, FileMode.Create));
            pdf.Open();

            // Başlık
            Paragraph baslik = new Paragraph("TRANSKRİPT");
            baslik.Alignment = Element.ALIGN_CENTER;
            baslik.SpacingAfter = 20;
            pdf.Add(baslik);

            // Tarih
            Paragraph tarih = new Paragraph("Tarih: ");
            tarih.Alignment = Element.ALIGN_RIGHT;
            tarih.SpacingAfter = 10;
            pdf.Add(tarih);

            // Tablo
            PdfPTable table = new PdfPTable(6);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 3f, 1f, 1f, 1f, 1f, 1.5f });

            string[] headers = { "Ders Adı", "Kredi", "Vize", "Final", "Ortalama", "Harf Notu" };
            foreach (string h in headers)
            {
                PdfPCell cell = new PdfPCell(new Phrase(h));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            foreach (DataGridViewRow row in dgvTranskript.Rows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        string value = row.Cells[i].Value?.ToString() ?? "";
                        PdfPCell cell = new PdfPCell(new Phrase(value));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
            }

            pdf.Add(table);

            // GANO bilgisi
            Paragraph ganoYazi = new Paragraph("\n" + lblGano.Text);
            ganoYazi.Alignment = Element.ALIGN_RIGHT;
            ganoYazi.SpacingBefore = 20;
            pdf.Add(ganoYazi);

            pdf.Close();

            MessageBox.Show("Transkript PDF olarak oluşturuldu:\n" + saveFileDialog.FileName, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
