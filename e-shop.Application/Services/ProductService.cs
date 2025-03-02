using e_shop.DataAccess;
using e_shop.Domain.Entities.Products;

namespace e_shop.Application.Services;

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
