using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecords4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EventDate",
                schema: "dbo",
                table: "NotificationRecords",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7096), new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2500), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2501), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2507), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2508), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2509), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2519), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2522), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2525), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2530), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2533), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2534), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2541), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2542), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2543), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2548), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2549), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2550), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2552), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2554), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2555), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2556), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2558), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2559), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2560), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2561), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2563), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2564), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2566), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5969), new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5970), new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1180), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1181), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1184), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1185), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1189), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1192), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9085), new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1323), new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1324), new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1324), new byte[] { 199, 29, 73, 24, 145, 81, 10, 137, 21, 152, 254, 64, 50, 245, 203, 9, 177, 231, 158, 249, 190, 41, 37, 94, 207, 146, 149, 122, 150, 228, 85, 245, 155, 226, 163, 211, 4, 96, 70, 9, 231, 235, 126, 94, 40, 208, 202, 106, 24, 200, 66, 158, 212, 115, 39, 250, 126, 205, 233, 165, 38, 13, 32, 103 }, new byte[] { 255, 30, 80, 86, 215, 243, 66, 162, 241, 170, 250, 238, 116, 68, 99, 163, 224, 55, 188, 6, 180, 108, 219, 205, 234, 84, 64, 175, 196, 27, 223, 244, 191, 154, 220, 132, 25, 77, 214, 135, 186, 2, 178, 229, 118, 220, 220, 213, 253, 105, 12, 87, 137, 88, 101, 169, 167, 61, 24, 161, 246, 190, 26, 50, 225, 56, 118, 99, 165, 147, 215, 253, 82, 216, 93, 117, 73, 18, 35, 89, 16, 149, 3, 128, 222, 218, 152, 226, 168, 7, 41, 16, 117, 109, 192, 127, 234, 12, 8, 116, 209, 166, 225, 104, 6, 116, 106, 1, 222, 59, 33, 254, 24, 120, 72, 7, 214, 107, 122, 128, 124, 92, 181, 51, 253, 162, 122, 227 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3896), new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3896), new byte[] { 89, 120, 155, 250, 99, 59, 153, 145, 35, 169, 128, 211, 70, 17, 68, 82, 228, 159, 235, 159, 181, 195, 173, 23, 25, 186, 7, 176, 175, 81, 45, 186, 241, 126, 204, 22, 105, 198, 242, 252, 52, 76, 221, 48, 100, 131, 54, 37, 103, 89, 116, 98, 44, 111, 63, 166, 117, 179, 251, 235, 167, 64, 146, 220 }, new byte[] { 122, 99, 99, 221, 16, 77, 30, 6, 218, 64, 33, 242, 195, 120, 127, 157, 29, 13, 17, 164, 102, 109, 57, 63, 29, 19, 102, 29, 165, 71, 90, 94, 11, 147, 218, 12, 65, 45, 144, 167, 192, 208, 138, 173, 62, 20, 222, 84, 106, 73, 45, 186, 64, 137, 229, 190, 86, 28, 168, 183, 230, 108, 244, 81, 234, 238, 175, 196, 89, 218, 33, 138, 233, 1, 32, 112, 114, 235, 122, 60, 72, 234, 54, 191, 114, 225, 10, 68, 86, 205, 10, 91, 228, 27, 95, 50, 223, 153, 204, 198, 226, 113, 62, 44, 234, 23, 65, 2, 65, 145, 15, 147, 85, 15, 142, 201, 126, 32, 233, 103, 157, 104, 75, 202, 249, 53, 93, 139 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EventDate",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(654), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(661), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5877), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5878), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5880), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5881), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5880) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5882) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5884) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5887), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5888), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5889), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5890), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5891), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5892), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5893), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5894), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5896), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5897), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5898), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5899), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5900), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5901), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5902), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5903), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5907), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5909), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5911), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5912), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5911) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5914), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5915), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5919), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5921), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5925), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5926), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5927), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5928), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5929), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5930), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5929) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5932), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5933), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5934), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5935), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5936), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5937), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5941), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5942), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5943), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5945), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5946), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947), new DateTime(2025, 3, 2, 2, 24, 45, 439, DateTimeKind.Utc).AddTicks(5947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6526), new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6529), new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(6528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 440, DateTimeKind.Utc).AddTicks(8285));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 443, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1787), new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1789), new DateTime(2025, 3, 2, 2, 24, 45, 450, DateTimeKind.Utc).AddTicks(1789) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5004), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5006), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5011), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5012), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5016), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5017), new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(5017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 457, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8400), new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8402), new DateTime(2025, 3, 2, 2, 24, 45, 460, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 463, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9814), new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 3, 2, 2, 24, 45, 464, DateTimeKind.Utc).AddTicks(9816), new byte[] { 101, 28, 205, 33, 105, 31, 2, 35, 233, 112, 158, 52, 95, 50, 37, 230, 27, 125, 226, 196, 17, 241, 90, 213, 27, 31, 62, 137, 116, 141, 245, 175, 67, 225, 35, 201, 10, 57, 114, 172, 41, 116, 50, 25, 114, 107, 2, 68, 150, 127, 42, 115, 175, 115, 17, 113, 34, 72, 102, 234, 160, 7, 40, 247 }, new byte[] { 177, 208, 124, 38, 158, 216, 196, 101, 72, 143, 191, 120, 242, 118, 176, 131, 154, 17, 38, 38, 168, 26, 151, 222, 125, 147, 230, 35, 107, 96, 238, 255, 186, 112, 61, 63, 185, 178, 147, 170, 142, 216, 94, 21, 226, 8, 220, 132, 249, 166, 164, 168, 175, 1, 58, 239, 223, 55, 236, 156, 135, 165, 146, 253, 191, 122, 183, 238, 227, 0, 197, 37, 239, 204, 76, 85, 216, 37, 153, 145, 117, 237, 254, 61, 12, 242, 30, 51, 195, 67, 39, 200, 33, 35, 8, 61, 177, 137, 111, 183, 211, 32, 6, 132, 199, 161, 228, 50, 52, 129, 189, 85, 102, 180, 127, 104, 161, 151, 242, 150, 41, 210, 10, 54, 11, 60, 157, 90 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(806), new DateTime(2025, 3, 2, 2, 24, 45, 467, DateTimeKind.Utc).AddTicks(807), new byte[] { 212, 9, 212, 213, 133, 60, 137, 141, 189, 57, 98, 13, 36, 98, 145, 89, 251, 170, 202, 19, 184, 255, 68, 214, 207, 81, 201, 172, 228, 98, 121, 11, 241, 177, 49, 220, 252, 251, 2, 219, 51, 224, 171, 50, 166, 154, 151, 95, 179, 231, 159, 153, 134, 19, 31, 38, 137, 231, 236, 241, 131, 158, 185, 151 }, new byte[] { 4, 241, 240, 72, 32, 238, 61, 33, 242, 84, 76, 37, 166, 210, 150, 50, 123, 127, 72, 213, 116, 242, 141, 162, 3, 52, 32, 38, 61, 87, 10, 11, 166, 210, 25, 22, 169, 39, 30, 150, 186, 43, 148, 16, 230, 45, 73, 109, 101, 29, 176, 219, 50, 101, 227, 115, 45, 75, 69, 254, 241, 118, 149, 72, 16, 137, 129, 166, 98, 106, 123, 123, 144, 121, 84, 171, 134, 46, 57, 21, 48, 249, 54, 40, 138, 0, 35, 186, 133, 165, 202, 107, 249, 29, 80, 214, 126, 255, 248, 216, 108, 2, 180, 193, 179, 138, 24, 202, 84, 204, 151, 67, 115, 206, 69, 143, 111, 99, 234, 91, 127, 190, 182, 87, 72, 100, 90, 173 } });
        }
    }
}
