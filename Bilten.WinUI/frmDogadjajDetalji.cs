using Bilten.Model.Requests.DogadjajiMjere;
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
    public partial class frmDogadjajDetalji : Form
    {
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");
        private readonly APIService _podorganizacione = new APIService("PodorganizacionaJedinica");
        private readonly APIService _organizacione = new APIService("OrganizacionaJedinica");
        private readonly APIService _mjere = new APIService("Mjere");
        private readonly APIService _dogadjajiMjere = new APIService("DogadjajMjere");

        private int? _Id = null;

        public frmDogadjajDetalji(int? dogadjajId = null)
        {
            InitializeComponent();
            _Id = dogadjajId;
        }

        private async void frmDogadjajDetalji_Load(object sender, EventArgs e)
        {

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

            Bitmap bmpMarker = (Bitmap)Image.FromFile("img/misc.png");


            GMapMarker marker = new GMarkerGoogle(point, bmpMarker);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);


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

                                           where a.MjeraPoduzeta == true
                                           select new
                                           {
                                               b.Opis

                                           }).ToList();


            ////////////////////////////////////////////////////////
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            frmDogadjajVideo frm = new frmDogadjajVideo(_Id.Value);
            frm.Show();
        }
    }
}
