using e_shop.Domain.Entities.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Cards
{
    [Table("card")]
    public class Card
    {
        public Card()
        {
            CardItems = new List<CardItem>();
        }
        [Key]
        [Column("card_id")]
        public int CardId { get; set; }
        [ForeignKey("Customer")]
        [Column("customer_id")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<CardItem> CardItems { get; set; }

    }
}
