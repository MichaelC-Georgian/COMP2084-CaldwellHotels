using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    /// <summary>
    /// Links Room and Person objects together within a timeslot (between startDate and endDate) to allow for a unique reservation
    /// </summary>
    public class Reservation
    {
        public int ReservationID { get; set; } //Primary Key
        [Required]

        public int PersonID { get; set; } //Foreign key in reference to a person object

        public int RoomID { get; set; } //Foreign key in reference to a room object

        public DateTime StartDate { get; set; } //The start date & Time of a reservation

        public DateTime EndDate { get; set; } //The end date & Time of a reservation

        public virtual Room Rooms { get; set; } //Allows for referecing from ApplicationDbContext.cs

        public virtual Person Persons { get; set; } //Allows for referecing from ApplicationDbContext.cs

        //As a side note, "virtual" allows a method or property to be overriden under certain circumstances, 
        //I dont fully understand it, but after over 10 literal hours of bashing my head against ApplicationDbContext & Scaffolding
        //This is what worked.
    }
}
