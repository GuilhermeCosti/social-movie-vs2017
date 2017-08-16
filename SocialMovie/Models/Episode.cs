using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int ENumber { get; set; }
        public int SNumber { get; set; }
        public Archive VideoFile { get; set; }
    }
}
