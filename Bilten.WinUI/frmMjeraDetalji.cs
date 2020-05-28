using Bilten.Model.Requests.Mjere;
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
    public partial class frmMjeraDetalji : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _mjere = new APIService("Mjere");

        private int? _Id = null;

        public frmMjeraDetalji(int? mjeraId = null)
        {
            InitializeComponent();
            _Id = mjeraId;
        }

        private async void frmMjeraDetalji_Load(object sender, EventArgs e)
        {
            if(_Id.HasValue)
            {
                var mjera = await _mjere.GetById<Model.Mjere>(_Id);
                var kategorija = await _kategorije.GetById<Model.Kategorije>(mjera.KategorijeId);

                txtKategorijaId.Text = mjera.KategorijeId.ToString();

                txtKategorija.Text = kategorija.Naziv;
                txtOpisMjere.Text = mjera.Opis;
            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new MjereUpsertRequest
            {
                Opis = txtOpisMjere.Text,
                KategorijeId = int.Parse(txtKategorijaId.Text)
            };

            await _mjere.Update<Model.Mjere>(_Id.Value, request);

            MessageBox.Show("Mjera uspješno spašena !");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKategorijaId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
