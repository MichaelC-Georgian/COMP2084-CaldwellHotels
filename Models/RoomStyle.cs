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
        public String BedroomDescription { get; set; }
        public String BathroomDescription { get; set; } 
        public String KitchenDescription { get; set; } 
        //public ICollection<Room> Rooms { get; set; }
    }
}
