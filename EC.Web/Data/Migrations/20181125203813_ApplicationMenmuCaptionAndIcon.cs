using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class ApplicationMenmuCaptionAndIcon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "ApplicationMenus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MenuCaption",
                table: "ApplicationMenus",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "ApplicationMenus");

            migrationBuilder.DropColumn(
                name: "MenuCaption",
                table: "ApplicationMenus");
        }
    }
}
