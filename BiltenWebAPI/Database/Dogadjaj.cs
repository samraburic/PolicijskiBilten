using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Dogadjaj
    {
        public Dogadjaj()
        {
            DogadjajDetalji = new HashSet<DogadjajDetalji>();
            DogadjajMjere = new HashSet<DogadjajMjere>();
            DogadjajSlike = new HashSet<DogadjajSlike>();
            DogadjajVideo = new HashSet<DogadjajVideo>();
        }

        public int Id { get; set; }
        public int OrganizacionaJedinicaId { get; set; }
        public int PodorganizacionaJedinicaId { get; set; }
        public int VrsteId { get; set; }
        public int KategorijeId { get; set; }
        public DateTime? DatumDogadjaja { get; set; }
        public string MjestoDogadjaja { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public string Prijavitelj { get; set; }
        public string Opis { get; set; }
        public bool? Odabran { get; set; }
        public double? Longituda { get; set; }
        public double? Latituda { get; set; }

        public virtual Kategorije Kategorije { get; set; }
        public virtual OrganizacionaJedinica OrganizacionaJedinica { get; set; }
        public virtual PodorganizacionaJedinica PodorganizacionaJedinica { get; set; }
        public virtual Vrste Vrste { get; set; }
        public virtual ICollection<DogadjajDetalji> DogadjajDetalji { get; set; }
        public virtual ICollection<DogadjajMjere> DogadjajMjere { get; set; }
        public virtual ICollection<DogadjajSlike> DogadjajSlike { get; set; }
        public virtual ICollection<DogadjajVideo> DogadjajVideo { get; set; }
    }
}
