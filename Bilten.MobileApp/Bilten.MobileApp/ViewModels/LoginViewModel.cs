using Bilten.MobileApp.Views;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Korisnici;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnici");
        private readonly APIService _vrsteService = new APIService("Vrste");

        public ObservableCollection<Model.Vrste> VrsteList { get; set; } = new ObservableCollection<Model.Vrste>();
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }


        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }


        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {

                var vrste = await _vrsteService.Get<IEnumerable<Model.Vrste>>(null);

                VrsteList.Clear();
                foreach (var vrsta in vrste)
                {
                    VrsteList.Add(vrsta);
                }

                await _service.Get<dynamic>(null);

                var request = new KorisniciSearchRequest()
                {
                    Username = Username
                };

                var korisnik = await _service.Get <List<Model.Korisnici>>(request);

                foreach (var item in korisnik)
                {
                    if(item.VrstaKorisnikaId == 1)
                        Application.Current.MainPage = new MainPage();
                    if (item.VrstaKorisnikaId == 2)
                        Application.Current.MainPage = new AboutPage();
                }



            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
