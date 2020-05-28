using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Kategorije
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
