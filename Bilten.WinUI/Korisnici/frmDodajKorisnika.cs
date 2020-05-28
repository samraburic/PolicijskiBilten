using Bilten.Model.Requests.Korisnici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.Korisnici
{
    public partial class frmDodajKorisnika : Form
    {
        private readonly APIService _korisnici = new APIService("Korisnici");
        private readonly APIService _vrstaKorisnika = new APIService("VrsteKorisnika");
        public frmDodajKorisnika()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void frmDodajKorisnika_Load(object sender, EventArgs e)
        {
            var vrste = await _vrstaKorisnika.Get<List<Model.VrstaKorisnika>>(null);
            vrste.Insert(0, new Model.VrstaKorisnika());
            cmbVrstaKorisnika.DisplayMember = "Naziv";
            cmbVrstaKorisnika.ValueMember = "Id";
            cmbVrstaKorisnika.DataSource = vrste;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _korisnici.Insert<Model.Korisnici>(new KorisniciUpsertRequest()
            {
                ImePrezime = txtImePrezime.Text,
                Jmbg = Convert.ToInt32(txtJMBG.Text),
                Email = txtEmail.Text,
                KorisnickoIme  = txtKorisnickoIme.Text,
                Password = txtPassword.Text,
                PasswordPotvrda = txtPotvrdaPassworda.Text,
                VrstaKorisnikaId = Convert.ToInt32(cmbVrstaKorisnika.SelectedValue)
            });

            MessageBox.Show("Korisnik " + txtKorisnickoIme.Text + " uspješno dodan !"," ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
