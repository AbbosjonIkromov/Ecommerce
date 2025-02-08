using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace e_shop.Domain.Entities
{
    [Table("slide_show")]
    public class SlideShow
    {
        [Column("id")]
        public int  Id { get; set; }
        [Column("destination_url")]
        public string DestinationURL { get; set; }
        [Column("image_url")]
        public string ImageURL { get; set; }
        [Column("clicks")]
        public int Clicks { get; set; }
        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("updated_at")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        [Column("created_by")]
        public int CreatedBy { get; set; }
        [Column("updated_by")]
        public int UpdatedBy { get; set; }

    }
}
