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
    public partial class frmOsobe : Form
    {
        private readonly APIService _osobe = new APIService("Osoba");
        public frmOsobe()
        {
            InitializeComponent();
        }

        private async void frmOsobe_Load(object sender, EventArgs e)
        {
            await LoadOsobe();
        }

        private async Task LoadOsobe()
        {
            var result = await _osobe.Get<List<Model.Osoba>>(null);

            dgvOsobe.AutoGenerateColumns = false;
            dgvOsobe.DataSource = result;
        }

        private void btnDodajOsobu_Click(object sender, EventArgs e)
        {
            frmDodajOsobu frm = new frmDodajOsobu();
            frm.Show();
        }

        private void dgvOsobe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvOsobe.SelectedRows[0].Cells[0].Value;

            frmOsobaDetalji frm = new frmOsobaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }
    }
}
