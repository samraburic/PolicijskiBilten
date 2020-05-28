using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class DogadjajVideo
    {
        public int DogadjajId { get; set; }
        public int VideoId { get; set; }

        public virtual Dogadjaj Dogadjaj { get; set; }
        public virtual Video Video { get; set; }
    }
}
