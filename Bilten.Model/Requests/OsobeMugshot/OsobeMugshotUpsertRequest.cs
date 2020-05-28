using System;
using System.Collections.Generic;
using System.Text;

namespace Bilten.Model.Requests.OsobeMugshot
{
    public class OsobeMugshotUpsertRequest
    {
        public int OsobaId { get; set; }
        public int MugshotId { get; set; }
    }
}
