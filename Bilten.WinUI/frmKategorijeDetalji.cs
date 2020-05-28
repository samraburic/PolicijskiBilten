using Bilten.Model.Requests.Kategorije;
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
    public partial class frmKategorijeDetalji : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");


        private int? _Id = null;
        public frmKategorijeDetalji(int? kategorijaId = null)
        {
            InitializeComponent();
            _Id = kategorijaId;
        }

        private async void frmKategorijeDetalji_Load(object sender, EventArgs e)
        {
            if (_Id.HasValue)
            {
                var kategorija = await _kategorije.GetById<Model.Kategorije>(_Id);

                txtNazivKategorije.Text = kategorija.Naziv;

            }
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new KategorijeUpsertRequest
            {
                Naziv = txtNazivKategorije.Text
            };

            await _kategorije.Update<Model.Kategorije>(_Id.Value, request);

            MessageBox.Show("Kategorija uspješno izmjenjena !");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
