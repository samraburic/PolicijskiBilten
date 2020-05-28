using Bilten.Model.Requests.Osoba;
using Bilten.Model.Requests.OsobeDogadjajDetalji;
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
    public partial class frmOsobeSearch : Form
    {
        private readonly APIService _osobe = new APIService("Osoba");
        private readonly APIService _osobeDogadjajiDetalji = new APIService("OsobeDogadjajDetalji");
        private readonly APIService _dogadjajiDetalji = new APIService("DogadjajDetalji");

        private int? _Id = null;

        public frmOsobeSearch(int? dogadjajdetaljiId = null)
        {
            InitializeComponent();
            _Id = dogadjajdetaljiId;
        }

        private async void frmOsobeSearch_Load(object sender, EventArgs e)
        {
            var osobe = await _osobe.Get<List<Model.Osoba>>(null);

            dgvOsobe.DataSource = osobe;

            if (dgvOsobe.ColumnCount == 6)
            {
                DataGridViewButtonColumn button = new DataGridViewButtonColumn();
                button.HeaderText = "Akcija";
                button.Name = "dodajOsobu";
                button.Text = "Dodaj osobu";
                button.UseColumnTextForButtonValue = true;
                dgvOsobe.Columns.Add(button);
            }
        }

        private async void txtPrikazi_Click(object sender, EventArgs e)
        {
            var osobaIme = await _osobe.Get<List<Model.Osoba>>(new OsobaSearchRequest()
            {
                Ime = txtPretraga.Text
            });
            if (osobaIme.Count > 0)
            {
                dgvOsobe.DataSource = osobaIme;
            }

            var osobaPrezime = await _osobe.Get<List<Model.Osoba>>(new OsobaSearchRequest()
            {
                Prezime = txtPretraga.Text
            });
            if (osobaPrezime.Count > 0)
            {
                dgvOsobe.DataSource = osobaPrezime;
            }

            var osobaJmbg = await _osobe.Get<List<Model.Osoba>>(new OsobaSearchRequest()
            {
                Jmbg = txtPretraga.Text
            });
            if (osobaJmbg.Count > 0)
            {
                dgvOsobe.DataSource = osobaJmbg;
            }

            var osobaBrLicneKarte = await _osobe.Get<List<Model.Osoba>>(new OsobaSearchRequest()
            {
                BrLicneKarte = txtPretraga.Text
            });
            if (osobaBrLicneKarte.Count > 0)
            {
                dgvOsobe.DataSource = osobaBrLicneKarte;
            }

        }

        private async void dgvOsobe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {

                var requestSearch = new OsobeDogadjajDetaljiSearchRequest()
                {
                    DogadjajDetaljiId = _Id,
                    OsobaId = int.Parse(dgvOsobe.CurrentRow.Cells["Id"].FormattedValue.ToString())
                };

                var osobeDogadjajDetalji = await _osobeDogadjajiDetalji.Get<List<Model.OsobeDogadjajDetalji>>(requestSearch);

                foreach (var item in osobeDogadjajDetalji)
                {
                    if (item.DogadjajDetaljiId == _Id && item.OsobaId == int.Parse(dgvOsobe.CurrentRow.Cells["Id"].FormattedValue.ToString()))
                    {
                        MessageBox.Show("Osoba vec postoji na dogadjaju");
                        Close();
                        throw new Exception("Osoba vec postoji na dogadjaju");
                    }

                }

                var request = new OsobeDogadjajDetaljiUpsertRequest()
                {
                    DogadjajDetaljiId = _Id.Value,
                    OsobaId = int.Parse(dgvOsobe.CurrentRow.Cells["Id"].FormattedValue.ToString())
                };

                await _osobeDogadjajiDetalji.Insert<Model.OsobeDogadjajDetalji>(request);
                MessageBox.Show("Osoba dodana");


            }
        }
    }
}
