using AutoMapper;
using Bilten.Model.Requests.OsobeDogadjajDetalji;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class OsobeDogadjajDetaljiService : BaseCRUDService<Bilten.Model.OsobeDogadjajDetalji, OsobeDogadjajDetaljiSearchRequest, Database.OsobeDogadjajDetalji, OsobeDogadjajDetaljiUpsertRequest, OsobeDogadjajDetaljiUpsertRequest>, IService<Bilten.Model.OsobeDogadjajDetalji, OsobeDogadjajDetaljiSearchRequest>
    {
        public OsobeDogadjajDetaljiService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.OsobeDogadjajDetalji> Get(OsobeDogadjajDetaljiSearchRequest search)
        {
            var query = _context.Set<Database.OsobeDogadjajDetalji>().AsQueryable();

            if (search?.DogadjajDetaljiId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajDetaljiId == search.DogadjajDetaljiId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.OsobeDogadjajDetalji>>(list);

        }
    }
}
