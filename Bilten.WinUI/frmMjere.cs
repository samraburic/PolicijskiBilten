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
    public partial class frmMjere : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _mjere = new APIService("Mjere");
        public frmMjere()
        {
            InitializeComponent();
        }

        private void frmMjere_Load(object sender, EventArgs e)
        {
            LoadKategorije();
        }

        private async void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorije.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadMjere(id);
            }
            
        }
        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
           // result.Insert(0, new Model.Kategorije());
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.ValueMember = "Id";
            cmbKategorije.DataSource = result;
        }

        private async Task LoadMjere(int kategorijaId)
        {
            var result = await _mjere.Get<List<Bilten.Model.Mjere>>(new MjereSearchRequest()
            {
                KategorijeId = kategorijaId
            });

            dgvMjere.AutoGenerateColumns = false;

            dgvMjere.DataSource = result;
        }

        private void dgvMjere_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var mjeraId = int.Parse(dgvMjere.SelectedRows[0].Cells[0].Value.ToString());

            frmMjeraDetalji frm = new frmMjeraDetalji(mjeraId);
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var mjeraId = int.Parse(dgvMjere.SelectedRows[0].Cells[0].Value.ToString());

            _mjere.Delete<Model.Mjere>(mjeraId);

            MessageBox.Show("Mjera obrisana !");
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            frmDodajMjeru frm = new frmDodajMjeru();
            frm.Show();
        }
    }
}
