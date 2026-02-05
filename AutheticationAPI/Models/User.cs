using Microsoft.AspNetCore.Identity;

namespace AutheticationAPI.Models
{
    public class User : IdentityUser
    {
        public string Document { get; set; } = string.Empty;
    }
}
