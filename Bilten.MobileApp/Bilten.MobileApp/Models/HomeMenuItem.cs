using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.MobileApp.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Kategorije,
        Dogadjaj,
        Vrste,
        Mjere,
        Osoba,
        Vozila,
        DodajDogadjaj
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
