using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public IContent Content { get; set; }
        public int Star1 { get; set; }
        public int Star2 { get; set; }
        public int Star3 { get; set; }
        public int Star4 { get; set; }
        public int Star5 { get; set; }
    }
}
