using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilten.Model.Requests.Video;
using BiltenWebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiltenWebAPI.Controllers
{
    public class VideoController : BaseCRUDController<Bilten.Model.Video, object, VideoUpsertRequest, VideoUpsertRequest>
    {
        public VideoController(ICRUDService<Bilten.Model.Video, object, VideoUpsertRequest, VideoUpsertRequest> service) : base(service)
        {
        }
    }
}