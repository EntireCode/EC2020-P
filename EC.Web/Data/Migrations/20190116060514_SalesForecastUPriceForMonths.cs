using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class SalesForecastUPriceForMonths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "UAprUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UAugUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UDecUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UFebUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UJanUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UJulUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UJunUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UMarUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UMayUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UNovUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "UOctUPrice",
                table: "SalesForecasts",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "USepUPrice",
                table: "SalesForecasts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UAprUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UAugUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UDecUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UFebUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UJanUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UJulUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UJunUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UMarUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UMayUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UNovUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "UOctUPrice",
                table: "SalesForecasts");

            migrationBuilder.DropColumn(
                name: "USepUPrice",
                table: "SalesForecasts");
        }
    }
}
