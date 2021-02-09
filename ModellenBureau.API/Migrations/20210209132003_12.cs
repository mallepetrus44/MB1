using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class _12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KvkNummer = table.Column<int>(type: "int", nullable: false),
                    BtwNummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "PhotoModels",
                columns: table => new
                {
                    PhotoModelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leeftijd = table.Column<int>(type: "int", nullable: false),
                    Geboortedatum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Geslacht = table.Column<int>(type: "int", nullable: false),
                    Bovenwijdte = table.Column<int>(type: "int", nullable: false),
                    Taillewijdte = table.Column<int>(type: "int", nullable: false),
                    Heupwijdte = table.Column<int>(type: "int", nullable: false),
                    Lengte = table.Column<int>(type: "int", nullable: false),
                    Fotos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoModels", x => x.PhotoModelID);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Achternaam", "Adres", "AppUserId", "BtwNummer", "KvkNummer", "Logo", "Postcode", "Stad", "Verified", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Janssen", "Verdilaan 107", 1, "NL123456789B01", 12345678, "", "4384 LG", "Vlissingen", false, "Klaas" },
                    { 2, "Gerritsen", "Uiterburen 13", 2, "NL234567890B02", 23456789, "", "9636 EC", "Groningen", false, "Angelina" }
                });

            migrationBuilder.InsertData(
                table: "PhotoModels",
                columns: new[] { "PhotoModelID", "Achternaam", "Adres", "AppUserId", "Bovenwijdte", "Fotos", "Geboortedatum", "Geslacht", "Heupwijdte", "Leeftijd", "Lengte", "Postcode", "Stad", "Taillewijdte", "Verified", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Vermeulen", "Leemwierde 40", 3, 90, "", new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 90, 35, 178, "1353 LT", "Almere", 61, false, "Fleur" },
                    { 2, "de Wit", "Oregondreef 102", 4, 86, "", new DateTime(1991, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 87, 29, 175, "3565 BG", "Utrecht", 59, false, "Lynn" },
                    { 3, "Peters", "Dollardstraat 2", 5, 101, "", new DateTime(1980, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 99, 41, 184, "1826 CS", "Alkmaar", 81, false, "Luuk" },
                    { 4, "Meijer", "Martin Luther Kinglaan 93", 6, 100, "", new DateTime(1990, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 100, 30, 185, "1111 LK", "Diemen", 81, false, "Stefan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "PhotoModels");
        }
    }
}
