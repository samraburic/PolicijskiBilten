using Bilten.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Bilten.Model.Requests;
using Xamarin.Forms.Maps;
using System;
using Bilten.Model.Requests.DogadjajDetalji;

namespace Bilten.MobileApp.ViewModels.Dogadjaj
{
    public class DodajDogadjajViewModel : BaseViewModel 
    {

        private readonly APIService _dogadjajService = new APIService("Dogadjaj");
        private readonly APIService _kategorijeService = new APIService("Kategorije");
        private readonly APIService _vrsteService = new APIService("Vrste");
        private readonly APIService _dogadjajiDetalji = new APIService("DogadjajDetalji");

        public DodajDogadjajViewModel()
        {
            InitCommand = new Command(async () => await Init());
            InitDodajDogadjajCommand = new Command(async () => await InitDodajDogadjaj());
        }

        public ObservableCollection<Model.Dogadjaj> DogadjajList { get; set; } = new ObservableCollection<Model.Dogadjaj>();
        public ObservableCollection<Model.Kategorije> KategorijeList { get; set; } = new ObservableCollection<Model.Kategorije>();
        public ObservableCollection<Model.Vrste> VrsteList { get; set; } = new ObservableCollection<Model.Vrste>();



        Position Position = new Position();
        Pin marker = new Pin();


        Model.Kategorije _selectedKategorije = null;
        public Kategorije SelectedKategorije
        {
            get { return _selectedKategorije; }
            set
            {
                SetProperty(ref _selectedKategorije, value);
                //if (value != null)
                //{
                //    InitCommand.Execute(null);
                //}
            }
        }

        private Model.Dogadjaj _dogadjaj = new Model.Dogadjaj();
        public Model.Dogadjaj Dogadjaj
        {
            get { return _dogadjaj; }
            set { SetProperty(ref _dogadjaj, value); }
        }


        Model.Vrste _selectedVrste = null;
        public Model.Vrste SelectedVrste
        {
            get { return _selectedVrste; }
            set
            {
                SetProperty(ref _selectedVrste, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }

        public ICommand InitCommand { get; set; }
        public ICommand InitDodajDogadjajCommand { get; set; }

        public async Task Init()
        {
            var vrste = await _vrsteService.Get<IEnumerable<Model.Vrste>>(new VrsteSearchRequest()
            {
                KategorijeId = 2
            });

            VrsteList.Clear();
            foreach (var vrsta in vrste)
            {
                VrsteList.Add(vrsta);
            }
        }


        public async Task InitPosition(double latitude, double longitude)
        {
           Position = new Position(latitude, longitude);

            marker = new Pin()
            {
                Position = Position,
                Type = PinType.Place,
                Label = "Lokacija događaja"
            };
        }


        public async Task InitDodajDogadjaj()
        {
            double lat = Position.Latitude;
            double lng = Position.Longitude;

            var request = new DogadjajUpsertRequest()
            {
                KategorijeId = 2,
                VrsteId = SelectedVrste.Id,
                Opis = Dogadjaj.Opis,
                Prijavitelj = Dogadjaj.Prijavitelj,
                MjestoDogadjaja = Dogadjaj.MjestoDogadjaja,
                OrganizacionaJedinicaId = 1,
                PodorganizacionaJedinicaId = 1,
                DatumDogadjaja = Dogadjaj.DatumDogadjaja,
                DatumPrijave = Dogadjaj.DatumPrijave,
                Odabran = false,
                Latituda = lat,
                Longituda = lng
            };

            await _dogadjajService.Insert<Model.Dogadjaj>(request);

            await Application.Current.MainPage.DisplayAlert("Događaj dodan !", "Unijeli ste novi događaj.", "OK");
        }
    }
}
