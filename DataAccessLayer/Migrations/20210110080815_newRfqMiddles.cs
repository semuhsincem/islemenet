using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class newRfqMiddles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_RfqTechnologies_TechnologyId",
                table: "RfqTechnologies",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqMaterials_MaterialId",
                table: "RfqMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_RfqCertifications_CertificationId",
                table: "RfqCertifications",
                column: "CertificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RfqCertifications_Certifications_CertificationId",
                table: "RfqCertifications",
                column: "CertificationId",
                principalTable: "Certifications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RfqMaterials_Materials_MaterialId",
                table: "RfqMaterials",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RfqTechnologies_Technologies_TechnologyId",
                table: "RfqTechnologies",
                column: "TechnologyId",
                principalTable: "Technologies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RfqCertifications_Certifications_CertificationId",
                table: "RfqCertifications");

            migrationBuilder.DropForeignKey(
                name: "FK_RfqMaterials_Materials_MaterialId",
                table: "RfqMaterials");

            migrationBuilder.DropForeignKey(
                name: "FK_RfqTechnologies_Technologies_TechnologyId",
                table: "RfqTechnologies");

            migrationBuilder.DropIndex(
                name: "IX_RfqTechnologies_TechnologyId",
                table: "RfqTechnologies");

            migrationBuilder.DropIndex(
                name: "IX_RfqMaterials_MaterialId",
                table: "RfqMaterials");

            migrationBuilder.DropIndex(
                name: "IX_RfqCertifications_CertificationId",
                table: "RfqCertifications");
        }
    }
}
