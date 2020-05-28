using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class DogadjajDetalji
    {
        public DogadjajDetalji()
        {
            OsobeDogadjajDetalji = new HashSet<OsobeDogadjajDetalji>();
            VozilaDogadjajDetalji = new HashSet<VozilaDogadjajDetalji>();
        }

        public int Id { get; set; }
        public int? DogadjajId { get; set; }

        public virtual Dogadjaj Dogadjaj { get; set; }
        public virtual ICollection<OsobeDogadjajDetalji> OsobeDogadjajDetalji { get; set; }
        public virtual ICollection<VozilaDogadjajDetalji> VozilaDogadjajDetalji { get; set; }
    }
}
