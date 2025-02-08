using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("card_item")]
    public class CardItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("product_id")]
        public int  ProductId { get; set; }
        [Column("card_id")]
        public int CardId { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
