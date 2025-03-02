using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Application.Dtos
{
    public class CreateOrderItemRequestDto
    {
        public int  OrderId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
