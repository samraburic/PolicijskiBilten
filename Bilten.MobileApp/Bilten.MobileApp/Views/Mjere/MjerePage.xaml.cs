using Bilten.MobileApp.ViewModels.Mjere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Mjere
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MjerePage : ContentPage
    {
        private readonly MjereViewModel model = null;
          public MjerePage(int dogadjajId)
        {
            InitializeComponent();
            BindingContext = model = new MjereViewModel()
            {
                DogadjajId = dogadjajId
            };

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if(e.Value == true)
            {
                await DisplayAlert("Poruka", "True", "Ok");
            }
            if(e.Value == false)
            {
                await DisplayAlert("Poruka", "False", "Ok");
            }
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Model.Mjere;

            await model.DodajMjere(item);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.model.DogadjajDetalji();
        }
    }
}