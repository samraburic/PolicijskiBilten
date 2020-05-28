using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.Korisnici
{
    public class KorisniciUpsertRequest
    {
        public string ImePrezime { get; set; }
        public int Jmbg { get; set; }
        public string Email { get; set; }
        public int VrstaKorisnikaId { get; set; }
        public string KorisnickoIme { get; set; }
        public string Password { get; set; }
        public string PasswordPotvrda { get; set; }
    }
}
