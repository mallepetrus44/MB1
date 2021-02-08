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

            //Seed data Customer
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 1,
                KvkNummer = 12345678,
                BtwNummer = "NL123456789B01",
                AppUserId = 1,
                Voornaam = "Klaas",
                Achternaam = "Janssen",
                Adres = "Verdilaan 107",
                Stad = "Vlissingen",
                Postcode = "4384 LG",
                Logo =""
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 2,
                KvkNummer = 23456789,
                BtwNummer = "NL234567890B02",
                AppUserId = 2,
                Voornaam = "Angelina",
                Achternaam = "Gerritsen",
                Adres = "Uiterburen 13",
                Stad = "Groningen",
                Postcode = "9636 EC",
                Logo=""
            });

            // Seed data Photomodel
            modelBuilder.Entity<PhotoModel>().HasData(new PhotoModel
            {
                AppUserId = 3,
                Voornaam = "Fleur",
                Achternaam = "Vermeulen",
                Adres = "Leemwierde 40",
                Stad = "Almere",
                Postcode = "1353 LT",
                PhotoModelID = 1,
                Geboortedatum = DateTime.ParseExact("15/06/1985", "dd/MM/yyyy", null),
                Geslacht = Geslacht.Vrouw,
                Bovenwijdte = 90,
                Taillewijdte = 61, 
                Heupwijdte = 90,
                Lengte = 178,
                Fotos = ""
            });
            modelBuilder.Entity<PhotoModel>().HasData(new PhotoModel
            {
                AppUserId = 4,
                Voornaam = "Lynn",
                Achternaam = "de Wit",
                Adres = "Oregondreef 102",
                Stad = "Utrecht",
                Postcode = "3565 BG",
                PhotoModelID = 2,
                Geboortedatum = DateTime.ParseExact("23/08/1991", "dd/MM/yyyy", null),
                Geslacht = Geslacht.Vrouw,
                Bovenwijdte = 86,
                Taillewijdte = 59,
                Heupwijdte = 87,
                Lengte = 175,
                Fotos = ""
            });
            modelBuilder.Entity<PhotoModel>().HasData(new PhotoModel
            {
                AppUserId = 5,
                Voornaam = "Luuk",
                Achternaam = "Peters",
                Adres = "Dollardstraat 2",
                Stad = "Alkmaar",
                Postcode = "1826 CS",
                PhotoModelID = 3,
                Geboortedatum = DateTime.ParseExact("04/01/1980", "dd/MM/yyyy", null),
                Geslacht = Geslacht.Man,
                Bovenwijdte = 101,
                Taillewijdte = 81,
                Heupwijdte = 99,
                Lengte = 184,
                Fotos = ""
            });
            modelBuilder.Entity<PhotoModel>().HasData(new PhotoModel
            {
                AppUserId = 6,
                Voornaam = "Stefan",
                Achternaam = "Meijer",
                Adres = "Martin Luther Kinglaan 93",
                Stad = "Diemen",
                Postcode = "1111 LK",
                PhotoModelID = 4,
                Geboortedatum = DateTime.ParseExact("25/11/1990", "dd/MM/yyyy", null),
                Geslacht = Geslacht.Man,
                Bovenwijdte = 100,
                Taillewijdte = 81,
                Heupwijdte = 100,
                Lengte = 185,
                Fotos = ""
            });
        }
    }
}
