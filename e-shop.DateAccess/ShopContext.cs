using System.Reflection;
using e_shop.DateAccess.ModelConfigurition;
using e_shop.DateAccess.Services;
using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Cards;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Customers;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProductTag = e_shop.Domain.Entities.Products.ProductTag;

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
        public DbSet<Tag> Tags { get; set; }

        //public ShopContext()
        //{
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString)
                .UseLazyLoadingProxies()
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Lesson

            //modelBuilder.ApplyConfiguration(new ProductConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new CardConfiguration());
            //modelBuilder.ApplyConfiguration(new TagConfiguration());


           // modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // Hamma IEntityConfiguration dan voris olgan larni ishlatadi
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ShopContext).Assembly); // bu ham wunaqa iwlaydi
            

            modelBuilder.Entity<CardItem>()
                .HasOne(r => r.Card)
                .WithMany(r => r.CardItems)
                .HasForeignKey(r => r.CardId);
            #endregion


            modelBuilder.Entity<ProductTag>(builder => 
            {
                builder.HasKey(r => new { r.ProductId, r.TagId });

                builder.HasOne(r => r.Product)
                    .WithMany(r => r.ProductTags);

                builder.HasOne(r => r.Tag)
                    .WithMany(r => r.ProductTags);


            });

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

            //modelBuilder.Entity<ProductCategory>()
            //    .HasData(
            //        new ProductCategory
            //        {
            //            CategoryId = 1,
            //            ProductId = 1
            //        }
            //    );

            
            modelBuilder.Seed();  // ModelBuilderExtensions class orqali malumoq qushish

            

        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<Category>())
            {
                if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedAt = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();  
        }
    }
}
