using Bilten.MobileApp.ViewModels.Dogadjaj;
using Bilten.MobileApp.Views.Vozila;
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
    public partial class DogadjajDetaljiPage : ContentPage
    {

        private DogadjajDetaljiViewModel model = null;
        public DogadjajDetaljiPage(Model.Dogadjaj dogadjaj)
        {
            InitializeComponent();


            BindingContext = model = new DogadjajDetaljiViewModel()
            {
                Dogadjaj = dogadjaj
            };


            //Position position = new Position(dogadjaj.Latituda.Value, dogadjaj.Longituda.Value);
            //MapSpan mapSpan = new MapSpan(position, 0.01, 0.01);

            //Map map = new Map(mapSpan);
            //Content = map;



            //Pin lokacija = new Pin()
            //{
            //    Position = new Position(dogadjaj.Latituda.Value, dogadjaj.Longituda.Value),
            //    Label = "Lokacija događaja",
            //    Type = PinType.Place
            //};

            //map.Pins.Add(lokacija);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();


            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.model.InitDodajVoziloPage();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {

            await this.model.InitDodajMjerePage();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await this.model.InitLokacijaPage();
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await this.model.Dogadjaji();
        }
    }
}