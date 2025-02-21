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
            return await _context.Orders
                .Include(r => r.OrderItem)
                .Include(r => r.OrderStatus)
                .ToListAsync();
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
            return await _context.OrderStatuses.ToListAsync();
        }

        public async Task<Order> GetOrderById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public async Task<OrderItem> GetOrderItemById(int orderItemId)
        {
            return _context.OrderItems.Find(orderItemId);
        }

        public async Task<OrderStatus> GetOrderStatusById(int orderStatusId)
        {
            return _context.OrderStatuses.Find(orderStatusId);
        }
        public void AddOrder(Order order)
        {
            Console.WriteLine(_context.Orders.Entry(order).State);
            _context.Orders.Add(order);
            _context.SaveChanges();
            Console.WriteLine(_context.Orders.Entry(order).State);
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Console.WriteLine(_context.OrderItems.Entry(orderItem).State);
            _context.OrderItems.Add(orderItem);
            _context.SaveChanges();
            Console.WriteLine(_context.OrderItems.Entry(orderItem).State);
        }

        public void AddOrderStatus(OrderStatus orderStatus)
        {
            Console.WriteLine(_context.OrderStatuses.Entry(orderStatus).State);
            _context.OrderStatuses.Add(orderStatus);
            _context.SaveChanges();
            Console.WriteLine(_context.OrderStatuses.Entry(orderStatus).State);
        }

        public async Task<bool> UpdateOrder(Order order)
        {
            Console.WriteLine(_context.Orders.Entry(order).State);
            var existingOrder = _context.Orders.Find(order.Id);
            if (existingOrder is null)
            {
                return false;
            }

            existingOrder.OrderApprovedAt = order.OrderApprovedAt;
            existingOrder.OrderDeliveredCustomerDate = order.OrderDeliveredCustomerDate;
            Console.WriteLine(_context.Orders.Entry(existingOrder).State);
            _context.SaveChanges();
            Console.WriteLine(_context.Orders.Entry(existingOrder).State);
            return true;
        }

        public async Task<bool> UpdateOrderItem(OrderItem orderItem)
        {
            Console.WriteLine(_context.OrderItems.Entry(orderItem).State);
            var existingOrderItem = _context.OrderItems.Find(orderItem.Id);
            if (existingOrderItem is null)
            {
                return false;
            }

            existingOrderItem.Price = orderItem.Price;
            existingOrderItem.Quantity = orderItem.Quantity;
            Console.WriteLine(_context.OrderItems.Entry(existingOrderItem).State);
            _context.SaveChanges();
            Console.WriteLine(_context.OrderItems.Entry(existingOrderItem).State);
            return true;
        }

        public async Task<bool> UpdateOrderStatus(OrderStatus orderStatus)
        {
            Console.WriteLine(_context.OrderStatuses.Entry(orderStatus).State);
            var existingOrderStatus = _context.OrderStatuses.Find(orderStatus.Id);
            if (existingOrderStatus is null)
            {
                return false;
            }

            existingOrderStatus.Color = orderStatus.Color;
            existingOrderStatus.Privacy = orderStatus.Privacy;
            existingOrderStatus.StatusName = orderStatus.StatusName;
            Console.WriteLine(_context.OrderStatuses.Entry(existingOrderStatus).State);
            _context.SaveChanges();
            Console.WriteLine(_context.OrderStatuses.Entry(existingOrderStatus).State);
            return true;
        }

        public async Task<bool> DeleteOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            Console.WriteLine(_context.Orders.Entry(order).State);
            if (order is null)
            {
                return false;
            }

            _context.Orders.Remove(order);
            Console.WriteLine(_context.Orders.Entry(order).State);
            _context.SaveChanges();
            Console.WriteLine(_context.Orders.Entry(order).State);
            return true;
        }

    }
}
