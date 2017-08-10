using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    interface IArchive
    {
        int Id { get; set; }
        string Name { get; set; }
        string Path { get; set; }
        string Extension { get; set; }
    }
}
