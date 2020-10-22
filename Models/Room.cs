using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    public class Room
    {
        public int RoomID { get; set; } //PK
        [Required]
        public int RoomFloor { get; set; }
        public bool RoomAccessible { get; set; }
        public RoomStyle BedroomStyle { get; set; } //FK
        public RoomStyle BathroomStyle { get; set; } //FK
        public RoomStyle KitchenStyle { get; set; } //FK
    }
}
