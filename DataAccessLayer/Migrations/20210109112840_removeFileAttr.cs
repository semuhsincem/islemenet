using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class removeFileAttr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RfqFilesId",
                table: "RFQ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RfqFilesId",
                table: "RFQ",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
