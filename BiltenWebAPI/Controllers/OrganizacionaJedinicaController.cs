using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.OrganizacionaJedinica;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class OrganizacionaJedinicaController : BaseCRUDController<Bilten.Model.OrganizacionaJedinica, object,OrganizacionaJedinicaUpsertRequest, OrganizacionaJedinicaUpsertRequest>
    {
        public OrganizacionaJedinicaController(ICRUDService<Bilten.Model.OrganizacionaJedinica, object, OrganizacionaJedinicaUpsertRequest, OrganizacionaJedinicaUpsertRequest> service) : base(service)
        {
        }
    }
}