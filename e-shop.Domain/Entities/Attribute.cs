using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("attribute")]
    public class Attribute
    {
        [Key]
        [Column("attribute_id")]
        public int  AttributeId { get; set; }
        [Column("attribute_name")]
        public string  AttributeName { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [Column("created_by")]
        public int  CreatedBy { get; set; }
        [Column("updated_by")]
        public int UpdatedBy { get; set; }
    }
}
