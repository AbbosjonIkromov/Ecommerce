using e_shop.Domain.Entities.Cards;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Customers;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        private readonly string _connectionString = "Host=localhost;Port=5432;Database=e_shopDb; User Id=postgres;Password=postgresql;";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardItem> CardItems { get; set; }

        //public ShopContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSnakeCaseNamingConvention();
        }
    }
}
