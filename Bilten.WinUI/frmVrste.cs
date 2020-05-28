using Bilten.Model.Requests;
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
    public partial class frmVrste : Form
    {
        private readonly APIService _vrste = new APIService("Vrste");
        private readonly APIService _kategorije = new APIService("Kategorije");

        public frmVrste()
        {
            InitializeComponent();
        }

        private async void frmVrste_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
        }

        private async Task LoadKategorije()
        {
            var list = await _kategorije.Get<List<Bilten.Model.Kategorije>>(null);
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.ValueMember = "Id";
            cmbKategorije.DataSource = list;
        }

        private void dgvVrste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {
            //var list = await _apiService.Get<List<Bilten.Model.Vrste>>();

            //dgvVrste.AutoGenerateColumns = false;

            //dgvVrste.DataSource = list;
        }

        private async void btnPrikazi_Click_1(object sender, EventArgs e)
        {
            //var search = new VrsteSearchRequest()
            //{
            //    Naziv = txtPretraga.Text
            //};

            //var list = await _apiService.Get<List<Model.Vrste>>(search);

            //dgvVrste.AutoGenerateColumns = false;

            //dgvVrste.DataSource = list;
        }

        private async void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorije.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVrste(id);
            }
        }

        private async Task LoadVrste(int kategorijaId)
        {
            var list = await _vrste.Get<List<Model.Vrste>>(new VrsteSearchRequest()
            { 
                KategorijeId = kategorijaId
            });
            dgvVrste.AutoGenerateColumns = false;
            dgvVrste.DataSource = list;
        }

        private void dgvVrste_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvVrste.SelectedRows[0].Cells[0].Value;

            frmVrsteDetalji frm = new frmVrsteDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            frmDodajVrstu frm = new frmDodajVrstu();
            frm.Show();
        }
    }
}
