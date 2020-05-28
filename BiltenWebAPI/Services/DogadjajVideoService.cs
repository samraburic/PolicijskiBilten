using AutoMapper;
using Bilten.Model.Requests.DogadjajVideo;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class DogadjajVideoService : BaseCRUDService<Bilten.Model.DogadjajVideo, DogadjajVideoSearchRequest, Database.DogadjajVideo, DogadjajVideoUpsertRequest, DogadjajVideoUpsertRequest>,
        ICRUDService<Bilten.Model.DogadjajVideo, DogadjajVideoSearchRequest, DogadjajVideoUpsertRequest, DogadjajVideoUpsertRequest>
    {
        public DogadjajVideoService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Bilten.Model.DogadjajVideo> Get(DogadjajVideoSearchRequest search)
        {
            var query = _context.Set<Database.DogadjajVideo>().AsQueryable();

            if (search?.DogadjajId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajId == search.DogadjajId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.DogadjajVideo>>(list);


        }
    }
}
