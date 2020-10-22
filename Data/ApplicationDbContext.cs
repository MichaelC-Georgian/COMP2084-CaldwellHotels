using System;
using System.Collections.Generic;
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
            builder.Entity<RoomStyle>().HasKey(x => x.StyleID);

            builder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(x => x.Reservations)
                .HasForeignKey(y => y.RoomID);

            builder.Entity<Reservation>()
                .HasOne(r => r.Room)
                .WithMany(x => x.Reservations)
                .HasForeignKey(y => y.PersonID);

            builder.Entity<Room>()
                .HasOne(r => r.RoomStyle)
                .WithMany(x => x.Rooms)
                .HasForeignKey(y => y.RoomStyleID);

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
