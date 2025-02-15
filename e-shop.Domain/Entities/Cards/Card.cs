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
    public class Card : IAuditable
    {
        public Card()
        {
            CardItems = new List<CardItem>();
        }
        public int CardId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CardItem> CardItems { get; set; }

        public DateTime CreateAt { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
