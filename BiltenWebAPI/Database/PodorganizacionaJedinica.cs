using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class PodorganizacionaJedinica
    {
        public PodorganizacionaJedinica()
        {
            Dogadjaj = new HashSet<Dogadjaj>();
        }

        public int Id { get; set; }
        public string Naziv { get; set; }
        public int OrganizacionaJedinicaId { get; set; }

        public virtual OrganizacionaJedinica OrganizacionaJedinica { get; set; }
        public virtual ICollection<Dogadjaj> Dogadjaj { get; set; }
    }
}
