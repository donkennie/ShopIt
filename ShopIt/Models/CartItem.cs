namespace ShopIt.Models
{
    public class CartItem : BaseEntity
    {
        public string ProductName { get; set; }
        public string PictureURL { get; set; }
        public int Quantity { get; set; }
    }
}
