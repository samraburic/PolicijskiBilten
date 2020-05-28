using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests.Vozila
{
    public class VozilaSearchRequest
    {
        //[RegularExpression(@"[A-Z]{1}[0-9]{2}[-]{1}[A-Z]{1}[-]{1}[0-9]{3}", ErrorMessage = "Nevalidan broj registracijske oznake")]
        public string BrRegOznake { get; set; }
    }
}
