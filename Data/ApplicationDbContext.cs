using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CaldwellHotels.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CaldwellHotels.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //Define model classes so the controllers can access our models
        public DbSet<Person> Persons { get; set;}
        public DbSet<RoomStyle> RoomStyles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        //Override the model creating method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            //Forcefully assigns primary key as add-migrations requested it upon execution
            builder.Entity<RoomStyle>().HasKey(x => x.StyleID);

           //For a reservation entry, ensure there's a RoomID
           builder.Entity<Reservation>()
               .HasOne(r => r.Rooms)
               .WithMany()
               .HasForeignKey(y => y.RoomID);

          //For a reservation entry, ensure there's a PersonID
           builder.Entity<Reservation>()
               .HasOne(r => r.Persons)
               .WithMany()
               .HasForeignKey(y => y.PersonID);

          //For a room entry, ensure there's a StyleID
           builder.Entity<Room>()
               .HasOne(r => r.RoomStyle)
               .WithMany()
               .HasForeignKey(y => y.StyleID);

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
