using e_shop.DataAccess;
using e_shop.Domain.Entities.Categories;

namespace e_shop.Application.Services;

public class CategoryService
{
    private readonly ShopContext _context;
    
    public CategoryService(ShopContext context)
    {
        _context = context;
    }

    public IEnumerable<Category> GetAll()
    {
        return _context.Categories;
    }

    public async Task<Category> GetById(int id)
    {
        return await _context.Categories.FindAsync(id);
    }

    public void Add(Category category)
    {
        _context.Categories.Add(category);
    }

    public int SaveChanges() => _context.SaveChanges();
}
