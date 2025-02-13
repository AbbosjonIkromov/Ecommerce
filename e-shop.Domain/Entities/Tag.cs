using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using e_shop.Domain.Entities.Products;

namespace e_shop.Domain.Entities
{
    [Table("Tag")]
    public class Tag
    {
        public Tag()
        {
            ProductTags = new List<ProductTag>();

        }

        public int TagId { get; set; }
        public string TagName { get; set; }
        public string Icon { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int  CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }

    }
}
