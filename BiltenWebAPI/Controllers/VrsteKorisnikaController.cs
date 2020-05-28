using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.VrstaKorisnika;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class VrsteKorisnikaController : BaseCRUDController<Bilten.Model.VrstaKorisnika, object, object, object>
    {
        public VrsteKorisnikaController(ICRUDService<Bilten.Model.VrstaKorisnika, object, object, object> service) : base(service)
        {
        }
    }
}