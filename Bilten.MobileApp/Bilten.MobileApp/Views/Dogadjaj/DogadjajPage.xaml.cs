using Bilten.MobileApp.ViewModels.Dogadjaj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Dogadjaj
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DogadjajPage : ContentPage
    {
        private readonly DogadjajViewModel model = null;
        public DogadjajPage()
        {
            InitializeComponent();
            BindingContext = model = new DogadjajViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();


        }

        private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Dogadjaj;

            await Navigation.PushModalAsync(new DogadjajDetaljiPage(item));
        }

    }
}