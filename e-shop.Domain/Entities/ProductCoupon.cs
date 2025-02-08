using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("product_coupon")]
    public class ProductCoupon
    {
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("coupon_id")]
        public int  CouponId { get; set; }
    }
}
