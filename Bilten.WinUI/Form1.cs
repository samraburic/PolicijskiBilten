using Bilten.WinUI.Korisnici;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogadjaji_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void btnDogadjaji_Click_1(object sender, EventArgs e)
        {
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dogadjajiCustomControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vrsteCustomControl1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            mjereCustomControl1.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.Show();
        }
    }
}
