using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Korisnici;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Bilten.Model.Korisnici> Get([FromQuery]KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        public Bilten.Model.Korisnici Insert(KorisniciUpsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Bilten.Model.Korisnici Update(int id, [FromBody]KorisniciUpsertRequest request)
        {
            return _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Bilten.Model.Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}