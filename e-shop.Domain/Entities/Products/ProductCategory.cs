using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Categories;

namespace e_shop.Domain.Entities.Products
{
    [Table("product_category")]
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
