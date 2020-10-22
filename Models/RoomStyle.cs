using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaldwellHotels.Models
{
    /// <summary>
    /// RoomStyle stores descriptve data for rooms
    /// </summary>
    public class RoomStyle
    {
        public int StyleID { get; set; } //Primary Key to be referenced in Room objects to link data.       
        [Required]

        public String BedroomDescription { get; set; } //Stores a description of a bedroom

        public String BathroomDescription { get; set; } //Stores a description of a bathroom

        public String KitchenDescription { get; set; } //Stores a description of a kitchen
    }
}
