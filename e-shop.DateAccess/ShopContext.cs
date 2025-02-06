using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        private static string _connectionString = "Host=localhost;Port=5432;Database=e_shopDb; User Id=postgres;Password=postgresql;";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ShopContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString)
                .UseSnakeCaseNamingConvention();
        }
    }
}
