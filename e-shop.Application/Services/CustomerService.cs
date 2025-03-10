﻿using e_shop.DataAccess;
using e_shop.Domain.Entities.Customers;
using Microsoft.EntityFrameworkCore;

namespace e_shop.Application.Services
{
    public interface ICustomerService
    {
        Task AddCustomer(Customer customer);
        Task AddCustomerAddress(CustomerAddress customerAddress);
        IEnumerable<Customer> GetCustomers();
        int SaveChanges();
    }
    public class CustomerService
    {
        private readonly ShopContext _context;

        public CustomerService(ShopContext shpContext)
        {
            _context = shpContext;
        }

        public async Task AddCustomer(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
        }

        public async Task AddCustomerAddress(CustomerAddress customerAddress)
        {
            await _context.CustomerAddresses.AddAsync(customerAddress);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers
                .Include(r => r.CustomerAddresses);
        }
        public int SaveChanges() => _context.SaveChanges();
    }
}
