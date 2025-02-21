using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Orders;

namespace e_shop.Domain.Entities.Customers
{
    [Table("customer")]
    public class Customer : IAuditable
    {
        public Customer()
        {
            CustomerAddresses = new List<CustomerAddress>();
            Orders = new List<Order>();

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public bool Active { get; set; }
        public DateTime? RegisteredAt { get; set; }
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }
        public virtual ICollection<Order> Orders { get; set; }   

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
