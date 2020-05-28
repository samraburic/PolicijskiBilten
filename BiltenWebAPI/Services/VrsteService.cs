using AutoMapper;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Vrste;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class VrsteService : BaseCRUDService<Bilten.Model.Vrste, VrsteSearchRequest, Database.Vrste, VrsteUpsertRequest, VrsteUpsertRequest>, IService<Bilten.Model.Vrste, VrsteSearchRequest>
    {
        public VrsteService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.Vrste> Get(VrsteSearchRequest search)
        {
            var query = _context.Set<Database.Vrste>().AsQueryable();

            if(search?.KategorijeId.HasValue == true)
            {
                query = query.Where(x => x.KategorijeId == search.KategorijeId);
            }

            if (search?.VrstaId.HasValue == true)
            {
                query = query.Where(x => x.Id == search.VrstaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.Vrste>>(list);



        }
    }
}
