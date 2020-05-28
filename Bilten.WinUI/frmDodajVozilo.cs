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
    public partial class frmDodajVozilo : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");
        public frmDodajVozilo()
        {
            InitializeComponent();
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new VozilaUpsertRequest() 
            { 
                Marka = txtMarka.Text,
                Model = txtModel.Text,
                BrRegOznake = txtBrRegOznake.Text
            };

            await _vozila.Insert<Model.Vozila>(request);

            MessageBox.Show("Vozilo uspješno dodano !");
        }
    }
}
