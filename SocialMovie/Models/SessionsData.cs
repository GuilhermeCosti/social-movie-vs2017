using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class SessionsData
    {
        Dictionary<int, string> sessions { get; set; }

        public SessionsData()
        {
            sessions = new Dictionary<int, string>();
        }
        
        public int SaveSession(string value)
        {

            var random = new Random();
            var key = random.Next();
            sessions.Add(key, value);
            return key;
        }

        public bool IsInSession(string value)
        {
            return sessions.ContainsValue(value);
        }
    }
}
