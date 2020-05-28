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
    public partial class frmDodajPodorganizacionuJedinicu : Form
    {

        private readonly APIService _podorganizacione = new APIService("PodorganizacionaJedinica");
        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");

        public frmDodajPodorganizacionuJedinicu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void frmDodajPodorganizacionuJedinicu_Load(object sender, EventArgs e)
        {
            await LoadOrganizacioneJedinice();
        }

        private async Task LoadOrganizacioneJedinice()
        {
            var result = await _organizacione.Get<List<Model.OrganizacionaJedinica>>(null);
            result.Insert(0, new Model.OrganizacionaJedinica());
            cmbOrgJed.DisplayMember = "Naziv";
            cmbOrgJed.ValueMember = "Id";
            cmbOrgJed.DataSource = result;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            PodorganizacionaJedinicaUpsertRequest request = new PodorganizacionaJedinicaUpsertRequest();

            var idObj = cmbOrgJed.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                request.OrganizacionaJedinicaId = id;
            }

            request.Naziv = txtPodorgJed.Text;

            await _podorganizacione.Insert<Model.PodorganizacionaJedinica>(request);

            MessageBox.Show("Podorganizaciona jedinica uspješno dodana !");
        }
    }
}
