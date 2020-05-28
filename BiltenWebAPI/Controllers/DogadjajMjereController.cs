using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.DogadjajiMjere;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class DogadjajMjereController : BaseCRUDController<Bilten.Model.DogadjajMjere, DogadjajiMjereSearchRequest, DogadjajiMjereUpsertRequest, DogadjajiMjereUpsertRequest>
    {
        public DogadjajMjereController(ICRUDService<Bilten.Model.DogadjajMjere, DogadjajiMjereSearchRequest, DogadjajiMjereUpsertRequest, DogadjajiMjereUpsertRequest> service) : base(service)
        {
        }
    }
}