using System.ComponentModel.DataAnnotations;

namespace ShopIt.DTOs
{
    public record LoginDTO
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
