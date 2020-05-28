using AutoMapper;
using Bilten.Model.Requests.Mugshot;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class MugshotService : BaseCRUDService<Bilten.Model.Mugshot, MugshotSearchRequest, Database.Mugshot, MugshotUpsertRequest, MugshotUpsertRequest>
    {
        public MugshotService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override List<Bilten.Model.Mugshot> Get(MugshotSearchRequest search)
        {
            var query = _context.Set<Database.Mugshot>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.MugshotPath))
            {
                query = query.Where(x => x.MugshotPath == search.MugshotPath);

            }

            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.Mugshot>>(list);


        }
    }
}
