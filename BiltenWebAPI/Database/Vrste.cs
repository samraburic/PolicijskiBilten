using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Vrste
    {
        public Vrste()
        {
            Dogadjaj = new HashSet<Dogadjaj>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KategorijeId { get; set; }

        public virtual Kategorije Kategorije { get; set; }
        public virtual ICollection<Dogadjaj> Dogadjaj { get; set; }
    }
}
