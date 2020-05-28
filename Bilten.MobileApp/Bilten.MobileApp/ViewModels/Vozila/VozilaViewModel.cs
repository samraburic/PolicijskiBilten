using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Bilten.Model;
using Bilten.Model.Requests.Vozila;

namespace Bilten.MobileApp.ViewModels.Vozila
{
    public class VozilaViewModel : BaseViewModel
    {
        private readonly APIService _vozilaService = new APIService("Vozila");

        public VozilaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Vozila> VozilaList { get; set; } = new ObservableCollection<Model.Vozila>();

        public ICommand InitCommand { get; set; }

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

                var vozila = await _vozilaService.Get <IEnumerable<Model.Vozila>>(request);

                foreach (var vozilo in vozila)
                {
                    VozilaList.Add(vozilo);
                }
            }
        }
    }
}
