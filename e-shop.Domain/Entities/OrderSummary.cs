using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public class OrderSummary
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime OrderApprovedAt { get; set; }
    }
}
