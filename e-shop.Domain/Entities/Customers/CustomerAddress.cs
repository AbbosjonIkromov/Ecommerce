using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Customers
{
    [Table("customer_address")]
    public class CustomerAddress
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        //[ForeignKey("CustomerId")]
        public virtual Customer Customers { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

    }
}
