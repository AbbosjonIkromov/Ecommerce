using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("notification")]
    public class Notification
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("Account_id")]
        public int AccountId { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("context")]
        public string Context { get; set; }
        [Column("seen")]
        public bool Seen { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("receive_time")]
        public DateTime ReceiveTime { get; set; } = DateTime.UtcNow;
        [Column("notification_expiry_date")]
        public DateTime NotificationExpiryDate { get; set; } = DateTime.UtcNow;
    }
}
