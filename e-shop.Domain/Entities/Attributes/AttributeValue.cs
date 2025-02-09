using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Attributes
{
    [Table("attribute_value")]
    public class AttributeValue
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("attribute_id")]
        public int AttributeId { get; set; }
        [Column("attribute_val")]
        public string AttributeVal { get; set; }
        [Column("color")]
        public string Color { get; set; }
    }
}
