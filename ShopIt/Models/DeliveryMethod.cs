using Microsoft.EntityFrameworkCore;

namespace ShopIt.Models
{
    public class DeliveryMethod : BaseEntity
    {
        public string DeliveryTime { get; set; }
        public string Description { get; set; }
        [Precision(18, 4)]
        public decimal Price { get; set; }
        [Precision(18, 4)] // Only in .NET
        public decimal AdditionalFee { get; set; }
    }
}
