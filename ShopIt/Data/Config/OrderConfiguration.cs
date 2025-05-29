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
            builder.Property(p => p.ShippingAddress);
        }
    }

    public static class OrderConfig
    {
        public static void Configure(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().OwnsOne(s => s.ShippingAddress, a =>
            {
                a.Property(p => p.Street).HasMaxLength(50);
                a.Property(p => p.City).HasMaxLength(100);
                a.Property(p => p.State).HasMaxLength(15);
                a.Property(p => p.ZipCode).HasMaxLength(10);
                a.Property(p => p.Country).HasMaxLength(20);
            });
        }
    }
}
