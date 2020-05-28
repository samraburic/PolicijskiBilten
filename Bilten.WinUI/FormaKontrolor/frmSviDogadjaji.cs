using Bilten.Model.Requests;
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

namespace Bilten.WinUI.FormaKontrolor
{
    public partial class frmSviDogadjaji : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        public frmSviDogadjaji()
        {
            InitializeComponent();
        }

        private async void frmSviDogadjaji_Load(object sender, EventArgs e)
        {
            await LoadDataGridView(null);
        }

        private async Task LoadDataGridView(DogadjajSearchRequest searchRequest = null)
        {

            var list = await _dogadjaji.Get<List<Bilten.Model.Dogadjaj>>(searchRequest);
            dgvSviDogadjaji.AutoGenerateColumns = false;
            
            dgvSviDogadjaji.DataSource = list;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var searchRequest = new DogadjajSearchRequest()
            {
                DatumDogadjaja = dtpDatumDogadjaja.Value
            };

            await LoadDataGridView(searchRequest);
        }

        private async Task IsOdabran(bool odabran = false)
        {
            var Id = dgvSviDogadjaji.SelectedRows[0].Cells[0].Value;

            var list = await _dogadjaji.GetById<Model.Dogadjaj>(int.Parse(Id.ToString()));

            var request = new DogadjajUpsertRequest()
            {
                KategorijeId = list.KategorijeId,
                VrsteId = list.VrsteId,
                OrganizacionaJedinicaId = list.OrganizacionaJedinicaId,
                PodorganizacionaJedinicaId = list.PodorganizacionaJedinicaId,
                DatumDogadjaja = list.DatumDogadjaja,
                DatumPrijave = list.DatumPrijave,
                Opis = list.Opis,
                MjestoDogadjaja = list.MjestoDogadjaja,
                Prijavitelj = list.Prijavitelj,
                Latituda = list.Latituda,
                Longituda = list.Longituda,
                Odabran = odabran
            };


            await _dogadjaji.Update<Model.Dogadjaj>(list.Id, request);

        }

        private async void dgvSviDogadjaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(e.ColumnIndex == 13)
            {
                if ((bool)this.dgvSviDogadjaji.CurrentCell.Value == true)
                {
                    await IsOdabran(false);

                    MessageBox.Show("Događaj izbrisan sa zvaničnog biltena!", "Događaj izbrisan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    frmSviDogadjaji_Load(sender, e);
                }

                if((bool)this.dgvSviDogadjaji.CurrentCell.Value == false) 
                {
                    await IsOdabran(true);

                    MessageBox.Show("Događaj dodan u zvanični bilten !", "Događaj dodan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmSviDogadjaji_Load(sender, e);
                }
             
            }
        }
    }
}
