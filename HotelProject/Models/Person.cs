using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.Models
{
    public class Person
    {
        public int PersonID { get; set; } //PK
        [Required]
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String PhoneNumber { get; set; }
        public String EmailAddress { get; set; }
        public String StreetAddress { get; set; }
        public String City { get; set; }
        public String Province { get; set; }
        public String Country { get; set; }
        public String PostalCode { get; set; }
    }
}
