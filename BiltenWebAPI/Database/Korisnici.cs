using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Korisnici
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public int Jmbg { get; set; }
        public string Email { get; set; }
        public int VrstaKorisnikaId { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public virtual VrstaKorisnika VrstaKorisnika { get; set; }
    }
}
