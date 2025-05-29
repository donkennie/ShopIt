using Microsoft.EntityFrameworkCore;

namespace ShopIt.Models
{
    public class OrderItem : BaseEntity
    {
        [Precision(18, 4)] // Only in .NET 6+
        public decimal Price { get; set; }

        public int Quantity { get; set; }
        public CartItem CartItem { get; set; }
        public int ProductId { get; set; }
        public string PictureUrl { get; set; }
        public string ProductName { get; set; }
    }
}
