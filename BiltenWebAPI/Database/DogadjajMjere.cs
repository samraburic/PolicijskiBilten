using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class DogadjajMjere
    {
        public int Id { get; set; }
        public int DogadjajId { get; set; }
        public int MjeraId { get; set; }
        public bool? MjeraPoduzeta { get; set; }

        public virtual Dogadjaj Dogadjaj { get; set; }
        public virtual Mjere Mjera { get; set; }
    }
}
