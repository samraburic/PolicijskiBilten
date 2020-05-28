using Bilten.Model.Requests.Dogadjaj;
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
    public partial class frmGoogleMapaDogadjaja : Form
    {

        private readonly APIService _dogadjaji = new APIService("Dogadjaj");

        int? kategorijaId = null;

        GMapOverlay markersOverlay = new GMapOverlay();

        GMapProvider mapProvider = GMapProviders.GoogleMap;


        public frmGoogleMapaDogadjaja()
        {
            InitializeComponent();
        }

        private void frmGoogleMapaDogadjaja_Load(object sender, EventArgs e)
        {

            if (kategorijaId != null)
            {
                var searchRequest = new DogadjajSearchRequest()
                {
                    KategorijeId = kategorijaId
                };

                LoadGoogleMap(searchRequest, mapProvider);
            }
            else
                LoadGoogleMap(null, mapProvider);
        }

        public async void LoadGoogleMap(DogadjajSearchRequest searchRequest = null, GMapProvider mapProvider = null)
        {
            //////////////////////Prikaz lokacija na mapi

            map.MapProvider = mapProvider;
            double lat = 43.3438;
            double longt = 17.8078;
            map.ShowCenter = false;
            map.MinZoom = 10;
            map.MaxZoom = 100;
            map.Zoom = 15;

            PointLatLng point = new PointLatLng(lat, longt);

            map.Position = point;


            var ListDogadjaji = await _dogadjaji.Get<List<Model.Dogadjaj>>(searchRequest);

            foreach (var item in ListDogadjaji)
            {
                if (item.Latituda != null && item.Longituda != null && item.KategorijeId == 1)
                {
                    PointLatLng pozicija = new PointLatLng(Convert.ToDouble(item.Latituda), Convert.ToDouble(item.Longituda));

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/criminal.png");

                    GMapMarker marker = new GMarkerGoogle(pozicija, bmpMarker);

                    markersOverlay.Markers.Add(marker);

                    map.Overlays.Add(markersOverlay);

                }
                if (item.Latituda != null && item.Longituda != null && item.KategorijeId == 2)
                {
                    PointLatLng pozicija = new PointLatLng(Convert.ToDouble(item.Latituda), Convert.ToDouble(item.Longituda));

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/traffic.png");

                    GMapMarker marker = new GMarkerGoogle(pozicija, bmpMarker);

                    markersOverlay.Markers.Add(marker);

                    map.Overlays.Add(markersOverlay);


                }

                if (item.Latituda != null && item.Longituda != null && item.KategorijeId == 3)
                {
                    PointLatLng pozicija = new PointLatLng(Convert.ToDouble(item.Latituda), Convert.ToDouble(item.Longituda));

                    Bitmap bmpMarker = (Bitmap)Image.FromFile("img/misc.png");

                    GMapMarker marker = new GMarkerGoogle(pozicija, bmpMarker);


                    markersOverlay.Markers.Add(marker);


                    map.Overlays.Add(markersOverlay);

                }

                if (item.Latituda != null && item.Longituda != null && item.KategorijeId == 4)
                {
                    PointLatLng pozicija = new PointLatLng(Convert.ToDouble(item.Latituda), Convert.ToDouble(item.Longituda));


                    GMapMarker marker = new GMarkerGoogle(pozicija, GMarkerGoogleType.red_small);


                    markersOverlay.Markers.Add(marker);


                    map.Overlays.Add(markersOverlay);

                }
            }

            ////////////////////////////////////////////////////////
        }

        //public int BrojTacaka { get; set; } =int.Parse( _dogadjaji.Get<List<Model.Dogadjaj>>(null));

        private async void map_OnMarkerDoubleClick(GMapMarker item, MouseEventArgs e)
        {


        }

        public int intBrojac { get; set; }

        private async void map_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            intBrojac++;
            
            if (intBrojac == 5)
            {

                var list = await _dogadjaji.Get<List<Model.Dogadjaj>>(new DogadjajSearchRequest()
                {
                    Longituda = item.Position.Lng,
                    Latituda = item.Position.Lat
                });

                foreach (var dogadjaj in list)
                {
                    if (dogadjaj.Kategorije.Naziv == "Saobraćaj")
                    {
                        frmDogadjajiDetaljiSaobracaj frm = new frmDogadjajiDetaljiSaobracaj(dogadjaj.Id);
                        frm.Show();
                    }

                    if (dogadjaj.Kategorije.Naziv == "Kriminal")
                    {
                        frmDogadjajDetaljiKriminal frm = new frmDogadjajDetaljiKriminal(dogadjaj.Id);
                        frm.Show();
                    }

                    else
                    {
                        frmDogadjajDetalji frm = new frmDogadjajDetalji(dogadjaj.Id);
                        frm.Show();
                    }
                    intBrojac = 0;
                }
                //MessageBox.Show(intBrojac.ToString());
            }
        }


        private void btnFilterSaobracaj_Click(object sender, EventArgs e)
        {

            kategorijaId = 2;
            map.Overlays.Clear();
            markersOverlay.Clear();
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void btnFilterKriminal_Click(object sender, EventArgs e)
        {
            kategorijaId = 1;
            map.Overlays.Clear();
            markersOverlay.Clear();
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void btnFilterNJRIM_Click(object sender, EventArgs e)
        {
            kategorijaId = 3;
            map.Overlays.Clear();
            markersOverlay.Clear();
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void picTerrain_Click(object sender, EventArgs e)
        {
            mapProvider = GMapProviders.GoogleSatelliteMap;
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void picSatellite_Click(object sender, EventArgs e)
        {
            mapProvider = GMapProviders.GoogleTerrainMap;
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void picNormal_Click(object sender, EventArgs e)
        {

            mapProvider = GMapProviders.GoogleMap;
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void picHybrid_Click(object sender, EventArgs e)
        {

            mapProvider = GMapProviders.GoogleHybridMap;
            frmGoogleMapaDogadjaja_Load(sender, e);
        }

        private void btnSviDogadjaji_Click(object sender, EventArgs e)
        {

            kategorijaId = null;
            map.Overlays.Clear();
            markersOverlay.Clear();
            frmGoogleMapaDogadjaja_Load(sender, e);
        }
    }
}
