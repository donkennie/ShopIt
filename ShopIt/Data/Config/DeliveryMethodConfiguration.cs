using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ShopIt.Models;

namespace ShopIt.Data.Config
{
    public class DeliveryMethodConfiguration : IEntityTypeConfiguration<DeliveryMethod>
    {
        public void Configure(EntityTypeBuilder<DeliveryMethod> builder)
        {
            builder.Property(p => p.DeliveryTime).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(p => p.LastModified).IsRequired();
            builder.Property(p => p.AdditionalFee).IsRequired();
        }
    }
}
