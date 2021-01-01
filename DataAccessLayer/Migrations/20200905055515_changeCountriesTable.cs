using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class changeCountriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryName",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CODE",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONTINENT_CODE",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COUNTRY_NAME",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "COUNTRY_NUMBER",
                table: "Countries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FULL_NAME",
                table: "Countries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISO3",
                table: "Countries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CODE",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CONTINENT_CODE",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "COUNTRY_NAME",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "COUNTRY_NUMBER",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "FULL_NAME",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "ISO3",
                table: "Countries");

            migrationBuilder.AddColumn<string>(
                name: "CountryName",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
