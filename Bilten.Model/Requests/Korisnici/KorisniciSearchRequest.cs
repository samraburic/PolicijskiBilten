using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.Korisnici
{
    public class KorisniciSearchRequest
    {
        public string Username { get; set; }
        public string VrstaKorisnika { get; set; }
    }
}
