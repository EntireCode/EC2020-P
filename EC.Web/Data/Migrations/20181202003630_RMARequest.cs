using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMARequest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RMARepairWorkOrderMaterials");

            migrationBuilder.DropTable(
                name: "RMAMaterials");

            migrationBuilder.DropTable(
                name: "RMARepairWorkOrders");

            migrationBuilder.DropTable(
                name: "RMACases");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    PartNumber = table.Column<string>(nullable: true),
                    ModelNumber = table.Column<string>(nullable: true),
                    WarrantyMonth = table.Column<int>(nullable: false),
                    ProductDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RMARequests",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerContact = table.Column<string>(nullable: true),
                    CustomerContactEmail = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    RMALocation = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false),
                    RMANumber = table.Column<string>(nullable: true),
                    RMANumberIssueDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMARequests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSerialNumbers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrantyStartFromDate = table.Column<DateTime>(nullable: false),
                    ProductId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSerialNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSerialNumbers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RMARequestDetails",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMARequestId = table.Column<string>(nullable: false),
                    SequenceNo = table.Column<int>(nullable: false),
                    CustomerPartNumber = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrantyStatus = table.Column<int>(nullable: false),
                    WarrantyRemark = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    DefectPhenomenon = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    UnitReturnLocation = table.Column<int>(nullable: false),
                    UnitReturnReceivedDate = table.Column<DateTime>(nullable: false),
                    ReturnDescription = table.Column<string>(nullable: true),
                    ReturnReceivedBy = table.Column<string>(nullable: true),
                    RepairWorkOrderIssueDate = table.Column<DateTime>(nullable: false),
                    PHCStatus = table.Column<string>(nullable: true),
                    PHCStatusDate = table.Column<DateTime>(nullable: false),
                    PHCStatusMadeBy = table.Column<string>(nullable: true),
                    PHAStatus = table.Column<string>(nullable: true),
                    PHAStatusDate = table.Column<DateTime>(nullable: false),
                    PHAStatusMadeBy = table.Column<string>(nullable: true),
                    PHNYStatus = table.Column<string>(nullable: true),
                    PHNYStatusDate = table.Column<DateTime>(nullable: false),
                    PHNYStatusMadeBy = table.Column<string>(nullable: true),
                    FailureAnalysis = table.Column<string>(nullable: true),
                    FailureAnalysisBy = table.Column<string>(nullable: true),
                    FailureAnalysisDate = table.Column<DateTime>(nullable: false),
                    EightDReport = table.Column<string>(nullable: true),
                    EightDReportDate = table.Column<DateTime>(nullable: false),
                    EightDReportBy = table.Column<string>(nullable: true),
                    FA8DApplication = table.Column<string>(nullable: true),
                    FA8DApplicationDate = table.Column<DateTime>(nullable: false),
                    FA8DApplicationBy = table.Column<string>(nullable: true),
                    CustomerApproval = table.Column<string>(nullable: true),
                    CustomerApprovedDate = table.Column<string>(nullable: true),
                    RMACompletedDate = table.Column<DateTime>(nullable: false),
                    RMACompletedBy = table.Column<string>(nullable: true),
                    RMAFinalRemark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMARequestDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMARequestDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RMARequestDetails_RMARequests_RMARequestId",
                        column: x => x.RMARequestId,
                        principalTable: "RMARequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSerialNumbers_ProductId",
                table: "ProductSerialNumbers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARequestDetails_ProductId",
                table: "RMARequestDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARequestDetails_RMARequestId",
                table: "RMARequestDetails",
                column: "RMARequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSerialNumbers");

            migrationBuilder.DropTable(
                name: "RMARequestDetails");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "RMARequests");

            migrationBuilder.CreateTable(
                name: "RMACases",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerContact = table.Column<string>(nullable: false),
                    CustomerContactEmail = table.Column<string>(nullable: false),
                    CustomerName = table.Column<string>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: false),
                    RMALocation = table.Column<int>(nullable: false),
                    RMANumber = table.Column<string>(nullable: true),
                    RMANumberIssueDate = table.Column<DateTime>(nullable: false),
                    ReceivedBy = table.Column<string>(nullable: true),
                    ReceivedDate = table.Column<DateTime>(nullable: false),
                    SalesPerson = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    StatusReason = table.Column<string>(nullable: true)
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
                    AnalysisDate = table.Column<DateTime>(nullable: false),
                    AnalysisResult = table.Column<string>(nullable: true),
                    AnalysisResultMadeBy = table.Column<string>(nullable: true),
                    CorrectiveAction = table.Column<string>(nullable: true),
                    CorrectiveActionCreatedBy = table.Column<string>(nullable: true),
                    CorrectiveActionCreatedDate = table.Column<string>(nullable: true),
                    CustomerPartNumber = table.Column<string>(nullable: true),
                    DefectPhenomenon = table.Column<string>(nullable: true),
                    IsMaterialReceived = table.Column<bool>(nullable: false),
                    PhihongModelNumber = table.Column<string>(nullable: true),
                    PhihongPartNumber = table.Column<string>(nullable: true),
                    RMACaseId = table.Column<string>(nullable: true),
                    RMARepairWorkOrderMaterialId = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    SequenceNo = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    WarrantyStatus = table.Column<int>(nullable: false)
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
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CustomerApprovalDate = table.Column<DateTime>(nullable: false),
                    RMACaseId = table.Column<string>(nullable: true),
                    RMARepairWorkOrderNumber = table.Column<string>(nullable: true),
                    Remark = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
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
                    Conclusion = table.Column<string>(nullable: true),
                    EightDCompleteDate = table.Column<DateTime>(nullable: false),
                    EightDCompletedBy = table.Column<string>(nullable: true),
                    EightDReport = table.Column<string>(nullable: true),
                    FailureAnalysisReport = table.Column<string>(nullable: true),
                    RMAMaterialId = table.Column<string>(nullable: true),
                    RMAMaterialId1 = table.Column<string>(nullable: true),
                    RMARepairWorkOrderId = table.Column<string>(nullable: true)
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
    }
}
