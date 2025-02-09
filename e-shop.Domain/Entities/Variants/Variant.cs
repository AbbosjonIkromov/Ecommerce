using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Variants
{
    [Table("variant")]
    public class Variant
    {
        [Key]
        [Column("variant_id")]
        public int VariantId { get; set; }
        [Column("variant_attribute_value_id")]
        public int VariantAttributeValueId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
    }
}
