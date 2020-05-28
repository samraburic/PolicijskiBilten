using AutoMapper;
using Bilten.Model.Requests.Video;
using BiltenWebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiltenWebAPI.Services
{
    public class VideoService : BaseCRUDService<Bilten.Model.Video, object, Database.Video, VideoUpsertRequest, VideoUpsertRequest>
    {
        public VideoService(RS2_BiltenContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
