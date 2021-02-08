using Microsoft.EntityFrameworkCore;
using ModellenBureau.Main.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModellenBureau.API.Models
{
    public class MBDbContext : DbContext
    {
        public MBDbContext(DbContextOptions<MBDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<PhotoModel> PhotoModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 1,
                //Logo
                KvkNummer = 12345678,
                BtwNummer = "NL123456789B01",
                AppUserId = 1,
                Voornaam = "Klaas",
                Achternaam = "Janssen",
                Adres = "Verdilaan 107",
                Stad = "Vlissingen",
                Postcode = "4384 LG"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 2,
                //Logo
                KvkNummer = 23456789,
                BtwNummer = "NL234567890B02",
                AppUserId = 2,
                Voornaam = "Angelina",
                Achternaam = "Gerritsen",
                Adres = "Uiterburen 13",
                Stad = "Groningen",
                Postcode = "9636 EC"
            });


        }
    }
}
