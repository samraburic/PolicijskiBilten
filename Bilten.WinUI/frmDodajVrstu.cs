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
    public partial class frmDodajVrstu : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");
        public frmDodajVrstu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void frmDodajVrstu_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
        }

        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            result.Insert(0, new Model.Kategorije());
            cmbKategorije.DisplayMember = "Naziv";
            cmbKategorije.ValueMember = "Id";
            cmbKategorije.DataSource = result;

        }


        private async void btnSacuvaj_Click(object sender, EventArgs e)
        {

            VrsteUpsertRequest request = new VrsteUpsertRequest();

            var idObj = cmbKategorije.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                request.KategorijeId = id;
            }

            request.Naziv = txtNazivVrste.Text;

            await _vrste.Insert<Model.Vrste>(request);

            MessageBox.Show("Vrsta uspješno dodana !");
        }
    }
}
