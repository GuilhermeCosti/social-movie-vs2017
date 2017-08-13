using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Number { get; set; }
        public Media Media { get; set; }
    }
}
