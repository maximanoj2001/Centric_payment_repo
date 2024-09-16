using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centric_Payment_API.Migrations
{
    public partial class PaymentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paymentHistory",
                columns: table => new
                {
                    PaymentTransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SalesforceBillingAccountId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "PaymentHistoryRecord",
                columns: table => new
                {
                    recorded_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    transaction_id = table.Column<int>(type: "int", nullable: true),
                    salesforce_acct_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_acct_id = table.Column<int>(type: "int", nullable: true),
                    transaction_type = table.Column<int>(type: "int", nullable: true),
                    transaction_desc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_amount = table.Column<int>(type: "int", nullable: true),
                    transaction_applied_amount = table.Column<int>(type: "int", nullable: true),
                    transaction_currency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_create_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statement_no = table.Column<int>(type: "int", nullable: true),
                    client_receipt_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    transaction_source_id = table.Column<int>(type: "int", nullable: true),
                    transaction_ref_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistoryRecord", x => x.recorded_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "paymentHistory");

            migrationBuilder.DropTable(
                name: "PaymentHistoryRecord");
        }
    }
}
