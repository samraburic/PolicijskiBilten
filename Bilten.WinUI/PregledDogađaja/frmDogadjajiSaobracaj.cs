using Bilten.Model.Requests.Dogadjaj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.PregledDogađaja
{
    public partial class frmDogadjajiSaobracaj : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");

        public frmDogadjajiSaobracaj()
        {
            InitializeComponent();
        }

        private async void frmDogadjajiSaobracaj_Load(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                KategorijeId = 2
            };
            await LoadDataGridView(searchRequest);
        }

        private async Task LoadDataGridView(DogadjajSearchRequest searchRequest = null)
        {

            var list = await _dogadjaji.Get<List<Bilten.Model.Dogadjaj>>(searchRequest);
            dgvDogadjaji.AutoGenerateColumns = false;
            dgvDogadjaji.DataSource = list;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                KategorijeId = 2,
                DatumDogadjajaOD = dtpDatumDogadjajaOD.Value,
                DatumDogadjajaDO = dtpDatumDogadjajaDO.Value
            };

            await LoadDataGridView(searchRequest);
        }
    }
}
