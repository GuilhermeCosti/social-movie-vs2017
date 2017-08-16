using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Archive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }
        public ArchiveType Type { get; set; }
        public string FullPath {
            get
            {
                return Path + Name + Extension;
            } 
        }
    }

    public enum ArchiveType
    {
        Video = 1,
        Image = 2,
        Audio = 3
    }
}
