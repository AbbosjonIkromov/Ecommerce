using e_shop.DataAccess;
using e_shop.Domain.Entities.Products;
using e_shop.Application.Dtos;
using e_shop.Application.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop.WbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly ShopContext context;

    public ProductController(ShopContext context)
    {
        this.context = context;
    }
    [HttpGet("all-products")]
    public async Task<IActionResult> GetAllProducts()
    {
        var products = await context.Products
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

            }).ToListAsync();

        return Ok(products);
    }

    [HttpPost("create-product")]
    public async Task<IActionResult> CreateProduct([FromBody] CreateProductRequesDto productDto)
    {
        var validator = new CreateProductRequestDtoValidator();
        var validatorRequest = await validator.ValidateAsync(productDto);

        if (!validatorRequest.IsValid)
        {
            return BadRequest(validatorRequest.Errors);
        }

        var product = new Product()
        {
            ProductName = productDto.ProductName,
            ProductDescription = productDto.ProductDescription,
            ProductWeight = productDto.ProductWeight,
            SKU = productDto.SKU,
            ProductNote = productDto.ProductNote,
            Quantity = productDto.Quantity,
            Published = productDto.Published,
        };

        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();

        return Ok(product);

    }

    [HttpPost("add-product")]
    public async Task<IActionResult> AddProduct([FromBody] CreateProductRequesDto productDto)
    {
        var product = new Product()
        {
            ProductName = productDto.ProductName,
            ProductDescription = productDto.ProductDescription,
            ProductWeight = productDto.ProductWeight,
            SKU = productDto.SKU,
            ProductNote = productDto.ProductNote,
            Quantity = productDto.Quantity,
            Published = productDto.Published,
        };

        await context.Products.AddAsync(product);
        await context.SaveChangesAsync();
        
        return Ok(product);
    }

    [HttpDelete("delete-product")]
    public async Task<IActionResult> DeleteProduct([FromQuery] int id)
    {
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

