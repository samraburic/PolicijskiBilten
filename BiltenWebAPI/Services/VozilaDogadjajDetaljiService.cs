using AutoMapper;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class VozilaDogadjajDetaljiService : BaseCRUDService<Bilten.Model.VozilaDogadjajDetalji, VozilaDogadjajDetaljiSearchRequest, Database.VozilaDogadjajDetalji, VozilaDogadjajDetaljiUpsertRequest, VozilaDogadjajDetaljiUpsertRequest>, IService<Bilten.Model.VozilaDogadjajDetalji, VozilaDogadjajDetaljiSearchRequest>
    {
        public VozilaDogadjajDetaljiService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.VozilaDogadjajDetalji> Get(VozilaDogadjajDetaljiSearchRequest search)
        {
            var query = _context.Set<Database.VozilaDogadjajDetalji>().AsQueryable();

            if (search?.DogadjajDetaljiId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajDetaljiId == search.DogadjajDetaljiId);
            }


            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.VozilaDogadjajDetalji>>(list);


        }
    }
}
