using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class VozilaDogadjajDetalji
    {
        public int DogadjajDetaljiId { get; set; }
        public int VoziloId { get; set; }

        public virtual DogadjajDetalji DogadjajDetalji { get; set; }
        public virtual Vozila Vozilo { get; set; }
    }
}
