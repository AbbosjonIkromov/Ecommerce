using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    public interface IAuditable
    {
        DateTime CreateAt { get; set; }
        DateTime? UpdateTime { get; set; }
        int CreatedBy { get; set; }
        int UpdatedBy { get; set; }
    }
}
