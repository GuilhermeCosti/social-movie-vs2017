using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public interface IContent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string ThumbnailPath { get; set; }
        ContentType Type { get; set; }
        int Star1 { get; set; }
        int Star2 { get; set; }
        int Star3 { get; set; }
        int Star4 { get; set; }
        int Star5 { get; set; }
        DateTime CreatedAt { get; set; }


    }
}
