using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecordsAdjust : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 670, DateTimeKind.Utc).AddTicks(5432), new DateTime(2025, 3, 4, 17, 33, 26, 670, DateTimeKind.Utc).AddTicks(5435), new DateTime(2025, 3, 4, 17, 33, 26, 670, DateTimeKind.Utc).AddTicks(5434) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(647), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(648), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(648) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(650), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(651), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(652), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(653), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(653) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(654), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(655), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(656), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(657), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(658), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(659) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(661), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(662), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(663), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(664), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(664), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(688), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(689), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(690), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(691), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(690) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(692), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(693), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(694), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(694), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(696), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(696), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(697), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(698), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(699), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(700), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(701), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(702), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(704), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(706), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(705) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(707), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(707), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(709), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(709), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(710), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(711), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(712), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(713), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(712) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(714), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(715), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(716), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(716), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(718), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(718), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(719), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(720), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(721), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(722), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(723), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(724), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(723) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(725), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(726), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(725) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(727), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(727), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(729), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(730), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(731), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(732), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(733), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(734), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(735), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(736), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(737), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(738), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(738), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(739), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(740), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(741), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 3, 4, 17, 33, 26, 671, DateTimeKind.Utc).AddTicks(742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 672, DateTimeKind.Utc).AddTicks(1302), new DateTime(2025, 3, 4, 17, 33, 26, 672, DateTimeKind.Utc).AddTicks(1304), new DateTime(2025, 3, 4, 17, 33, 26, 672, DateTimeKind.Utc).AddTicks(1303) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 672, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 672, DateTimeKind.Utc).AddTicks(3043));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3004));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3006));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3007));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3011));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 675, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 681, DateTimeKind.Utc).AddTicks(4818), new DateTime(2025, 3, 4, 17, 33, 26, 681, DateTimeKind.Utc).AddTicks(4819), new DateTime(2025, 3, 4, 17, 33, 26, 681, DateTimeKind.Utc).AddTicks(4820) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8988), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8989), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8992), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8993), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8995), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8996), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8998), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8999), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(8998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9000), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9001), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9003), new DateTime(2025, 3, 4, 17, 33, 26, 688, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 689, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 689, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 689, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 692, DateTimeKind.Utc).AddTicks(3178), new DateTime(2025, 3, 4, 17, 33, 26, 692, DateTimeKind.Utc).AddTicks(3179), new DateTime(2025, 3, 4, 17, 33, 26, 692, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2196));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2201));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(2203));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 33, 26, 695, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 696, DateTimeKind.Utc).AddTicks(3008), new DateTime(2025, 3, 4, 17, 33, 26, 696, DateTimeKind.Utc).AddTicks(3009), new DateTime(2025, 3, 4, 17, 33, 26, 696, DateTimeKind.Utc).AddTicks(3009), new byte[] { 234, 48, 171, 129, 64, 146, 195, 112, 255, 50, 180, 104, 122, 97, 93, 169, 119, 136, 226, 128, 94, 203, 38, 98, 182, 87, 156, 103, 238, 168, 173, 247, 3, 126, 132, 118, 199, 21, 45, 254, 177, 242, 13, 155, 19, 12, 205, 9, 137, 67, 215, 200, 153, 31, 83, 50, 200, 237, 140, 97, 151, 202, 137, 53 }, new byte[] { 6, 10, 154, 63, 75, 22, 8, 114, 189, 70, 214, 72, 204, 190, 57, 108, 151, 55, 177, 95, 211, 248, 212, 88, 94, 131, 32, 179, 223, 66, 167, 211, 7, 96, 57, 182, 68, 14, 48, 208, 20, 212, 175, 159, 27, 246, 39, 204, 196, 49, 165, 66, 22, 207, 127, 140, 249, 103, 239, 191, 134, 169, 124, 27, 10, 129, 87, 140, 210, 115, 77, 58, 233, 41, 117, 74, 80, 37, 159, 47, 117, 188, 229, 196, 169, 168, 244, 15, 173, 7, 165, 190, 150, 255, 73, 76, 6, 53, 159, 143, 175, 17, 196, 63, 50, 22, 61, 84, 136, 188, 3, 99, 103, 163, 120, 46, 241, 164, 58, 227, 228, 137, 79, 76, 124, 184, 118, 158 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 33, 26, 698, DateTimeKind.Utc).AddTicks(3844), new DateTime(2025, 3, 4, 17, 33, 26, 698, DateTimeKind.Utc).AddTicks(3845), new DateTime(2025, 3, 4, 17, 33, 26, 698, DateTimeKind.Utc).AddTicks(3845), new byte[] { 101, 87, 86, 94, 206, 157, 224, 206, 177, 205, 141, 178, 124, 114, 220, 44, 155, 129, 40, 106, 246, 206, 3, 138, 228, 123, 244, 138, 101, 73, 53, 126, 246, 134, 16, 218, 129, 11, 200, 20, 62, 162, 191, 60, 18, 38, 114, 219, 57, 241, 235, 222, 251, 207, 122, 77, 31, 46, 115, 226, 116, 204, 67, 80 }, new byte[] { 122, 238, 141, 222, 219, 85, 116, 71, 7, 115, 183, 23, 250, 53, 29, 111, 191, 208, 151, 42, 158, 112, 44, 201, 36, 174, 223, 10, 128, 17, 51, 36, 113, 74, 36, 2, 113, 213, 228, 150, 255, 99, 169, 179, 101, 7, 74, 222, 199, 17, 255, 173, 89, 61, 241, 31, 237, 144, 100, 36, 172, 17, 221, 111, 99, 158, 163, 240, 57, 6, 54, 159, 31, 192, 232, 211, 191, 135, 151, 123, 132, 200, 117, 9, 139, 146, 245, 153, 71, 2, 131, 178, 131, 19, 181, 20, 130, 80, 230, 37, 151, 190, 92, 191, 171, 179, 124, 124, 255, 247, 242, 59, 105, 38, 54, 134, 227, 1, 34, 115, 115, 10, 217, 72, 181, 216, 143, 248 } });
        }
    }
}
