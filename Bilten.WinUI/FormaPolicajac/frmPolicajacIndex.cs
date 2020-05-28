using Bilten.WinUI.Login;
using Bilten.WinUI.PregledDogađaja;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.FormaPolicajac
{
    public partial class frmPolicajacIndex : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        APIService _service = new APIService("Korisnici");

        private readonly int? _korisnikId = null;
        public frmPolicajacIndex(int? korisnikId = null)
        {
            InitializeComponent();

            _korisnikId = korisnikId;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var kategorije = await _kategorije.Get<List<Model.Kategorije>>(null);

            foreach (var item in kategorije)
            {
                if(item.Naziv == "Saobraćaj")
                {
                    frmDodajDogadjaj frm = new frmDodajDogadjaj(item.Id);
                    frm.Show();
                }
            }

           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private async void frmPolicajacIndex_Load(object sender, EventArgs e)
        {
            var korisnik = await _service.GetById<Model.Korisnici>(_korisnikId);

            labelLogovanKorisnik.Text = korisnik.KorisnickoIme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDogadjajiSaobracaj frm = new frmDogadjajiSaobracaj();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGoogleMapaDogadjaja frm = new frmGoogleMapaDogadjaja();
            frm.Show();
        }
    }
}
