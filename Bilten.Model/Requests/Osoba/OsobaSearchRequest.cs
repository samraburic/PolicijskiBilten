using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Osoba
{
    public class OsobaSearchRequest
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public string BrLicneKarte { get; set; }

        public string Jmbg { get; set; }

    }
}
