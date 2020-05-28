using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bilten.WinUI;

namespace Bilten.WinUI.FormaKontrolor
{
    public partial class frmKontrolorIndex : Form
    {
        APIService _service = new APIService("Korisnici");

        private readonly int? _korisnikId = null;
        public frmKontrolorIndex(int? korisnikId = null)
        {
            InitializeComponent();
            _korisnikId = korisnikId;
        }

        private void btnSviDogadjaji_Click(object sender, EventArgs e)
        {
            frmSviDogadjaji frm = new frmSviDogadjaji();
            frm.Show();
        }

        private async void frmKontrolorIndex_Load(object sender, EventArgs e)
        {
            var korisnik = await _service.GetById<Model.Korisnici>(_korisnikId);

            labelLogovanKorisnik.Text = korisnik.KorisnickoIme;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            frmZvanicniBilten frm = new frmZvanicniBilten();
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
