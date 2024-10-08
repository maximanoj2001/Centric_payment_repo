﻿// <auto-generated />
using System;
using Centric_Payment_API.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Centric_Payment_API.Migrations.StatementEntitiesMigrations
{
    [DbContext(typeof(StatementEntities))]
    [Migration("20240828103854_StatementMigration")]
    partial class StatementMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Centric_Payment_API.DataBase.HistoricalStatement", b =>
                {
                    b.Property<string>("S3fileurl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("invoice_amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("invoice_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("invoice_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salesforce_billingaccount_id")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("historicalStatement");
                });

            modelBuilder.Entity("Centric_Payment_API.DataBase.StatementHistoryRecord", b =>
                {
                    b.Property<int?>("recorded_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("recorded_id"), 1L, 1);

                    b.Property<int?>("account_balance")
                        .HasColumnType("int");

                    b.Property<int?>("balance_forward_amount")
                        .HasColumnType("int");

                    b.Property<string>("client_master_plan_instance_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("create_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("currency_cd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("date_sent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("due_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("due_date_plus_grace_period")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("invoice_no")
                        .HasColumnType("int");

                    b.Property<int?>("is_paid_ind")
                        .HasColumnType("int");

                    b.Property<int?>("master_plan_instance_no")
                        .HasColumnType("int");

                    b.Property<int?>("new_charges_amount")
                        .HasColumnType("int");

                    b.Property<int?>("new_payments_account")
                        .HasColumnType("int");

                    b.Property<int?>("old_acct_id")
                        .HasColumnType("int");

                    b.Property<string>("salesforce_acct_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sent_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("seq_statement_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("statement_no")
                        .HasColumnType("int");

                    b.Property<int?>("total_amount")
                        .HasColumnType("int");

                    b.Property<int?>("unapplied_pament_summary")
                        .HasColumnType("int");

                    b.Property<string>("usage_type_description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("recorded_id");

                    b.ToTable("StatementHistoryRecord");
                });
#pragma warning restore 612, 618
        }
    }
}
