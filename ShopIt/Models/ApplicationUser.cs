using Microsoft.AspNetCore.Identity;
using _Address = ShopIt.Models.ValueObject.Address;

namespace ShopIt.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Username { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int ZipCode { get; set; }
        public string Country { get; set; } = string.Empty;
        public string Password { get; set; }
        public _Address ShippingAddress { get; set; }

    }
}
