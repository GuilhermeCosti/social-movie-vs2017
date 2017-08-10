using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    interface IContent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        DateTime CreatedAt { get; set; }


    }
}
