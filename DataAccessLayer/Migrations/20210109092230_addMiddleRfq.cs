using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addMiddleRfq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RfqCertifications",
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
                    CertificationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RfqCertifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RfqCertifications_RFQ_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RFQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RfqMaterials",
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
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RfqMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RfqMaterials_RFQ_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RFQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RfqTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false),
                    RFQId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RfqTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RfqTechnologies_RFQ_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RFQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RfqCertifications_RFQId",
                table: "RfqCertifications",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqMaterials_RFQId",
                table: "RfqMaterials",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqTechnologies_RFQId",
                table: "RfqTechnologies",
                column: "RFQId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RfqCertifications");

            migrationBuilder.DropTable(
                name: "RfqMaterials");

            migrationBuilder.DropTable(
                name: "RfqTechnologies");
        }
    }
}
