using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Movie : IContent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MediaURL { get; set; }
        public string File { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string ThumbnailPath { get; set; }
        public ContentType Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Star1 { get; set; }
        public int Star2 { get; set; }
        public int Star3 { get; set; }
        public int Star4 { get; set; }
        public int Star5 { get; set; }
    }
}
