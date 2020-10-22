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
        //Persons, RoomStyle, Rooms, Reservation
        public DbSet<Person> Persons { get; set;}
        public DbSet<RoomStyle> RoomStyles { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        //Override the model creating method
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Gone off the deep end - Take me home ~~~~~ country roads ~~~~ west virginia

            //Forcefully assigns primary key as add-migrations requested it upon execution
            builder.Entity<RoomStyle>().HasKey(x => x.StyleID);

            //builder.Entity<Reservation>().HasOne(x => x.RoomID)
                

           //For a reservation entry, ensure there's a RoomID
           builder.Entity<Reservation>()
               .HasOne(r => r.Rooms)
               //.WithMany(x => x.Reservations)
               .WithMany()
               .HasForeignKey(y => y.RoomID);

          //For a reservation entry, ensure there's a PersonID
           builder.Entity<Reservation>()
               .HasOne(r => r.Persons)
               .WithMany()
               //.WithMany(x => x.Reservations)
               .HasForeignKey(y => y.PersonID);

          //For a room entry, ensure there's a RoomStyleID
           builder.Entity<Room>()
               .HasOne(r => r.RoomStyle)
               //.WithMany(x => x.Rooms)
               .WithMany()
               .HasForeignKey(y => y.StyleID);

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
