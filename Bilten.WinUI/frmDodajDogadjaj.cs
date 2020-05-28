using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.PodorganizacionaJedinica;
using Bilten.WinUI.CustomControl;
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
    public partial class frmDodajDogadjaj : Form
    {
        private readonly APIService _kategorije = new APIService("Kategorije");
        private readonly APIService _vrste = new APIService("Vrste");
        private readonly APIService _orgJedinice = new APIService("OrganizacionaJedinica");
        private readonly APIService _podorgJedinice = new APIService("PodorganizacionaJedinica");
        private readonly APIService _dogadjaji = new APIService("Dogadjaj");
        private readonly APIService _dogadjajDetalji = new APIService("DogadjajDetalji");

        private readonly int? _Id = null;
        public frmDodajDogadjaj(int? id = null)
        {
            InitializeComponent();
            _Id = id;
        }

        private async void cmbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbKategorije.SelectedValue;

            if(int.TryParse(idObj.ToString(), out int id))
            {
                await LoadVrste(id);
            }
        }

        private async void frmDodajDogadjaj_Load(object sender, EventArgs e)
        {

            //GMapProviders.GoogleMap.ApiKey = AppConfig.Key;
            //GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //map.CacheLocation = @"cache";
            //map.DragButton = MouseButtons.Left;
            //map.MapProvider = GMapProviders.GoogleMap;
            //map.ShowCenter = false;
            //map.MinZoom = 10;
            //map.MaxZoom = 100;
            //map.Zoom = 12;
            //map.SetPositionByKeywords("Nagpur, India");

            map.MapProvider = GMapProviders.GoogleMap;
            double lat = 43.3438;
            double longt = 17.8078;
            map.ShowCenter = false;
            map.MinZoom = 10;
            map.MaxZoom = 100;
            map.Zoom = 18;

            PointLatLng point = new PointLatLng(lat, longt);

            map.Position = point;


            await LoadKategorije();
            await LoadOrganizacionaJedinice();


        }

        private async Task LoadKategorije()
        {
            if (_Id == null)
            {
                var result = await _kategorije.Get<List<Model.Kategorije>>(null);
                result.Insert(0, new Model.Kategorije());
                cmbKategorije.DisplayMember = "Naziv";
                cmbKategorije.ValueMember = "Id";
                cmbKategorije.DataSource = result;
            }
            else
            {
                var result = await _kategorije.Get<List<Model.Kategorije>>(null);
                cmbKategorije.DisplayMember = "Naziv";
                cmbKategorije.ValueMember = "Id";
                cmbKategorije.DataSource = result;
                cmbKategorije.SelectedValue = 2;
                cmbKategorije.AllowDrop = false;

            }
        }

        private async Task LoadVrste(int kategorijaId)
        {
            var result = await _vrste.Get<List<Bilten.Model.Vrste>>(new VrsteSearchRequest()
            {
                KategorijeId = kategorijaId
            });
            result.Insert(0, new Model.Vrste());
            cmbVrste.DisplayMember = "Naziv";
            cmbVrste.ValueMember = "Id";
            cmbVrste.DataSource = result;
        }

        private async void cmbOrgJedinice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idObj = cmbOrgJedinice.SelectedValue;

            if (int.TryParse(idObj.ToString(), out int id))
            {
                await LoadPodorganizacioneJedinice(id);
            }
        }
        private async Task LoadOrganizacionaJedinice()
        {
            var result = await _orgJedinice.Get<List<Model.OrganizacionaJedinica>>(null);
            result.Insert(0, new Model.OrganizacionaJedinica());
            cmbOrgJedinice.DisplayMember = "Naziv";
            cmbOrgJedinice.ValueMember = "Id";
            cmbOrgJedinice.DataSource = result;
        }

        private async Task LoadPodorganizacioneJedinice(int orgJedinicaId)
        {
            var result = await _podorgJedinice.Get<List<Bilten.Model.PodorganizacionaJedinica>>(new PodorganizacionaJedinicaSearchRequest()
            {
                OrganizacionaJedinicaId = orgJedinicaId
            });
            result.Insert(0, new Model.PodorganizacionaJedinica());
            cmbPodOrgJedinice.DisplayMember = "Naziv";
            cmbPodOrgJedinice.ValueMember = "Id";
            cmbPodOrgJedinice.DataSource = result;
        }

        private async void btnSnimi_Click(object sender, EventArgs e)
        {
            var request = new DogadjajUpsertRequest()
            {
                KategorijeId = int.Parse(cmbKategorije.SelectedValue.ToString()),
                VrsteId = int.Parse(cmbVrste.SelectedValue.ToString()),
                OrganizacionaJedinicaId = int.Parse(cmbOrgJedinice.SelectedValue.ToString()),
                PodorganizacionaJedinicaId = int.Parse(cmbPodOrgJedinice.SelectedValue.ToString()),
                MjestoDogadjaja = txtMjesto.Text,
                DatumDogadjaja = calDatumDogadaja.Value,
                DatumPrijave = calDatumPrijave.Value,
                Prijavitelj = txtPrijavitelj.Text,
                Opis = txtOpis.Text,
                Latituda = Convert.ToDouble(txtLat.Text),
                Longituda = Convert.ToDouble(txtLong.Text),
                Odabran = false
                
            };

            

            await _dogadjaji.Insert<Model.Dogadjaj>(request);


            MessageBox.Show("Novi događaj uspješno dodan !");
        }

        void LoadMap(PointLatLng point) => map.Position = point;

        void AddMarker(PointLatLng pointToAdd, Bitmap bmpMarker)
        {
            map.Overlays.Clear();

            GMapMarker marker = new GMarkerGoogle(pointToAdd, bmpMarker);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                var lat = point.Lat;
                var lng = point.Lng;

                txtLat.Text = lat + "";
                txtLong.Text = lng + "";


                LoadMap(point);

                if (Convert.ToInt32(cmbKategorije.SelectedValue) == 1)
                {
                    map.Overlays.Clear();

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/criminal.png");



                    AddMarker(point, bmpMarker);
                }

                if (Convert.ToInt32(cmbKategorije.SelectedValue) == 2)
                {
                    map.Overlays.Clear();

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/traffic.png");



                    
                }

                if (Convert.ToInt32(cmbKategorije.SelectedValue) == 3)
                {
                    map.Overlays.Clear();

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/misc.png");


                    AddMarker(point, bmpMarker);
                }

            }
        }

    }
}
