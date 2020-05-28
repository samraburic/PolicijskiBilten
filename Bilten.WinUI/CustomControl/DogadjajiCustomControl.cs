using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI
{
    public partial class DogadjajiCustomControl : UserControl
    {
        public DogadjajiCustomControl()
        {
            InitializeComponent();
        }

        private void btnPregledDogadjaja_Click(object sender, EventArgs e)
        {
            frmDogadjaj frm = new frmDogadjaj();
            frm.Show();
        }

        private void btnDodajDogadjaj_Click(object sender, EventArgs e)
        {
            frmDodajDogadjaj frm = new frmDodajDogadjaj();
            frm.Show();
        }
    }
}
