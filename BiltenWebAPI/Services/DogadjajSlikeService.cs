using AutoMapper;
using Bilten.Model.Requests.DogadjajSlike;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class DogadjajSlikeService : BaseCRUDService<Bilten.Model.DogadjajSlike, DogadjajSlikeSearchRequest, Database.DogadjajSlike, DogadjajSlikeUpsertRequest, DogadjajSlikeUpsertRequest>
    {
        public DogadjajSlikeService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.DogadjajSlike> Get(DogadjajSlikeSearchRequest search)
        {
            var query = _context.Set<Database.DogadjajSlike>().AsQueryable();

            if (search?.DogadjajId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajId == search.DogadjajId);

            }


            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.DogadjajSlike>>(list);


        }
    }
}
