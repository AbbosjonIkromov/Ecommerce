using e_shop.DataAccess;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Products;

namespace e_shop.Application.Services
{
    public class DataSeeder
    {
        public static void SeedData(ShopContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        CategoryId = 1,
                        ParentId = 1,
                        CategoryName = "Books",
                        CategoryDescription = "This is crazy",
                        Icon = "_bb",
                        ImagePath = "image",
                        Active = true,
                    },
                    
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

                if (!context.Products.Any())
                {
                    context.Products.AddRange(
                        new Product
                        {
                            ProductId = 1,
                            ProductName = "Yashamoq",
                            SKU = "bb",
                            RegularPrice = 45_000,
                            DiscountPrice = 37_000,
                            Quantity = 13,
                            ProductDescription = "Awesome",
                            ProductNote = "Library",
                            Published = true
                        },

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
    }
}
