using System.Net;

namespace keycloakIdentityProvider.Models
{
   
    public class Credential
    {
        public string? type { get; set; }
        public string? value { get; set; }
    }
    public class Register
    {
        public string? username { get; set; }
        public string? email { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public bool enabled { get; set; }
       
        public List<Credential>? credentials { get; set; }
    }
}
