using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Vozila
    {
        public Vozila()
        {
            VozilaDogadjajDetalji = new HashSet<VozilaDogadjajDetalji>();
        }

        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string BrRegOznake { get; set; }

        public virtual ICollection<VozilaDogadjajDetalji> VozilaDogadjajDetalji { get; set; }
    }
}
