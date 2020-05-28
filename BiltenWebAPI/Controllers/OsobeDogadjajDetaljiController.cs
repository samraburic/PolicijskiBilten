using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.OsobeDogadjajDetalji;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class OsobeDogadjajDetaljiController : BaseCRUDController<Bilten.Model.OsobeDogadjajDetalji, OsobeDogadjajDetaljiSearchRequest, OsobeDogadjajDetaljiUpsertRequest, OsobeDogadjajDetaljiUpsertRequest>
    {
        public OsobeDogadjajDetaljiController(ICRUDService<Bilten.Model.OsobeDogadjajDetalji, OsobeDogadjajDetaljiSearchRequest, OsobeDogadjajDetaljiUpsertRequest, OsobeDogadjajDetaljiUpsertRequest> service) : base(service)
        {
        }
    }
}