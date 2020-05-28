using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bilten.Model.Requests
{
    public class MjereSearchRequest
    {
        public int? KategorijeId { get; set; }

        public string Opis { get; set; }
    }
}
