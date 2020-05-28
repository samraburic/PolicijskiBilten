using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BiltenWebAPI.Database;
using Microsoft.AspNetCore.Authorization;

namespace BiltenWebAPI.Services
{
    public class BaseCRUDService<TModel, TSearch, TDatabase, TInsert, TUpdate> : BaseService<TModel, TDatabase, TSearch>, ICRUDService<TModel, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        public BaseCRUDService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }


       //[Authorize(Roles = "Administrator")]
        public virtual TModel Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);

            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual TModel Update(int id, TUpdate request)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<TModel>(entity);
        }

        public virtual void Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            _context.Remove(entity);
            _context.SaveChanges();
        }

        public virtual Bilten.Model.Korisnici Authenticiraj(string username, string pass)
        {
            throw new NotImplementedException();
        }

        //       {"\nUnmapped members were found. Review the types and members below.\nAdd a custom mapping expression, ignore,
        //add a custom resolver, or modify the source/destination type\nFor no matching constructor, add a no-arg ctor, 
        //           add optional arguments, or map all of the constructor parameters
        //           \n=============================================================================================
        //           \r\nAutoMapper created this type map for you, but your types cannot be mapped using the current configuration
        //       .\r\nKategorijeUpsertRequest ->
        //                Kategorije (Destination member list)\r\nBilten.Model.Requests.Kategorije.KategorijeUpsertRequest -> 
        //       BiltenWebAPI.Database.Kategorije (Destination member list)\r\n\r\n
        //       Unmapped properties:\r\nId\r\nDogadjaj\r\nMjere\r\nVrste\r\n"}
    }
 }
