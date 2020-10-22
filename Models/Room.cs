using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    /// <summary>
    /// Stores general data on Room
    /// </summary>
    public class Room
    {
        public int RoomID { get; set; } //Primary key that can be referenced in Reservation object as a foreign key
        [Required]

        public int RoomFloor { get; set; } //Indicates floor number

        public bool RoomAccessible { get; set; } //Indicates whether the room is easily accessible

        public RoomStyle RoomStyle { get; set; } //To allow for referencing from ApplicationDbContext
        [ForeignKey("StyleID")]

        public int StyleID { get; set; } // Foreign key from RoomStyle for linking data
    }
}
