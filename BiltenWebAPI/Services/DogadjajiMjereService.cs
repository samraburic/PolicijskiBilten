using AutoMapper;
using Bilten.Model.Requests.DogadjajiMjere;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{

    public class DogadjajiMjereService : BaseCRUDService<Bilten.Model.DogadjajMjere, DogadjajiMjereSearchRequest, Database.DogadjajMjere, DogadjajiMjereUpsertRequest, DogadjajiMjereUpsertRequest>,
        ICRUDService<Bilten.Model.DogadjajMjere, DogadjajiMjereSearchRequest, DogadjajiMjereUpsertRequest, DogadjajiMjereUpsertRequest>
    {
        public DogadjajiMjereService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.DogadjajMjere> Get(DogadjajiMjereSearchRequest search)
        {
            var query = _context.Set<Database.DogadjajMjere>().AsQueryable();

            if (search?.DogadjajId.HasValue == true)
            {
                query = query.Where(x => x.DogadjajId == search.DogadjajId);
            }

            if (search?.MjeraId.HasValue == true)
            {
                query = query.Where(x => x.MjeraId == search.MjeraId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.DogadjajMjere>>(list);


        }
    }
}
