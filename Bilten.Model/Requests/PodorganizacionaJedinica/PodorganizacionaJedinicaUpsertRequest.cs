using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.PodorganizacionaJedinica
{
    public class PodorganizacionaJedinicaUpsertRequest
    {

        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        public int OrganizacionaJedinicaId { get; set; }
    }
}
