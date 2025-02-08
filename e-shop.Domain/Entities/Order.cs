using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column("id")]
        public int  Id { get; set; }
        [Column("coupon_id")]
        public int CouponId { get; set; }
        [Column("customer_id")]
        public int  CustomerId { get; set; }
        [Column("order_status_id")]
        public int  OrderStatusId { get; set; }
        [Column("order_approved_at")]
        public DateTime OrderApprovedAt { get; set; } = DateTime.UtcNow;
        [Column("order_delivered_carrier_id")]
        public DateTime OrderDeliveredCarrierId  { get; set; } = DateTime.UtcNow;
        [Column("order_delivered_customer_date")]
        public DateTime OrderDeliveredCustomerDate { get; set; } = DateTime.UtcNow;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
