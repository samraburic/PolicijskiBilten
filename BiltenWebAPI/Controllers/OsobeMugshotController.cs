using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.OsobeMugshot;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class OsobeMugshotController : BaseCRUDController<Bilten.Model.OsobeMugshot, OsobeMugshotSearchRequest, OsobeMugshotUpsertRequest, OsobeMugshotUpsertRequest>
    {
        public OsobeMugshotController(ICRUDService<Bilten.Model.OsobeMugshot, OsobeMugshotSearchRequest, OsobeMugshotUpsertRequest, OsobeMugshotUpsertRequest> service) : base(service)
        {
        }
    }
}