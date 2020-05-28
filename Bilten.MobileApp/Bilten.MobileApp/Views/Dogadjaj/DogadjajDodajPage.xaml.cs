using Bilten.MobileApp.ViewModels.Dogadjaj;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Dogadjaj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogadjajDodajPage : ContentPage
    {

        private readonly DodajDogadjajViewModel model = null;
        public DogadjajDodajPage()
        {
            InitializeComponent();
            BindingContext = model = new DodajDogadjajViewModel();

            Position position = new Position(43.340814, 17.808932);

            Map map = new Map(MapSpan.FromCenterAndRadius(new Position(43.340814, 17.808932), Distance.FromKilometers(100)))
            {
                IsShowingUser = true,
                VerticalOptions = LayoutOptions.FillAndExpand,
                MapType = MapType.Hybrid
            };

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await model.Init();
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await this.model.InitDodajDogadjaj();
        }

        public async void Map_MapClicked(object sender, Xamarin.Forms.Maps.MapClickedEventArgs e)
        {
            await this.model.InitPosition(e.Position.Latitude, e.Position.Longitude);
        }

        private async void map_MapClicked_1(object sender, MapClickedEventArgs e)
        {
            map.Pins.Clear();

            Pin lokacija = new Pin()
            {
                Position = new Position(e.Position.Latitude, e.Position.Longitude),
                Label = "Lokacija događaja",
                Type = PinType.Place
            };

            map.Pins.Add(lokacija);

            await this.model.InitPosition(e.Position.Latitude, e.Position.Longitude);
        }
    }
}