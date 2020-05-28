using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class OrganizacionaJedinica
    {
        public OrganizacionaJedinica()
        {
            Dogadjaj = new HashSet<Dogadjaj>();
            PodorganizacionaJedinica = new HashSet<PodorganizacionaJedinica>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<Dogadjaj> Dogadjaj { get; set; }
        public virtual ICollection<PodorganizacionaJedinica> PodorganizacionaJedinica { get; set; }
    }
}
