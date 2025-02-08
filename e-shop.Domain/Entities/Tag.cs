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
    [Table("Tag")]
    public class Tag
    {
        [Key]
        [Column("tag_id")]
        public int TagId { get; set; }
        [Column("tag_name")]
        public string TagName { get; set; }
        [Column("icon")]
        public string Icon { get; set; }
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
