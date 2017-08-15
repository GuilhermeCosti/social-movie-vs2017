using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class User
    {
        public int Id { get; set; }
        public DateTime Birthday { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public byte[] Salt { get; set; }
        public Archive Avatar { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
