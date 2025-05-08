using System.ComponentModel.DataAnnotations;
using _Address = ShopIt.Models.ValueObject.Address;
using _ApplicationUser = ShopIt.Models.ApplicationUser;
namespace ShopIt.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public _ApplicationUser User { get; set; }
    }
}
