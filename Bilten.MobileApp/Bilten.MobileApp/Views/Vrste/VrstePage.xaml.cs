using Bilten.MobileApp.ViewModels.Vrste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views.Vrste
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VrstePage : ContentPage
    {
        private readonly VrsteViewModel model = null;
        public VrstePage()
        {
            InitializeComponent();
            BindingContext = model = new VrsteViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}