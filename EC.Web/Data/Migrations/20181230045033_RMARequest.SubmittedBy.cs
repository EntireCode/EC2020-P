using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMARequestSubmittedBy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SubmittedBy",
                table: "RMARequests",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubmittedBy",
                table: "RMARequests");
        }
    }
}
