using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centric_Payment_API.Migrations.StatementEntitiesMigrations
{
    public partial class StatementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historicalStatement",
                columns: table => new
                {
                    invoice_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesforce_billingaccount_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    invoice_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    S3fileurl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "StatementHistoryRecord",
                columns: table => new
                {
                    recorded_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statement_no = table.Column<int>(type: "int", nullable: true),
                    salesforce_acct_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    old_acct_id = table.Column<int>(type: "int", nullable: true),
                    create_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    currency_cd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    due_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    due_date_plus_grace_period = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_type_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    new_charges_amount = table.Column<int>(type: "int", nullable: true),
                    new_payments_account = table.Column<int>(type: "int", nullable: true),
                    balance_forward_amount = table.Column<int>(type: "int", nullable: true),
                    total_amount = table.Column<int>(type: "int", nullable: true),
                    is_paid_ind = table.Column<int>(type: "int", nullable: true),
                    seq_statement_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    master_plan_instance_no = table.Column<int>(type: "int", nullable: true),
                    client_master_plan_instance_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_no = table.Column<int>(type: "int", nullable: true),
                    unapplied_pament_summary = table.Column<int>(type: "int", nullable: true),
                    account_balance = table.Column<int>(type: "int", nullable: true),
                    sent_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_sent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatementHistoryRecord", x => x.recorded_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historicalStatement");

            migrationBuilder.DropTable(
                name: "StatementHistoryRecord");
        }
    }
}
