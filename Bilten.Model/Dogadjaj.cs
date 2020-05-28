using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Dogadjaj
    {
        public int Id { get; set; }
        public int OrganizacionaJedinicaId { get; set; }
        public int PodorganizacionaJedinicaId { get; set; }
        public int VrsteId { get; set; }
        public virtual Vrste Vrste { get; set; }

        public int KategorijeId { get; set; }
        public virtual Kategorije Kategorije { get; set; }

        public DateTime? DatumDogadjaja { get; set; }
        public string MjestoDogadjaja { get; set; }
        public DateTime? DatumPrijave { get; set; }
        public string Prijavitelj { get; set; }
        public string Opis { get; set; }
        public bool? Odabran { get; set; }

        public double? Latituda { get; set; }

        public double? Longituda { get; set; }
    }
}
