using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Vozila;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class VozilaController : BaseCRUDController<Bilten.Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest>
    {
        public VozilaController(ICRUDService<Bilten.Model.Vozila, VozilaSearchRequest, VozilaUpsertRequest, VozilaUpsertRequest> service) : base(service)
        {
        }
    }
}