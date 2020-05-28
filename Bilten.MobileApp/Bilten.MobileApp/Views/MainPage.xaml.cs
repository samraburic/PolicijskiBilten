using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Bilten.MobileApp.Models;
using Bilten.MobileApp.Views.Dogadjaj;
using Bilten.MobileApp.Views.Vrste;
using Bilten.MobileApp.Views.Mjere;
using Bilten.MobileApp.Views.Osoba;
using Bilten.MobileApp.Views.Vozila;

namespace Bilten.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.Kategorije:
                        MenuPages.Add(id, new NavigationPage(new KategorijePage()));
                        break;
                    case (int)MenuItemType.Dogadjaj:
                        MenuPages.Add(id, new NavigationPage(new DogadjajPage()));
                        break;
                    case (int)MenuItemType.Vrste:
                        MenuPages.Add(id, new NavigationPage(new VrstePage()));
                        break;
                    case (int)MenuItemType.Osoba:
                        MenuPages.Add(id, new NavigationPage(new OsobaPage()));
                        break;
                    case (int)MenuItemType.Vozila:
                        MenuPages.Add(id, new NavigationPage(new VozilaPage()));
                        break;
                    case (int)MenuItemType.DodajDogadjaj:
                        MenuPages.Add(id, new NavigationPage(new DogadjajDodajPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}