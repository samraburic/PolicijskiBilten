using Bilten.Model.Requests.Dogadjaj;
using Bilten.Model.Requests.Korisnici;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.FormaKontrolor
{
    public partial class frmZvanicniBilten : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _korisnici = new APIService("Korisnici");

        public frmZvanicniBilten()
        {
            InitializeComponent();
        }

        private async void frmZvanicniBilten_Load(object sender, EventArgs e)
        {
            await LoadDataGridView(null);
        }

        private async Task LoadDataGridView(DogadjajSearchRequest searchRequest = null)
        {
            if(searchRequest == null)
            {
                var list1 = await _dogadjaji.Get<List<Model.Dogadjaj>>(new DogadjajSearchRequest()
                {
                    DatumDogadjaja = DateTime.Now
                });


                dgvSviDogadjaji.AutoGenerateColumns = false;
                dgvSviDogadjaji.DataSource = list1;
            }
            else
            {

                var list = await _dogadjaji.Get<List<Bilten.Model.Dogadjaj>>(searchRequest);
                dgvSviDogadjaji.AutoGenerateColumns = false;
                dgvSviDogadjaji.DataSource = list;
            }


        }

        public void exportToPDF(DataGridView dgv, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //HEADER
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //DATAROW
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = filename;
            saveFileDialog.DefaultExt = ".pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(saveFileDialog.FileName.ToString());//putanja
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(pdfTable);
                    pdfDoc.Close();
                    stream.Close();

                    string pdf = saveFileDialog.FileName.ToString();
                    Mail(pdf);
                }
            }
        }

        private void btnPDF_Click_1(object sender, EventArgs e)
        {

            //DateTime.Now.ToString("MM/dd/yyyy")
            string nazivPDFa = "ZvanicniBilten_" + DateTime.Now.Date.ToString("dd.MM.yyyy");
            exportToPDF(dgvSviDogadjaji, nazivPDFa);
        }


        private async void Mail(string pdf)
        {
            var korisnici = await _korisnici.Get<List<Model.Korisnici>>(null);
            var kontrolor = await _korisnici.Get<List<Model.Korisnici>>(new KorisniciSearchRequest()
            {
                VrstaKorisnika = "Kontrolor"
            });

            foreach (var korisnik in korisnici)
            {
                if (korisnik.VrstaKorisnika.Naziv != "Kontrolor")
                {
                    MailMessage mail = new MailMessage(kontrolor[0].Email,
                        korisnik.Email,
                        "Zvanicni bilten - " + DateTime.Now.Date.ToString("dd.MM.yyyy"),
                        "Poštovani " + korisnik.ImePrezime + ", u prilogu se nalazi zvanicni bilten za " + DateTime.Now.Date.ToString("dd.MM.yyyy"));
                    mail.Attachments.Add(new Attachment(pdf));

                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(kontrolor[0].Email, "Sb20082014");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
            }


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                DatumDogadjaja = dtpDatumDogadjaja.Value,
                Odabran = true
            };


            await LoadDataGridView(searchRequest);
        }
    }
}
