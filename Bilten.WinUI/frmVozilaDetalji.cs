using Bilten.Model.Requests.Vozila;
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
    public partial class frmVozilaDetalji : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");

        private int? _Id = null;
        public frmVozilaDetalji(int? voziloId = null)
        {
            InitializeComponent();
            _Id = voziloId;
        }

        private async void frmVozilaDetalji_Load(object sender, EventArgs e)
        {
            var vozilo = await _vozila.GetById<Model.Vozila>(_Id);

            txtMarka.Text = vozilo.Marka;
            txtModel.Text = vozilo.Model;
            txtBrRegOznake.Text = vozilo.BrRegOznake;
        }

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var request = new VozilaUpsertRequest()
            {
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                BrRegOznake = txtBrRegOznake.Text
            };

            await _vozila.Update<Model.Vozila>(_Id.Value, request);

            MessageBox.Show("Vozilo uspješno uređeno !");
        }
    }
}
