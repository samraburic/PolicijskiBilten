using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public interface ICRUDService<TModel, TSearch, TInsert, TUpdate> : IService<TModel, TSearch>
    {
        TModel Insert(TInsert request);

        TModel Update(int id, TUpdate request);

        void Delete(int id);

        //Bilten.Model.Korisnici Authenticiraj(string username, string pass);
    }
}
