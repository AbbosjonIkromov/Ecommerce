using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities.Staff
{
    [Table("staff_role")]
    public class StaffRole
    {
        [Column("staff_id")]
        public int StaffId { get; set; }
        [Column("role_id")]
        public int RoleId { get; set; }

    }
}
