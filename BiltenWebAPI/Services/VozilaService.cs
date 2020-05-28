using AutoMapper;
using Bilten.Model.Requests.Vozila;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class VozilaService : BaseCRUDService<Bilten.Model.Vozila, VozilaSearchRequest, Database.Vozila, VozilaUpsertRequest, VozilaUpsertRequest>
    {
        public VozilaService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.Vozila> Get(VozilaSearchRequest search)
        {
            var query = _context.Set<Database.Vozila>().AsQueryable();
            
            if (!string.IsNullOrWhiteSpace(search?.BrRegOznake))
            {
                query = query.Where(x => (x.BrRegOznake.StartsWith(search.BrRegOznake) || x.BrRegOznake.Contains(search.BrRegOznake)));

            }

            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.Vozila>>(list);


        }
    }
}
