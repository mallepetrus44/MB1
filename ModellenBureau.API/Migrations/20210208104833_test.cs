using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Taillewijdte",
                table: "PhotoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Heupwijdte",
                table: "PhotoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "Bovenwijdte",
                table: "PhotoModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<int>(
                name: "Lengte",
                table: "PhotoModels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "PhotoModels",
                columns: new[] { "PhotoModelID", "Achternaam", "Adres", "AppUserId", "Bovenwijdte", "Fotos", "Geboortedatum", "Geslacht", "Heupwijdte", "Leeftijd", "Lengte", "Postcode", "Stad", "Taillewijdte", "Voornaam" },
                values: new object[,]
                {
                    { 1, "Vermeulen", "Leemwierde 40", 3, 90, "", new DateTime(1985, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 90, 35, 178, "1353 LT", "Almere", 61, "Fleur" },
                    { 2, "de Wit", "Oregondreef 102", 4, 86, "", new DateTime(1991, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 87, 29, 175, "3565 BG", "Utrecht", 59, "Lynn" },
                    { 3, "Peters", "Dollardstraat 2", 5, 101, "", new DateTime(1980, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 99, 41, 184, "1826 CS", "Alkmaar", 81, "Luuk" },
                    { 4, "Meijer", "Martin Luther Kinglaan 93", 6, 100, "", new DateTime(1990, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 100, 30, 185, "1111 LK", "Diemen", 81, "Stefan" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Lengte",
                table: "PhotoModels");

            migrationBuilder.AlterColumn<double>(
                name: "Taillewijdte",
                table: "PhotoModels",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Heupwijdte",
                table: "PhotoModels",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Bovenwijdte",
                table: "PhotoModels",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
