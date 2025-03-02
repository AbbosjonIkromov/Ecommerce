using e_shop.DataAccess;
using e_shop.DateAccess;
using e_shop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace e_shop.WbApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            //builder.Services.AddDbContext<ShopContext>(builder =>
            //{
            //    var conntectionString = "Host=localhost;Port=5432;Database=e_shopDb; User Id=postgres;Password=postgresql;";

            //    builder.UseNpgsql(conntectionString)
            //        .LogTo(Console.WriteLine, new[] { RelationalEventId.CommandExecuted })
            //        .UseSnakeCaseNamingConvention()
            //        .AddInterceptors(new AuditInterceptor());
            //});

            builder.Services.AddSwaggerGen(); // swagger yoqish uchun

            var app = builder.Build();

            if (app.Environment.IsDevelopment()) // swagger yoqish uchun
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
