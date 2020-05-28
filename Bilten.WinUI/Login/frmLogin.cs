using Bilten.Model.Requests.Korisnici;
using Bilten.WinUI.FormaKontrolor;
using Bilten.WinUI.FormaOperater;
using Bilten.WinUI.FormaPolicajac;
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
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("Korisnici");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;

            try
            {
               await _service.Get<dynamic>(null);

                //frmIndex frm = new frmIndex();
                //frm.Show();
                var request = new KorisniciSearchRequest()
                {
                    Username = txtUsername.Text
                };

                var korisnik = await _service.Get<List<Model.Korisnici>>(request);

                foreach (var item in korisnik)
                {
                    if (item.VrstaKorisnika.Naziv == "Operater")
                    {
                        frmOperaterIndex frm1 = new frmOperaterIndex(item.Id);
                        frm1.Show();
                    }
                }

                foreach (var item in korisnik)
                {
                    if (item.VrstaKorisnika.Naziv == "Administrator")
                    {
                        Form1 frm = new Form1();
                        frm.Show();
                    }
                }

                foreach (var item in korisnik)
                {
                    if (item.VrstaKorisnika.Naziv == "Policajac")
                    {
                        frmPolicajacIndex frm = new frmPolicajacIndex(item.Id);
                        frm.Show();
                        this.Hide();
                    }
                }

                foreach (var item in korisnik)
                {
                    if (item.VrstaKorisnika.Naziv == "Kontrolor")
                    {
                        frmKontrolorIndex frm = new frmKontrolorIndex(item.Id);
                        frm.Show();
                    }
                }


            }
                catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Authentikacija", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
