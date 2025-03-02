using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Application.Dtos
{
    public class CreateOrderRequestDto
    {
        public int  CustomerId { get; set; }
        public ICollection<CreateOrderItemRequestDto> OrderItems { get; set; }
    }
}
