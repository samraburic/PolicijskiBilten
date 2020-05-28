using AutoMapper;
using Bilten.Model.Requests.PodorganizacionaJedinica;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class PodorganizacionaJedinicaService : BaseCRUDService<Bilten.Model.PodorganizacionaJedinica, PodorganizacionaJedinicaSearchRequest, Database.PodorganizacionaJedinica, PodorganizacionaJedinicaUpsertRequest, PodorganizacionaJedinicaUpsertRequest>,
        ICRUDService<Bilten.Model.PodorganizacionaJedinica, PodorganizacionaJedinicaSearchRequest, PodorganizacionaJedinicaUpsertRequest, PodorganizacionaJedinicaUpsertRequest>
    {
        public PodorganizacionaJedinicaService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.PodorganizacionaJedinica> Get(PodorganizacionaJedinicaSearchRequest search)
        {
            var query = _context.Set<Database.PodorganizacionaJedinica>().AsQueryable();

            if (search?.OrganizacionaJedinicaId.HasValue == true)
            {
                query = query.Where(x => x.OrganizacionaJedinicaId == search.OrganizacionaJedinicaId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.PodorganizacionaJedinica>>(list);


        }
    }
}
