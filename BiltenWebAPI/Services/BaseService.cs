using AutoMapper;
using BiltenWebAPI.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class BaseService<TModel, TDatabase, TSearch> : IService<TModel, TSearch> where TDatabase : class 
    {
        protected readonly RS2_BiltenContext _context;
        protected readonly IMapper _mapper;
        public BaseService(RS2_BiltenContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual List<TModel> Get(TSearch search)
        {
            var list = _context.Set<TDatabase>().ToList();

            return _mapper.Map<List<TModel>>(list);
        }

        public virtual TModel GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);

            return _mapper.Map<TModel>(entity);
        }
    }
}
