using Bilten.MobileApp.ViewModels.Osoba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Osoba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OsobaPage : ContentPage
    {
        private readonly OsobaViewModel model = null;
        public OsobaPage()
        {
            InitializeComponent();
            BindingContext = model = new OsobaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}