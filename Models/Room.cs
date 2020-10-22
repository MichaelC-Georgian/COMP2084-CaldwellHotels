using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public RoomStyle RoomStyle { get; set; }
        [ForeignKey("StyleID")]
        public int StyleID { get; set; }
        //public ICollection<Reservation> Reservations { get; set; }
    }
}
