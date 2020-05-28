using AutoMapper;
using Bilten.Model.Requests.Slike;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class SlikeService : BaseCRUDService<Bilten.Model.Slike, SlikeSearchRequest, Database.Slike, SlikeUpsertRequest, SlikeUpsertRequest>
    {
        public SlikeService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.Slike> Get(SlikeSearchRequest search)
        {
            var query = _context.Set<Database.Slike>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.SlikaName))
            {
                query = query.Where(x => x.SlikaName == search.SlikaName);

            }

            var list = query.ToList();


            return _mapper.Map<List<Bilten.Model.Slike>>(list);


        }
    }
}
