using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.Dogadjaj
{
    public class DogadjajSearchRequest
    {
        public int? Id { get; set; }

        public DateTime? DatumDogadjajaOD { get; set; }
        public DateTime? DatumDogadjajaDO { get; set; }

        public DateTime? DatumDogadjaja { get; set; }

        public double? Longituda { get; set; }  

        public double? Latituda { get; set; }

        public int? KategorijeId { get; set; }

        public bool? Odabran { get; set; }
    }
}
