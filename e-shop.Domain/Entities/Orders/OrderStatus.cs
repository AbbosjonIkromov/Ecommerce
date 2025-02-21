using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Orders
{
    public class OrderStatus : IAuditable
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Color { get; set; }
        public string Privacy { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}
