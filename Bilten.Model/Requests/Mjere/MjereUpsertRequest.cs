using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Mjere
{
    public class MjereUpsertRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string Opis { get; set; }
        public int KategorijeId { get; set; }
    }
}
