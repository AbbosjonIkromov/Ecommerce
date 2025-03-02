using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace e_shop.Application.Services
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        CategoryId = 2,
                        ParentId = 1,
                        CategoryName = "Sports",
                        CategoryDescription = "This is crazy",
                        Icon = "_dd",
                        ImagePath = "image",
                        Active = true,
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        ProductId = 2,
                        ProductName = "Ball",
                        SKU = "bb",
                        RegularPrice = 75_000,
                        DiscountPrice = 70_000,
                        Quantity = 13,
                        ProductDescription = "Awesome",
                        ProductNote = "Sports",
                        Published = true
                    }    
                );
        }
    }
}
