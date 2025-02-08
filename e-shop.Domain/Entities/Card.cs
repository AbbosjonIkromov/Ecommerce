using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("card")]
    public class Card
    {
        [Key]
        [Column("card_id")]
        public int Card_id { get; set; }
        [Column("customer_id")]
        public int  CustomerId { get; set; }
    }
}
