using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopIt.Models;

namespace ShopIt.Data.Config
{
    public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.Property(p => p.ProductId).IsRequired();
            builder.Property(p => p.PictureUrl);
            builder.Property(p => p.Quantity).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.ProductName).IsRequired().HasMaxLength(100);

        }
    }
}
