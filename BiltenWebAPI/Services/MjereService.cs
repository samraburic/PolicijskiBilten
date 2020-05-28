using AutoMapper;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Mjere;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class MjereService : BaseCRUDService<Bilten.Model.Mjere, MjereSearchRequest, Database.Mjere, MjereUpsertRequest, MjereUpsertRequest>
    {
        public MjereService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.Mjere> Get(MjereSearchRequest search)
        {
            var query = _context.Set<Database.Mjere>().AsQueryable();

            if (search?.KategorijeId.HasValue == true)
            {
                query = query.Where(x => x.KategorijeId == search.KategorijeId);

            }

            if (!string.IsNullOrWhiteSpace(search?.Opis))
            {
                query = query.Where(x => x.Opis == search.Opis);

            }

            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.Mjere>>(list);


        }
    }
}
