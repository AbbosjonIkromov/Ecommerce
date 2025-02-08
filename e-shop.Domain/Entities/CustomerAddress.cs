using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("customer_address")]
    public class CustomerAddress
    {
        [Key]
        [Column("id")]
        public int  Id { get; set; }
        [Column("customer_id")]
        public int  CustomerId { get; set; }
        [Column("address_line1")]
        public string AddressLine1 { get; set; }
        [Column("address_line2")]
        public string AddressLine2 { get; set; }
        [Column("postal_code")]
        public string  PostalCode { get; set; }
        [Column("country")]
        public string Country { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
    }
}
