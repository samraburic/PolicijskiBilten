using AutoMapper;
using Bilten.Model.Requests.DogadjajDetalji;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class DogadjajDetaljiService : BaseCRUDService<Bilten.Model.DogadjajDetalji, DogadjajDetaljiSearchRequest, Database.DogadjajDetalji, DogadjajDetaljiUpsertRequest, DogadjajDetaljiUpsertRequest>, IService<Bilten.Model.DogadjajDetalji, DogadjajDetaljiSearchRequest>
    {
        public DogadjajDetaljiService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.DogadjajDetalji> Get(DogadjajDetaljiSearchRequest search)
        {
            var query = _context.Set<Database.DogadjajDetalji>().AsQueryable();

            if (search?.DogadjajId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajId == search.DogadjajId);
            }


            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.DogadjajDetalji>>(list);


        }
    }
}
