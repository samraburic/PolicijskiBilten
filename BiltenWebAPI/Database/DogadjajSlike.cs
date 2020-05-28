﻿using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class DogadjajSlike
    {
        public int DogadjajId { get; set; }
        public int SlikaId { get; set; }

        public virtual Dogadjaj Dogadjaj { get; set; }
        public virtual Slike Slika { get; set; }
    }
}