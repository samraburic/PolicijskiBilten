using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Mugshot;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class MugshotController : BaseCRUDController<Bilten.Model.Mugshot, MugshotSearchRequest, MugshotUpsertRequest, MugshotUpsertRequest>
    {
        public MugshotController(ICRUDService<Bilten.Model.Mugshot, MugshotSearchRequest, MugshotUpsertRequest, MugshotUpsertRequest> service) : base(service)
        {
        }
    }
}