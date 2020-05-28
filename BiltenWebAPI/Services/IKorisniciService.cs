using Bilten.Model.Requests.Korisnici;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public interface IKorisniciService
    {
        List<Bilten.Model.Korisnici> Get(KorisniciSearchRequest request);

        Bilten.Model.Korisnici GetById(int id);

        Bilten.Model.Korisnici Insert(KorisniciUpsertRequest request);

        Bilten.Model.Korisnici Update(int id, KorisniciUpsertRequest request);

        Bilten.Model.Korisnici Authenticiraj(string username, string pass);
    }
}
