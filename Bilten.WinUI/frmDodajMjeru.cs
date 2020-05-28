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
    public partial class frmDodajMjeru : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _mjere = new APIService("Mjere");
        public frmDodajMjeru()
        {
            InitializeComponent();
        }

        private async void frmDodajMjeru_Load(object sender, EventArgs e)
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

        MjereUpsertRequest request = new MjereUpsertRequest();

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var idObj = cmbKategorije.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int kategorijaId))
            {
                request.KategorijeId = kategorijaId;
            }

            request.Opis = txtOpisMjere.Text;

            await _mjere.Insert<Model.Mjere>(request);

            MessageBox.Show("Mjera uspješno dodana !");
        }

    }
}
