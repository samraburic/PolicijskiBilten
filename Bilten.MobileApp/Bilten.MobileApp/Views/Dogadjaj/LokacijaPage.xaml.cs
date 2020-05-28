using Bilten.MobileApp.ViewModels.Dogadjaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Dogadjaj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LokacijaPage : ContentPage
    {
        private DogadjajDetaljiViewModel model = null;
        public LokacijaPage(Model.Dogadjaj dogadjaj)
        {
            InitializeComponent();

            BindingContext = model = new DogadjajDetaljiViewModel()
            {
                Dogadjaj = dogadjaj
            };

            Map map = new Map(MapSpan.FromCenterAndRadius(new Position(dogadjaj.Latituda.Value, dogadjaj.Longituda.Value), Distance.FromMiles(1.0)))
            {
                VerticalOptions = LayoutOptions.Fill,
                MapType = MapType.Hybrid,
                HasZoomEnabled=false,
                HasScrollEnabled=false
            };

            Content = map;


            Pin lokacija = new Pin()
            {
                Position = new Position(dogadjaj.Latituda.Value, dogadjaj.Longituda.Value),
                Label = "Lokacija događaja",
                Type = PinType.Place
            };

            map.Pins.Add(lokacija);
        }
    }
}