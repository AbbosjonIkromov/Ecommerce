using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Products;

namespace e_shop.Domain.Entities.Categories;

[Table("category")]
public class Category
{

    public int CategoryId { get; set; }
    public int ParentId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string Icon { get; set; }
    public string ImagePath { get; set; }
    public bool Active { get; set; }
    public DateTime CreatedAt { get; set; } 
    public DateTime? UpdatedAt { get; set; } 
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }

   // public virtual ICollection<ProductCategory> ProductCategories { get; set; }

   public virtual ICollection<Product> Products { get; set; }

}
