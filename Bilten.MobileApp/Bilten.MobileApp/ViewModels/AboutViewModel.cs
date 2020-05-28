using Bilten.MobileApp.Views.Vozila;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => new VozilaPage());
        }

        public ICommand OpenWebCommand { get; }
    }
}