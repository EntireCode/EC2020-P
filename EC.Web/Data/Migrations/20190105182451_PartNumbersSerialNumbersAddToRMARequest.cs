using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class PartNumbersSerialNumbersAddToRMARequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PartNumbers",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbners",
                table: "RMARequests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartNumbers",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "SerialNumbners",
                table: "RMARequests");
        }
    }
}
