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
        public int BedroomDescription { get; set; }
        public int BathroomDescription { get; set; } 
        public int KitchenDescription { get; set; } 
        public ICollection<Room> Rooms { get; set; }
    }
}
