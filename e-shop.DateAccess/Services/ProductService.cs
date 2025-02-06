using e_shop.DataAccess;
using e_shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.DateAccess.Services;

public class ProductService
{
    private readonly ShopContext _context;
    public ProductService(ShopContext context)
    {
        _context = context;
    }

    public IEnumerable<Product> GetAll()
    {
        return _context.Products;
    }
    public async Task<Product> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }
    
    public void Add(Product product)
    {
        _context.Products.Add(product);
    }

    public int SaveChanges() => _context.SaveChanges();
}
