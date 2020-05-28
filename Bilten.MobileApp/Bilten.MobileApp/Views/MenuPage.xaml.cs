using Bilten.MobileApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bilten.MobileApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Dogadjaj, Title="Svi događaji" },
                new HomeMenuItem {Id = MenuItemType.DodajDogadjaj, Title="Novi događaj" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                //new HomeMenuItem {Id = MenuItemType.Kategorije, Title="Kategorije" },
                new HomeMenuItem {Id = MenuItemType.Vozila, Title="Registar vozila" }
                //new HomeMenuItem {Id = MenuItemType.Osoba, Title="Osoba" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}