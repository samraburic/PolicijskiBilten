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
    public partial class frmOrganizacionaJedinicaDetalji : Form
    {

        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");
        private int? _Id = null;

        public frmOrganizacionaJedinicaDetalji(int? orgJedId=null)
        {
            InitializeComponent();
            _Id = orgJedId;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void frmOrganizacionaJedinicaDetalji_Load(object sender, EventArgs e)
        {
            if (_Id.HasValue)
            {
                var organizacionaJedinica = await _organizacione.GetById<Model.OrganizacionaJedinica>(_Id);
                txtNaziv.Text = organizacionaJedinica.Naziv;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new OrganizacionaJedinicaUpsertRequest
            {
                Naziv=txtNaziv.Text
            };

            await _organizacione.Update<Model.OrganizacionaJedinica>(_Id.Value, request);

            MessageBox.Show("Organizaciona jedinica uspješno izmjenjena !");
        }
    }
}
