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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKategorije frm = new frmKategorije();
            frm.Show();
        }

        private void pregledVrstaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVrste frm = new frmVrste();
            frm.Show();
        }

        private void pregledDogađajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDogadjaj frm = new frmDogadjaj();
            frm.Show();
        }

        private void dodajDogađajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajDogadjaj frm = new frmDodajDogadjaj();
            frm.Show();
        }

        private void pregledMjeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMjere frm = new frmMjere();
            frm.Show();
        }

        private void dodajMjeruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajMjeru frm = new frmDodajMjeru();
            frm.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dodajNovuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKategoriju frm = new frmDodajKategoriju();
            frm.Show();
        }

        private void dodajNovuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDodajVrstu frm = new frmDodajVrstu();
            frm.Show();
        }

        private void pregledOsobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOsobe frm = new frmOsobe();
            frm.Show();
        }

        private void dodajNovuOsobuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajOsobu frm = new frmDodajOsobu();
            frm.Show();
        }

        private void pregledVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVozila frm = new frmVozila();
            frm.Show();
        }

        private void dodajVoziloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajVozilo frm = new frmDodajVozilo();
            frm.Show();
        }

        private void pregledOrganizacionihJedinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrganizacionaJedinica frm = new frmOrganizacionaJedinica();
            frm.Show();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {


        }

        private void pregledPodorganizacionihJedinicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPodorganizacionaJedinica frm = new frmPodorganizacionaJedinica();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void dodajKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDodajKorisnika frm = new frmDodajKorisnika();
            frm.Show();
        }
    }
}
