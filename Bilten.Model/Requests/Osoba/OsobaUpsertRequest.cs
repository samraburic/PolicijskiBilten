using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Osoba
{
    public class OsobaUpsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Ime { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Prezime { get; set; }

        [RegularExpression(@"[0-9A-Z]{9}", ErrorMessage = "Nevalidan broj licne karte")]
        public string BrLicneKarte { get; set; }

        [RegularExpression(@"[0-9]{13}", ErrorMessage = "Nevalidan JMBG")]
        public string Jmbg { get; set; }

        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }
    }
}
