using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Slike
    {
        public Slike()
        {
            DogadjajSlike = new HashSet<DogadjajSlike>();
        }

        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string SlikaName { get; set; }

        public virtual ICollection<DogadjajSlike> DogadjajSlike { get; set; }
    }
}
