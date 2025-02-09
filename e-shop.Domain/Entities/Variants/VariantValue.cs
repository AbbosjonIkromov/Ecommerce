using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Variants
{
    [Table("variant_value")]
    public class VariantValue
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("variant_id")]
        public int VariantId { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
