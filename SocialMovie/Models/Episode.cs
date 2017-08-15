using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public Archive VideoFile { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
