using Bilten.Model.Requests.OrganizacionaJedinica;
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
    public partial class frmDodajOrganizacionuJedinicu : Form
    {

        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");

        public frmDodajOrganizacionuJedinicu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new OrganizacionaJedinicaUpsertRequest();

            request.Naziv = txtOrganizacionaJedinica.Text;

            await _organizacione.Insert<Model.OrganizacionaJedinica>(request);

            MessageBox.Show("Organizaciona jedinica uspješno dodana !");
        }
    }
}
