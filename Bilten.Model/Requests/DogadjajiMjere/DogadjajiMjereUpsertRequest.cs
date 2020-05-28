using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.DogadjajiMjere
{
    public class DogadjajiMjereUpsertRequest
    {
        public int DogadjajId { get; set; }
        public int MjeraId { get; set; }

        public bool? MjeraPoduzeta { get; set; }
    }
}
