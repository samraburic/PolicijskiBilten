using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Vrste
{
    public class VrsteUpsertRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public int KategorijeId { get; set; }
    }
}
