using e_shop.DataAccess;
using e_shop.DateAccess.Services;
using e_shop.Domain.Entities;

namespace e_shop.console;
    class Program
{
    static void Main(string[] args)
    {
        using var dbContext = new ShopContext();
        var productService = new ProductService(dbContext);
        var product1 = new Product
        {
            ProductName = "Banan",
            ProductDescription = "Fruits",
            SKU = "Sk1",
            RegularPrice = 100,
            DiscountPrice = 90,
            Quantity = 10,
            ProductWeight = 1,
            ProductNote = "Fresh",
            Published = true,
            CreatedBy = 1,
            UpdatedBy = 1
        };
        productService.Add(product1);
        productService.SaveChanges();

    }
}
