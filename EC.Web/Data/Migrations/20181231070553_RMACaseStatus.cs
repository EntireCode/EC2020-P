using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMACaseStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MRACaseStatus",
                table: "RMACases");

            migrationBuilder.AddColumn<int>(
                name: "RMACaseStatus",
                table: "RMACases",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RMACaseStatus",
                table: "RMACases");

            migrationBuilder.AddColumn<int>(
                name: "MRACaseStatus",
                table: "RMACases",
                nullable: false,
                defaultValue: 0);
        }
    }
}
