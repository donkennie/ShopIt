namespace ShopIt.Models
{
    public class CartItem : BaseEntity
    {
        public string ProductName { get; set; }
        public string PictureURL { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
