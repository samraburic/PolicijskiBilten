using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.DogadjajSlike;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class DogadjajSlikeController : BaseCRUDController<Bilten.Model.DogadjajSlike, DogadjajSlikeSearchRequest, DogadjajSlikeUpsertRequest, DogadjajSlikeUpsertRequest>
    {
        public DogadjajSlikeController(ICRUDService<Bilten.Model.DogadjajSlike, DogadjajSlikeSearchRequest, DogadjajSlikeUpsertRequest, DogadjajSlikeUpsertRequest> service) : base(service)
        {
        }
    }
}