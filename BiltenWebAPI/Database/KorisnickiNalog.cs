using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class KorisnickiNalog
    {
        public KorisnickiNalog()
        {
            Korisnici = new HashSet<Korisnici>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Lozinka { get; set; }

        public virtual ICollection<Korisnici> Korisnici { get; set; }
    }
}
