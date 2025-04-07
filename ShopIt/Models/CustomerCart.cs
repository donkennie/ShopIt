namespace ShopIt.Models
{
    public class CustomerCart : BaseEntity
    {
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

        public decimal ShippingPrice { get; set; }
        public Guid DeliveryMethodId { get; set; }
        public virtual DeliveryMethod DeliveryMethod { get; set; }
    }
}
