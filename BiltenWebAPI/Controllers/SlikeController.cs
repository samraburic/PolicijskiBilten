using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Slike;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class SlikeController : BaseCRUDController<Bilten.Model.Slike, SlikeSearchRequest, SlikeUpsertRequest, SlikeUpsertRequest>
    {
        public SlikeController(ICRUDService<Bilten.Model.Slike, SlikeSearchRequest, SlikeUpsertRequest, SlikeUpsertRequest> service) : base(service)
        {
        }
    }
}