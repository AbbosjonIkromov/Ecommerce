using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Categories;

[Table("category")]
public class Category
{
    [Key]
    [Column("category_id")]
    public int CategoryId { get; set; }
    [Column("parent_id")]
    public int ParentId { get; set; }
    [Column("category_name")]
    public string CategoryName { get; set; }
    [Column("category_description")]
    public string CategoryDescription { get; set; }
    [Column("icon")]
    public string Icon { get; set; }
    [Column("image_path")]
    public string ImagePath { get; set; }
    [Column("active")]
    public bool Active { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    [Column("created_by")]
    public int CreatedBy { get; set; }
    [Column("updated_by")]
    public int UpdatedBy { get; set; }

}
