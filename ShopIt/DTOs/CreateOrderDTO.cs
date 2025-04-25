using ShopIt.Models.ValueObject;

namespace ShopIt.DTOs
{
    public record CreateOrderDTO
    {
        public string BuyerEmail { get; set; }
        public Guid DeliveryMethodId { get; set; }
        public Address Address { get; set; }
        public Guid CustomerCartId { get; set; }
    }
}
