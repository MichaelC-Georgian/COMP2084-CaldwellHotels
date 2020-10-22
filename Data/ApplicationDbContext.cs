using System;
using System.Collections.Generic;
using System.Text;
using CaldwellHotels.Models;
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
            //Not gonna lie - am confused to all hell, 
            // Couldn't get code from S2E3 working so I visited 
            // https://docs.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-3.1
            // And based code off their examples... Maybe it'll work?


            //Creates a foreign key requirement for Reservation based on PersonID
            builder.Entity<Reservation>()
                .HasMany<Reservation>().WithOne()
                .HasForeignKey(p => p.PersonID).IsRequired();
            //Creates a foreign key requirement for Reservation based on RoomID
            builder.Entity<Reservation>()
                .HasMany<Reservation>().WithOne()
                .HasForeignKey(p => p.RoomID).IsRequired();


            //Creates a foreign key requirement for Room based on BathroomStyle
            builder.Entity<Room>()
                .HasMany<Room>().WithOne()
                .HasForeignKey(p => p.BathroomStyle).IsRequired();

            //Creates a foreign key requirement for Room based on BedroomStyle
            builder.Entity<Room>()
                .HasMany<Room>().WithOne()
                .HasForeignKey(p => p.BedroomStyle).IsRequired();

            //Creates a foreign key requirement for Room based on KitchenStyle
            builder.Entity<Room>()
                .HasMany<Room>().WithOne()
                .HasForeignKey(p => p.KitchenStyle).IsRequired();
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
