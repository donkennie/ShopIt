using Microsoft.EntityFrameworkCore;

namespace ShopIt.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Precision(18, 4)] // Only in .NET 6+
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public string Brand { get; set; } = string.Empty;
        public string? PictureURL { get; set; }

        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; } = new Category();

    }
}
