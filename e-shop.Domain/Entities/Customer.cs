using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("customer")]
    public class Customer
    {
        public Customer()
        {
            CustomerAddresses = new List<CustomerAddress>();
        }
        [Key]
        [Column("id")]
        public int  Id { get; set; }
        [Column("first_name")]
        public string FirstName { get; set; }
        [Column("last_name")]
        public string LastName { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password_hash")]
        public string PasswordHash { get; set; }
        [Column("active")]
        public bool Active { get; set; }
        [Column("registered_at")]
        public DateTime? RegisteredAt { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<CustomerAddress> CustomerAddresses { get; set; }

    }
}
