using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Slike
    {
        public int Id { get; set; }
        public byte[] Slika { get; set; }
        public string SlikaName { get; set; }
    }
}
