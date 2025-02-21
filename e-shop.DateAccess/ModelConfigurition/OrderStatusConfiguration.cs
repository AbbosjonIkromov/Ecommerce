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
    internal class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Color)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(r => r.Privacy)
                .HasColumnType("varchar")
                .HasMaxLength(100);
            builder.HasOne(r => r.Order)
                .WithOne(r => r.OrderStatus)
                .HasForeignKey<OrderStatus>(r => r.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
