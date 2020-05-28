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
    public partial class frmDogadjajiNJRIM : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");

        public frmDogadjajiNJRIM()
        {
            InitializeComponent();
        }

        private async void frmDogadjajiNJRIM_Load(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                KategorijeId = 3
            };
            await LoadDataGridView(searchRequest);
        }

        private async Task LoadDataGridView(DogadjajSearchRequest searchRequest = null)
        {

            var list = await _dogadjaji.Get<List<Bilten.Model.Dogadjaj>>(searchRequest);
            dgvDogadjajiNJRIM.AutoGenerateColumns = false;
            dgvDogadjajiNJRIM.DataSource = list;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                KategorijeId = 3,
                DatumDogadjajaOD = dtpDatumDogadjajaOD.Value,
                DatumDogadjajaDO = dtpDatumDogadjajaDO.Value
            };

            await LoadDataGridView(searchRequest);
        }
    }
}
