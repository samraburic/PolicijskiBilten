using Bilten.MobileApp.Views;
using Bilten.MobileApp.Views.Dogadjaj;
using Bilten.MobileApp.Views.Vozila;
using Bilten.Model;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Dogadjaj;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels.Dogadjaj
{
    public class DogadjajViewModel : BaseViewModel
    {
        private readonly APIService _dogadjajService = new APIService("Dogadjaj");
        private readonly APIService _kategorijeService = new APIService("Kategorije");
        private readonly APIService _vrsteService = new APIService("Vrste");


        public DogadjajViewModel()
        {
            InitCommand = new Command(async () => await Init());

            VozilaDogadjajCommand = new Command(async () => await VozilaDogadjaj());
        }


        public ObservableCollection<Model.Dogadjaj> DogadjajList{ get; set; } = new ObservableCollection<Model.Dogadjaj>();
        public ObservableCollection<Model.Kategorije> KategorijeList { get; set; } = new ObservableCollection<Model.Kategorije>();
        public ObservableCollection<Model.Vrste> VrsteList { get; set; } = new ObservableCollection<Model.Vrste>();

     

        public ICommand InitCommand { get; set; }

        public ICommand VozilaDogadjajCommand { get; set; }

        DateTime _datumPretraga = new DateTime(2019, 12, 12);

        public DateTime DatumPretraga
        {
            get { return _datumPretraga; }
            set
            {
                SetProperty(ref _datumPretraga, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public async Task Init()
        {

            var list = await _dogadjajService.Get<IEnumerable<Model.Dogadjaj>>(new DogadjajSearchRequest()
            {
                KategorijeId = 2
            });

            DogadjajList.Clear();
            foreach (var dogadjaj in list)
            {
                DogadjajList.Add(dogadjaj);
            }

            if(_datumPretraga != null)
            {
                DogadjajList.Clear();

                var request = new DogadjajSearchRequest()
                {
                    DatumDogadjajaOD = _datumPretraga,
                    DatumDogadjajaDO = DateTime.Now,
                    KategorijeId = 2
                };

                var dogadjaji = await _dogadjajService.Get<IEnumerable<Model.Dogadjaj>>(request);

                foreach (var x in dogadjaji)
                {
                    DogadjajList.Add(x);
                }
            }
        }

        public async Task VozilaDogadjaj()
        {
            //Application.Current.MainPage = new DodajVoziloPage();
        }

    }
}
