using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model
{
    public class Mjere
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public int KategorijeId { get; set; }
        public bool IsSelected { get; set; }

        //public string NazivKategorije { get; set; }

    }
}
