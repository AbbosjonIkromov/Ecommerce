using e_shop.DataAccess;
using e_shop.Domain.Entities.Categories;
using e_shop.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop.WbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ShopContext context;

    public CategoryController(ShopContext context)
    {
        this.context = context;
    }
    [HttpGet("all-categories")]
    public async Task<IActionResult> GetAllCategories()
    {
        var categories = await context.Categories
            .Select(r => new
            {
                Id = r.CategoryId,
                CategoryName = r.CategoryName,
                CategoryDescription = r.CategoryDescription,
                Icon = r.Icon,
                ImagePath = r.ImagePath,
                Active = r.Active,
            }).ToListAsync();

        return Ok(categories);
    }

    [HttpPost("add-category")]
    public async Task<IActionResult> AddCategory([FromBody] CategoryDto categoryDto)
    {
        var category = new Category()
        {
            CategoryId = categoryDto.Id,
            CategoryName = categoryDto.CategoryName,
            CategoryDescription = categoryDto.CategoryDescription,
            Icon = categoryDto.Icon,
            ImagePath = categoryDto.ImagePath,
            Active = categoryDto.Active,
        };

        await context.Categories.AddAsync(category);
        await context.SaveChangesAsync();
        return Ok(category);
    }

    [HttpDelete("delete-category")]
    public async Task<IActionResult> DeleteCategory([FromQuery] int id)
    {
        var category = await context.Categories.FindAsync(id);
        if (category is null)
        {
            return NotFound();
        }

        context.Categories.Remove(category);
        await context.SaveChangesAsync();
        return Ok(category);
    }
}

