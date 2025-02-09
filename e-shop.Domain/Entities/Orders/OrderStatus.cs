using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Orders
{
    [Table("order_status")]
    public class OrderStatus
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("status_name")]
        public string StatusName { get; set; }
        [Column("color")]
        public string Color { get; set; }
        [Column("privacy")]
        public string Privacy { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [Column("created_by")]
        public int CreatedBy { get; set; }
        [Column("updated_by")]
        public int UpdatedBy { get; set; }
    }
}
