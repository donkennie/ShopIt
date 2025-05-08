﻿namespace ShopIt.Models
{
    public class OrderItem : BaseEntity
    {
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public CartItem CartItem { get; set; }
        public int ProductId { get; set; }
        public string PictureUrl { get; set; }
        public string ProductName { get; set; }
    }
}
