using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class VrstaKorisnika
    {
        public VrstaKorisnika()
        {
            Korisnici = new HashSet<Korisnici>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Korisnici> Korisnici { get; set; }
    }
}
