using System;
using System.Collections.Generic;

namespace BiltenWebAPI.Database
{
    public partial class Video
    {
        public Video()
        {
            DogadjajVideo = new HashSet<DogadjajVideo>();
        }

        public int Id { get; set; }
        public string Url { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<DogadjajVideo> DogadjajVideo { get; set; }
    }
}
