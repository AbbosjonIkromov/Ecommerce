using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("coupon")]
    public class Coupon
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("code")]
        public string Code { get; set; }
        [Column("coupon_description")]
        public string CouponDescription { get; set; }
        [Column("discount_value")]
        public decimal DiscountValue { get; set; }
        [Column("discount_type")]
        public string DiscountType { get; set; }
        [Column("time_used")]
        public int  TimesUsed { get; set; }
        [Column("max_usage")]
        public int  MaxUsage { get; set; }
        [Column("coupon_start_date")]
        public DateTime CouponStartDate { get; set; } = DateTime.UtcNow;
        [Column("coupon_end_date")]
        public DateTime CouponEndDate { get; set; } = DateTime.UtcNow;
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [Column("created_by")]
        public int  CreatedBy { get; set; }
        [Column("updated_by")]
        public int  UpdatedBy { get; set; }
    }
}
