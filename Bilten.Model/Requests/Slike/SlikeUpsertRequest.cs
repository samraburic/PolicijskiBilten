using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.Slike
{
    public class SlikeUpsertRequest
    {
        //public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string SlikaName { get; set; }
    }
}
