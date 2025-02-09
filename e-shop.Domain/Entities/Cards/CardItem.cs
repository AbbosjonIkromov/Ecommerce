using e_shop.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Cards
{
    [Table("card_item")]
    public class CardItem
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [ForeignKey("Product")]
        [Column("product_id")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Column("card_id")]
        [ForeignKey("Card")]
        public int CardId { get; set; }

        public Card Card { get; set; }
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
