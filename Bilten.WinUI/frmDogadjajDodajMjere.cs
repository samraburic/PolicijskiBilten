using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajiMjere;
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
    public partial class frmDogadjajDodajMjere : Form
    {
        private readonly APIService _mjere = new APIService("Mjere");
        private readonly APIService _dogadjajiMjere = new APIService("DogadjajMjere");

        private int? _dogadjajId = null;
        private int? _kategorijaId = null;

        public frmDogadjajDodajMjere(int? dogadjajId = null, int? kategorijaId = null)
        {
            InitializeComponent();
            _dogadjajId = dogadjajId;
            _kategorijaId = kategorijaId;
        }

        private async void frmDogadjajDodajMjere_Load(object sender, EventArgs e)
        {
            txtDogadjajId.Text = _dogadjajId.ToString();
            txtKategorijaID.Text = _kategorijaId.ToString();

            await LoadMjere();
        }

        private async Task LoadMjere()
        {
            MjereSearchRequest request = new MjereSearchRequest()
            {
                KategorijeId = _kategorijaId
            };
            var list = await _mjere.Get<List<Model.Mjere>>(request);

            ((ListBox)clbMjere).DataSource = list;
            ((ListBox)clbMjere).DisplayMember = "Opis";
            ((ListBox)clbMjere).ValueMember = "Id";

            DogadjajiMjereSearchRequest DogMjere = new DogadjajiMjereSearchRequest()
            {
                DogadjajId = _dogadjajId.Value
            };

            var listDM = await _dogadjajiMjere.Get<List<Model.DogadjajMjere>>(DogMjere);
         

            if (clbMjere.Items.Count > 0)
            {
                for (int i = 0; i < clbMjere.Items.Count; i++)
                {
                    object clb = clbMjere.Items[i];

                    foreach (var item in listDM)
                    {
                        if ((clb as Model.Mjere).Id == item.MjeraId && item.MjeraPoduzeta == true)
                            clbMjere.SetItemChecked(i, true);
                    }

                }
            }
        }


        private async void btnDodaj_Click_1(object sender, EventArgs e)
        {
            DogadjajiMjereSearchRequest DogMjere = new DogadjajiMjereSearchRequest()
            {
                DogadjajId = _dogadjajId.Value
            };

            var listDM = await _dogadjajiMjere.Get<List<Model.DogadjajMjere>>(DogMjere);

            for (int i = 0; i < clbMjere.Items.Count; i++)
            {
                //object clb = clbMjere.Items[i];

                if(clbMjere.GetItemCheckState(i) == CheckState.Checked)
                {
                    object clb = clbMjere.Items[i];
                    var searchRequest = await _dogadjajiMjere.Get<List<Model.DogadjajMjere>>(new DogadjajiMjereSearchRequest()
                    {
                        DogadjajId = _dogadjajId.Value,
                        MjeraId = (clb as Model.Mjere).Id
                    });

                    if (searchRequest.Count == 0)
                    {
                            //object clb = clbMjere.Items[i];

                            await _dogadjajiMjere.Insert<Model.DogadjajMjere>(new DogadjajiMjereUpsertRequest()
                            {
                                DogadjajId = _dogadjajId.Value,
                                MjeraId = (clb as Model.Mjere).Id,
                                MjeraPoduzeta = true
                            });

                            //MessageBox.Show("Mjera " + (clb as Model.Mjere).Opis + " dodana !");
                    }

                    if (searchRequest.Count == 1)
                    {
                        //object clb = clbMjere.Items[i];
                        foreach (var item in searchRequest)
                        {
                            if (item.MjeraPoduzeta == false)
                            {

                                await _dogadjajiMjere.Update<Model.DogadjajMjere>(item.Id, new DogadjajiMjereUpsertRequest()
                                {
                                    DogadjajId = _dogadjajId.Value,
                                    MjeraId = (clb as Model.Mjere).Id,
                                    MjeraPoduzeta = true
                                });

                                //MessageBox.Show("Mjera " + (clb as Model.Mjere).Opis + " PONOVO dodana na true !");
                            }
                        }
                    }

                    for (int k = 0; k < listDM.Count; k++)
                    {
                        if ((clb as Model.Mjere).Id == listDM[k].MjeraId && listDM[k].MjeraPoduzeta == true)
                        {
                            await _dogadjajiMjere.Update<Model.DogadjajMjere>(listDM[k].Id, new DogadjajiMjereUpsertRequest()
                            {
                                DogadjajId = _dogadjajId.Value,
                                MjeraId = (clb as Model.Mjere).Id,
                                MjeraPoduzeta = true
                            });

                            //MessageBox.Show("Mjera " + (clb as Model.Mjere).Opis + " UPDATEovana !");
                        }
                    }

                   

                   
                }

                if(clbMjere.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    object clb = clbMjere.Items[i];

                    var searchRequest = await _dogadjajiMjere.Get<List<Model.DogadjajMjere>>(new DogadjajiMjereSearchRequest()
                    {
                        DogadjajId = _dogadjajId.Value,
                        MjeraId = (clb as Model.Mjere).Id
                    });

                   


                    for (int j = 0; j < listDM.Count; j++)
                    {
                        if((clb as Model.Mjere).Id == listDM[j].MjeraId && listDM[j].MjeraPoduzeta == true)
                        {
                            await _dogadjajiMjere.Update<Model.DogadjajMjere>(listDM[j].Id, new DogadjajiMjereUpsertRequest()
                            {
                                DogadjajId = _dogadjajId.Value,
                                MjeraId = (clb as Model.Mjere).Id,
                                MjeraPoduzeta = false
                            });

                            //MessageBox.Show("Mjera " + (clb as Model.Mjere).Opis + " uklonjena !");
                        }
                    }
                }
            }
            MessageBox.Show("Mjere snimljene !");

        }

        

    }
}
