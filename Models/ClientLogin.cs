using System.ComponentModel.DataAnnotations;

namespace keycloakIdentityProvider.Models
{
    public class ClientLogin
    {
        [Required]
        public string? userName { get; set;}
        [Required]
        public string? password { get; set;}
    }
}
