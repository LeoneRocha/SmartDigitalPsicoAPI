using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class EmailTemplateUpdates3 : Migration
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
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2631), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2632), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2634), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2635), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2636), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2638), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2639), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2644), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2645), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2646), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2648), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2650), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2655), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2657), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2658), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2659), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2661), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2666), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2669), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2708), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2709), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2710), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2713), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2718), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2721), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2723), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2724), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2726), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2727), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2729), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2730), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(7998), new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(8000), new byte[] { 156, 6, 237, 178, 136, 153, 22, 116, 205, 10, 228, 134, 247, 7, 83, 144, 198, 163, 200, 9, 24, 166, 115, 88, 147, 117, 52, 44, 205, 72, 169, 70, 235, 118, 51, 128, 221, 175, 79, 8, 55, 184, 53, 207, 41, 230, 50, 77, 11, 171, 37, 175, 22, 235, 156, 44, 245, 210, 125, 206, 203, 171, 26, 57 }, new byte[] { 188, 219, 239, 212, 192, 91, 91, 98, 87, 75, 3, 184, 166, 25, 9, 70, 49, 175, 223, 28, 194, 198, 125, 159, 54, 159, 26, 83, 104, 175, 200, 196, 63, 60, 158, 239, 163, 97, 173, 10, 232, 95, 63, 181, 145, 151, 190, 208, 152, 12, 12, 238, 254, 5, 8, 2, 212, 67, 195, 156, 233, 152, 37, 61, 89, 57, 168, 143, 218, 180, 4, 47, 97, 143, 93, 119, 29, 245, 71, 32, 148, 149, 189, 61, 241, 118, 117, 49, 99, 252, 227, 198, 106, 86, 120, 63, 157, 81, 80, 44, 68, 119, 223, 198, 192, 30, 223, 159, 169, 191, 9, 5, 128, 45, 87, 139, 203, 40, 63, 165, 212, 65, 42, 221, 106, 104, 216, 150 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(705), new byte[] { 79, 102, 197, 196, 51, 64, 228, 81, 32, 39, 219, 192, 201, 143, 86, 213, 62, 56, 28, 79, 44, 249, 213, 50, 35, 153, 54, 69, 162, 223, 188, 105, 203, 47, 31, 12, 242, 56, 2, 199, 239, 148, 251, 151, 205, 235, 175, 136, 45, 74, 127, 39, 102, 205, 107, 250, 173, 140, 162, 137, 29, 121, 22, 81 }, new byte[] { 178, 179, 167, 11, 14, 16, 74, 131, 0, 212, 240, 252, 125, 209, 236, 21, 18, 87, 244, 2, 161, 47, 19, 85, 196, 217, 157, 77, 192, 24, 59, 192, 207, 29, 219, 157, 158, 104, 155, 129, 131, 169, 195, 56, 1, 168, 177, 16, 149, 22, 93, 96, 152, 199, 97, 205, 155, 119, 47, 88, 70, 243, 126, 24, 204, 40, 107, 43, 24, 35, 64, 118, 103, 123, 207, 204, 46, 27, 184, 8, 107, 126, 182, 97, 84, 154, 48, 227, 128, 91, 9, 206, 198, 92, 196, 30, 198, 167, 208, 79, 104, 182, 146, 204, 36, 129, 161, 102, 188, 141, 43, 248, 48, 120, 233, 60, 206, 72, 8, 205, 157, 184, 133, 56, 2, 16, 156, 187 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_Language",
                schema: "dbo",
                table: "EmailTemplate",
                column: "Language");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "EmailTemplate",
                columns: new[] { "Language", "TagApi", "Enable" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_TagApi",
                schema: "dbo",
                table: "EmailTemplate",
                column: "TagApi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmailTemplate_Language",
                schema: "dbo",
                table: "EmailTemplate");

            migrationBuilder.DropIndex(
                name: "IX_EmailTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "EmailTemplate");

            migrationBuilder.DropIndex(
                name: "IX_EmailTemplate_TagApi",
                schema: "dbo",
                table: "EmailTemplate");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2094), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2097), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3464), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3466), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3468), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3469), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3470), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3471), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3472), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3473), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3474), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3476), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3478), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3479), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3489), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3493), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3498), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3500), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3502), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3504), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3505), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3506), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3508), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3515), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3516), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3518), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3522), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3542), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3545), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3546), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3547), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3548), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3556), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4944), new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3962), new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3963), new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9835), new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6791), new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6792), new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6793), new byte[] { 189, 186, 125, 224, 79, 67, 59, 105, 238, 192, 173, 106, 100, 43, 126, 192, 11, 141, 221, 56, 162, 197, 249, 3, 223, 181, 199, 37, 168, 21, 30, 78, 185, 187, 109, 112, 120, 47, 46, 14, 107, 120, 130, 44, 197, 159, 8, 82, 210, 18, 26, 67, 12, 83, 229, 174, 49, 222, 13, 186, 204, 98, 187, 21 }, new byte[] { 53, 198, 134, 31, 133, 226, 45, 70, 117, 66, 244, 25, 246, 207, 98, 23, 14, 96, 9, 18, 163, 148, 123, 22, 99, 99, 114, 10, 238, 83, 123, 8, 116, 191, 132, 173, 52, 214, 247, 202, 111, 234, 75, 222, 230, 132, 184, 142, 119, 116, 109, 47, 125, 200, 220, 126, 43, 0, 178, 192, 144, 92, 215, 212, 184, 31, 245, 58, 232, 139, 124, 226, 71, 109, 85, 31, 61, 111, 69, 139, 52, 141, 66, 109, 90, 64, 230, 35, 38, 198, 64, 88, 21, 122, 56, 216, 175, 125, 117, 85, 152, 80, 250, 111, 216, 79, 92, 163, 250, 112, 238, 212, 64, 194, 119, 90, 146, 167, 130, 24, 115, 120, 137, 187, 190, 10, 224, 36 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8088), new byte[] { 18, 62, 9, 16, 31, 87, 4, 241, 189, 29, 221, 136, 114, 232, 53, 196, 10, 78, 163, 200, 222, 153, 228, 47, 205, 208, 150, 31, 203, 230, 192, 89, 201, 58, 38, 207, 52, 136, 63, 9, 221, 5, 244, 200, 234, 205, 178, 82, 191, 223, 112, 176, 123, 200, 167, 55, 47, 220, 15, 235, 219, 194, 17, 112 }, new byte[] { 141, 108, 0, 187, 65, 32, 49, 119, 117, 207, 70, 99, 56, 65, 150, 166, 154, 244, 49, 128, 13, 100, 198, 198, 188, 9, 188, 201, 77, 98, 2, 173, 29, 247, 25, 85, 76, 176, 180, 62, 212, 215, 189, 245, 220, 88, 229, 102, 183, 160, 21, 172, 231, 113, 156, 214, 48, 203, 136, 125, 204, 132, 155, 7, 229, 165, 143, 4, 133, 213, 238, 117, 89, 70, 92, 106, 58, 139, 239, 151, 229, 160, 41, 69, 9, 169, 128, 203, 61, 133, 253, 95, 155, 75, 141, 212, 212, 196, 178, 86, 120, 168, 225, 189, 53, 108, 176, 2, 210, 219, 154, 41, 188, 111, 141, 58, 114, 203, 204, 187, 223, 157, 145, 198, 32, 17, 54, 252 } });
        }
    }
}
