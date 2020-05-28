using Bilten.WinUI.FormaOperater;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.Login
{

    public partial class MainForma : Form
    {

        private readonly APIService _korisnici = new APIService("Korisnici");

        private readonly int? _Id = null;
        public MainForma(int? id = null)
        {
            InitializeComponent();
            _Id = id;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var korisnik = await _korisnici.GetById<Model.Korisnici>(_Id.Value);

            frmOperaterIndex frm = new frmOperaterIndex(korisnik.Id);
            frm.Show();
        }
    }
}
