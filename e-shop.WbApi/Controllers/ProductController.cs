using e_shop.DataAccess;
using e_shop.Domain.Entities.Products;
using e_shop.WbApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace e_shop.WbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet("all-products")]
    public IActionResult GetAllProducts()
    {
        using var context = new ShopContext();
        var products = context.Products
            .Select(r => new
            {
                Id = r.ProductId,
                ProductName = r.ProductName,
                ProductDescription = r.ProductDescription,
                ProductWeight = r.ProductWeight,
                Quantity = r.Quantity,
                ProductNote = r.ProductNote,
                SKU = r.SKU,
                Published = r.Published

            }).ToList();

        return Ok(products);
    }

    [HttpPost("add-product")]
    public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
    {
        var product = new Product()
        {
            ProductId = productDto.Id,
            ProductName = productDto.ProductName,
            ProductDescription = productDto.ProductDescription,
            ProductWeight = productDto.ProductWeight,
            SKU = productDto.SKU,
            ProductNote = productDto.ProductNote,
            Quantity = productDto.Quantity,
            Published = productDto.Published,
        };

        await using var context = new ShopContext();
        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();
        
        return Ok(product);
    }

    [HttpDelete("delete-product")]
    public async Task<IActionResult> DeleteProduct([FromQuery] int id)
    {
        await using var context = new ShopContext();
        var product = await context.Products.FindAsync(id);
        if (product is null)
        {
            return NotFound();
        }
        context.Products.Remove(product);
        await context.SaveChangesAsync();
        return Ok(product);
    }
}

