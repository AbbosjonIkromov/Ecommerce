using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("product_tag")]
    public class ProductTag
    {
        [Column("tag_id")]
        public int TagId { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
    }
}
