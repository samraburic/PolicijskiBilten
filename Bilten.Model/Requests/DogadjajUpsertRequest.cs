using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests
{
    public class DogadjajUpsertRequest
    {
        //public int Id { get; set; }
        public int OrganizacionaJedinicaId { get; set; }
        public int PodorganizacionaJedinicaId { get; set; }
        public int VrsteId { get; set; }
        public int KategorijeId { get; set; }
        public DateTime? DatumDogadjaja { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string MjestoDogadjaja { get; set; }
        public DateTime? DatumPrijave { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prijavitelj { get; set; }
        public string Opis { get; set; }

        public double? Longituda { get; set; }  

        public double? Latituda { get; set; }

        public bool? Odabran { get; set; }
    }
}
