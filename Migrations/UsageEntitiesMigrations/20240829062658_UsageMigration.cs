using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Centric_Payment_API.Migrations.UsageEntitiesMigrations
{
    public partial class UsageMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historicalUsage",
                columns: table => new
                {
                    usage_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    salesforce_billing_account_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    start_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    end_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: true),
                    unit_price = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    total_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "usageHistory",
                columns: table => new
                {
                    recorded_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    old_acct_id = table.Column<int>(type: "int", nullable: true),
                    salesforce_acct_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    billable_acct_no = table.Column<int>(type: "int", nullable: true),
                    client_billable_acct_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plan_instance_id = table.Column<int>(type: "int", nullable: true),
                    client_plan_instance_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_type_no = table.Column<int>(type: "int", nullable: true),
                    usage_type_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    units = table.Column<int>(type: "int", nullable: true),
                    units_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    usage_units_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    invoice_no = table.Column<int>(type: "int", nullable: true),
                    telco_To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telco_from = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_excluded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualifier_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualifier_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualifier_3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    qualifier_4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    recorded_units = table.Column<int>(type: "int", nullable: true),
                    usage_record_no = table.Column<int>(type: "int", nullable: true),
                    usage_type_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_record_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    master_plan_instance_no = table.Column<int>(type: "int", nullable: true),
                    client_master_plan_instance_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    acct_locale_no = table.Column<int>(type: "int", nullable: true),
                    acct_locale_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    filtered_usage_count = table.Column<int>(type: "int", nullable: true),
                    location_no = table.Column<int>(type: "int", nullable: true),
                    date_installed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meter_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MIU_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model_no = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_read_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actual_usage = table.Column<int>(type: "int", nullable: true),
                    start_read = table.Column<int>(type: "int", nullable: true),
                    end_read = table.Column<int>(type: "int", nullable: true),
                    reading_days = table.Column<int>(type: "int", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    revenue_class = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usageHistory", x => x.recorded_id);
                });

            migrationBuilder.CreateTable(
                name: "usageHistorySource",
                columns: table => new
                {
                    account_no = table.Column<int>(type: "int", nullable: true),
                    location_no = table.Column<int>(type: "int", nullable: true),
                    date_installed = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    meter_no = table.Column<int>(type: "int", nullable: true),
                    MIU_number = table.Column<int>(type: "int", nullable: true),
                    manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    model_no = table.Column<int>(type: "int", nullable: true),
                    end_read_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    actual_usage = table.Column<int>(type: "int", nullable: true),
                    start_read = table.Column<int>(type: "int", nullable: true),
                    end_read = table.Column<int>(type: "int", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reading_days = table.Column<int>(type: "int", nullable: true),
                    revenue_class = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historicalUsage");

            migrationBuilder.DropTable(
                name: "usageHistory");

            migrationBuilder.DropTable(
                name: "usageHistorySource");
        }
    }
}
