using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class SerialNumbnersAddedRMAStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumbers",
                table: "RMACases");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbers",
                table: "RMAStages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumbers",
                table: "RMAStages");

            migrationBuilder.AddColumn<string>(
                name: "SerialNumbers",
                table: "RMACases",
                nullable: true);
        }
    }
}
