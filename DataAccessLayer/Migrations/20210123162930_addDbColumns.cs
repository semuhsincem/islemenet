using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class addDbColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Certifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CertificateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanySizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CountrySize = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanySizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CODE = table.Column<string>(nullable: true),
                    COUNTRY_NAME = table.Column<string>(nullable: true),
                    FULL_NAME = table.Column<string>(nullable: true),
                    ISO3 = table.Column<string>(nullable: true),
                    COUNTRY_NUMBER = table.Column<int>(nullable: false),
                    CONTINENT_CODE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Illers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Ad = table.Column<string>(nullable: true),
                    Plaka = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IndustryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Lang = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    MaterialName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RFQ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Need = table.Column<int>(nullable: false),
                    RFQDeadline = table.Column<DateTime>(nullable: false),
                    DelivaryDate = table.Column<DateTime>(nullable: false),
                    CustomRFQId = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Diameter = table.Column<int>(nullable: false),
                    MinTol = table.Column<int>(nullable: false),
                    BasicInformation = table.Column<string>(nullable: true),
                    OfferCurrency = table.Column<string>(nullable: true),
                    CorrespondenceLanguage = table.Column<int>(nullable: false),
                    PublicationSettingsType = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RFQ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RfqCountries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    CountryCode = table.Column<int>(nullable: false),
                    RFQId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RfqCountries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    TechnologyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCertifications",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CertificaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCertifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserIndustries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIndustries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MaterialId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMaterials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTechologies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AtCreated = table.Column<DateTime>(nullable: true),
                    AtModified = table.Column<DateTime>(nullable: true),
                    AtDeleted = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTechologies", x => x.Id);
                });

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
                        name: "FK_RfqCertifications_Certifications_CertificationId",
                        column: x => x.CertificationId,
                        principalTable: "Certifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RfqCertifications_RFQ_RFQId",
                        column: x => x.RFQId,
                        principalTable: "RFQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_RfqMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    RFQId = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false)
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
                    table.ForeignKey(
                        name: "FK_RfqTechnologies_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RfqCertifications_CertificationId",
                table: "RfqCertifications",
                column: "CertificationId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqCertifications_RFQId",
                table: "RfqCertifications",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqFiles_RFQId",
                table: "RfqFiles",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqMaterials_MaterialId",
                table: "RfqMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqMaterials_RFQId",
                table: "RfqMaterials",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqTechnologies_RFQId",
                table: "RfqTechnologies",
                column: "RFQId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqTechnologies_TechnologyId",
                table: "RfqTechnologies",
                column: "TechnologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanySizes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Illers");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "RfqCertifications");

            migrationBuilder.DropTable(
                name: "RfqCountries");

            migrationBuilder.DropTable(
                name: "RfqFiles");

            migrationBuilder.DropTable(
                name: "RfqMaterials");

            migrationBuilder.DropTable(
                name: "RfqTechnologies");

            migrationBuilder.DropTable(
                name: "UserCertifications");

            migrationBuilder.DropTable(
                name: "UserIndustries");

            migrationBuilder.DropTable(
                name: "UserMaterials");

            migrationBuilder.DropTable(
                name: "UserTechologies");

            migrationBuilder.DropTable(
                name: "Certifications");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "RFQ");

            migrationBuilder.DropTable(
                name: "Technologies");
        }
    }
}
