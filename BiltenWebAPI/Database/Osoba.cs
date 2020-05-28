using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Osoba
    {
        public Osoba()
        {
            OsobeDogadjajDetalji = new HashSet<OsobeDogadjajDetalji>();
            OsobeMugshot = new HashSet<OsobeMugshot>();
        }

        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrLicneKarte { get; set; }
        public string Jmbg { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool? Potraga { get; set; }

        public virtual ICollection<OsobeDogadjajDetalji> OsobeDogadjajDetalji { get; set; }
        public virtual ICollection<OsobeMugshot> OsobeMugshot { get; set; }
    }
}
