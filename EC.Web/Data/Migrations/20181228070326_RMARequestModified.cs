using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EC.Web.Data.Migrations
{
    public partial class RMARequestModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RMARequestDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "RMALocation",
                table: "RMARequests");

            migrationBuilder.RenameColumn(
                name: "SalesPerson",
                table: "RMARequests",
                newName: "SalesPersonUserId");

            migrationBuilder.RenameColumn(
                name: "RequestDate",
                table: "RMARequests",
                newName: "SubmittedDate");

            migrationBuilder.RenameColumn(
                name: "RMANumberIssueDate",
                table: "RMARequests",
                newName: "RMAIssueDate");

            migrationBuilder.RenameColumn(
                name: "WarrantyMonth",
                table: "Products",
                newName: "BasicWarrantyMonth");

            migrationBuilder.AlterColumn<int>(
                name: "RMANumber",
                table: "RMARequests",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SalesPersonUserId",
                table: "RMARequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerERPId",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DefectPhenomenon",
                table: "RMARequests",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WarrantyExpireDate",
                table: "ProductSerialNumbers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "RMACases",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerPartNumber = table.Column<string>(nullable: true),
                    PartNumber = table.Column<string>(nullable: true),
                    SerialNumber = table.Column<string>(nullable: true),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    WarrantyStatus = table.Column<int>(nullable: false),
                    RMALocation = table.Column<int>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    MRACaseStatus = table.Column<int>(nullable: false),
                    RMARequestId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMACases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMACases_RMARequests_RMARequestId",
                        column: x => x.RMARequestId,
                        principalTable: "RMARequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RMAStages",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    RMAStageName = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    RMACaseId = table.Column<string>(nullable: false),
                    ProcessedByUserId = table.Column<string>(nullable: true),
                    ProcessedDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RMAStages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RMAStages_AspNetUsers_ProcessedByUserId",
                        column: x => x.ProcessedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RMAStages_RMACases_RMACaseId",
                        column: x => x.RMACaseId,
                        principalTable: "RMACases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileAttachments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ObjectName = table.Column<string>(nullable: true),
                    ObjectId = table.Column<string>(nullable: true),
                    ItemNo = table.Column<int>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    Size = table.Column<long>(nullable: false),
                    UploadedByUserId = table.Column<string>(nullable: true),
                    UploadedDate = table.Column<DateTime>(nullable: false),
                    RMACaseId = table.Column<string>(nullable: true),
                    RMARequestId = table.Column<string>(nullable: true),
                    RMAStageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileAttachments_RMACases_RMACaseId",
                        column: x => x.RMACaseId,
                        principalTable: "RMACases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileAttachments_RMARequests_RMARequestId",
                        column: x => x.RMARequestId,
                        principalTable: "RMARequests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileAttachments_RMAStages_RMAStageId",
                        column: x => x.RMAStageId,
                        principalTable: "RMAStages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FileAttachments_AspNetUsers_UploadedByUserId",
                        column: x => x.UploadedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RMARequests_SalesPersonUserId",
                table: "RMARequests",
                column: "SalesPersonUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_RMACaseId",
                table: "FileAttachments",
                column: "RMACaseId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_RMARequestId",
                table: "FileAttachments",
                column: "RMARequestId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_RMAStageId",
                table: "FileAttachments",
                column: "RMAStageId");

            migrationBuilder.CreateIndex(
                name: "IX_FileAttachments_UploadedByUserId",
                table: "FileAttachments",
                column: "UploadedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RMACases_RMARequestId",
                table: "RMACases",
                column: "RMARequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RMAStages_ProcessedByUserId",
                table: "RMAStages",
                column: "ProcessedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RMAStages_RMACaseId",
                table: "RMAStages",
                column: "RMACaseId");

            migrationBuilder.AddForeignKey(
                name: "FK_RMARequests_AspNetUsers_SalesPersonUserId",
                table: "RMARequests",
                column: "SalesPersonUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RMARequests_AspNetUsers_SalesPersonUserId",
                table: "RMARequests");

            migrationBuilder.DropTable(
                name: "FileAttachments");

            migrationBuilder.DropTable(
                name: "RMAStages");

            migrationBuilder.DropTable(
                name: "RMACases");

            migrationBuilder.DropIndex(
                name: "IX_RMARequests_SalesPersonUserId",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "CustomerERPId",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "DefectPhenomenon",
                table: "RMARequests");

            migrationBuilder.DropColumn(
                name: "WarrantyExpireDate",
                table: "ProductSerialNumbers");

            migrationBuilder.RenameColumn(
                name: "SubmittedDate",
                table: "RMARequests",
                newName: "RequestDate");

            migrationBuilder.RenameColumn(
                name: "SalesPersonUserId",
                table: "RMARequests",
                newName: "SalesPerson");

            migrationBuilder.RenameColumn(
                name: "RMAIssueDate",
                table: "RMARequests",
                newName: "RMANumberIssueDate");

            migrationBuilder.RenameColumn(
                name: "BasicWarrantyMonth",
                table: "Products",
                newName: "WarrantyMonth");

            migrationBuilder.AlterColumn<string>(
                name: "RMANumber",
                table: "RMARequests",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SalesPerson",
                table: "RMARequests",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "RMARequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RMALocation",
                table: "RMARequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RMARequestDetails",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CustomerApproval = table.Column<string>(nullable: true),
                    CustomerApprovedDate = table.Column<string>(nullable: true),
                    CustomerPartNumber = table.Column<string>(nullable: true),
                    DefectPhenomenon = table.Column<string>(nullable: true),
                    EightDReport = table.Column<string>(nullable: true),
                    EightDReportBy = table.Column<string>(nullable: true),
                    EightDReportDate = table.Column<DateTime>(nullable: false),
                    FA8DApplication = table.Column<string>(nullable: true),
                    FA8DApplicationBy = table.Column<string>(nullable: true),
                    FA8DApplicationDate = table.Column<DateTime>(nullable: false),
                    FailureAnalysis = table.Column<string>(nullable: true),
                    FailureAnalysisBy = table.Column<string>(nullable: true),
                    FailureAnalysisDate = table.Column<DateTime>(nullable: false),
                    InvoiceNumber = table.Column<string>(nullable: true),
                    PHAStatus = table.Column<string>(nullable: true),
                    PHAStatusDate = table.Column<DateTime>(nullable: false),
                    PHAStatusMadeBy = table.Column<string>(nullable: true),
                    PHCStatus = table.Column<string>(nullable: true),
                    PHCStatusDate = table.Column<DateTime>(nullable: false),
                    PHCStatusMadeBy = table.Column<string>(nullable: true),
                    PHNYStatus = table.Column<string>(nullable: true),
                    PHNYStatusDate = table.Column<DateTime>(nullable: false),
                    PHNYStatusMadeBy = table.Column<string>(nullable: true),
                    ProductId = table.Column<string>(nullable: true),
                    RMACompletedBy = table.Column<string>(nullable: true),
                    RMACompletedDate = table.Column<DateTime>(nullable: false),
                    RMAFinalRemark = table.Column<string>(nullable: true),
                    RMARequestId = table.Column<string>(nullable: false),
                    Remark = table.Column<string>(nullable: true),
                    RepairWorkOrderIssueDate = table.Column<DateTime>(nullable: false),
                    ReturnDescription = table.Column<string>(nullable: true),
                    ReturnReceivedBy = table.Column<string>(nullable: true),
                    SalesPerson = table.Column<string>(nullable: true),
                    SequenceNo = table.Column<int>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: true),
                    UnitReturnLocation = table.Column<int>(nullable: false),
                    UnitReturnReceivedDate = table.Column<DateTime>(nullable: false),
                    WarrantyRemark = table.Column<string>(nullable: true),
                    WarrantyStatus = table.Column<int>(nullable: false)
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
                name: "IX_RMARequestDetails_ProductId",
                table: "RMARequestDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_RMARequestDetails_RMARequestId",
                table: "RMARequestDetails",
                column: "RMARequestId");
        }
    }
}
