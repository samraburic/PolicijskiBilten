using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.DogadjajVideo;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class DogadjajVideoController : BaseCRUDController<Bilten.Model.DogadjajVideo, DogadjajVideoSearchRequest, DogadjajVideoUpsertRequest, DogadjajVideoUpsertRequest>
    {
        public DogadjajVideoController(ICRUDService<Bilten.Model.DogadjajVideo, DogadjajVideoSearchRequest, DogadjajVideoUpsertRequest, DogadjajVideoUpsertRequest> service) : base(service)
        {
        }
    }
}