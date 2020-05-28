using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.PodorganizacionaJedinica;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class PodorganizacionaJedinicaController : BaseCRUDController<Bilten.Model.PodorganizacionaJedinica, PodorganizacionaJedinicaSearchRequest, PodorganizacionaJedinicaUpsertRequest, PodorganizacionaJedinicaUpsertRequest>
    {
        public PodorganizacionaJedinicaController(ICRUDService<Bilten.Model.PodorganizacionaJedinica, PodorganizacionaJedinicaSearchRequest, PodorganizacionaJedinicaUpsertRequest, PodorganizacionaJedinicaUpsertRequest> service) : base(service)
        {
        }
    }
}