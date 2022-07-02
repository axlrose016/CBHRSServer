using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AXLSmartWebAPI.Models.Auth
{
    public class AuthCredentials
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class TokenModel
    {
        public string token { get; set; }
        public string expiration { get; set; }
        public string userId { get; set; }
        public string personId { get; set; }
        public string userName { get; set; }
    }
}
