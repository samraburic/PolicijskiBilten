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
    public partial class frmPodorganizacionaJedinicaDetalji : Form
    {

        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");
        private readonly APIService _podorganizacione = new APIService("PodorganizacionaJedinica");

        private int? _Id = null;

        public frmPodorganizacionaJedinicaDetalji(int? podorganizacionaJedinicaId=null)
        {
            InitializeComponent();
            _Id = podorganizacionaJedinicaId;
        }

        private async void frmPodorganizacionaJedinicaDetalji_Load(object sender, EventArgs e)
        {
            if (_Id.HasValue)
            {
                var podorgJed = await _podorganizacione.GetById<Model.PodorganizacionaJedinica>(_Id);
                var orgJed = await _organizacione.GetById<Model.OrganizacionaJedinica>(podorgJed.OrganizacionaJedinicaId);

                txtOrgJedId.Text = orgJed.Id.ToString();

                txtOrganizacionaJedinica.Text = orgJed.Naziv;
                txtPodorganizacionaJedinica.Text = podorgJed.Naziv;
            
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            PodorganizacionaJedinicaUpsertRequest request = new PodorganizacionaJedinicaUpsertRequest()
            {
                Naziv=txtPodorganizacionaJedinica.Text,
                OrganizacionaJedinicaId=int.Parse(txtOrgJedId.Text)

            };

            await _podorganizacione.Update<Model.PodorganizacionaJedinica>(_Id.Value, request);
            MessageBox.Show("Podorganizaciona jedinica uspješno uređena !");
        }
    }
}
