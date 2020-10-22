using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    public class RoomStyle
    {
        public int StyleID { get; set; } //PK
        [Required]
        public String RoomType { get; set; }
        public String RoomDescription { get; set; }
    }
}
