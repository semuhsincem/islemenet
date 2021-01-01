using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class AdvertisementRefresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Advertisements");

            migrationBuilder.RenameTable(
                name: "Advertisements",
                newName: "RFQ");

            migrationBuilder.AddColumn<string>(
                name: "BasicInformation",
                table: "RFQ",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorrespondenceLanguage",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CustomRFQId",
                table: "RFQ",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DelivaryDate",
                table: "RFQ",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Diameter",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Length",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinTol",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Need",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "OfferCurrency",
                table: "RFQ",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PublicationSettingsType",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "RFQDeadline",
                table: "RFQ",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "RFQ",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Width",
                table: "RFQ",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RFQ",
                table: "RFQ",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RFQ",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "BasicInformation",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "CorrespondenceLanguage",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "CustomRFQId",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "DelivaryDate",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "MinTol",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Need",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "OfferCurrency",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "PublicationSettingsType",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "RFQDeadline",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "RFQ");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "RFQ");

            migrationBuilder.RenameTable(
                name: "RFQ",
                newName: "Advertisements");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Advertisements",
                table: "Advertisements",
                column: "Id");
        }
    }
}
