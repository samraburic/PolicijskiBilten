using Bilten.Model;
using Bilten.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels.Vrste
{
    public class VrsteViewModel : BaseViewModel
    {
        private readonly APIService _vrsteService = new APIService("Vrste");
        private readonly APIService _kategorije = new APIService("Kategorije");

        public VrsteViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Vrste> VrsteList { get; set; } = new ObservableCollection<Model.Vrste>();
        public ObservableCollection<Kategorije> KategorijeList { get; set; } = new ObservableCollection<Kategorije>();

        Kategorije _selectedKategorije = null;

        public Kategorije SelectedKategorije
        {
            get { return _selectedKategorije; }
            set
            {
                SetProperty(ref _selectedKategorije, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }
        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (KategorijeList.Count == 0)
            {
                var kategorijeList = await _kategorije.Get<List<Kategorije>>(null);

                foreach (var kategorije in kategorijeList)
                {
                    KategorijeList.Add(kategorije);
                }
            }

         if(SelectedKategorije != null)
            {
                VrsteSearchRequest request = new VrsteSearchRequest();
                request.KategorijeId = SelectedKategorije.Id;

                var list = await _vrsteService.Get<IEnumerable<Model.Vrste>>(request);

                VrsteList.Clear();
                foreach (var vrsta in list)
                {
                    VrsteList.Add(vrsta);
                }
            }

          
        }
    }
}
