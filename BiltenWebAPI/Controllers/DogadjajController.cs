using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bilten.Model;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Dogadjaj;

namespace BiltenWebAPI.Controllers
{
    public class DogadjajController : BaseCRUDController<Bilten.Model.Dogadjaj, DogadjajSearchRequest, DogadjajUpsertRequest, DogadjajUpsertRequest>
    {
        public DogadjajController(ICRUDService<Dogadjaj, DogadjajSearchRequest, DogadjajUpsertRequest, DogadjajUpsertRequest> service) : base(service)
        {
        }
    }
}