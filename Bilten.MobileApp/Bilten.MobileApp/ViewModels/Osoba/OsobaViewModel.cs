using Bilten.Model.Requests.Osoba;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels.Osoba
{
    public class OsobaViewModel : BaseViewModel
    {
        private readonly APIService _osobaService = new APIService("Osoba");

        public OsobaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Osoba> OsobaList { get; set; } = new ObservableCollection<Model.Osoba>();

        public ICommand InitCommand { get; set; }

        //string _pretraga = string.Empty;
        //public string Pretraga
        //{
        //    get { return _pretraga; }
        //    set
        //    {
        //        SetProperty(ref _pretraga, value);
        //        if (value != null)
        //            InitCommand.Execute(null);
        //    }
        //}

        public async Task Init()
        {
            //var searchRequest = new OsobaSearchRequest();


            //if (!string.IsNullOrEmpty(Pretraga))
            //{
            //    searchRequest.Jmbg = Pretraga.Trim();
            //}

            var list = await _osobaService.Get<IEnumerable<Model.Osoba>>(null);

            OsobaList.Clear();
            foreach (var osoba in list)
            {
                OsobaList.Add(osoba);
            }
        }
    }
}
