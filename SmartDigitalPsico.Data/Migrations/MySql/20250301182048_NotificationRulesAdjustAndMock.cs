using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRulesAdjustAndMock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "NotificationType",
                schema: "dbo",
                table: "NotificationRules",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4296), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4300), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(4300) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9309), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9310), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9312), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9313), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9314), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9315), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9316), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9317), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9321), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9322), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9323), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9324), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9324) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9325), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9326), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9327), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9328), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9332), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9333), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9334), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9335), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9336), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9337), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9338), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9339), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9362), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9363), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9364), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9365), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9371), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9372), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9373), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9374), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9375), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9376), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9377), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9378), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9382), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9383), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9384), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9385), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9386), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9387), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9391), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9392), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9393), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9394), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9395), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9396), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9397), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9398), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9402), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9403), new DateTime(2025, 3, 1, 18, 20, 47, 673, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9866), new DateTime(2025, 3, 1, 18, 20, 47, 674, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 675, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 675, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1147));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1154));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 678, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 3, 1, 18, 20, 47, 684, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotificationRules",
                columns: new[] { "Id", "CreatedDate", "Description", "ENotificationServiceType", "Enable", "IntervalType", "IntervalValue", "IsBefore", "IsEnabled", "Language", "LastAccessDate", "MedicalId", "ModifyDate", "NotificationType" },
                values: new object[,]
                {
                    { 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9023), "Envio 24 horas antes do agendamento", "0", true, (short)1, (short)24, true, true, "pt-BR", new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9025), 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9024), (short)0 },
                    { 2L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9027), "Envio 3 dias antes do agendamento", "0", true, (short)2, (short)3, true, true, "pt-BR", new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9028), 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9028), (short)0 },
                    { 3L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9030), "Envio 1 hora antes do agendamento", "0", true, (short)1, (short)1, true, true, "pt-BR", new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9031), 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9031), (short)0 },
                    { 4L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033), "Envio 15 minutos antes do agendamento", "0", true, (short)0, (short)15, true, true, "pt-BR", new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033), 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9033), (short)0 },
                    { 5L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9035), "Lembrete de pagamento (3 dias antes do vencimento)", "0", true, (short)2, (short)3, true, true, "pt-BR", new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9036), 1L, new DateTime(2025, 3, 1, 18, 20, 47, 691, DateTimeKind.Utc).AddTicks(9035), (short)2 }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 692, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3140), new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3141), new DateTime(2025, 3, 1, 18, 20, 47, 695, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 18, 20, 47, 698, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4309), new DateTime(2025, 3, 1, 18, 20, 47, 699, DateTimeKind.Utc).AddTicks(4310), new byte[] { 248, 215, 166, 152, 200, 97, 247, 123, 212, 133, 140, 153, 167, 22, 66, 44, 83, 240, 153, 93, 240, 72, 141, 106, 137, 157, 47, 188, 232, 89, 161, 57, 250, 60, 221, 196, 14, 137, 196, 6, 133, 79, 205, 184, 90, 209, 103, 126, 204, 20, 120, 187, 52, 31, 242, 87, 186, 130, 228, 218, 21, 153, 12, 218 }, new byte[] { 54, 52, 96, 189, 74, 211, 173, 221, 215, 245, 132, 166, 70, 102, 145, 91, 87, 245, 78, 158, 26, 61, 226, 243, 108, 99, 116, 232, 17, 34, 187, 200, 53, 216, 54, 242, 69, 221, 49, 81, 172, 116, 79, 171, 49, 48, 113, 96, 187, 67, 151, 152, 55, 194, 241, 225, 221, 96, 114, 57, 55, 177, 85, 52, 246, 106, 88, 124, 255, 101, 111, 45, 182, 102, 86, 26, 72, 48, 5, 42, 84, 127, 104, 166, 130, 26, 231, 4, 107, 13, 99, 126, 41, 213, 13, 61, 37, 186, 77, 7, 42, 176, 122, 199, 121, 64, 131, 144, 130, 144, 155, 127, 23, 61, 44, 78, 72, 63, 194, 244, 29, 233, 97, 152, 65, 10, 30, 17 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5486), new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5487), new DateTime(2025, 3, 1, 18, 20, 47, 701, DateTimeKind.Utc).AddTicks(5487), new byte[] { 245, 209, 76, 152, 252, 196, 44, 94, 9, 129, 5, 57, 151, 144, 132, 135, 154, 12, 120, 183, 89, 237, 31, 241, 17, 92, 221, 146, 118, 121, 205, 226, 20, 58, 27, 224, 21, 84, 77, 46, 239, 78, 225, 241, 166, 0, 33, 108, 75, 58, 27, 48, 183, 80, 157, 140, 17, 233, 85, 17, 102, 10, 242, 1 }, new byte[] { 197, 202, 109, 206, 36, 25, 83, 145, 66, 246, 202, 199, 245, 189, 94, 70, 174, 143, 44, 171, 169, 211, 171, 203, 228, 28, 39, 159, 93, 36, 6, 91, 211, 221, 43, 208, 242, 180, 105, 212, 226, 9, 12, 204, 159, 165, 93, 101, 12, 4, 176, 115, 3, 247, 77, 130, 170, 62, 79, 100, 118, 107, 217, 94, 181, 234, 95, 77, 145, 224, 40, 42, 246, 152, 216, 98, 243, 142, 158, 226, 255, 112, 91, 215, 10, 186, 98, 53, 50, 233, 204, 8, 203, 7, 232, 124, 44, 42, 232, 253, 196, 228, 124, 153, 250, 146, 190, 69, 101, 112, 117, 116, 2, 154, 254, 217, 19, 173, 204, 78, 168, 164, 141, 225, 229, 177, 77, 228 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DropColumn(
                name: "NotificationType",
                schema: "dbo",
                table: "NotificationRules");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 586, DateTimeKind.Utc).AddTicks(7694), new DateTime(2025, 3, 1, 17, 56, 53, 586, DateTimeKind.Utc).AddTicks(7698), new DateTime(2025, 3, 1, 17, 56, 53, 586, DateTimeKind.Utc).AddTicks(7697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3379), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3380), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3382), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3384), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3385), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3386), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3387), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3388), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3389), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3390), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3391), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3392), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3393), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3394), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3395), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3396), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3397), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3398), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3399), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3400), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3401), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3400) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3402), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3403), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3404), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3405), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3406), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3407), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3408), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3409), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3410), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3412), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3412), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3414), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3414), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3415), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3416), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3417), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3418), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3419), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3420), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3420) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3421), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3422), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3422) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3423), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3424), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3425), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3426), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3426) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3427), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3428), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3429), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3430), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3429) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3431), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3432), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3433), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3434), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3433) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3435), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3436), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3435) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3437), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3438), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3439), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3439), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3441), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3441), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3443), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3443), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3444), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3445), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3446), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3447), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3448), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3449), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3449) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3450), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3451), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3451) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3452), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3453), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3454), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3455), new DateTime(2025, 3, 1, 17, 56, 53, 587, DateTimeKind.Utc).AddTicks(3454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 588, DateTimeKind.Utc).AddTicks(5405), new DateTime(2025, 3, 1, 17, 56, 53, 588, DateTimeKind.Utc).AddTicks(5407), new DateTime(2025, 3, 1, 17, 56, 53, 588, DateTimeKind.Utc).AddTicks(5406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 588, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 588, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 593, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 600, DateTimeKind.Utc).AddTicks(8099), new DateTime(2025, 3, 1, 17, 56, 53, 600, DateTimeKind.Utc).AddTicks(8101), new DateTime(2025, 3, 1, 17, 56, 53, 600, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 609, DateTimeKind.Utc).AddTicks(598));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 609, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 609, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 612, DateTimeKind.Utc).AddTicks(6473), new DateTime(2025, 3, 1, 17, 56, 53, 612, DateTimeKind.Utc).AddTicks(6474), new DateTime(2025, 3, 1, 17, 56, 53, 612, DateTimeKind.Utc).AddTicks(6474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 615, DateTimeKind.Utc).AddTicks(9126));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 17, 56, 53, 616, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 617, DateTimeKind.Utc).AddTicks(1521), new DateTime(2025, 3, 1, 17, 56, 53, 617, DateTimeKind.Utc).AddTicks(1522), new DateTime(2025, 3, 1, 17, 56, 53, 617, DateTimeKind.Utc).AddTicks(1522), new byte[] { 129, 195, 251, 218, 175, 211, 27, 149, 139, 185, 183, 31, 65, 144, 93, 156, 151, 180, 45, 175, 66, 35, 25, 95, 161, 132, 80, 136, 55, 23, 60, 214, 150, 231, 155, 206, 194, 19, 130, 232, 62, 215, 169, 69, 25, 239, 170, 32, 253, 58, 56, 124, 35, 119, 83, 45, 170, 49, 96, 120, 86, 192, 1, 112 }, new byte[] { 141, 168, 54, 68, 10, 220, 16, 110, 14, 151, 28, 128, 78, 225, 31, 21, 135, 229, 24, 62, 11, 221, 25, 118, 44, 201, 28, 210, 133, 16, 65, 42, 58, 0, 4, 11, 26, 72, 184, 167, 66, 61, 127, 41, 3, 16, 76, 67, 134, 12, 9, 21, 21, 197, 82, 120, 248, 2, 183, 118, 67, 143, 105, 243, 123, 231, 201, 181, 104, 215, 81, 73, 240, 50, 246, 194, 168, 133, 116, 136, 55, 93, 54, 81, 131, 18, 41, 109, 56, 52, 170, 179, 58, 225, 85, 180, 121, 104, 65, 181, 87, 89, 68, 200, 166, 248, 105, 70, 6, 95, 125, 216, 104, 74, 83, 96, 134, 40, 156, 240, 159, 193, 189, 112, 148, 100, 108, 6 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 17, 56, 53, 619, DateTimeKind.Utc).AddTicks(2678), new DateTime(2025, 3, 1, 17, 56, 53, 619, DateTimeKind.Utc).AddTicks(2678), new DateTime(2025, 3, 1, 17, 56, 53, 619, DateTimeKind.Utc).AddTicks(2679), new byte[] { 15, 95, 117, 206, 28, 27, 183, 1, 144, 115, 50, 202, 250, 9, 29, 102, 120, 99, 163, 214, 118, 42, 241, 34, 114, 203, 88, 85, 35, 25, 173, 16, 184, 55, 135, 241, 30, 182, 241, 228, 211, 126, 23, 113, 106, 68, 247, 122, 94, 24, 245, 136, 192, 89, 229, 175, 51, 64, 63, 81, 61, 74, 254, 74 }, new byte[] { 72, 169, 249, 179, 186, 88, 43, 193, 182, 236, 168, 250, 223, 181, 240, 7, 200, 69, 114, 157, 91, 66, 228, 127, 192, 190, 169, 212, 68, 194, 49, 156, 189, 200, 188, 170, 171, 121, 247, 83, 172, 152, 146, 21, 203, 193, 42, 225, 53, 236, 59, 19, 168, 131, 51, 131, 67, 148, 55, 131, 211, 82, 34, 161, 23, 95, 36, 13, 239, 222, 66, 64, 179, 229, 152, 83, 99, 29, 103, 171, 252, 211, 71, 48, 2, 69, 214, 236, 76, 74, 125, 78, 69, 53, 31, 24, 130, 235, 174, 243, 50, 240, 125, 150, 246, 232, 131, 172, 10, 165, 164, 106, 1, 142, 76, 82, 183, 202, 109, 9, 151, 99, 148, 125, 168, 243, 243, 139 } });
        }
    }
}
