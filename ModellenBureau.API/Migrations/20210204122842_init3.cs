using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Postal",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "HomeAddress",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postal",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "PhotoModels",
                newName: "Land");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Customers",
                newName: "Land");

            migrationBuilder.AddColumn<string>(
                name: "Achternaam",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Achternaam",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Postcode",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Voornaam",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Achternaam",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Achternaam",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Postcode",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Voornaam",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Land",
                table: "PhotoModels",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Land",
                table: "Customers",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postal",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HomeAddress",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Postal",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
