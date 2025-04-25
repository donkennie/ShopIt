using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShopIt.Models;

namespace ShopIt.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(p => p.OrderDate).IsRequired();
            builder.Property(p => p.OrderItems).IsRequired();
            builder.Property(p => p.OrderStatus).IsRequired();
            builder.Property(p => p.SubTotal).IsRequired();
            builder.Property(p => p.BuyerEmail).IsRequired();
            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.DeliveryMethod).IsRequired();
        }
    }
}
