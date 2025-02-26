using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using e_shop.DataAccess;
using e_shop.Domain.Entities.Orders;
using Microsoft.EntityFrameworkCore;

namespace e_shop.DateAccess.Services
{
    public class OrderService
    {
        private readonly ShopContext _context;

        public OrderService(ShopContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAll()
        {
            return _context.Orders
                .Include(r => r.OrderItems)
                .ToList();
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        public async Task<List<OrderItem>> GetOrderItems()
        {
            return await _context.OrderItems.ToListAsync();
        }

        public async Task<List<OrderStatus>> GetOrderStatuses()
        {
            return await _context.OrderStatuses
                .Include(r => r.Orders)
                .ToListAsync();
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return await _context.Orders.FindAsync(orderId);
        }

        public async Task<OrderItem> GetOrderItemById(int orderItemId)
        {
            return await _context.OrderItems.FindAsync(orderItemId);
        }

        public async Task<OrderStatus> GetOrderStatusById(int orderStatusId)
        {
            return await _context.OrderStatuses.FindAsync(orderStatusId);
        }
        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            _context.SaveChanges();
        }

        public void AddOrderStatus(OrderStatus orderStatus)
        {
            _context.OrderStatuses.Add(orderStatus);
            _context.SaveChanges();
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            var existingOrder = await _context.Orders.FindAsync(order.Id);
            if (existingOrder is null)
            {
                return false;
            }

            existingOrder.OrderApprovedAt = order.OrderApprovedAt;
            existingOrder.OrderDeliveredCustomerDate = order.OrderDeliveredCustomerDate;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOrderItem(OrderItem orderItem)
        {
            var existingOrderItem = await _context.OrderItems.FindAsync(orderItem.Id);
            if (existingOrderItem is null)
            {
                return false;
            }

            existingOrderItem.Price = orderItem.Price;
            existingOrderItem.Quantity = orderItem.Quantity;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOrderStatus(OrderStatus orderStatus)
        {
            var existingOrderStatus = await _context.OrderStatuses.FindAsync(orderStatus.Id);
            if (existingOrderStatus is null)
            {
                return false;
            }

            existingOrderStatus.Color = orderStatus.Color;
            existingOrderStatus.Privacy = orderStatus.Privacy;
            existingOrderStatus.StatusName = orderStatus.StatusName;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteOrder(int orderId)
        {
            var order = await _context.Orders.FindAsync(orderId);
            if (order is null)
            {
                return false;
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
