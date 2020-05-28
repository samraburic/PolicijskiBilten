using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrLicneKarte { get; set; }
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool? Potraga { get; set; }
    }
}
