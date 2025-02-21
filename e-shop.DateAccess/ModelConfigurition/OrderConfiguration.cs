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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.OrderApprovedAt)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("current_timestamp");

            builder.Property(r => r.OrderDeliveredCustomerDate)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("current_timestamp");

            builder.HasOne(r => r.Customer)
                .WithMany(r => r.Orders)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
