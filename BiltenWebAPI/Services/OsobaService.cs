using AutoMapper;
using Bilten.Model.Requests.Osoba;
using BiltenWebAPI.Database;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class OsobaService : BaseCRUDService<Bilten.Model.Osoba, OsobaSearchRequest, Database.Osoba, OsobaUpsertRequest, OsobaUpsertRequest>
    {
        public OsobaService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<Bilten.Model.Osoba> Get(OsobaSearchRequest search)
        {
            var query = _context.Set<Database.Osoba>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));

            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));

            }

            if (!string.IsNullOrWhiteSpace(search?.BrLicneKarte))
            {
                query = query.Where(x => x.BrLicneKarte == search.BrLicneKarte);

            }

            if (!string.IsNullOrWhiteSpace(search?.Jmbg))
            {
                query = query.Where(x => x.Jmbg == search.Jmbg);

            }

            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.Osoba>>(list);


        }
    }
}
