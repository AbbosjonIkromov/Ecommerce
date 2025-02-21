using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Customers;

namespace e_shop.Domain.Entities.Orders
{
    public class Order : IAuditable
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public virtual Coupon Coupon { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int OrderStatusId { get; set; }
        public virtual OrderStatus  OrderStatus { get; set; }
        public int OrderItemId { get; set; }
        public virtual OrderItem OrderItem { get; set; }
        public DateTime OrderApprovedAt { get; set; } 
        public DateTime OrderDeliveredCustomerDate { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
