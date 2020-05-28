using Bilten.MobileApp.Views.Dogadjaj;
using Bilten.Model;
using Bilten.Model.Requests;
using Bilten.Model.Requests.DogadjajiMjere;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels.Mjere
{

    class MjereOdabraneDto {
        public int Id { get; set; }
    }
    public class MjereViewModel : BaseViewModel
    {
        private readonly APIService _mjereService = new APIService("Mjere");
        private readonly APIService _dogadjajiMjereService = new APIService("DogadjajMjere");

        private readonly APIService _dogadjaj = new APIService("Dogadjaj");

        public bool MjeraPoduzeta;

        public MjereViewModel()
        {
            InitCommand = new Command(async () => await Init());

            DogadjajiCommand = new Command(async () => await DogadjajDetalji());
            //DodajMjereCommand = new Command(async () => await DodajMjere());
        }

        public ObservableCollection<Model.Mjere> MjereList { get; set; } = new ObservableCollection<Model.Mjere>();

        public int DogadjajId { get; set; }

        
        public ICommand InitCommand { get; set; }

        public ICommand DodajMjereCommand { get; set; }
        public ICommand DogadjajiCommand { get; set; }


        //public async Task SpremiMjere()
        //{
        //    var odabranejere = MjereList.Where(x => x.IsSelected)
        //        .Select(x =>new MjereOdabraneDto { 
        //        Id= x.Id});


        //}

        public async Task Init()
        {
            DogadjajiMjereSearchRequest DogMjere = new DogadjajiMjereSearchRequest()
            {
                DogadjajId = DogadjajId
            };

            var list = await _mjereService.Get<IEnumerable<Model.Mjere>>(new MjereSearchRequest() { KategorijeId = 2 });

            var listDM = await _dogadjajiMjereService.Get<List<Model.DogadjajMjere>>(DogMjere);

            MjereList.Clear();

            foreach (var item in list)
            {
                MjereList.Add(item);
            }

            foreach (var item in MjereList)
            {
                foreach (var x in listDM)
                {
                    if(item.Id == x.MjeraId && x.MjeraPoduzeta == true)
                    {
                        MjeraPoduzeta = true;
                    }

                    if (item.Id == x.MjeraId && x.MjeraPoduzeta == false)
                    {
                        MjeraPoduzeta = false;
                    }
                }
            }
        }


        public async Task DodajMjere(Model.Mjere mjera)
        {
            DogadjajiMjereUpsertRequest request = new DogadjajiMjereUpsertRequest()
            {
                DogadjajId = DogadjajId,
                MjeraId = mjera.Id,
                MjeraPoduzeta = true
            };

            var listDM = await _dogadjajiMjereService.Get<List<Model.DogadjajMjere>>(new DogadjajiMjereSearchRequest()
            {
                DogadjajId = DogadjajId,
                MjeraId = mjera.Id
            });

            if (listDM.Count == 0)
            {
                await _dogadjajiMjereService.Insert<Model.DogadjajMjere>(request);

                await Application.Current.MainPage.DisplayAlert("Poruka !", "Mjera " + mjera.Opis + " poduzeta !", "OK");
            }

            if(listDM.Count == 1)
            {
                foreach (var item in listDM)
                {
                    if (mjera.Id == item.MjeraId && item.MjeraPoduzeta == true)
                    {
                        await Application.Current.MainPage.DisplayAlert("Poruka !", "Bilo TRUE sad je FALSE", "OK");
                        mjera.IsSelected = false;
                        await _dogadjajiMjereService.Update<Model.DogadjajMjere>(item.Id, new DogadjajiMjereUpsertRequest()
                        {
                            DogadjajId = DogadjajId,
                            MjeraId = mjera.Id,
                            MjeraPoduzeta = false
                        });
                    }
                    if (mjera.Id == item.MjeraId && item.MjeraPoduzeta == false)
                    {
                        //await _dogadjajiMjereService.Update<Model.DogadjajMjere>(item.Id, request);

                        await Application.Current.MainPage.DisplayAlert("Poruka !", "Bilo FALSE sad je TRUE", "OK");
                        mjera.IsSelected = true;
                        await _dogadjajiMjereService.Update<Model.DogadjajMjere>(item.Id, new DogadjajiMjereUpsertRequest()
                        {
                            DogadjajId = DogadjajId,
                            MjeraId = mjera.Id,
                            MjeraPoduzeta = true
                        });
                    }
                }
            }

            


        }

        public async Task DogadjajDetalji()
        {
            Model.Dogadjaj model = await _dogadjaj.GetById<Model.Dogadjaj>(DogadjajId);

            Application.Current.MainPage = new DogadjajDetaljiPage(model);
        }
    }
}
