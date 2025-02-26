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
    internal class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress> 
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.AddressLine1)
                .HasColumnType("varchar")
                .HasDefaultValue("Tashkent");

            builder.Property(r => r.AddressLine2)
                .HasColumnType("varchar")
                .HasDefaultValue("Kashkadarya");

            builder.Property(r => r.Country)
                .HasColumnType("varchar")
                .HasDefaultValue("Uzbekistan");

            builder.Property(r => r.City)
                .HasColumnType("varchar")
                .HasDefaultValue("Tashkent");

            builder.Property(r => r.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            
        }
    }
}
