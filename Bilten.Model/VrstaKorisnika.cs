using System.Collections.Generic;

namespace Bilten.Model
{
    public class VrstaKorisnika
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}