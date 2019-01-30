using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMAClosedDateToRMARequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatusChangedDate",
                table: "RMARequests",
                newName: "RMAClosedDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RMAClosedDate",
                table: "RMARequests",
                newName: "StatusChangedDate");
        }
    }
}
