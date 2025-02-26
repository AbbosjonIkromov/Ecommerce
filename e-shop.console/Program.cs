using Bogus;
using e_shop.DataAccess;
using e_shop.DateAccess.Services;
using e_shop.Domain.Entities.Cards;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Customers;
using e_shop.Domain.Entities.Orders;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace e_shop.console;
class Program
{
    static async Task Main(string[] args)
    {
        await using var dbContext = new ShopContext();
        var productService = new ProductService(dbContext);
        var categoryService = new CategoryService(dbContext);
        var customerService = new CustomerService(dbContext);
        var cardService = new CardService(dbContext);
        var orderService = new OrderService(dbContext);

        #region Practice
        //var product1 = new Product
        //{
        //    ProductId = 1,
        //    ProductName = "Banana",
        //    ProductDescription = "Fruits",
        //    SKU = "Sk1",
        //    RegularPrice = 100,
        //    DiscountPrice = 90,
        //    Quantity = 10,
        //    ProductWeight = 1,
        //    ProductNote = "Fresh",
        //    Published = true,
        //    CreatedBy = 1,
        //    UpdatedBy = 1
        //};

        //productService.Add(product1);
        //productService.SaveChanges();

        //var category = new Category()
        //{
        //    CategoryName = "Toys",
        //    Active = false,
        //    Icon = "",
        //    ImagePath = "Path",
        //    CategoryDescription = "Toys Toys",
        //};

        //categoryService.Add(category);
        //categoryService.SaveChanges();

        //var customer = new Customer()
        //{
        //    FirstName = "Ali",
        //    LastName = "Malikov",
        //    Email = "ali142342",
        //    Active = true,
        //    PhoneNumber = "2222222",
        //    PasswordHash = "password",
        //    CustomerAddresses = new List<CustomerAddress>()
        //    {
        //        new CustomerAddress()
        //        {
        //            CustomerId = 5,
        //            AddressLine2 = "aaaaaaa",
        //            PhoneNumber = "9998888",
        //            AddressLine1 = "Tashkent",
        //            City = "Tashkent",
        //            Country = "Uzbekistan",
        //            PostalCode = "10000",
        //        }
        //    }
        //};



        //await customerService.AddCustomer(customer);
        //await customerService.AddCustomerAddress(customerAddress);
        //customerService.SaveChanges();

        //var card = new Card()
        //{
        //    CardId = 2,
        //    CustomerId = 5,
        //    CardItems = new List<CardItem>()
        //    {
        //        new CardItem()
        //        {
        //            Id = 2,
        //            ProductId = 1,
        //            CardId = 2,
        //            Quantity = 5
        //        }
        //    }
        //};

        //var cardItem = new CardItem()
        //{
        //    Id = 1,
        //    ProductId = 1,
        //    CardId = 1,
        //    Quantity = 2
        //};

        //var updateCard = dbContext.CardItems.FirstOrDefault(s => s.Id == 2);
        //updateCard.Quantity = 3;


        //cardService.AddCard(card);
        //cardService.SaveChanges();

        //var allCards = cardService.GetCards();
        //foreach (var c in allCards)
        //{
        //    Console.WriteLine(c.CardId);
        //}

        /*
        var deletedCategory = dbContext.Categories.Find(1);
        if (deletedCategory is not null)
        {
            dbContext.Categories.Remove(deletedCategory);
            dbContext.SaveChanges();
        }

        var deletedProduct = dbContext.Products.Find(1);
        if (deletedProduct is not null)
        {
            dbContext.Products.Remove(deletedProduct);
            dbContext.SaveChanges();
            Console.WriteLine("Product deleted!");
        }
        */

        //DataSeeder.SeedData(dbContext); // DataSeeder class orqali malumot qushish



        ////var categories = dbContext.Categories
        ////    .Include(r => r.Products)
        ////    .ToList();

        //foreach (var category in categories)
        //{
        //    Console.WriteLine($"CategoryId: {category.CategoryId}, CategoryName: {category.CategoryName}");
        //    foreach (var product in category.Products)
        //    {
        //        Console.WriteLine($"productId: {product.ProductId}, productName: {product.ProductName}");
        //    }
        //}


        //var categories = dbContext.Categories.ToList();

        //if (!categories.Any())
        //{
        //    Console.WriteLine("NOT FOUND");
        //}

        //foreach (var category in dbContext.Categories.ToList())
        //{
        //    var product = new Product()
        //    {
        //        ProductName = "Chocolate",
        //        ProductDescription = "Fruits",
        //        SKU = "Sk1",
        //        RegularPrice = 100,
        //        DiscountPrice = 90,
        //        Quantity = 10,
        //        ProductWeight = 1,
        //        ProductNote = "Fresh",
        //        Published = true,
        //        CreatedBy = 1,
        //        UpdatedBy = 1
        //    };
        //    product.Categories.Add(category);
        //    dbContext.Products.Add(product);
        //}

        //dbContext.SaveChanges();

        //var categoryProduct = await dbContext.Categories
        //    .Include(r => r.Products)
        //    .ToListAsync();

        //foreach (var category in categoryProduct)
        //{
        //    Console.WriteLine($"CategoryId {category.CategoryId}, CategoryName:{category.CategoryName}");
        //    foreach (var product in category.Products)
        //    {
        //        Console.WriteLine($"ProductId: {product.ProductId}, ProductName: {product.ProductName}");
        //    }
        //}

        //var deletedCategory = dbContext.Products.Where(r => r.ProductId < 15).ToList();
        //dbContext.Products.RemoveRange(deletedCategory);

        //dbContext.SaveChanges();
        #endregion

        var product = new Product()
        {
            ProductId = 40,
            ProductName = "Name",
            ProductNote = "Note",
            ProductWeight = 1,
            ProductDescription = "This is crazy",
            Published = false,
            RegularPrice = 45.00m,
            DiscountPrice = 15.00m,
            SKU = " "
        };
        //Console.WriteLine(dbContext.Products.Entry(product).State);

        //dbContext.Attach(product);
        //Console.WriteLine(dbContext.Products.Entry(product).State);
        //product.ProductName = "Name1";
        //Console.WriteLine(dbContext.Products.Entry(product).State);

        ////dbContext.SaveChanges();
        //Console.WriteLine(dbContext.ChangeTracker.DebugView.LongView);

        List<Order> orders = new List<Order>
        {
            new Order { Id = 1, CouponId = 1, CustomerId = 14, OrderStatusId = 1, OrderApprovedAt = DateTime.UtcNow.AddDays(-6) },
            new Order { Id = 2, CouponId = 2, CustomerId = 15, OrderStatusId = 2, OrderApprovedAt = DateTime.UtcNow.AddDays(-5) },
            new Order { Id = 3, CouponId = 3, CustomerId = 16, OrderStatusId = 3, OrderApprovedAt = DateTime.UtcNow.AddDays(-4) },
            new Order { Id = 4, CouponId = 1, CustomerId = 17, OrderStatusId = 1, OrderApprovedAt = DateTime.UtcNow.AddDays(-3) },
            new Order { Id = 5, CouponId = 2, CustomerId = 18, OrderStatusId = 2, OrderApprovedAt = DateTime.UtcNow.AddDays(-3) },
            new Order { Id = 6, CouponId = 3, CustomerId = 19, OrderStatusId = 3, OrderApprovedAt = DateTime.UtcNow.AddDays(-2) },
            new Order { Id = 7, CouponId = 1, CustomerId = 20, OrderStatusId = 1, OrderApprovedAt = DateTime.UtcNow.AddDays(-1) }
        };

        dbContext.Orders.AddRange(orders);
        dbContext.SaveChanges();

        Console.WriteLine("DONE!");

        Console.ReadLine();

    }
}
