using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Land",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Land",
                table: "PhotoModels",
                newName: "Leeftijd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Leeftijd",
                table: "PhotoModels",
                newName: "Land");

            migrationBuilder.AddColumn<int>(
                name: "Land",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
