using System.Reflection;
using e_shop.Application.Services;
using e_shop.DateAccess.ModelConfigurition;
using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Cards;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Customers;
using e_shop.Domain.Entities.Orders;
using e_shop.Domain.Entities.Products;
using e_shop.Domain.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace e_shop.DataAccess
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
            
        }

        //private readonly string _connectionString = "Host=localhost;Port=5432;Database=e_shopDb; User Id=postgres;Password=postgresql;";
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardItem> CardItems { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }

        public DbSet<LastMonthOrder> LastMonthOrders { get; set; }
        public DbSet<OrderSummary> OrderSummaries { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //var config = new ConfigurationBuilder()
        //    //    .AddJsonFile("appsettings.json")
        //    //    .SetBasePath(Directory.GetCurrentDirectory())
        //    //    .Build();

        //    optionsBuilder.UseNpgsql(_connectionString)
        //        //.UseLazyLoadingProxies()
        //        .LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted })
        //        .UseSnakeCaseNamingConvention()
        //        .AddInterceptors(new AuditInterceptor());
        //}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly); // bu ham wunaqa iwlaydi

            modelBuilder.Entity<LastMonthOrder>()
                .ToView("last_month_orders")
                .HasNoKey();

            modelBuilder.Entity<OrderSummary>()
                .HasNoKey()
                .ToFunction("SP_GetOrders");

            #region Lesson
            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new CardConfiguration());
            //modelBuilder.ApplyConfiguration(new TagConfiguration());


            // modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Hamma IEntityConfiguration dan voris olgan larni ishlatadi

            #region DataSeeding
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category
                    {
                        CategoryId = 1,
                        ParentId = 1,
                        CategoryName = "Books",
                        CategoryDescription = "This is crazy",
                        Icon = "_bb",
                        ImagePath = "image",
                        Active = true,
                    }
                );

            modelBuilder.Entity<Product>()
                .HasData(
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
                    }
                );
            
            modelBuilder.Seed();  // ModelBuilderExtensions class orqali malumoq qushish
            #endregion    

            #endregion

        }

        #region Interceptor
        //public override int SaveChanges()
        //{

        //    var entries = ChangeTracker.Entries();

        //    var addedEntries = entries.Where(r => r.State == EntityState.Added);

        //    var updateEntries = entries.Where(r => r.State == EntityState.Modified);

        //    foreach (var entry in addedEntries)
        //    {
        //        if (entry.Entity is IAuditable entity)
        //        {
        //            entity.CreateAt = DateTime.UtcNow;
        //            entity.CreatedBy = 1;
        //        }
        //    }

        //    foreach (var entry in updateEntries)
        //    {
        //        if (entry.Entity is IAuditable entity)
        //        {
        //            entity.UpdateTime = DateTime.UtcNow;
        //            entity.UpdatedBy = 1;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
        #endregion
    }
}
