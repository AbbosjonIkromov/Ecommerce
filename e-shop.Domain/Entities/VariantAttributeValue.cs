using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("variant_attribute_value")]
    public class VariantAttributeValue
    {
        [Key]
        [Column("variant_attribute_value_id")]
        public int  VariantAttributeValueId { get; set; }
        [Column("attribute_value_id")]
        public int  AttributeValueId { get; set; }  
    }
}
