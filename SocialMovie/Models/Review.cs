using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public User Reviewer { get; set; }
        public int IdContent{ get; set; }
        public int Likes { get; set; }
        public int Deslikes { get; set; }

    }
}
