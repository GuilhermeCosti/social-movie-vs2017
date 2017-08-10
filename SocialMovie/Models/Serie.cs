using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Serie : IContent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Season> Seasons { get; set; }
    }
}
