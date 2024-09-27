using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfig_02 : Migration
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
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2458), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2685), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2687), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2689), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2692), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2695) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2697), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2700), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2708) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2710), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2716), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2718), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2719), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2721), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2723), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2725), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2727), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2728), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2731), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2732), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2734), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2735), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2736), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2737) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2738), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2739), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2740), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2741), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2743), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2744), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2745), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2746), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2747), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2748), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3048), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3048), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3153));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 5, 17, 23, 51, 13, 969, DateTimeKind.Utc).AddTicks(3598), new byte[] { 106, 12, 103, 208, 61, 207, 37, 127, 191, 56, 40, 60, 206, 150, 6, 99, 205, 101, 193, 13, 208, 67, 141, 99, 81, 235, 129, 84, 153, 48, 109, 22, 207, 176, 197, 4, 72, 137, 97, 180, 217, 71, 4, 203, 0, 123, 137, 183, 91, 117, 182, 46, 178, 48, 99, 96, 172, 168, 172, 121, 25, 33, 190, 20 }, new byte[] { 23, 111, 165, 77, 17, 177, 148, 119, 154, 188, 209, 182, 83, 128, 99, 191, 64, 171, 93, 233, 122, 178, 9, 148, 233, 128, 74, 36, 58, 156, 154, 175, 153, 152, 101, 95, 204, 202, 93, 15, 108, 128, 123, 58, 163, 171, 210, 32, 9, 117, 138, 179, 144, 135, 58, 93, 155, 240, 65, 56, 59, 198, 248, 155, 185, 120, 120, 227, 22, 186, 250, 127, 42, 249, 11, 129, 175, 237, 191, 249, 107, 92, 153, 200, 235, 19, 19, 156, 112, 220, 132, 55, 58, 121, 111, 214, 117, 186, 210, 58, 110, 84, 233, 13, 106, 142, 205, 252, 17, 230, 151, 145, 219, 105, 165, 40, 162, 10, 205, 235, 219, 116, 3, 105, 211, 27, 41, 224 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4842), new DateTime(2024, 5, 17, 23, 51, 13, 971, DateTimeKind.Utc).AddTicks(4842), new byte[] { 140, 222, 209, 74, 3, 198, 76, 182, 168, 68, 49, 72, 12, 31, 134, 45, 153, 123, 85, 241, 87, 175, 251, 42, 135, 184, 200, 211, 70, 176, 204, 226, 112, 195, 219, 216, 172, 175, 109, 65, 175, 88, 160, 205, 90, 53, 68, 132, 23, 106, 140, 98, 168, 150, 147, 25, 145, 112, 74, 7, 26, 169, 223, 247 }, new byte[] { 79, 236, 173, 231, 37, 152, 52, 74, 246, 161, 220, 240, 222, 16, 162, 72, 58, 108, 251, 71, 222, 88, 167, 201, 4, 148, 11, 230, 221, 96, 244, 124, 124, 94, 19, 172, 210, 111, 162, 36, 193, 249, 152, 136, 125, 13, 164, 120, 145, 68, 110, 125, 136, 54, 177, 149, 52, 251, 248, 164, 62, 125, 71, 192, 26, 205, 230, 187, 132, 63, 186, 21, 150, 216, 207, 217, 200, 243, 9, 25, 202, 54, 117, 168, 115, 27, 94, 230, 206, 154, 19, 31, 176, 232, 5, 74, 20, 75, 122, 145, 7, 252, 3, 0, 122, 231, 120, 251, 23, 254, 9, 225, 232, 161, 1, 161, 24, 36, 34, 224, 157, 252, 95, 240, 77, 247, 93, 61 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4285), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4519), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4522), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4526), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4533), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4537), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4547), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4551), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4556), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4558), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4560), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4562), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4571), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4572) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5047), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5048), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5402), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5402), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5403), new byte[] { 40, 81, 149, 136, 146, 66, 3, 174, 24, 187, 107, 158, 213, 66, 192, 245, 139, 176, 197, 190, 78, 211, 165, 31, 109, 81, 5, 227, 111, 221, 243, 180, 166, 75, 135, 251, 62, 18, 110, 71, 88, 67, 96, 200, 175, 197, 134, 44, 115, 145, 234, 15, 250, 158, 240, 147, 57, 234, 219, 91, 124, 145, 100, 63 }, new byte[] { 20, 236, 213, 214, 25, 41, 228, 250, 201, 108, 85, 80, 92, 99, 4, 37, 146, 128, 152, 38, 161, 136, 121, 255, 39, 239, 28, 117, 235, 41, 65, 226, 226, 252, 74, 112, 139, 218, 76, 16, 238, 2, 70, 38, 68, 80, 1, 160, 47, 254, 243, 127, 173, 99, 70, 23, 104, 100, 226, 170, 168, 129, 114, 15, 125, 89, 129, 117, 141, 221, 138, 89, 182, 152, 251, 221, 196, 187, 85, 175, 91, 16, 164, 50, 129, 101, 232, 62, 232, 20, 83, 207, 89, 75, 183, 3, 195, 130, 51, 240, 158, 30, 193, 217, 97, 123, 112, 180, 145, 13, 4, 212, 184, 212, 42, 108, 198, 224, 198, 99, 25, 181, 33, 41, 67, 13, 137, 41 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6400), new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6401), new byte[] { 32, 55, 201, 105, 148, 233, 94, 195, 37, 131, 12, 27, 120, 146, 20, 201, 234, 101, 52, 2, 65, 178, 48, 149, 11, 166, 231, 7, 126, 215, 167, 254, 48, 148, 125, 255, 44, 86, 91, 51, 222, 82, 117, 91, 185, 193, 195, 82, 29, 119, 199, 61, 85, 21, 92, 170, 241, 250, 16, 184, 129, 32, 67, 245 }, new byte[] { 60, 222, 108, 37, 192, 117, 177, 61, 244, 61, 203, 187, 134, 2, 243, 77, 128, 178, 157, 84, 232, 173, 110, 16, 145, 120, 74, 148, 155, 17, 69, 45, 42, 248, 247, 87, 191, 175, 169, 173, 150, 254, 95, 5, 88, 207, 108, 186, 176, 194, 57, 6, 39, 16, 214, 223, 49, 201, 118, 41, 162, 142, 121, 161, 87, 207, 205, 89, 125, 46, 118, 105, 18, 58, 47, 26, 240, 202, 175, 48, 95, 42, 125, 15, 249, 87, 97, 51, 187, 101, 133, 238, 18, 32, 159, 226, 157, 243, 229, 254, 216, 26, 75, 20, 2, 157, 49, 198, 103, 209, 66, 140, 222, 100, 138, 57, 190, 2, 241, 42, 222, 212, 8, 200, 215, 245, 208, 188 } });
        }
    }
}
