using Microsoft.AspNetCore.Identity;

namespace WebApiLab.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Role { get; set; }
    }
}