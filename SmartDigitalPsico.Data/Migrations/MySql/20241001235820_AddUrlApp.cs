using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class AddUrlApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlRootManager",
                schema: "dbo",
                table: "ApplicationConfigSetting",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "UrlRootManager" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9346), "https://smartdigitalpsicoui-staging.azurewebsites.net/" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2637), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2638), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2644), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2645), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2646), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2647), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2651), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2652), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2654), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2656), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2658), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2659), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2661), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2665), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2666), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2668), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2673), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2678), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2680), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2687), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2689), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2692), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2697), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2714), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2716), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2719), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2721), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2725), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2727), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8557), new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9152), new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7597), new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7598), new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7598), new byte[] { 205, 132, 138, 253, 146, 243, 58, 76, 34, 5, 98, 80, 92, 211, 227, 12, 252, 246, 231, 252, 134, 116, 140, 241, 178, 18, 145, 112, 33, 161, 121, 179, 20, 14, 222, 13, 15, 60, 136, 91, 182, 253, 80, 172, 214, 94, 90, 121, 158, 169, 202, 226, 203, 58, 186, 40, 203, 90, 249, 220, 127, 230, 69, 32 }, new byte[] { 165, 20, 34, 42, 17, 210, 24, 205, 11, 199, 121, 246, 63, 183, 170, 162, 14, 199, 240, 7, 106, 69, 140, 190, 159, 225, 177, 116, 96, 205, 125, 162, 88, 212, 160, 15, 12, 156, 118, 145, 246, 230, 70, 99, 34, 61, 203, 131, 138, 123, 13, 62, 184, 56, 96, 178, 45, 136, 157, 43, 22, 41, 136, 105, 21, 90, 23, 96, 194, 104, 165, 1, 67, 38, 249, 101, 30, 81, 184, 52, 49, 164, 214, 40, 30, 110, 113, 24, 228, 246, 40, 123, 231, 26, 87, 62, 123, 45, 3, 99, 212, 48, 249, 160, 215, 41, 147, 164, 132, 248, 41, 106, 29, 43, 201, 204, 136, 254, 73, 61, 254, 12, 210, 151, 122, 33, 189, 165 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2708), new byte[] { 16, 119, 45, 234, 32, 248, 201, 208, 107, 119, 4, 31, 46, 159, 83, 199, 121, 78, 170, 185, 225, 11, 212, 253, 215, 254, 19, 220, 150, 197, 150, 145, 94, 194, 223, 176, 80, 120, 36, 6, 133, 136, 246, 149, 212, 253, 202, 219, 137, 200, 121, 196, 89, 21, 229, 194, 174, 169, 4, 139, 253, 53, 254, 55 }, new byte[] { 179, 95, 102, 42, 141, 238, 39, 36, 61, 7, 150, 244, 166, 85, 31, 182, 3, 203, 207, 10, 28, 246, 98, 161, 80, 74, 103, 236, 21, 166, 147, 119, 194, 216, 151, 84, 14, 1, 15, 76, 143, 25, 46, 61, 2, 211, 11, 123, 4, 140, 103, 72, 219, 227, 138, 234, 240, 213, 117, 177, 223, 170, 13, 117, 43, 71, 64, 24, 168, 90, 243, 57, 220, 216, 61, 167, 223, 200, 161, 40, 202, 53, 190, 71, 93, 213, 169, 111, 213, 56, 128, 127, 170, 57, 150, 115, 47, 190, 10, 162, 58, 29, 115, 13, 226, 211, 179, 91, 235, 213, 10, 181, 87, 171, 97, 175, 127, 135, 76, 232, 152, 135, 22, 177, 170, 71, 189, 254 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlRootManager",
                schema: "dbo",
                table: "ApplicationConfigSetting");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(728), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(934), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(935), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(936), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(941), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1026), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1027), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1028), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1031), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1033), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1034), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1035), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1036) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1037), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1038), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1037) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1039), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1042), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1043), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1044), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1045), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1046), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1292), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1293) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1606));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1714));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1718));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1826), new DateTime(2024, 9, 28, 5, 5, 51, 5, DateTimeKind.Utc).AddTicks(1827), new byte[] { 36, 53, 47, 95, 113, 28, 8, 202, 68, 45, 120, 114, 78, 67, 55, 187, 207, 124, 41, 21, 5, 238, 251, 125, 79, 31, 184, 186, 88, 124, 33, 65, 243, 17, 180, 78, 192, 41, 244, 241, 203, 2, 188, 138, 243, 68, 75, 75, 222, 33, 47, 159, 99, 144, 238, 195, 12, 51, 101, 197, 244, 243, 76, 198 }, new byte[] { 24, 37, 160, 188, 215, 204, 82, 59, 183, 100, 225, 252, 21, 80, 121, 203, 82, 105, 203, 64, 17, 15, 146, 97, 212, 213, 137, 126, 136, 98, 82, 76, 188, 223, 157, 10, 170, 225, 150, 9, 139, 216, 172, 85, 7, 225, 13, 249, 131, 1, 57, 26, 236, 64, 204, 234, 91, 134, 146, 225, 232, 241, 108, 78, 160, 8, 214, 85, 0, 142, 46, 121, 214, 204, 186, 33, 160, 109, 131, 74, 159, 169, 72, 223, 138, 51, 143, 217, 21, 104, 132, 32, 162, 233, 51, 177, 238, 179, 131, 207, 173, 236, 66, 207, 112, 65, 170, 62, 232, 121, 201, 218, 148, 50, 166, 56, 17, 178, 251, 127, 36, 144, 51, 181, 88, 92, 98, 11 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 9, 28, 5, 5, 51, 7, DateTimeKind.Utc).AddTicks(3193), new byte[] { 33, 39, 26, 96, 154, 1, 17, 195, 134, 14, 81, 38, 197, 157, 163, 13, 152, 31, 46, 205, 23, 222, 81, 158, 51, 125, 70, 73, 241, 5, 22, 15, 73, 229, 245, 49, 82, 23, 192, 152, 139, 92, 28, 4, 100, 117, 164, 227, 199, 206, 108, 40, 246, 66, 45, 146, 255, 227, 37, 11, 209, 81, 44, 80 }, new byte[] { 227, 97, 242, 4, 228, 168, 164, 65, 216, 33, 100, 154, 232, 86, 111, 206, 247, 229, 255, 32, 62, 202, 66, 253, 255, 18, 205, 104, 57, 60, 205, 186, 40, 92, 211, 114, 79, 205, 22, 153, 123, 231, 18, 7, 220, 71, 141, 19, 58, 120, 70, 75, 22, 44, 151, 204, 116, 92, 132, 100, 203, 43, 179, 85, 55, 253, 120, 18, 86, 207, 140, 237, 21, 27, 200, 56, 89, 63, 53, 197, 244, 91, 22, 169, 69, 32, 97, 83, 122, 50, 72, 29, 34, 137, 217, 27, 97, 62, 167, 244, 23, 0, 193, 66, 183, 9, 225, 0, 86, 197, 237, 84, 12, 182, 5, 221, 184, 144, 214, 230, 31, 198, 28, 70, 34, 249, 63, 162 } });
        }
    }
}
