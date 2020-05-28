using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Bilten.Model;
using Bilten.Model.Requests.Vozila;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using Bilten.Model.Requests.DogadjajDetalji;
using Bilten.MobileApp.Views.Dogadjaj;
using Bilten.MobileApp.Views.Vozila;
using Bilten.MobileApp.Views;

namespace Bilten.MobileApp.ViewModels.Vozila
{
    public class DodajVoziloViewModel : BaseViewModel
    {
        private readonly APIService _vozilaService = new APIService("Vozila");
        private readonly APIService _vozilaDogadjajiDetalji = new APIService("VozilaDogadjajDetalji");
        private readonly APIService _dogadjajiDetalji = new APIService("DogadjajDetalji");

        private readonly APIService _dogadjaj = new APIService("Dogadjaj");

        public DodajVoziloViewModel()
        {
            InitCommand = new Command(async () => await Init());

            DodajVoziloNaDogadjajCommand = new Command(async () => await DodajVoziloNaDogadjaj());

            DogadjajiCommand = new Command(async () => await DogadjajDetalji());
        }


        public ObservableCollection<Model.Vozila> VozilaList { get; set; } = new ObservableCollection<Model.Vozila>();

        public int DogadjajId { get; set; }

        public ICommand InitCommand { get; set; }

        public ICommand DodajVoziloNaDogadjajCommand { get; set; }

        public ICommand DogadjajiCommand { get; set; }

        string _searchTerm = string.Empty;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }

        public async Task Init()
        {
            var list = await _vozilaService.Get<IEnumerable<Model.Vozila>>(null);

            int id = DogadjajId;

            VozilaList.Clear();
            foreach (var vozilo in list)
            {
                VozilaList.Add(vozilo);
            }

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                VozilaList.Clear();
                var request = new VozilaSearchRequest()
                {
                    BrRegOznake = _searchTerm.Trim()
                };

                var vozila = await _vozilaService.Get<IEnumerable<Model.Vozila>>(request);

                foreach (var vozilo in vozila)
                {
                    VozilaList.Add(vozilo);
                }
            }
        }

        public async Task DodajVoziloNaDogadjaj()
        {

            var Dogdetalji = await _dogadjajiDetalji.Get<IEnumerable<Model.DogadjajDetalji>>(new DogadjajDetaljiSearchRequest() { DogadjajId = DogadjajId });

            try
            {

                if (Dogdetalji != null)
                {
                    foreach (var item in Dogdetalji)
                    {
                        foreach (var vozilo in VozilaList)
                        {
                            var searchRequest = new VozilaDogadjajDetaljiSearchRequest()
                            {
                                DogadjajDetaljiId = item.Id,
                                VoziloId = vozilo.Id
                            };


                            var vozilaDogadjajDetalji = await _vozilaDogadjajiDetalji.Get<List<VozilaDogadjajDetalji>>(searchRequest);

                            foreach (var x in vozilaDogadjajDetalji)
                            {
                                if (vozilo.Id == x.VoziloId)
                                {
                                    await Application.Current.MainPage.DisplayAlert("Greška !", "Vozilo " + vozilo.BrRegOznake + " već postoji na događaju !", "OK");
                                    throw new Exception();
                                }
                            }

                            var request = new VozilaDogadjajDetaljiUpsertRequest()
                            {
                                DogadjajDetaljiId = item.Id,
                                VoziloId = vozilo.Id
                            };



                            await _vozilaDogadjajiDetalji.Insert<VozilaDogadjajDetalji>(request);

                            await Application.Current.MainPage.DisplayAlert("Vozilo dodano !", "Dodali ste vozilo reg oznaka " + vozilo.BrRegOznake + " na događaj !", "OK");

                        }
                    }
                }


            }
            catch (Exception ex)
            {

                Application.Current.MainPage = new MainPage();
            }

        }



        public async Task DogadjajDetalji()
        {
            Model.Dogadjaj model = await _dogadjaj.GetById<Model.Dogadjaj>(DogadjajId);

            Application.Current.MainPage = new DogadjajDetaljiPage(model);
        }
    }
}
