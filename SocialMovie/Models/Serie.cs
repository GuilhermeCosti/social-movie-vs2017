using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Serie : Content
    { 
        public ICollection<Season> Seasons { get; set; }
    }
}
