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

namespace Bilten.WinUI.FormaOperater
{
    public partial class frmOperaterIndex : Form
    {
        APIService _service = new APIService("Korisnici");

        private readonly int? _korisnikId = null;
        public frmOperaterIndex(int? korisnikId = null)
        {
            InitializeComponent();
            _korisnikId = korisnikId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDogadjaj frm = new frmDogadjaj();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDodajDogadjaj frm = new frmDodajDogadjaj();
            frm.Show();
        }

        private async void frmOperaterIndex_Load(object sender, EventArgs e)
        {
            var korisnik = await _service.GetById<Model.Korisnici>(_korisnikId);

            labelLogovanKorisnik.Text = korisnik.KorisnickoIme;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDogadjajiSaobracaj frm = new frmDogadjajiSaobracaj();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDogadjajiKriminal frm = new frmDogadjajiKriminal();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmDogadjajiNJRIM frm = new frmDogadjajiNJRIM();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmGoogleMapaDogadjaja frm = new frmGoogleMapaDogadjaja();
            frm.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVideoStream frm = new frmVideoStream();
            frm.Show();
        }

        private void btnFaceDetectionRecognition_Click(object sender, EventArgs e)
        {
            frmFaceDetectionRecognition frm = new frmFaceDetectionRecognition();
            frm.Show();
        }
    }
}
