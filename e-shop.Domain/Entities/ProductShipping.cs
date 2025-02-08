using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("product_shipping")]
    public class ProductShipping
    {
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("shipping_id")]
        public int ShippingId { get; set; }
        [Column("ship_change")]
        public decimal ShipChange { get; set; }
        [Column("free")]
        public bool Free { get; set; }
        [Column("estimated_days")]
        public decimal EstimatedDays { get; set; }
    }
}
