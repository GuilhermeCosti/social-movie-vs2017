using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class EmailSettings
    {
        public int Port { get; set; }
        public string Password { get; set; }
        public string Server { get; set; }
        public string Login { get; set; }
        public string From {
            get
            {
                return Login;
            }
        }
    }
}
