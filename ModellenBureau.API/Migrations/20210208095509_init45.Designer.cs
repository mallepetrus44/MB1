﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModellenBureau.API.Models;

namespace ModellenBureau.API.Migrations
{
    [DbContext(typeof(MBDbContext))]
    [Migration("20210208095509_init45")]
    partial class init45
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ModellenBureau.Main.Shared.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<string>("BtwNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KvkNummer")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerID = 1,
                            Achternaam = "Janssen",
                            Adres = "Verdilaan 107",
                            AppUserId = 1,
                            BtwNummer = "NL123456789B01",
                            KvkNummer = 12345678,
                            Logo = "",
                            Postcode = "4384 LG",
                            Stad = "Vlissingen",
                            Voornaam = "Klaas"
                        },
                        new
                        {
                            CustomerID = 2,
                            Achternaam = "Gerritsen",
                            Adres = "Uiterburen 13",
                            AppUserId = 2,
                            BtwNummer = "NL234567890B02",
                            KvkNummer = 23456789,
                            Logo = "",
                            Postcode = "9636 EC",
                            Stad = "Groningen",
                            Voornaam = "Angelina"
                        });
                });

            modelBuilder.Entity("ModellenBureau.Main.Shared.PhotoModel", b =>
                {
                    b.Property<int>("PhotoModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Achternaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<double>("Bovenwijdte")
                        .HasColumnType("float");

                    b.Property<string>("Fotos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortedatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Geslacht")
                        .HasColumnType("int");

                    b.Property<double>("Heupwijdte")
                        .HasColumnType("float");

                    b.Property<int>("Leeftijd")
                        .HasColumnType("int");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Taillewijdte")
                        .HasColumnType("float");

                    b.Property<string>("Voornaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhotoModelID");

                    b.ToTable("PhotoModels");
                });
#pragma warning restore 612, 618
        }
    }
}
