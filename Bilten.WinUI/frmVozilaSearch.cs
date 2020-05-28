using Bilten.Model;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.Vozila;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
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
    public partial class frmVozilaSearch : Form
    {
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _vozilaDogadjajiDetalji = new APIService("VozilaDogadjajDetalji");
        private readonly APIService _dogadjajiDetalji = new APIService("DogadjajDetalji");


        private int? _Id = null;

        public frmVozilaSearch(int? dogadjajDetaljiId=null)
        {
            InitializeComponent();
            _Id = dogadjajDetaljiId;
        }

        private async void btnPrikaziVozila_Click(object sender, EventArgs e)
        {
            var request = new VozilaSearchRequest()
            {
                BrRegOznake=txtBrRegOznake.Text.Trim()
            };

            var list = await _vozila.Get<List<Model.Vozila>>(request);

            dgvVozila.AutoGenerateColumns = true;
            dgvVozila.DataSource = list;

            if (dgvVozila.ColumnCount == 4)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Akcija";
                button.Name = "dodajVozilo";
                button.Text = "Dodaj vozilo";
                button.UseColumnTextForButtonValue = true;
                button.FlatStyle = FlatStyle.Flat;

                dgvVozila.Columns.Add(button);
            }
            
        }

        private async void frmVozilaSearch_Load(object sender, EventArgs e)
        {

            var list = await _vozila.Get<List<Model.Vozila>>(null);
            
            dgvVozila.DataSource = list;

            if (dgvVozila.ColumnCount == 4)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Dodaj vozilo";
                button.Name = "dodajVozilo";
                button.Text = "Dodaj vozilo";
                button.UseColumnTextForButtonValue = true;
                dgvVozila.Columns.Add(button);
            }
        }

        private async void dgvVozila_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                
                var requestSearch = new VozilaDogadjajDetaljiSearchRequest()
                {
                    DogadjajDetaljiId = _Id,
                    VoziloId=int.Parse(dgvVozila.CurrentRow.Cells["Id"].FormattedValue.ToString())
                };
                var vozilaDogadjajDetalji = await _vozilaDogadjajiDetalji.Get<List<VozilaDogadjajDetalji>>(requestSearch);
                foreach (var item in vozilaDogadjajDetalji)
                {
                        if (item.DogadjajDetaljiId == _Id && item.VoziloId == int.Parse(dgvVozila.CurrentRow.Cells["Id"].FormattedValue.ToString()))
                        {
                           MessageBox.Show("Vozilo vec postoji na dogadjaju");
                           Close();
                            throw new Exception("Vozilo vec postoji na dogadjaju");
                        }
                    
                }
                
                    var request = new VozilaDogadjajDetaljiUpsertRequest()
                    {
                        DogadjajDetaljiId = _Id.Value,
                        VoziloId = int.Parse(dgvVozila.CurrentRow.Cells["Id"].FormattedValue.ToString())
                    };

                    await _vozilaDogadjajiDetalji.Insert<VozilaDogadjajDetalji>(request);
                    MessageBox.Show("Vozilo dodano");
                

                
            }
        }
    }
}
