using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarURL",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDateTime",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetRoles",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApplicationMenus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    Description = table.Column<string>(nullable: false),
                    AreaName = table.Column<string>(maxLength: 30, nullable: true),
                    FolderName = table.Column<string>(maxLength: 30, nullable: true),
                    PageName = table.Column<string>(maxLength: 30, nullable: true),
                    Position = table.Column<int>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    ParentId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationMenus_ApplicationMenus_ParentId",
                        column: x => x.ParentId,
                        principalTable: "ApplicationMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationRoleMenus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false),
                    MenuId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRoleMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApplicationRoleMenus_ApplicationMenus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "ApplicationMenus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationRoleMenus_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationMenus_ParentId",
                table: "ApplicationMenus",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleMenus_MenuId",
                table: "ApplicationRoleMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationRoleMenus_RoleId",
                table: "ApplicationRoleMenus",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationRoleMenus");

            migrationBuilder.DropTable(
                name: "ApplicationMenus");

            migrationBuilder.DropColumn(
                name: "AvatarURL",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CreatedDateTime",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetRoles");
        }
    }
}
