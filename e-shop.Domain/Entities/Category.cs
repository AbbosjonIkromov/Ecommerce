using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public int ParentId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }
    public string Icon { get; set; }
    public string ImagePath { get; set; }
    public bool Active { get; set; }
    public DateTime CraetedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }

}
