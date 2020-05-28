using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Mjere
    {
        public Mjere()
        {
            DogadjajMjere = new HashSet<DogadjajMjere>();
        }

        public int Id { get; set; }
        public string Opis { get; set; }
        public int KategorijeId { get; set; }

        public virtual Kategorije Kategorije { get; set; }
        public virtual ICollection<DogadjajMjere> DogadjajMjere { get; set; }
    }
}
