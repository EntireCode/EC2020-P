using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RMACases",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMANumber = table.Column<string>(nullable: true),
                    RMANumberIssueDate = table.Column<DateTime>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    CustomerContact = table.Column<string>(nullable: false),
                    CustomerContactEmail = table.Column<string>(nullable: false),
                    SalesPerson = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: false),
                    RMALocation = table.Column<int>(nullable: false),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    StatusReason = table.Column<string>(nullable: true),
                    ReceivedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMACases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RMAMaterials",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMACaseId = table.Column<string>(nullable: true),
                    SequenceNo = table.Column<int>(nullable: false),
                    CustomerPartNumber = table.Column<string>(nullable: true),
                    PhihongModelNumber = table.Column<string>(nullable: true),
                    PhihongPartNumber = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrantyStatus = table.Column<int>(nullable: false),
                    IsMaterialReceived = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    DefectPhenomenon = table.Column<string>(nullable: true),
                    AnalysisResult = table.Column<string>(nullable: true),
                    AnalysisDate = table.Column<DateTime>(nullable: false),
                    AnalysisResultMadeBy = table.Column<string>(nullable: true),
                    CorrectiveAction = table.Column<string>(nullable: true),
                    CorrectiveActionCreatedBy = table.Column<string>(nullable: true),
                    CorrectiveActionCreatedDate = table.Column<string>(nullable: true),
                    RMARepairWorkOrderMaterialId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMAMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMAMaterials_RMACases_RMACaseId",
                        column: x => x.RMACaseId,
                        principalTable: "RMACases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RMARepairWorkOrders",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMARepairWorkOrderNumber = table.Column<string>(nullable: true),
                    RMACaseId = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CustomerApprovalDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    StatusChangedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMARepairWorkOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMARepairWorkOrders_RMACases_RMACaseId",
                        column: x => x.RMACaseId,
                        principalTable: "RMACases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RMARepairWorkOrderMaterials",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMARepairWorkOrderId = table.Column<string>(nullable: true),
                    RMAMaterialId = table.Column<string>(nullable: true),
                    RMAMaterialId1 = table.Column<string>(nullable: true),
                    FailureAnalysisReport = table.Column<string>(nullable: true),
                    EightDReport = table.Column<string>(nullable: true),
                    EightDCompleteDate = table.Column<DateTime>(nullable: false),
                    EightDCompletedBy = table.Column<string>(nullable: true),
                    Conclusion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMARepairWorkOrderMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMARepairWorkOrderMaterials_RMAMaterials_RMAMaterialId1",
                        column: x => x.RMAMaterialId1,
                        principalTable: "RMAMaterials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RMARepairWorkOrderMaterials_RMARepairWorkOrders_RMARepairWorkOrderId",
                        column: x => x.RMARepairWorkOrderId,
                        principalTable: "RMARepairWorkOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RMAMaterials_RMACaseId",
                table: "RMAMaterials",
                column: "RMACaseId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARepairWorkOrderMaterials_RMAMaterialId1",
                table: "RMARepairWorkOrderMaterials",
                column: "RMAMaterialId1");

            migrationBuilder.CreateIndex(
                name: "IX_RMARepairWorkOrderMaterials_RMARepairWorkOrderId",
                table: "RMARepairWorkOrderMaterials",
                column: "RMARepairWorkOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARepairWorkOrders_RMACaseId",
                table: "RMARepairWorkOrders",
                column: "RMACaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RMARepairWorkOrderMaterials");

            migrationBuilder.DropTable(
                name: "RMAMaterials");

            migrationBuilder.DropTable(
                name: "RMARepairWorkOrders");

            migrationBuilder.DropTable(
                name: "RMACases");
        }
    }
}
