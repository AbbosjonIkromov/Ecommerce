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
    //public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    //{
    //    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    //    {
    //        builder.HasKey(r => new { r.CategoryId, r.ProductId });

    //        builder.HasOne(r => r.Category)
    //            .WithMany(r => r.ProductCategories);

    //        builder.HasOne(r => r.Product)
    //            .WithMany(r => r.ProductCategories);
    //    }
    //}
}
