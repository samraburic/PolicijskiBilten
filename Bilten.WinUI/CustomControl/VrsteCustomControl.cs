using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI.CustomControl
{
    public partial class VrsteCustomControl : UserControl
    {
        public VrsteCustomControl()
        {
            InitializeComponent();
        }

        private void btnPregledVrsta_Click(object sender, EventArgs e)
        {
            frmVrste frm = new frmVrste();
            frm.Show();
        }

        private void btnDodajVrstu_Click(object sender, EventArgs e)
        {
            frmDodajVrstu frm = new frmDodajVrstu();
            frm.Show();
        }
    }
}
