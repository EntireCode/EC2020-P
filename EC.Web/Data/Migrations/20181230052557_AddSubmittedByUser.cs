using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class AddSubmittedByUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RMARequests_AspNetUsers_SalesPersonUserId",
                table: "RMARequests");

            migrationBuilder.DropIndex(
                name: "IX_RMARequests_SalesPersonUserId",
                table: "RMARequests");

            migrationBuilder.AlterColumn<string>(
                name: "SalesPersonUserId",
                table: "RMARequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubmittedByUserId",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RMARequests_SubmittedByUserId",
                table: "RMARequests",
                column: "SubmittedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RMARequests_AspNetUsers_SubmittedByUserId",
                table: "RMARequests",
                column: "SubmittedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RMARequests_AspNetUsers_SubmittedByUserId",
                table: "RMARequests");

            migrationBuilder.DropIndex(
                name: "IX_RMARequests_SubmittedByUserId",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "SubmittedByUserId",
                table: "RMARequests");

            migrationBuilder.AlterColumn<string>(
                name: "SalesPersonUserId",
                table: "RMARequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RMARequests_SalesPersonUserId",
                table: "RMARequests",
                column: "SalesPersonUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RMARequests_AspNetUsers_SalesPersonUserId",
                table: "RMARequests",
                column: "SalesPersonUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
