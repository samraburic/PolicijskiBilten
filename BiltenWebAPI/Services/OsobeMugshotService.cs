using AutoMapper;
using Bilten.Model.Requests.OsobeMugshot;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class OsobeMugshotService : BaseCRUDService<Bilten.Model.OsobeMugshot, OsobeMugshotSearchRequest, Database.OsobeMugshot, OsobeMugshotUpsertRequest, OsobeMugshotUpsertRequest>
    {
        public OsobeMugshotService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.OsobeMugshot> Get(OsobeMugshotSearchRequest search)
        {
            var query = _context.Set<Database.OsobeMugshot>().AsQueryable();

            if (search?.OsobaId.HasValue == true)
            {
                query = query.Where(x => x.OsobaId == search.OsobaId);
            }

            if (search?.MugshotId.HasValue == true)
            {
                query = query.Where(x => x.MugshotId == search.MugshotId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.OsobeMugshot>>(list);

        }
    }
}
