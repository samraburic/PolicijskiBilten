using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Kategorije
    {
        public Kategorije()
        {
            Dogadjaj = new HashSet<Dogadjaj>();
            Mjere = new HashSet<Mjere>();
            Vrste = new HashSet<Vrste>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Dogadjaj> Dogadjaj { get; set; }
        public virtual ICollection<Mjere> Mjere { get; set; }
        public virtual ICollection<Vrste> Vrste { get; set; }
    }
}
