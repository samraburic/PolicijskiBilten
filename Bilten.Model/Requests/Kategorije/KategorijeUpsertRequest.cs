using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Kategorije
{
    public class KategorijeUpsertRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
    }
}
