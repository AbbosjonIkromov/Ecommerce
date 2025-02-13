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
                .LogTo(Console.WriteLine, LogLevel.Information)
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Lesson
            modelBuilder.Entity<Product>()
                .Property(r => r.SKU)
                .HasMaxLength(255)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(r => r.ProductName)
                .HasMaxLength(255)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(r => r.RegularPrice)
                .HasDefaultValue(0)
                .IsRequired();

            modelBuilder.Entity<Product>(builder =>
            {
                builder.Property(r => r.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
                builder.Property(r => r.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");
            });


            modelBuilder.Entity<Category>(builder =>
            {
                builder.Property(r => r.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                builder.Property(r => r.UpdatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                builder.Property(r => r.CategoryName)
                    .HasMaxLength(255)
                    .IsRequired();

                builder.Property(r => r.Active)
                    .HasDefaultValue(true);

            });

            modelBuilder.Entity<ProductCategory>(builder =>
            {
                builder.HasKey(r => new { r.CategoryId, r.ProductId });

                builder.HasOne(r => r.Category)
                    .WithMany(r => r.ProductCategories);

                builder.HasOne(r => r.Product)
                    .WithMany(r => r.ProductCategories);
            });

            modelBuilder.Entity<Card>(builder =>
            {
                builder.HasMany(r => r.CardItems)
                    .WithOne(r => r.Card);
            });

            modelBuilder.Entity<CardItem>()
                .HasOne(r => r.Card)
                .WithMany(r => r.CardItems)
                .HasForeignKey(r => r.CardId);
            #endregion


            modelBuilder.Entity<Tag>(builder =>
            {
                builder.HasKey(r => r.TagId);

                builder.Property(r => r.TagName)
                    .HasMaxLength(255)
                    .HasColumnType("varchar")
                    .IsRequired();

                builder.Property(r => r.Icon)
                    .HasMaxLength(255)
                    .HasColumnType("varchar");

                builder.Property(r => r.CreatedAt)
                    .HasDefaultValueSql("CURRENT_TIMESTAMP");

                

            });

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

            modelBuilder.Entity<ProductCategory>()
                .HasData(
                    new ProductCategory
                    {
                        CategoryId = 1,
                        ProductId = 1
                    }
                );

            
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
