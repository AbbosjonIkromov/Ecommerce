using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DateAccess.ModelConfigurition
{
    internal class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Price)
                .HasPrecision(10, 2)
                .HasDefaultValue(0.00m);

            builder.Property(r => r.Quantity)
                .HasColumnType("integer")
                .HasDefaultValue("0");

            builder.Property(r => r.ShippingId)
                .HasDefaultValue(1);

            builder.HasOne(r => r.Order)
                .WithOne(r => r.OrderItem)
                .HasForeignKey<OrderItem>(r => r.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
