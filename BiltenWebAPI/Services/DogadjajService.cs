using AutoMapper;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Dogadjaj;
using BiltenWebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class DogadjajService : BaseCRUDService<Bilten.Model.Dogadjaj, DogadjajSearchRequest, Database.Dogadjaj, DogadjajUpsertRequest, DogadjajUpsertRequest>, IService<Bilten.Model.Dogadjaj, DogadjajSearchRequest>
    {
        public DogadjajService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Bilten.Model.Dogadjaj> Get(DogadjajSearchRequest search)
        {
            var query = _context.Set<Database.Dogadjaj>().AsQueryable();

            query = query.Include(x => x.Kategorije);

            query = query.Include(x => x.Vrste);

            //if (search?.DatumDogadjajaOD.HasValue == true && search?.DatumDogadjajaOD.HasValue == true && search?.DatumDogadjajaOD <= search?.DatumDogadjajaDO)
            //{
            //    query = query.Where(x => x.DatumDogadjaja >= search.DatumDogadjajaOD && x.DatumDogadjaja <= search.DatumDogadjajaDO);
            //}

            //if (search?.DatumDogadjajaOD.HasValue == true)
            //{
            //    query = query.Where(x => x.DatumDogadjaja.Value.ToShortDateString() == search.DatumDogadjajaOD.Value.ToShortDateString());
            //}

            if (search?.DatumDogadjajaOD.HasValue == true && search?.DatumDogadjajaOD.HasValue == true && search?.DatumDogadjajaOD <= search?.DatumDogadjajaDO)
            {
                query = query.Where(x => x.DatumDogadjaja >= search.DatumDogadjajaOD && x.DatumDogadjaja <= search.DatumDogadjajaDO);
            }

            if (search?.DatumDogadjaja.HasValue == true)
            {
                query = query.Where(x => x.DatumDogadjaja.Value.Day == search.DatumDogadjaja.Value.Day 
                && x.DatumDogadjaja.Value.Month == search.DatumDogadjaja.Value.Month 
                && x.DatumDogadjaja.Value.Year == search.DatumDogadjaja.Value.Year);
            }

            //if (search?.DatumDogadjajaOD.HasValue == true)
            //{
            //    query = query.Where(x => x.DatumDogadjaja.Value.ToShortDateString() == search.DatumDogadjajaOD.Value.ToShortDateString());
            //}

            if (search?.Longituda != null && search?.Latituda != null)
            {
                query = query.Where(x => x.Longituda == search.Longituda && x.Latituda == search.Latituda);
            }

            if (search?.KategorijeId.HasValue == true)
            {
                query = query.Where(x => x.KategorijeId == search.KategorijeId);
            }

            if (search?.Odabran.HasValue == true)
            {
                query = query.Where(x => x.Odabran == search.Odabran);
            }

            var list = query.ToList();

            return _mapper.Map<List<Bilten.Model.Dogadjaj>>(list);


        }
    }
}
