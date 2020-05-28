using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Korisnici
    {
        public int Id { get; set; }
        public string ImePrezime { get; set; }
        public int Jmbg { get; set; }
        public string Email { get; set; }
        public int VrstaKorisnikaId { get; set; }
        public string KorisnickoIme { get; set; }

        public VrstaKorisnika VrstaKorisnika { get; set; }
    }
}
