using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Avatar : IArchive
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string Path { get ; set; }
        public string Extension { get ; set ; }

    }
}
