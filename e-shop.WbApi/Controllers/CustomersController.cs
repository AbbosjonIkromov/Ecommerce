﻿using System.Text;
using e_shop.DataAccess;
using e_shop.Domain.Entities.Customers;
using e_shop.Application.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop.WbApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ShopContext context;

    public CustomersController(ShopContext context)
    {
        this.context = context;
    }

    [HttpGet("all-customers")]
    public async Task<IActionResult> GetAllCustomers()
    {
        var customers =  await context.Customers
            .Select(r => new
            {
                Id = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                PhoneNumber = r.PhoneNumber,
                Password = Encoding.UTF8.GetString(Convert.FromBase64String(r.PasswordHash)),
            }).ToListAsync();

        return Ok(customers);
    }

    [HttpPost("add-customer")]
    public async Task<IActionResult> AddCustomer([FromBody] CreateCustomerRequestDto customerDto)
    {
        var customer = new Customer()
        {
            FirstName = customerDto.FirstName,
            LastName = customerDto.LastName,
            PhoneNumber = customerDto.PhoneNumber,
            PasswordHash = Convert.ToBase64String(Encoding.UTF8.GetBytes(customerDto.Password)),
            Active = true
        };

        await context.Customers.AddAsync(customer);
        await context.SaveChangesAsync();
        return Ok(customer);
    }

    [HttpDelete("remove-customer")]
    public async Task<IActionResult> DeleteCustomer([FromQuery] int id)
    {
        var customer = await context.Customers.FindAsync(id);
        if (customer is null)
        {
            return NotFound("Customer not found");
        }

        context.Customers.Remove(customer);
        await context.SaveChangesAsync();
        return Ok();
    }
}

