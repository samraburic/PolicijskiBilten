using Bilten.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Bilten.MobileApp.ViewModels
{
    public class KategorijeViewModel
    {
        private readonly APIService _kategorijeService = new APIService("Kategorije");

        public KategorijeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Kategorije> KategorijeList { get; set; } = new ObservableCollection<Kategorije>();

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var list = await _kategorijeService.Get<IEnumerable<Kategorije>>(null);

            KategorijeList.Clear();
            foreach (var kategorija in list)
            {
                KategorijeList.Add(kategorija);
            }
        }
    }
}
