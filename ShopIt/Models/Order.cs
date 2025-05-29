using Microsoft.EntityFrameworkCore;
using ShopIt.Models.Enums;
using _Address = ShopIt.Models.ValueObject.Address;

namespace ShopIt.Models
{
    public class Order : BaseEntity
    {
        public string BuyerEmail { get; set; }
        public DateTime OrderDate { get; set; }
        public DeliveryMethod DeliveryMethod { get; set; }
        public IReadOnlyList<OrderItem> OrderItems { get; set; }
        [Precision(18, 4)] // Only in .NET 6
        public decimal SubTotal { get; set; }
        public _Address? ShippingAddress { get; set; } = new();
        public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;
    }

}
