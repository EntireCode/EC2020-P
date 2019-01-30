using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class addClosedByIssuedByToRMARequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RMAClosedByUserId",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RMANumberIssuedByUserId",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RMARequests_RMAClosedByUserId",
                table: "RMARequests",
                column: "RMAClosedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARequests_RMANumberIssuedByUserId",
                table: "RMARequests",
                column: "RMANumberIssuedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RMARequests_AspNetUsers_RMAClosedByUserId",
                table: "RMARequests",
                column: "RMAClosedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RMARequests_AspNetUsers_RMANumberIssuedByUserId",
                table: "RMARequests",
                column: "RMANumberIssuedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RMARequests_AspNetUsers_RMAClosedByUserId",
                table: "RMARequests");

            migrationBuilder.DropForeignKey(
                name: "FK_RMARequests_AspNetUsers_RMANumberIssuedByUserId",
                table: "RMARequests");

            migrationBuilder.DropIndex(
                name: "IX_RMARequests_RMAClosedByUserId",
                table: "RMARequests");

            migrationBuilder.DropIndex(
                name: "IX_RMARequests_RMANumberIssuedByUserId",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "RMAClosedByUserId",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "RMANumberIssuedByUserId",
                table: "RMARequests");
        }
    }
}
