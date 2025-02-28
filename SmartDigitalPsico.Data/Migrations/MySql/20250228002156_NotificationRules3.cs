using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRules3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "IntervalValue",
                schema: "dbo",
                table: "NotificationRules",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(851), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(860), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7133), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7134), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7136), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7139), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7145), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7146), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7146) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7148), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7149), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7150), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7157), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7158), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7159), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7167), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7168), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7172), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7209), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7211), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7212), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7213), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7217), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7218), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7221), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7222), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7225), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7226), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7227), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7228), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7233), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7234), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7235), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7236), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9328), new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9330), new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 4, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 4, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2811), new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2813), new byte[] { 53, 173, 17, 222, 137, 228, 156, 215, 220, 46, 7, 193, 250, 166, 146, 114, 98, 114, 250, 48, 140, 155, 216, 133, 151, 188, 87, 91, 155, 72, 75, 123, 244, 244, 241, 148, 35, 137, 53, 13, 174, 127, 116, 35, 120, 114, 3, 188, 252, 159, 254, 73, 124, 86, 128, 160, 209, 211, 223, 74, 108, 58, 47, 194 }, new byte[] { 190, 162, 234, 180, 25, 192, 168, 119, 57, 127, 168, 176, 120, 113, 53, 1, 131, 45, 235, 174, 141, 36, 209, 84, 96, 49, 101, 45, 190, 220, 71, 190, 159, 60, 159, 14, 42, 119, 120, 113, 126, 57, 70, 221, 153, 46, 114, 41, 157, 168, 222, 240, 175, 84, 158, 207, 117, 186, 17, 150, 107, 5, 49, 249, 216, 182, 94, 69, 93, 141, 64, 147, 3, 123, 227, 23, 122, 0, 230, 41, 145, 152, 14, 205, 122, 140, 96, 81, 243, 167, 180, 88, 64, 111, 3, 38, 89, 242, 72, 175, 150, 9, 119, 131, 133, 76, 148, 149, 154, 80, 77, 222, 49, 7, 160, 114, 17, 45, 170, 17, 191, 3, 13, 203, 210, 82, 201, 197 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3991), new byte[] { 154, 89, 59, 114, 120, 43, 41, 80, 220, 0, 136, 152, 46, 66, 136, 134, 113, 109, 150, 9, 57, 4, 64, 71, 20, 113, 24, 2, 95, 1, 220, 67, 139, 110, 171, 48, 231, 199, 218, 56, 158, 162, 172, 122, 227, 39, 28, 169, 35, 76, 39, 230, 197, 219, 34, 123, 1, 68, 211, 80, 137, 106, 243, 39 }, new byte[] { 177, 224, 32, 101, 86, 1, 200, 235, 175, 192, 114, 83, 230, 116, 26, 31, 237, 4, 45, 135, 130, 226, 234, 243, 190, 134, 184, 53, 103, 13, 243, 70, 30, 166, 221, 109, 4, 252, 129, 109, 133, 44, 243, 198, 24, 149, 82, 109, 150, 199, 133, 36, 225, 215, 140, 210, 57, 87, 83, 56, 131, 142, 33, 54, 196, 211, 224, 45, 196, 190, 250, 192, 227, 250, 172, 169, 253, 136, 162, 41, 48, 98, 83, 168, 214, 0, 151, 47, 120, 222, 84, 248, 62, 74, 80, 251, 24, 198, 87, 254, 215, 196, 69, 190, 226, 130, 47, 55, 82, 93, 110, 10, 186, 225, 96, 210, 98, 176, 237, 149, 99, 239, 75, 104, 177, 133, 65, 169 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRules_Medical_MedicalId",
                schema: "dbo",
                table: "NotificationRules",
                column: "MedicalId",
                principalSchema: "dbo",
                principalTable: "Medical",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRules_Medical_MedicalId",
                schema: "dbo",
                table: "NotificationRules");

            migrationBuilder.AlterColumn<int>(
                name: "IntervalValue",
                schema: "dbo",
                table: "NotificationRules",
                type: "int",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8956), new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8959), new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4312), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4313), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4315), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4317), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4319), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4327), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4330), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4331), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4333), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4337), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4338), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4339), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4342), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4346), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4351), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4382), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4383), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4384), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4385), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4386), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4387), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4391), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4392), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4393), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4394), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4395), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4396), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4400), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4402), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4403), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4404), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4405), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4407), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4409), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4410), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4411), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4412), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4413), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4414), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(123), new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(124), new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5081), new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5082), new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5082) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6362), new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6363), new byte[] { 159, 136, 85, 54, 178, 254, 92, 207, 29, 81, 93, 85, 39, 155, 149, 165, 177, 41, 116, 173, 186, 205, 177, 131, 190, 251, 83, 85, 197, 0, 4, 88, 90, 243, 172, 218, 61, 213, 235, 125, 192, 171, 23, 79, 176, 154, 129, 185, 29, 1, 129, 222, 201, 238, 33, 180, 134, 170, 247, 89, 157, 126, 193, 124 }, new byte[] { 164, 124, 197, 171, 16, 229, 64, 253, 199, 206, 212, 242, 11, 137, 119, 229, 159, 81, 92, 184, 102, 164, 32, 16, 221, 108, 134, 13, 55, 81, 34, 69, 189, 84, 210, 119, 15, 144, 6, 54, 158, 245, 192, 103, 154, 86, 149, 114, 31, 94, 127, 71, 109, 131, 29, 79, 223, 111, 222, 201, 28, 23, 231, 200, 110, 3, 227, 119, 123, 238, 151, 165, 11, 154, 71, 37, 247, 187, 198, 28, 249, 81, 48, 125, 78, 6, 61, 188, 3, 241, 158, 101, 213, 196, 130, 132, 48, 221, 106, 110, 92, 245, 131, 73, 120, 125, 125, 81, 157, 4, 47, 85, 94, 33, 245, 104, 175, 39, 173, 96, 9, 182, 14, 80, 119, 46, 196, 34 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8254), new byte[] { 202, 10, 20, 218, 215, 107, 171, 36, 144, 165, 20, 230, 166, 72, 248, 142, 222, 20, 121, 111, 21, 109, 103, 45, 94, 161, 115, 206, 25, 235, 14, 36, 113, 196, 12, 39, 235, 61, 114, 166, 132, 27, 6, 39, 20, 94, 79, 8, 212, 250, 41, 159, 96, 245, 185, 246, 138, 222, 72, 133, 69, 123, 156, 149 }, new byte[] { 168, 152, 214, 146, 65, 85, 223, 10, 6, 248, 74, 79, 212, 16, 56, 106, 63, 230, 168, 119, 146, 158, 35, 250, 248, 17, 207, 145, 122, 66, 44, 115, 194, 172, 115, 92, 196, 130, 159, 242, 150, 187, 67, 132, 185, 138, 123, 225, 148, 207, 18, 99, 94, 66, 181, 69, 95, 196, 32, 154, 25, 120, 32, 143, 101, 156, 55, 217, 179, 208, 32, 86, 239, 74, 241, 12, 102, 55, 172, 190, 108, 132, 163, 211, 19, 60, 49, 167, 250, 4, 56, 59, 114, 99, 15, 119, 211, 207, 6, 46, 13, 32, 229, 184, 9, 211, 182, 157, 226, 204, 184, 229, 164, 174, 88, 124, 35, 163, 189, 12, 61, 185, 160, 70, 156, 163, 123, 178 } });
        }
    }
}
