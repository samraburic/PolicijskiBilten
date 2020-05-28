using Bilten.Model.Requests.PodorganizacionaJedinica;
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
    public partial class frmPodorganizacionaJedinica : Form
    {
        private readonly APIService _podorganizacione = new APIService("PodorganizacionaJedinica");
        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");

        public frmPodorganizacionaJedinica()
        {
            InitializeComponent();
        }

        private async void frmPodorganizacionaJedinica_Load(object sender, EventArgs e)
        {
            await LoadOrganizacioneJedinice();
        }

        private async Task LoadOrganizacioneJedinice()
        {
            var list = await _organizacione.Get<List<Model.OrganizacionaJedinica>>(null);
            cmbOrganizacionaJedinica.DisplayMember = "Naziv";
            cmbOrganizacionaJedinica.ValueMember = "Id";
            cmbOrganizacionaJedinica.DataSource = list;
        }

        private async void cmbOrganizacionaJedinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbOrganizacionaJedinica.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadPodorganizacioneJedinice(id);
            }
        }

        private async Task LoadPodorganizacioneJedinice(int organizacionaJedinicaId)
        {
            var list = await _podorganizacione.Get<List<Model.PodorganizacionaJedinica>>(new PodorganizacionaJedinicaSearchRequest()
            {
                OrganizacionaJedinicaId = organizacionaJedinicaId
            });

            dgvPodorganizacioneJedinice.AutoGenerateColumns = false;
            dgvPodorganizacioneJedinice.DataSource = list;
        }

        private void dgvPodorganizacioneJedinice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvPodorganizacioneJedinice.SelectedRows[0].Cells[0].Value;

            frmPodorganizacionaJedinicaDetalji frm = new frmPodorganizacionaJedinicaDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void btnDodajPodorgJed_Click(object sender, EventArgs e)
        {
            frmDodajPodorganizacionuJedinicu frm = new frmDodajPodorganizacionuJedinicu();
            frm.Show();
          
        }
    }
}
