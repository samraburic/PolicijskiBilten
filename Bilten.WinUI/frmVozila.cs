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
    public partial class frmVozila : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");
        public frmVozila()
        {
            InitializeComponent();
        }

        private async void frmVozila_Load(object sender, EventArgs e)
        {
            await LoadVozila();
        }

        private async Task LoadVozila()
        {
            var result = await _vozila.Get<List<Model.Vozila>>(null);

            dgvVozila.AutoGenerateColumns = false;

            dgvVozila.DataSource = result;
        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            frmDodajVozilo frm = new frmDodajVozilo();
            frm.Show();
        }

        private void dgvVozila_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvVozila.SelectedRows[0].Cells[0].Value;

            frmVozilaDetalji frm = new frmVozilaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
