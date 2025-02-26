using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DateAccess.ModelConfigurition
{
    internal class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.FirstName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(r => r.LastName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(r => r.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(r => r.Email)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(r => r.Active)
                .HasColumnType("bool")
                .HasDefaultValue(false);

            builder.Property(r => r.RegisteredAt)
                .HasColumnType("timestamp")
                .HasDefaultValueSql("current_timestamp");

            builder.HasMany(r => r.CustomerAddresses)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.CustomerId);
        }
    }
}
