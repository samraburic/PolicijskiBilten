using Bilten.MobileApp.ViewModels.Vozila;
using Bilten.Model.Requests.Dogadjaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Vozila
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajVoziloPage : ContentPage
    {
        private readonly DodajVoziloViewModel model = null;
        public DodajVoziloPage(int dogadjajId)
        {
            InitializeComponent();
            BindingContext = model = new DodajVoziloViewModel()
            {
                DogadjajId = dogadjajId
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.model.DodajVoziloNaDogadjaj();
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await this.model.DogadjajDetalji();
        }
    }
}