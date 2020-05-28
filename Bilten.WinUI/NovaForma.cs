using Bilten.Model.Requests;
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
    public partial class NovaForma : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");

        public NovaForma()
        {
            InitializeComponent();
        }


        private async void NovaForma_Load(object sender, EventArgs e)
        {
            await LoadKategorije();
        }

        private async Task LoadKategorije()
        {
            var result = await _kategorije.Get<List<Model.Kategorije>>(null);
            result.Insert(0, new Model.Kategorije());
            comboKategorije.DisplayMember = "Naziv";
            comboKategorije.ValueMember = "Id";
            comboKategorije.DataSource = result;
        }


        private async void comboKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = comboKategorije.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVrste(id);
            }
        }

        private async Task LoadVrste(int kategorijaId)
        {
            var result = await _vrste.Get<List<Model.Vrste>>(new VrsteSearchRequest()
            {
                KategorijeId = kategorijaId
            });

            comboVrste.DisplayMember = "Naziv";
            comboVrste.ValueMember = "Id";
            comboVrste.DataSource = result;
            gridVrste.DataSource = result;
        }
    }
}
