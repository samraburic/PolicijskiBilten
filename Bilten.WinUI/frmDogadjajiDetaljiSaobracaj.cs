using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.DogadjajiMjere;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class frmDogadjajiDetaljiSaobracaj : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");
        private readonly APIService _podorganizacione = new APIService("PodorganizacionaJedinica");
        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");

        private readonly APIService _mjere = new APIService("Mjere");
        private readonly APIService _dogadjajiMjere = new APIService("DogadjajMjere");
        private readonly APIService _dogadjajDetalji = new APIService("DogadjajDetalji");
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _vozilaDogadjajDetalji = new APIService("VozilaDogadjajDetalji");

        private int? _Id = null;

        public frmDogadjajiDetaljiSaobracaj(int? dogadjajId = null)
        {
            InitializeComponent();
            _Id = dogadjajId;
        }

        private async void frmDogadjajDetalji_Load(object sender, EventArgs e)
        {
            var request = new DogadjajDetaljiSearchRequest()
            {
                DogadjajId = _Id
            };
            var list = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(request);
            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.DogadjajId != _Id)
                    {
                        var requestDetalji = new DogadjajDetaljiUpsertRequest()
                        {
                            DogadjajId = _Id
                        };

                        await _dogadjajDetalji.Insert<Model.DogadjajDetalji>(requestDetalji);
                        MessageBox.Show("Kreirani detalji za dogadjaj " + requestDetalji.DogadjajId + " !");
                    }
                }
            }
            else
            {
                await _dogadjajDetalji.Insert<Model.DogadjajDetalji>(request);
            }






            var dogadjaj = await _dogadjaji.GetById<Model.Dogadjaj>(_Id);

            int vrstaId = dogadjaj.VrsteId;

            int katid = dogadjaj.KategorijeId;

            var vrste = await _vrste.GetById<Model.Vrste>(dogadjaj.VrsteId);

            var kategorija = await _kategorije.GetById<Model.Kategorije>(dogadjaj.KategorijeId);

            var orgJedinica = await _organizacione.GetById<Model.OrganizacionaJedinica>(dogadjaj.OrganizacionaJedinicaId);

            var podOrgJedinica = await _podorganizacione.GetById<Model.PodorganizacionaJedinica>(dogadjaj.PodorganizacionaJedinicaId);

            txtKategorija.Text = kategorija.Naziv;
            txtVrste.Text = vrste.Naziv;
            txtOrgJedinica.Text = orgJedinica.Naziv;
            txtPodOrgJed.Text = podOrgJedinica.Naziv;
            txtDatumDogadjaja.Text = dogadjaj.DatumDogadjaja.ToString();
            txtDatumPrijave.Text = dogadjaj.DatumPrijave.ToString();
            txtPrijavitelj.Text = dogadjaj.Prijavitelj;
            txtOpis.Text = dogadjaj.Opis;
            txtMjesto.Text = dogadjaj.MjestoDogadjaja;

            //var dogadjajDetalji = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(_Id);

            var dogadjajiDetalji = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(new DogadjajDetaljiSearchRequest()
            {
                DogadjajId = _Id
            });



            foreach (var item in dogadjajiDetalji)
            {
                var result = await _vozilaDogadjajDetalji.Get<List<Model.VozilaDogadjajDetalji>>
                    (new VozilaDogadjajDetaljiSearchRequest()
                {
                    DogadjajDetaljiId = item.Id
                });

                var vozila = await _vozila.Get<List<Model.Vozila>>(result);



                //dgvVozila.AutoGenerateColumns = true;
                //dgvVozila.DataSource = result;

                var aEnum = dogadjajiDetalji.AsEnumerable();

                var bEnum = result.AsEnumerable();

                var cEnum = vozila.AsEnumerable();

                dgvVozila.DataSource = (from a in aEnum
                                           join b in bEnum on a.Id equals b.DogadjajDetaljiId
                                           join c in cEnum on b.VoziloId equals c.Id
                                           select new
                                           {
                                               Id = c.Id,
                                               Marka = c.Marka,
                                               Model = c.Model,
                                               BrRegOznake = c.BrRegOznake

                                           }).ToList();


            }

            //////////////////////Prikaz lokacija na mapi

            map.MapProvider = GMapProviders.GoogleMap;
            double lat = Convert.ToDouble(dogadjaj.Latituda);
            double longt = Convert.ToDouble(dogadjaj.Longituda);
            //map.ShowCenter = false;
            //map.MinZoom = 10;
            //map.MaxZoom = 18;
            //map.Zoom = 12;

            PointLatLng point = new PointLatLng(lat, longt);

            map.Position = point;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 18;
            map.ShowCenter = false;

            //Creating custom marker

            map.Overlays.Clear();

            Bitmap bmpMarker = (Bitmap)Image.FromFile("img/traffic.png");


            GMapMarker marker = new GMarkerGoogle(point, bmpMarker);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);


            ////////////////////////////////////////////////////////
            ///
            //////////////////// Poduzete mjere /////////////////////////

            DogadjajiMjereSearchRequest DogMjere = new DogadjajiMjereSearchRequest()
            {
                DogadjajId = _Id.Value
            };

            var listDM = await _dogadjajiMjere.Get<List<Model.DogadjajMjere>>(DogMjere);

            var listMjere = await _mjere.Get<List<Model.Mjere>>(null);

            var DMmjere = listDM.AsEnumerable();

            var Mmjere = listMjere.AsEnumerable();

            dgvPoduzeteMjere.DataSource = (from a in DMmjere
                                           join b in Mmjere on a.MjeraId equals b.Id

                                           where a.MjeraPoduzeta != null && a.MjeraPoduzeta == true
                                           select new
                                           {
                                               b.Opis

                                           }).ToList();





        }

        private void txtDetaljiDogadjaja_Click(object sender, EventArgs e)
        {
        
        }

 
        private async  void button1_Click(object sender, EventArgs e)
        {

            var requestDetalji = new DogadjajDetaljiUpsertRequest()
            {
                DogadjajId = _Id
            };

            var dogadjajDetalji = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(null);

            for (int i = 0; i < dogadjajDetalji.Count(); i++)
            {
                if (dogadjajDetalji[i].DogadjajId == _Id)
                {
                    MessageBox.Show("Detalji su već snimljeni !");
                    await _dogadjajDetalji.Update<Model.DogadjajDetalji>(_Id.Value, requestDetalji);
                }
                  
            }
            
        }

        private async void btnDodajVozila_Click(object sender, EventArgs e)
        {
            var dogadjajiDetalji = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(new DogadjajDetaljiSearchRequest()
            {
                DogadjajId = _Id
            });

            foreach (var item in dogadjajiDetalji)
            {
                frmVozilaSearch frm = new frmVozilaSearch(item.Id);
                frm.Show();
                frm.FormClosing += new FormClosingEventHandler(ChildFormClosing);
            }
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            frmDogadjajDetalji_Load(null, EventArgs.Empty);
            this.BringToFront();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            frmDogadjajVideo frm = new frmDogadjajVideo(_Id.Value);
            frm.Show();
        }
    }
}
