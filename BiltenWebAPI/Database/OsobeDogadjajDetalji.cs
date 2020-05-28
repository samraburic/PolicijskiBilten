using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class OsobeDogadjajDetalji
    {
        public int DogadjajDetaljiId { get; set; }
        public int OsobaId { get; set; }

        public virtual DogadjajDetalji DogadjajDetalji { get; set; }
        public virtual Osoba Osoba { get; set; }
    }
}
