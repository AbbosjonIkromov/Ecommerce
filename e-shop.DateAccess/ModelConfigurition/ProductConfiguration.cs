using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DateAccess.ModelConfigurition
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .Property(r => r.SKU)
                .HasMaxLength(255)
                .HasColumnType("varchar")
                .IsRequired();

            builder
                .Property(r => r.ProductName)
                .HasMaxLength(255)
                .IsRequired();

            builder
                .Property(r => r.RegularPrice)
                .HasDefaultValue(0)
                .IsRequired();

            builder.Property(r => r.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.Property(r => r.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP");

            builder.HasMany(r => r.Categories)
                .WithMany(r => r.Products);

        }
    }
}
