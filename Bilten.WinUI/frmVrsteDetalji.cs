using Bilten.Model.Requests.Vrste;
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
    public partial class frmVrsteDetalji : Form
    {
        private readonly APIService _vrste = new APIService("Vrste");
        private readonly APIService _kategorije = new APIService("Kategorije");

        private int? _Id = null;
        public frmVrsteDetalji(int? vrstaId = null)
        {
            InitializeComponent();
            _Id = vrstaId;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void frmVrsteDetalji_Load(object sender, EventArgs e)
        {
            if(_Id.HasValue)
            {
                var vrsta = await _vrste.GetById<Model.Vrste>(_Id);
                var kategorija = await _kategorije.GetById<Model.Kategorije>(vrsta.KategorijeId);

                txtKategorijaId.Text = vrsta.KategorijeId.ToString();

                txtNazivVrste.Text = vrsta.Naziv;
                txtNazivKategorije.Text = kategorija.Naziv;
            }

            
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            VrsteUpsertRequest request = new VrsteUpsertRequest() 
            { 
                Naziv = txtNazivVrste.Text,
                KategorijeId = int.Parse(txtKategorijaId.Text)
            };

            await _vrste.Update<Model.Vrste>(_Id.Value, request);

            MessageBox.Show("Vrsta uspješno uređena !");
        }
    }
}
