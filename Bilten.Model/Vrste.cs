using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Vrste
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public int KategorijeId { get; set; }
        public string KategorijaNaziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
