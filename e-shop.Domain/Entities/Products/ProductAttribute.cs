using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Products
{
    [Table("product_attribute")]
    public class ProductAttribute
    {
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("attribute_id")]
        public int AttributeId { get; set; }
    }
}
