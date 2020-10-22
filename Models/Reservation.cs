using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    public class Reservation
    {
        public int ReservationID { get; set; } //PK

        public Person Person { get; set; } //FK
        public Room Room { get; set; } //FK
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PersonID { get; set; } //FK
        public int RoomID { get; set; } //FK
    }
}
