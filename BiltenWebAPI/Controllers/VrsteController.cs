using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Vrste;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class VrsteController : BaseCRUDController<Bilten.Model.Vrste, VrsteSearchRequest, VrsteUpsertRequest, VrsteUpsertRequest>
    {
        public VrsteController(ICRUDService<Bilten.Model.Vrste, VrsteSearchRequest, VrsteUpsertRequest, VrsteUpsertRequest> service) : base(service)
        {
        }
    }
}