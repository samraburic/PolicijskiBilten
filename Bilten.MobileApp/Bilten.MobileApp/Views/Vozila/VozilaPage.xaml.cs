using Bilten.MobileApp.ViewModels.Vozila;
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
    public partial class VozilaPage : ContentPage
    {
        private readonly VozilaViewModel model = null;
        public VozilaPage()
        {
            InitializeComponent();
            BindingContext = model = new VozilaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}