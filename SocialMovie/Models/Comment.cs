using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        [ForeignKey("Archive")]
        public int ArchiveId { get; set; }
    }
}
