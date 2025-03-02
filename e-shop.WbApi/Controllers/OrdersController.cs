using e_shop.DataAccess;
using e_shop.Domain.Entities.Orders;
using e_shop.Application.Dtos;
using e_shop.Application.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace e_shop.WbApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet("all-orders")]
        public async Task<IActionResult> GetAllOrders()
        {
            await using var context = new ShopContext();
            var orders = await context.Orders
                .Select(r => new
                {
                    r.Id,
                    r.CustomerId,
                    r.OrderStatusId,
                    r.OrderApprovedAt
                }).ToListAsync();

            return Ok(orders);
        }

        [HttpGet("get-last-month")]
        public async Task<IActionResult> GetLastMonthOrders()
        {
            await using var context = new ShopContext();
            var lastMonthOrders = await context.LastMonthOrders
                .Select(r => new
                {
                    r.Id,
                    r.CustomerId,
                    r.OrderStatusId,
                    r.OrderApprovedAt
                }).ToListAsync();

            return Ok(lastMonthOrders);
        }

        [HttpGet("get-by-date-range")]
        public async Task<IActionResult> GetOrdersByDateRange([FromQuery] DateTime fromDate, [FromQuery] DateTime toDate)
        {
            await using var context = new ShopContext();

            fromDate = DateTime.SpecifyKind(fromDate, DateTimeKind.Utc);
            toDate = DateTime.SpecifyKind(toDate, DateTimeKind.Utc);

            var orders = await context.OrderSummaries
                .FromSqlRaw("Select * from \"SP_GetOrders\"({0}, {1})", fromDate, toDate)
                .ToListAsync();
            

            return Ok(orders);


        }

        [HttpPost("add-order/{id}")]
        public async Task<IActionResult> AddOrder([FromRoute] int id, [FromBody] OrderDto orderDto)
        {
            await using var context = new ShopContext();
            var customer = await context.Customers.FindAsync(id);
            if (customer is null)
            {
                return NotFound("Customer not found");
            }

            var order = new Order()
            {
                //Id = orderDto.Id,
                CustomerId = id,
                OrderStatusId = orderDto.OrderStatusId,
               // OrderItems = orderDto.OrderItems
            };

            await context.Orders.AddAsync(order);
            await context.SaveChangesAsync();
            return Ok(order);
        }

        [HttpDelete("delete-order{orderId}")]
        public async Task<IActionResult> DeleteOrder([FromRoute] int orderId)
        {
            await using var context = new ShopContext();
            var order = await context.Orders.FindAsync(orderId);
            if (order is null)
            {
                return NotFound("Order not found");
            }
            context.Orders.Remove(order);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("create-order")]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderRequestDto orderDto)
        {
            var validator = new CreateOrderRequestDtoValidator();
            
            await validator.ValidateAndThrowAsync(orderDto);
            return Ok();
        }
    }
}
