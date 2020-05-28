using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests;
using Bilten.Model.Requests.Mjere;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class MjereController : BaseCRUDController<Bilten.Model.Mjere, MjereSearchRequest, MjereUpsertRequest, MjereUpsertRequest>
    {
        public MjereController(ICRUDService<Bilten.Model.Mjere, MjereSearchRequest, MjereUpsertRequest, MjereUpsertRequest> service) : base(service)
        {
        }
        //[Route()]
        //public async Task<IActionResult> Update([FromBody] List<MjereOdabraneDto> asd)
        //{

        //}
    }
}