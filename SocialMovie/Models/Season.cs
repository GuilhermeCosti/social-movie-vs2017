using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Season
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public ICollection<Episode> Episodes { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
