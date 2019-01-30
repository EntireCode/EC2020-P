using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMADataStructureChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RMAStageName",
                table: "RMAStages");

            migrationBuilder.RenameColumn(
                name: "SerialNumber",
                table: "RMACases",
                newName: "SerialNumbers");

            migrationBuilder.AddColumn<int>(
                name: "CorrectiveAction",
                table: "RMAStages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CorrectiveActionNote",
                table: "RMAStages",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActionDone",
                table: "RMAStages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ProcessedByUserId",
                table: "RMACases",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessedDate",
                table: "RMACases",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "RMACases",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RMACases_ProcessedByUserId",
                table: "RMACases",
                column: "ProcessedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RMACases_AspNetUsers_ProcessedByUserId",
                table: "RMACases",
                column: "ProcessedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RMACases_AspNetUsers_ProcessedByUserId",
                table: "RMACases");

            migrationBuilder.DropIndex(
                name: "IX_RMACases_ProcessedByUserId",
                table: "RMACases");

            migrationBuilder.DropColumn(
                name: "CorrectiveAction",
                table: "RMAStages");

            migrationBuilder.DropColumn(
                name: "CorrectiveActionNote",
                table: "RMAStages");

            migrationBuilder.DropColumn(
                name: "IsActionDone",
                table: "RMAStages");

            migrationBuilder.DropColumn(
                name: "ProcessedByUserId",
                table: "RMACases");

            migrationBuilder.DropColumn(
                name: "ProcessedDate",
                table: "RMACases");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RMACases");

            migrationBuilder.RenameColumn(
                name: "SerialNumbers",
                table: "RMACases",
                newName: "SerialNumber");

            migrationBuilder.AddColumn<int>(
                name: "RMAStageName",
                table: "RMAStages",
                nullable: false,
                defaultValue: 0);
        }
    }
}
