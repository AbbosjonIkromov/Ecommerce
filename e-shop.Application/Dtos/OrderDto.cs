using e_shop.Domain.Entities.Orders;

namespace e_shop.Application.Dtos
{
    public class OrderDto
    {
        public OrderDto()
        {
            //OrderItems = new List<OrderItem>();
        }
        //public int CustomerId { get; set; }
        public int OrderStatusId { get; set; }
        //public List<OrderItem> OrderItems { get; set; }

    }
}
