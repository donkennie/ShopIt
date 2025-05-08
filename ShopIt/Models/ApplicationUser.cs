using Microsoft.AspNetCore.Identity;

namespace ShopIt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Street { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;
        public string? State { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public string? Country { get; set; } = string.Empty;

    }
}
