using Bilten.MobileApp.Views.Dogadjaj;
using Bilten.MobileApp.Views.Mjere;
using Bilten.MobileApp.Views.Vozila;
using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.Model.Requests.DogadjajiMjere;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Bilten.MobileApp.ViewModels.Dogadjaj
{
    public class DogadjajDetaljiViewModel : BaseViewModel
    {
        private readonly APIService _dogadjajService = new APIService("Dogadjaj");
        private readonly APIService _dogadjajiMjereService = new APIService("DogadjajMjere");
        private readonly APIService _mjereService = new APIService("Mjere");
        private readonly APIService _dogadjajDetalji = new APIService("DogadjajDetalji");
        private readonly APIService _vozila = new APIService("Vozila");
        private readonly APIService _vozilaDogadjajDetalji = new APIService("VozilaDogadjajDetalji");


        public ObservableCollection<Model.Vozila> DogadjajVozilaList { get; set; } = new ObservableCollection<Model.Vozila>();

        public ObservableCollection<Model.Mjere> DogadjajMjereList { get; set; } = new ObservableCollection<Model.Mjere>();

        public DogadjajDetaljiViewModel()
        {
            InitCommand = new Command(async () => await Init());

            InitDodajVoziloPageCommand = new Command(async () => await InitDodajVoziloPage());

            InitDodajMjerePageCommand = new Command(async () => await InitDodajMjerePage());

            InitLokacijaCommand = new Command(async () => await InitLokacijaPage());

            DogadjajiCommand = new Command(async () => await Dogadjaji());
        }

        public Model.Dogadjaj Dogadjaj { get; set; }


        public ICommand InitCommand { get; set; }

        public ICommand InitLokacijaCommand { get; set; }

        public ICommand DogadjajiCommand { get; set; }

        public ICommand InitDodajVoziloPageCommand { get; set; }

        public ICommand InitDodajMjerePageCommand { get; set; }

        public async Task Init()
        {
            var request = new DogadjajDetaljiSearchRequest()
            {
                DogadjajId = Dogadjaj.Id
            };
            var list = await _dogadjajDetalji.Get<List<Model.DogadjajDetalji>>(request);

            if (list.Count != 0)
            {
                foreach (var item in list)
                {
                    if (item.DogadjajId != Dogadjaj.Id)
                    {
                        var requestDetalji = new DogadjajDetaljiUpsertRequest()
                        {
                            DogadjajId = Dogadjaj.Id
                        };

                        await _dogadjajDetalji.Insert<Model.DogadjajDetalji>(requestDetalji);
                    }
                }
            }
            else
            {
                await _dogadjajDetalji.Insert<Model.DogadjajDetalji>(request);
            }




            var listDM = await _dogadjajiMjereService.Get<IEnumerable<Model.DogadjajMjere>>(new DogadjajiMjereSearchRequest()
            {
                DogadjajId = Dogadjaj.Id
            });


            if (listDM != null)
            {
                var mjere = await _mjereService.Get<IEnumerable<Model.Mjere>>(new MjereSearchRequest() { KategorijeId = 2 });

                DogadjajMjereList.Clear();
                foreach (var item in listDM)
                {
                    foreach (var mjera in mjere)
                    {
                        if (item.MjeraId == mjera.Id && item.MjeraPoduzeta == true)
                        {
                            DogadjajMjereList.Add(mjera);
                        }
                    }
                }
            }

            var dogDetalji = await _dogadjajDetalji.Get<IEnumerable<Model.DogadjajDetalji>>(new DogadjajDetaljiSearchRequest() { DogadjajId = Dogadjaj.Id });

            if (dogDetalji != null)
            {
                DogadjajVozilaList.Clear();
                foreach (var item in dogDetalji)
                {
                    var dogVozila = await _vozilaDogadjajDetalji.Get<IEnumerable<Model.VozilaDogadjajDetalji>>(new VozilaDogadjajDetaljiSearchRequest() { DogadjajDetaljiId = item.Id });

                    var vozila = await _vozila.Get<IEnumerable<Model.Vozila>>(null);

                    foreach (var item1 in dogVozila)
                    {
                        foreach (var item2 in vozila)
                        {
                            if (item1.VoziloId == item2.Id)
                            {
                                DogadjajVozilaList.Add(item2);
                            }
                        }
                    }
                }
            }

        }

        public async Task InitDodajVoziloPage()
        {
            Application.Current.MainPage = new DodajVoziloPage(Dogadjaj.Id);
        }


        public async Task InitDodajMjerePage()
        {
            //Application.Current.MainPage = new MjerePage(Dogadjaj.Id);
            Application.Current.MainPage = new NavigationPage(new MjerePage(Dogadjaj.Id));
        }

        public async Task InitLokacijaPage()
        {
            Application.Current.MainPage = new LokacijaPage(Dogadjaj);
        }


        public async Task Dogadjaji()
        {
            Application.Current.MainPage = new DogadjajPage();
        }

    }
}
