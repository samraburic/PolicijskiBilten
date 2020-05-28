using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bilten.Model;
using BiltenWebAPI.Services;
using Bilten.Model.Requests.Kategorije;

namespace BiltenWebAPI.Controllers
{
    public class KategorijeController : BaseCRUDController<Bilten.Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest>
    {
        public KategorijeController(ICRUDService<Bilten.Model.Kategorije, object, KategorijeUpsertRequest, KategorijeUpsertRequest> service) : base(service)
        {
        }
    }
}