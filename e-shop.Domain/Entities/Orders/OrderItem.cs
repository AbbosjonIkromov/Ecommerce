using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Products;

namespace e_shop.Domain.Entities.Orders
{
    public class OrderItem : IAuditable

    {
    public int Id { get; set; }
    public int ProductId { get; set; }
    public virtual Product Product{ get; set; }
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public int ShippingId { get; set; }
    public virtual Shipping Shipping { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? UpdateTime { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    }
}
