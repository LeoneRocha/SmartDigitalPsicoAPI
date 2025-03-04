using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class PatientMockDataUpdate04032025 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 998, DateTimeKind.Utc).AddTicks(7445), new DateTime(2025, 3, 4, 19, 19, 20, 998, DateTimeKind.Utc).AddTicks(7447), new DateTime(2025, 3, 4, 19, 19, 20, 998, DateTimeKind.Utc).AddTicks(7447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2645), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2646), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2650), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2652), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2655), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2657), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2658), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2659), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2661), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2663), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2666), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2669), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2673) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2674), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2675), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2675) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2676), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2677), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2678), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2679), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2680), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2681), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2680) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2682), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2682), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2683), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2684), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2684) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2685), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2686), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2687), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2688), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2687) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2730), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2733), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2733), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2734), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2735), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2736), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2737), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2738), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2739), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2740), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2740), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2742), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2742), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2743), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2744), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2745), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2746), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2747), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2748), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2749), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2749), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2751), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2752), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2753), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2753) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2754), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2755), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2756), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2757), new DateTime(2025, 3, 4, 19, 19, 20, 999, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 0, DateTimeKind.Utc).AddTicks(3454), new DateTime(2025, 3, 4, 19, 19, 21, 0, DateTimeKind.Utc).AddTicks(3455), new DateTime(2025, 3, 4, 19, 19, 21, 0, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 0, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 0, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 3, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 10, DateTimeKind.Utc).AddTicks(1645), new DateTime(2025, 3, 4, 19, 19, 21, 10, DateTimeKind.Utc).AddTicks(1647), new DateTime(2025, 3, 4, 19, 19, 21, 10, DateTimeKind.Utc).AddTicks(1647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8217), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8219) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8222), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8223), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8225), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8226), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8227), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8230) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8232), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8232), new DateTime(2025, 3, 4, 19, 19, 21, 17, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 18, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 18, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 18, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Patient",
                columns: new[] { "Id", "AddressCep", "AddressCity", "AddressNeighborhood", "AddressState", "AddressStreet", "Cpf", "CreatedDate", "CreatedUserId", "DateOfBirth", "Education", "Email", "EmergencyContactName", "EmergencyContactPhoneNumber", "Enable", "GenderId", "LastAccessDate", "MaritalStatus", "MedicalId", "ModifyDate", "ModifyUserId", "Name", "PhoneNumber", "Profession", "Rg" },
                values: new object[,]
                {
                    { 2L, "12345-678", "São Paulo", "Jardins", "São Paulo", "Rua das Flores, 123", "123.456.789-00", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2563), 2L, new DateTime(1990, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Médio Completo", "ana.luiza@domain.com", "Carlos Ferreira", "(11) 91234-5678", true, 2L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2563), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2564), null, "Ana Luiza Ferreira", "(11) 4002-8922", "Estudante", "12.345.678-9" },
                    { 3L, "98765-432", "Rio de Janeiro", "Copacabana", "Rio de Janeiro", "Av. Atlântica, 456", "987.654.321-99", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2589), 2L, new DateTime(1985, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Superior Completo", "jose.henrique@domain.com", "Mariana Silva", "(21) 99876-5432", true, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2590), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2590), null, "José Henrique Silva", "(21) 3000-7000", "Advogado", "98.765.432-1" },
                    { 4L, "45678-123", "Belo Horizonte", "Savassi", "Minas Gerais", "Rua dos Ipês, 789", "456.789.123-10", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2594), 2L, new DateTime(1975, 12, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Pós-Graduação", "maria.clara@domain.com", "Fernando Oliveira", "(31) 97654-3210", true, 2L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2595), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2595), null, "Maria Clara Oliveira", "(31) 4004-3003", "Arquiteta", "45.678.912-0" },
                    { 5L, "65432-789", "Curitiba", "Centro Cívico", "Paraná", "Av. Paraná, 987", "654.321.987-88", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2598), 2L, new DateTime(2000, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Fundamental Completo", "gabriel.santos@domain.com", "Lucas Santos", "(41) 98432-1234", true, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2599), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2599), null, "Gabriel Santos", "(41) 3020-8989", "Atendente", "65.432.198-7" },
                    { 6L, "89010-123", "Blumenau", "Centro", "Santa Catarina", "Rua das Flores, 45", "456.123.789-09", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2602), 2L, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Médio Completo", "laura.costa@example.com", "Ana Costa", "(47) 99987-6543", true, 2L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2603), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2603), null, "Laura Carolina Costa", "(47) 3030-2020", "Estilista", "12.345.678-9" },
                    { 7L, "01310-100", "São Paulo", "Bela Vista", "São Paulo", "Avenida Paulista, 1500", "123.456.789-00", new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2606), 2L, new DateTime(1985, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Pós-Graduação", "diego.almeida@example.com", "Marina Almeida", "(11) 98888-1234", true, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2606), (byte)0, 1L, new DateTime(2025, 3, 4, 19, 19, 21, 21, DateTimeKind.Utc).AddTicks(2607), null, "Diego Rafael Almeida", "(11) 3111-4567", "Analista de Sistemas", "23.456.789-0" }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 24, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(5362), new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(5363), new DateTime(2025, 3, 4, 19, 19, 21, 25, DateTimeKind.Utc).AddTicks(5364), new byte[] { 26, 87, 149, 94, 208, 223, 151, 213, 85, 206, 23, 99, 207, 61, 115, 31, 239, 204, 60, 10, 239, 11, 248, 78, 210, 107, 252, 13, 126, 61, 233, 131, 68, 30, 150, 205, 58, 120, 126, 19, 48, 107, 221, 252, 181, 194, 196, 56, 50, 195, 47, 177, 203, 230, 80, 1, 49, 100, 8, 93, 164, 193, 92, 75 }, new byte[] { 176, 51, 174, 161, 214, 231, 180, 134, 48, 180, 248, 58, 6, 184, 206, 166, 132, 109, 251, 66, 7, 239, 172, 35, 204, 69, 79, 146, 192, 153, 200, 21, 158, 78, 136, 25, 25, 146, 219, 118, 36, 71, 239, 133, 167, 53, 103, 39, 178, 223, 250, 59, 225, 42, 36, 74, 18, 186, 156, 190, 5, 35, 3, 47, 196, 105, 223, 178, 156, 185, 142, 140, 28, 57, 2, 179, 189, 39, 112, 214, 235, 252, 138, 97, 67, 124, 229, 236, 34, 235, 61, 25, 190, 10, 16, 93, 154, 138, 121, 189, 146, 6, 41, 106, 19, 185, 21, 30, 121, 203, 194, 243, 189, 176, 4, 104, 123, 219, 80, 98, 187, 74, 177, 240, 236, 81, 2, 44 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 19, 21, 27, DateTimeKind.Utc).AddTicks(6831), new DateTime(2025, 3, 4, 19, 19, 21, 27, DateTimeKind.Utc).AddTicks(6832), new DateTime(2025, 3, 4, 19, 19, 21, 27, DateTimeKind.Utc).AddTicks(6832), new byte[] { 174, 60, 236, 77, 185, 142, 226, 202, 16, 214, 128, 144, 2, 135, 1, 159, 150, 217, 55, 220, 252, 189, 162, 185, 10, 10, 194, 94, 163, 153, 30, 184, 125, 124, 117, 210, 58, 18, 76, 81, 149, 150, 208, 189, 114, 118, 153, 223, 220, 77, 248, 191, 115, 231, 202, 102, 119, 240, 238, 90, 192, 2, 88, 55 }, new byte[] { 24, 208, 214, 171, 247, 29, 56, 155, 150, 102, 52, 23, 190, 109, 145, 1, 13, 138, 181, 231, 246, 49, 62, 229, 97, 144, 183, 40, 240, 51, 2, 93, 24, 194, 216, 239, 158, 252, 50, 205, 61, 24, 142, 3, 3, 89, 190, 156, 182, 141, 22, 223, 98, 214, 147, 195, 208, 199, 25, 119, 175, 195, 129, 219, 243, 18, 27, 184, 139, 56, 71, 233, 208, 3, 50, 227, 252, 210, 31, 60, 121, 122, 28, 176, 151, 86, 152, 107, 37, 90, 75, 94, 170, 94, 188, 22, 147, 186, 250, 184, 154, 199, 134, 245, 175, 191, 224, 38, 22, 18, 250, 86, 28, 198, 72, 129, 206, 165, 137, 158, 105, 175, 252, 97, 120, 0, 9, 114 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(409), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(412), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5630), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5632), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5633), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5634), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5634) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5635), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5636), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5636) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5637), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5638), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5638) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5639), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5640), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5640) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5641), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5642), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5641) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5643), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5644), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5643) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5645), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5645), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5645) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5647), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5647), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5648), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5649), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5649) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5650), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5651), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5651) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5652), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5653), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5654), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5655), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5656), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5656), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5658), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5658), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5659), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5660), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5662), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5663), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5664), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5665), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5665), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5667), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5667), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5668), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5669), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5670), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5671), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5672), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5673), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5674), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5675), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5676), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5677), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5678), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5680), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5680), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5680) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5681), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5682), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5683), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5684), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5685), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5686), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5685) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5687), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5687), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5689), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5689), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5690), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5691), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5692), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5693), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5694), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5695), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5696), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5697), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5698), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5698), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5699), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5700), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5701), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5702), new DateTime(2025, 3, 4, 18, 26, 41, 331, DateTimeKind.Utc).AddTicks(5702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 332, DateTimeKind.Utc).AddTicks(5835), new DateTime(2025, 3, 4, 18, 26, 41, 332, DateTimeKind.Utc).AddTicks(5836), new DateTime(2025, 3, 4, 18, 26, 41, 332, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 332, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 332, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6757));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 335, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 341, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 3, 4, 18, 26, 41, 341, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 3, 4, 18, 26, 41, 341, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(233), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(234), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(237), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(238), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(237) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(269), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(269), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(269) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(271), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(272), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(273), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(274), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(273) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(275), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(276), new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(276) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 349, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 352, DateTimeKind.Utc).AddTicks(3026), new DateTime(2025, 3, 4, 18, 26, 41, 352, DateTimeKind.Utc).AddTicks(3027), new DateTime(2025, 3, 4, 18, 26, 41, 352, DateTimeKind.Utc).AddTicks(3028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2255));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2257));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8213));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 18, 26, 41, 355, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 356, DateTimeKind.Utc).AddTicks(3235), new DateTime(2025, 3, 4, 18, 26, 41, 356, DateTimeKind.Utc).AddTicks(3236), new DateTime(2025, 3, 4, 18, 26, 41, 356, DateTimeKind.Utc).AddTicks(3236), new byte[] { 218, 99, 83, 154, 49, 150, 44, 86, 124, 223, 255, 145, 30, 41, 162, 88, 32, 209, 223, 213, 182, 162, 201, 108, 158, 247, 152, 179, 237, 80, 144, 5, 214, 80, 199, 23, 52, 107, 167, 61, 147, 62, 155, 39, 126, 96, 124, 177, 248, 197, 144, 17, 232, 31, 7, 201, 7, 176, 135, 98, 106, 88, 78, 248 }, new byte[] { 43, 196, 66, 250, 10, 82, 225, 25, 18, 178, 182, 153, 104, 172, 165, 21, 253, 147, 212, 232, 12, 93, 31, 57, 247, 211, 152, 134, 58, 125, 166, 81, 63, 0, 113, 41, 162, 64, 192, 63, 17, 56, 61, 4, 209, 56, 122, 116, 87, 190, 230, 75, 117, 250, 90, 130, 144, 184, 134, 19, 43, 199, 14, 98, 66, 234, 211, 195, 227, 128, 172, 31, 37, 4, 120, 121, 56, 105, 89, 168, 218, 205, 180, 65, 95, 184, 212, 18, 83, 146, 130, 29, 125, 227, 28, 223, 216, 12, 190, 83, 52, 253, 175, 48, 156, 197, 225, 149, 105, 243, 219, 180, 208, 200, 2, 150, 35, 232, 92, 113, 44, 76, 167, 220, 23, 211, 112, 191 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 18, 26, 41, 358, DateTimeKind.Utc).AddTicks(4048), new DateTime(2025, 3, 4, 18, 26, 41, 358, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 3, 4, 18, 26, 41, 358, DateTimeKind.Utc).AddTicks(4050), new byte[] { 239, 61, 63, 189, 82, 20, 134, 220, 96, 12, 152, 6, 46, 238, 129, 84, 44, 141, 60, 169, 210, 23, 26, 62, 17, 133, 209, 195, 176, 95, 234, 161, 1, 168, 218, 19, 136, 97, 71, 197, 130, 237, 148, 114, 227, 170, 21, 137, 2, 57, 14, 65, 78, 150, 231, 177, 179, 48, 151, 231, 144, 251, 70, 162 }, new byte[] { 160, 247, 167, 75, 39, 233, 173, 214, 215, 99, 177, 102, 94, 197, 80, 18, 17, 21, 152, 15, 132, 184, 106, 10, 169, 228, 111, 24, 44, 194, 83, 49, 153, 108, 235, 207, 13, 254, 170, 117, 202, 46, 29, 67, 38, 88, 228, 239, 191, 197, 67, 225, 114, 101, 164, 124, 58, 207, 32, 7, 77, 218, 14, 146, 186, 112, 205, 199, 168, 39, 92, 155, 23, 14, 45, 133, 40, 40, 138, 72, 200, 80, 191, 239, 119, 49, 92, 148, 250, 175, 124, 131, 126, 164, 138, 130, 82, 199, 77, 193, 23, 65, 128, 242, 10, 195, 46, 60, 156, 94, 245, 14, 125, 47, 120, 115, 73, 178, 28, 70, 178, 163, 218, 98, 207, 206, 228, 187 } });
        }
    }
}
