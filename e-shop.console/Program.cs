using e_shop.DataAccess;
using e_shop.DateAccess.Services;
using e_shop.Domain.Entities.Cards;

namespace e_shop.console;
class Program
{
    static async Task Main(string[] args)
    {
        using var dbContext = new ShopContext();
        var productService = new ProductService(dbContext);
        var categoryService = new CategoryService(dbContext);
        var customerService = new CustomerService(dbContext);
        var cardService = new CardService(dbContext);
        
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

         

        Console.ReadLine();

    }
}
