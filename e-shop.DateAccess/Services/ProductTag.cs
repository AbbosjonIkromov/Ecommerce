using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using e_shop.DataAccess;
using e_shop.Domain.Entities;
using e_shop.Domain.Entities.Categories;
using e_shop.Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DateAccess.Services
{
    public class ProductTag
    {
        public readonly ShopContext _shopContext;
        public ProductTag(ShopContext context)
        {
            _shopContext = context;
        }

        public async Task AddProduct(Product product)
        {
            await _shopContext.Products.AddAsync(product);
        }

        public async Task AddTag(Tag tag)
        {
            await _shopContext.Tags.AddAsync(tag);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return _shopContext.Products.ToList();


        }
    }
    
}
