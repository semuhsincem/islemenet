using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addRfqFileTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RfqFilesId",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RfqFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RFQId = table.Column<int>(nullable: false),
                    FilePath = table.Column<string>(nullable: true),
                    FileType = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RfqFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RfqFiles_RFQ_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RFQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RfqFiles_RFQId",
                table: "RfqFiles",
                column: "RFQId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RfqFiles");

            migrationBuilder.DropColumn(
                name: "RfqFilesId",
                table: "RFQ");
        }
    }
}
