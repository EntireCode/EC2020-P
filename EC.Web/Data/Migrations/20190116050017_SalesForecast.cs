using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class SalesForecast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalesForecasts",
                columns: table => new
                {
                    Code = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<long>(nullable: false),
                    USMgr = table.Column<string>(nullable: true),
                    USRep = table.Column<string>(nullable: true),
                    USPerson = table.Column<string>(nullable: true),
                    UPj = table.Column<string>(nullable: true),
                    UCardCode = table.Column<string>(nullable: true),
                    UModel = table.Column<string>(nullable: true),
                    UItemGroup = table.Column<string>(nullable: true),
                    UYear = table.Column<short>(nullable: true),
                    UJan = table.Column<decimal>(nullable: true),
                    UFeb = table.Column<decimal>(nullable: true),
                    UMar = table.Column<decimal>(nullable: true),
                    UApr = table.Column<decimal>(nullable: true),
                    UMay = table.Column<decimal>(nullable: true),
                    UJun = table.Column<decimal>(nullable: true),
                    UJul = table.Column<decimal>(nullable: true),
                    UAug = table.Column<decimal>(nullable: true),
                    USep = table.Column<decimal>(nullable: true),
                    UOct = table.Column<decimal>(nullable: true),
                    UNov = table.Column<decimal>(nullable: true),
                    UDec = table.Column<decimal>(nullable: true),
                    ULatestDate = table.Column<DateTime>(nullable: true),
                    UPrice = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesForecasts", x => x.Code);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesForecasts");
        }
    }
}
