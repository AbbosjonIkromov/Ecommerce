using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("order_item")]
    public class OrderItem
    {
        [Key]
        [Column("id")]
        public int  Id { get; set; }
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("order_id")]
        public int  OrderId { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int  Quantity { get; set; }
        [Column("shippingId")]
        public int ShippingId { get; set; }
    }
}
