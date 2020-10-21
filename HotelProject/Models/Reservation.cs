using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; } //PK
        [Required]
        public Person PersonID { get; set; } //FK
        [Required]
        public Room RoomID { get; set; } //FK
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
