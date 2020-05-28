using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.DogadjajDetalji;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class DogadjajDetaljiController : BaseCRUDController<Bilten.Model.DogadjajDetalji, DogadjajDetaljiSearchRequest, DogadjajDetaljiUpsertRequest, DogadjajDetaljiUpsertRequest>
    {
        public DogadjajDetaljiController(ICRUDService<Bilten.Model.DogadjajDetalji, DogadjajDetaljiSearchRequest, DogadjajDetaljiUpsertRequest, DogadjajDetaljiUpsertRequest> service) : base(service)
        {
        }
    }
}