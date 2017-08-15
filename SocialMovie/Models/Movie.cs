using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Movie : Content
    {
        public Archive VideoFile { get; set; }
    }
}
