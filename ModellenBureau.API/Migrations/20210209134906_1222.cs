using Microsoft.EntityFrameworkCore.Migrations;

namespace ModellenBureau.API.Migrations
{
    public partial class _1222 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Paswoord",
                table: "PhotoModels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Paswoord",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    Verified = table.Column<bool>(type: "bit", nullable: false),
                    Voornaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Achternaam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Paswoord = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AdminId", "Achternaam", "Adres", "AppUserId", "Email", "Paswoord", "Postcode", "Stad", "Verified", "Voornaam" },
                values: new object[] { 1, "Beheerder", "Karel Luther Queenlaan 12", 7, "", "", "1212 DE", "Den Haag", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 1,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerID",
                keyValue: 2,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 1,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 2,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 3,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "PhotoModels",
                keyColumn: "PhotoModelID",
                keyValue: 4,
                columns: new[] { "Email", "Paswoord" },
                values: new object[] { "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Paswoord",
                table: "PhotoModels");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Paswoord",
                table: "Customers");
        }
    }
}
