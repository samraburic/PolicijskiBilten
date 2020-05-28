using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Mugshot
    {
        public Mugshot()
        {
            OsobeMugshot = new HashSet<OsobeMugshot>();
        }

        public int Id { get; set; }
        public string MugshotPath { get; set; }

        public virtual ICollection<OsobeMugshot> OsobeMugshot { get; set; }
    }
}
