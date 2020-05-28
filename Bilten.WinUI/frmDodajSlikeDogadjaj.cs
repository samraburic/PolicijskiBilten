using Bilten.Model.Requests.DogadjajSlike;
using Bilten.Model.Requests.Slike;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilten.WinUI
{
    public partial class frmDodajSlikeDogadjaj : Form
    {
        private readonly APIService _dogadjajSlike = new APIService("DogadjajSlike");
        private readonly APIService _slike = new APIService("Slike");

        private int? _Id = null;
        public frmDodajSlikeDogadjaj(int? dogadjajId=null)
        {
            InitializeComponent();
            _Id = dogadjajId;
        }

        private async void frmDodajSlikeDogadjaj_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImages = new DataGridViewImageColumn();
            dgvImages.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView.Columns.Add(dgvImages);

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowTemplate.Height = 200;
            dataGridView.AllowUserToAddRows = false;

            var list = await _dogadjajSlike.Get<List<Model.DogadjajSlike>>(new DogadjajSlikeSearchRequest()
            {
                DogadjajId=_Id
            });
            var slike = await _slike.Get<List<Model.Slike>>(null);
            foreach (var item in list)
            {
                foreach (var slika in slike)
                {
                    if (item.SlikaId == slika.Id)
                    {
                        dataGridView.Rows.Add(slika.Slika);
                    }
                }
            }

            //DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            //button.HeaderText = "Akcija";
            //button.Name = "Obrisi";
            //button.Text = "Obrisi";
            //button.UseColumnTextForButtonValue = true;
            //button.Width = 100;
            //dataGridView.Columns.Add(button);
        }

        private async void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);


                var slike = await _slike.Get<List<Model.Slike>>(new SlikeSearchRequest()
                {
                    SlikaName=fileName
                });
                var dogadjajSlike = await _dogadjajSlike.Get<List<Model.DogadjajSlike>>(new DogadjajSlikeSearchRequest()
                {
                    DogadjajId=_Id
                });
                int BrojSlikaUDogadjaju = 0;
                foreach (var slika in slike)
                {
                    foreach (var dogadjajSlika in dogadjajSlike)
                    {
                        if (slika.Id == dogadjajSlika.SlikaId)
                        {
                            BrojSlikaUDogadjaju++;
                        }
                    }
                }
                if (BrojSlikaUDogadjaju == 0)
                 {
                    var novaSlika = await _slike.Insert<Model.Slike>(new SlikeUpsertRequest()
                    {
                        Slika = file,
                        SlikaName=fileName
                    });
                    await _dogadjajSlike.Insert<Model.DogadjajSlike>(new DogadjajSlikeUpsertRequest()
                    {
                        DogadjajId=_Id.Value,
                        SlikaId=novaSlika.Id
                    });

                    Image image = Image.FromFile(fileName);
                    pictureBox.Image = image;

                    MessageBox.Show("Slika uspješno dodana !");

                    //frmDodajSlikeDogadjaj_Load(sender, e);

                    dataGridView.Rows.Add(image);

                    

                    dataGridView.Refresh();
                }
                else
                {
                    MessageBox.Show("Slika je vec dodana!");
                    this.Close();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 1)
            {
                var idObj = dataGridView.CurrentRow.Cells["dgvImages"].FormattedValue;

                MessageBox.Show(idObj.ToString());
            }
        }
    }
}
