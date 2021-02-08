using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class init45 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Stad",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Stad",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Achternaam", "Adres", "AppUserId", "BtwNummer", "KvkNummer", "Logo", "Postcode", "Stad", "Voornaam" },
                values: new object[] { 1, "Janssen", "Verdilaan 107", 1, "NL123456789B01", 12345678, "", "4384 LG", "Vlissingen", "Klaas" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Achternaam", "Adres", "AppUserId", "BtwNummer", "KvkNummer", "Logo", "Postcode", "Stad", "Voornaam" },
                values: new object[] { 2, "Gerritsen", "Uiterburen 13", 2, "NL234567890B02", 23456789, "", "9636 EC", "Groningen", "Angelina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Stad",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Stad",
                table: "Customers");
        }
    }
}
