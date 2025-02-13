using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Categories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace e_shop.DateAccess.ModelConfigurition
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            
                builder.Property(r => r.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                builder.Property(r => r.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                builder.Property(r => r.CategoryName)
                    .HasMaxLength(255)
                    .IsRequired();

                builder.Property(r => r.Active)
                    .HasDefaultValue(true);



        }
    }
}
