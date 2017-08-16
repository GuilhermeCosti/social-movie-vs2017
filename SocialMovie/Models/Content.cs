using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Archive Thumbnail { get; set; }
        public ContentType Type { get; set; }
        public int Star1 { get; set; }
        public int Star2 { get; set; }
        public int Star3 { get; set; }
        public int Star4 { get; set; }
        public int Star5 { get; set; }
    }

    public enum ContentType : byte
    {
        Movie = 1,
        Episode = 2
    }
}
