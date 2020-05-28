using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Osoba;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class OsobaController : BaseCRUDController<Bilten.Model.Osoba, OsobaSearchRequest, OsobaUpsertRequest, OsobaUpsertRequest>
    {
        public OsobaController(ICRUDService<Bilten.Model.Osoba, OsobaSearchRequest, OsobaUpsertRequest, OsobaUpsertRequest> service) : base(service)
        {
        }
    }
}