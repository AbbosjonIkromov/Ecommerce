using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("Sell")]
    public class Sell
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }

    }
}
