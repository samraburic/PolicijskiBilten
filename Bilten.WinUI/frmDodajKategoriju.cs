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
    public partial class frmDodajKategoriju : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        public frmDodajKategoriju()
        {
            InitializeComponent();
        }

        KategorijeUpsertRequest request = new KategorijeUpsertRequest();

        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNazivKategorije.Text;

            await _kategorije.Insert<Model.Kategorije>(request);

            MessageBox.Show("Kategorija uspješno dodana !");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDodajKategoriju_Load(object sender, EventArgs e)
        {

        }
    }
}
