using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.VozilaDogadjajDetalji;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
   public class VozilaDogadjajDetaljiController : BaseCRUDController<Bilten.Model.VozilaDogadjajDetalji, VozilaDogadjajDetaljiSearchRequest, VozilaDogadjajDetaljiUpsertRequest, VozilaDogadjajDetaljiUpsertRequest>
    {
        public VozilaDogadjajDetaljiController(ICRUDService<Bilten.Model.VozilaDogadjajDetalji, VozilaDogadjajDetaljiSearchRequest, VozilaDogadjajDetaljiUpsertRequest, VozilaDogadjajDetaljiUpsertRequest> service) : base(service)
        {
        }
    }
}