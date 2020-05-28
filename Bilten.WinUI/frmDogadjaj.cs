using Bilten.Model.Requests.Dogadjaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI
{
    public partial class frmDogadjaj : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");


        public frmDogadjaj()
        {
            InitializeComponent();
        }

        private async void frmDogadjaj_Load(object sender, EventArgs e)
        {
            await LoadDataGridView(null);
        }

        private async Task LoadDataGridView(DogadjajSearchRequest searchRequest = null)
        {
            var list = await _dogadjaji.Get<List<Bilten.Model.Dogadjaj>>(searchRequest);
            dgvDogadjaji.AutoGenerateColumns = false;
            dgvDogadjaji.DataSource = list;
        }
        private void btnPretraga_Click(object sender, EventArgs e)
        {
        }
        private void dgvDogadjaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                var dogadjajId = dgvDogadjaji.CurrentRow.Cells["Id"].FormattedValue;
                var kategorijaId = dgvDogadjaji.CurrentRow.Cells["KategorijeId"].FormattedValue;

                frmDogadjajDodajMjere frm = new frmDogadjajDodajMjere(int.Parse(dogadjajId.ToString()), int.Parse(kategorijaId.ToString()));
                frm.Show();
            }
            if (e.ColumnIndex == 9)
            {
                var dogadjajId = dgvDogadjaji.CurrentRow.Cells["Id"].FormattedValue;

                frmDodajSlikeDogadjaj frm = new frmDodajSlikeDogadjaj(int.Parse(dogadjajId.ToString()));
                frm.Show();
            }
            if (e.ColumnIndex == 10)
            {
                var dogadjajId = dgvDogadjaji.CurrentRow.Cells["Id"].FormattedValue;

                frmDodajDogadjajVideo frm = new frmDodajDogadjajVideo(int.Parse(dogadjajId.ToString()));
                frm.Show();
            }
        }


        private async void dgvDogadjaji_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var idObj = dgvDogadjaji.SelectedRows[0].Cells[0].Value;

            var dogadjaj = await _dogadjaji.GetById<Model.Dogadjaj>(idObj);
            var kategorije = await _kategorije.GetById<Model.Kategorije>(dogadjaj.KategorijeId);

            if (kategorije.Naziv == "Saobraćaj" && dogadjaj.KategorijeId == kategorije.Id)
            {
                frmDogadjajiDetaljiSaobracaj frm = new frmDogadjajiDetaljiSaobracaj(int.Parse(idObj.ToString()));
                frm.Show();
            }

            if (kategorije.Naziv == "Kriminal" && dogadjaj.KategorijeId == kategorije.Id)
            {
                frmDogadjajDetaljiKriminal frm = new frmDogadjajDetaljiKriminal(int.Parse(idObj.ToString()));
                frm.Show();
            }

            if (dogadjaj.KategorijeId == 3)
            {
                frmDogadjajDetalji frm = new frmDogadjajDetalji(int.Parse(idObj.ToString()));
                frm.Show();
            }

            if (kategorije.Naziv == "Ostali događaji" && dogadjaj.KategorijeId == kategorije.Id)
            {
                frmDogadjajDetalji frm = new frmDogadjajDetalji(int.Parse(idObj.ToString()));
                frm.Show();
            }

        }
        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            frmDodajDogadjaj frm = new frmDodajDogadjaj();
            frm.Show();
        }


        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                DatumDogadjajaOD = dtpDatumDogadjajaOD.Value,
                DatumDogadjajaDO = dtpDatumDogadjajaDO.Value
            };

            await LoadDataGridView(searchRequest);
        }
    }
}
