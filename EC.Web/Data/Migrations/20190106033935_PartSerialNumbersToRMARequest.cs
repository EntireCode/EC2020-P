using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class PartSerialNumbersToRMARequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartNumbers",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "SerialNumbners",
                table: "RMARequests");

            migrationBuilder.RenameColumn(
                name: "SubmittedBy",
                table: "RMARequests",
                newName: "PartSerialNumbers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PartSerialNumbers",
                table: "RMARequests",
                newName: "SubmittedBy");

            migrationBuilder.AddColumn<string>(
                name: "PartNumbers",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbners",
                table: "RMARequests",
                nullable: true);
        }
    }
}
