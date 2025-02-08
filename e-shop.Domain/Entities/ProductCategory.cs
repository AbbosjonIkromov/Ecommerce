using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("product_category")]
    public class ProductCategory
    {
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("category_id")]
        public int CategoryId { get; set; }
    }
}
