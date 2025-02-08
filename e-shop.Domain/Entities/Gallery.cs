using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("gallery")]
    public class Gallery
    {
        [Key]
        [Column("id")]
        public int  Id { get; set; }
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("image_path")]
        public string ImagePath { get; set; }
        [Column("thumbnail")]
        public bool ThumbNail { get; set; }
        [Column("display_order")]
        public int  DisplayOrder { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set;} = DateTime.UtcNow;
        [Column("created_by")]
        public DateTime CreatedBy { get; set; } = DateTime.UtcNow;
        [Column("updated_by")]
        public DateTime UpdatedBy { get; set; } = DateTime.UtcNow;

    }
}
