using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class OsobeMugshot
    {
        public int OsobaId { get; set; }
        public int MugshotId { get; set; }

        public virtual Mugshot Mugshot { get; set; }
        public virtual Osoba Osoba { get; set; }
    }
}
