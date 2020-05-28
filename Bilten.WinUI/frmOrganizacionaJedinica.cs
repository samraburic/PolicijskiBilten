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
    public partial class frmOrganizacionaJedinica : Form
    {
        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");

        public frmOrganizacionaJedinica()
        {
            InitializeComponent();
        }

        private async void frmOrganizacionaJedinica_Load(object sender, EventArgs e)
        {
            await LoadOrganizacioneJedinice();
        }
         
        private async Task LoadOrganizacioneJedinice()
        {
            var result = await _organizacione.Get<List<Model.OrganizacionaJedinica>>(null);

            dgvOrganizacioneJed.AutoGenerateColumns = false;
            dgvOrganizacioneJed.DataSource = result;
        }

        private void btnDodajOrgJed_Click(object sender, EventArgs e)
        {
            frmDodajOrganizacionuJedinicu frm = new frmDodajOrganizacionuJedinicu();
            frm.Show();
        }

        private void dgvOrganizacioneJed_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orgJedId = int.Parse(dgvOrganizacioneJed.SelectedRows[0].Cells[0].Value.ToString());

            frmOrganizacionaJedinicaDetalji frm = new frmOrganizacionaJedinicaDetalji(orgJedId);
            frm.Show();
        }
        
    }
}
