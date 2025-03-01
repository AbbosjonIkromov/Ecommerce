using e_shop.Domain.Entities.Customers;
using e_shop.Domain.Entities.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.ViewModels
{
    public class LastMonthOrder
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderApprovedAt { get; set; }
    }
}
