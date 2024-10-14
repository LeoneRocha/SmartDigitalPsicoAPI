using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1321), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1324), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(1323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2538), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2540), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2542), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2543), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2544), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2545), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2546), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2548), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2554), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2555), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2556), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2557), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2558), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2559), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2560), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2561), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2563), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2564), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2565), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2566), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2567), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2568), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2569), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2570), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2569) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2574), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2575), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2576), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2578), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2579), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2584), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2585), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2586), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2585) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2587) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2589) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2591) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2593), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2594), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2595), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2595) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2596) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2600) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2601), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2602) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2603), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2604), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2604) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2606), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2605) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2607) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609), new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(2609) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 10, 14, 2, 39, 9, 529, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 512, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7258), new DateTime(2024, 10, 14, 2, 39, 9, 518, DateTimeKind.Utc).AddTicks(7258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 519, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(741), new DateTime(2024, 10, 14, 2, 39, 9, 522, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6091), new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6092), new DateTime(2024, 10, 14, 2, 39, 9, 524, DateTimeKind.Utc).AddTicks(6093), new byte[] { 140, 78, 186, 17, 87, 169, 164, 128, 96, 132, 8, 81, 143, 78, 99, 29, 214, 212, 227, 109, 54, 20, 237, 166, 213, 101, 246, 104, 7, 116, 62, 135, 181, 44, 26, 54, 61, 138, 75, 160, 28, 142, 215, 227, 63, 101, 120, 17, 138, 49, 39, 219, 252, 237, 51, 169, 65, 19, 86, 186, 73, 168, 239, 221 }, new byte[] { 53, 239, 48, 211, 19, 66, 100, 90, 116, 82, 172, 148, 247, 35, 253, 249, 66, 69, 5, 15, 169, 75, 74, 212, 196, 111, 66, 86, 174, 194, 250, 140, 235, 255, 181, 81, 120, 196, 52, 164, 182, 121, 159, 217, 56, 70, 204, 6, 247, 200, 20, 124, 75, 159, 24, 71, 138, 115, 245, 184, 170, 67, 72, 206, 232, 161, 197, 166, 144, 80, 67, 68, 89, 247, 104, 59, 24, 237, 119, 250, 43, 28, 78, 146, 237, 233, 51, 231, 164, 100, 51, 52, 136, 124, 50, 35, 192, 216, 209, 74, 133, 220, 255, 10, 125, 180, 150, 109, 179, 139, 231, 75, 244, 161, 30, 74, 78, 52, 214, 83, 121, 216, 93, 1, 238, 253, 156, 60 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7100), new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7101), new DateTime(2024, 10, 14, 2, 39, 9, 526, DateTimeKind.Utc).AddTicks(7101), new byte[] { 231, 80, 112, 249, 54, 192, 158, 187, 121, 161, 121, 109, 52, 155, 89, 48, 140, 1, 240, 188, 59, 196, 87, 208, 33, 57, 114, 33, 198, 231, 19, 28, 127, 66, 198, 7, 52, 86, 244, 252, 164, 114, 59, 103, 6, 58, 244, 26, 80, 158, 142, 30, 120, 138, 20, 96, 82, 219, 21, 198, 230, 245, 139, 250 }, new byte[] { 65, 95, 185, 184, 183, 27, 55, 59, 103, 236, 50, 60, 179, 53, 76, 182, 53, 109, 173, 67, 4, 25, 164, 224, 189, 3, 6, 90, 79, 77, 185, 85, 174, 195, 212, 230, 93, 92, 32, 141, 47, 34, 81, 88, 224, 132, 180, 225, 131, 236, 221, 18, 6, 15, 40, 15, 143, 185, 227, 186, 99, 117, 83, 249, 62, 8, 41, 201, 129, 21, 95, 117, 215, 147, 239, 201, 151, 224, 98, 61, 145, 103, 104, 193, 159, 208, 118, 151, 36, 91, 166, 241, 158, 78, 5, 172, 4, 168, 133, 92, 235, 31, 41, 97, 34, 72, 227, 244, 86, 46, 253, 240, 234, 253, 100, 221, 105, 205, 0, 120, 52, 165, 11, 100, 236, 44, 209, 59 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "int",
                nullable: true,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 10, 14, 2, 24, 41, 300, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1152), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1154), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1155), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1156), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1156) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1157), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1158), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1159), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1160), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1159) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1186), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1188) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1197), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1199) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1201) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1206), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1217), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1219), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1220), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1222), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1223), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1228), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1229), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1231), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1235), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1240) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1113), new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1114), new DateTime(2024, 10, 14, 2, 24, 41, 319, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 301, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7554), new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 10, 14, 2, 24, 41, 307, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 308, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1376), new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1377), new DateTime(2024, 10, 14, 2, 24, 41, 311, DateTimeKind.Utc).AddTicks(1377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(3474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(4076));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7894), new DateTime(2024, 10, 14, 2, 24, 41, 313, DateTimeKind.Utc).AddTicks(7894), new byte[] { 21, 115, 207, 168, 175, 161, 61, 251, 227, 66, 1, 249, 141, 52, 141, 29, 232, 204, 133, 126, 174, 52, 221, 87, 253, 38, 232, 240, 57, 237, 153, 163, 67, 80, 5, 202, 18, 140, 13, 164, 135, 45, 184, 206, 236, 60, 254, 190, 211, 213, 91, 243, 96, 228, 20, 50, 77, 231, 144, 89, 218, 81, 240, 130 }, new byte[] { 115, 147, 106, 58, 127, 138, 215, 94, 249, 169, 108, 78, 170, 246, 47, 23, 116, 193, 42, 115, 220, 255, 107, 13, 165, 178, 247, 52, 215, 109, 192, 249, 35, 166, 151, 147, 220, 77, 182, 67, 226, 166, 97, 108, 138, 150, 203, 174, 173, 157, 231, 12, 40, 171, 69, 250, 250, 153, 20, 198, 61, 121, 118, 225, 107, 160, 16, 193, 196, 169, 255, 237, 214, 151, 41, 96, 79, 185, 67, 9, 204, 118, 201, 214, 146, 198, 13, 89, 152, 108, 68, 7, 249, 54, 117, 119, 50, 181, 32, 154, 221, 133, 211, 68, 232, 21, 111, 48, 186, 162, 182, 150, 78, 12, 232, 214, 103, 243, 194, 139, 203, 210, 4, 171, 104, 93, 25, 166 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9168), new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 10, 14, 2, 24, 41, 315, DateTimeKind.Utc).AddTicks(9170), new byte[] { 3, 160, 60, 185, 224, 145, 176, 211, 14, 118, 251, 92, 185, 240, 9, 18, 253, 95, 56, 174, 125, 128, 37, 226, 221, 120, 94, 1, 73, 46, 39, 77, 149, 200, 246, 108, 46, 110, 45, 172, 219, 206, 39, 91, 226, 68, 16, 62, 176, 10, 98, 72, 54, 46, 15, 236, 168, 200, 230, 243, 246, 31, 67, 83 }, new byte[] { 245, 52, 94, 44, 185, 154, 1, 150, 77, 206, 151, 233, 6, 61, 58, 12, 110, 142, 159, 132, 253, 165, 14, 13, 119, 106, 177, 9, 9, 251, 4, 247, 41, 14, 187, 57, 211, 169, 113, 52, 70, 148, 123, 143, 153, 243, 6, 44, 169, 214, 19, 205, 132, 140, 57, 188, 209, 122, 156, 67, 8, 133, 120, 211, 167, 97, 255, 184, 211, 255, 125, 92, 138, 111, 143, 229, 112, 14, 174, 236, 77, 178, 199, 121, 143, 171, 58, 145, 0, 221, 213, 180, 25, 90, 235, 209, 1, 92, 192, 91, 144, 246, 82, 114, 219, 65, 120, 250, 3, 99, 175, 214, 229, 97, 140, 165, 107, 16, 245, 252, 227, 38, 232, 159, 127, 188, 16, 186 } });
        }
    }
}
