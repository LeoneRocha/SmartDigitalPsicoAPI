using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RenameContext3 : Migration
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
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8182), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8184), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8381), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8383), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8385), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8386), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8392), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8393), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8396), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8399), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8401), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8438) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8442) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8445), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8446), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8446) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8447), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8448), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8449), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8449) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8451), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8452), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8451) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8453) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8455) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8458), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8459), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8460), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8461), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8465), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8466), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8467), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8468), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8469), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8470), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8474), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8475), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8476), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8477), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8478), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8479), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8707), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9253), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9254), new DateTime(2024, 9, 28, 4, 45, 31, 570, DateTimeKind.Utc).AddTicks(9254), new byte[] { 194, 241, 54, 112, 95, 142, 135, 13, 217, 151, 161, 111, 21, 123, 35, 175, 166, 168, 110, 237, 177, 115, 217, 43, 76, 241, 153, 110, 177, 127, 27, 15, 111, 216, 149, 138, 14, 141, 93, 161, 206, 39, 66, 12, 212, 146, 222, 239, 175, 129, 163, 71, 221, 223, 195, 39, 72, 44, 36, 120, 145, 188, 76, 157 }, new byte[] { 198, 96, 252, 48, 134, 194, 48, 61, 4, 97, 246, 111, 26, 142, 15, 197, 176, 253, 94, 164, 228, 111, 114, 44, 4, 202, 79, 255, 90, 175, 131, 218, 7, 14, 146, 238, 239, 254, 105, 255, 111, 140, 118, 176, 95, 124, 154, 115, 147, 215, 101, 75, 157, 185, 139, 136, 138, 31, 178, 15, 115, 247, 224, 17, 253, 35, 187, 105, 157, 135, 254, 115, 249, 224, 90, 189, 68, 131, 134, 177, 255, 250, 201, 68, 152, 54, 186, 78, 88, 180, 240, 106, 157, 127, 194, 232, 193, 234, 82, 76, 76, 159, 93, 124, 73, 128, 252, 241, 151, 1, 240, 133, 146, 169, 58, 246, 33, 153, 16, 223, 126, 204, 22, 89, 165, 53, 24, 110 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 9, 28, 4, 45, 31, 573, DateTimeKind.Utc).AddTicks(494), new byte[] { 36, 188, 236, 53, 69, 205, 202, 159, 31, 91, 142, 60, 71, 19, 110, 48, 252, 210, 26, 217, 135, 189, 128, 232, 180, 124, 157, 253, 208, 65, 26, 251, 9, 223, 203, 126, 217, 44, 129, 97, 26, 248, 52, 21, 228, 107, 151, 254, 111, 15, 39, 131, 196, 198, 137, 220, 150, 91, 137, 53, 242, 217, 104, 9 }, new byte[] { 138, 46, 140, 57, 64, 209, 181, 236, 165, 91, 113, 6, 172, 79, 184, 171, 199, 61, 204, 4, 82, 205, 21, 200, 239, 188, 12, 38, 115, 176, 232, 224, 65, 141, 32, 181, 237, 180, 38, 52, 180, 68, 79, 19, 236, 65, 189, 80, 78, 98, 122, 82, 145, 6, 230, 42, 189, 92, 118, 214, 225, 10, 81, 10, 4, 4, 158, 214, 25, 85, 148, 119, 121, 36, 229, 122, 197, 193, 119, 89, 45, 174, 79, 59, 206, 97, 120, 107, 57, 237, 241, 68, 120, 2, 103, 179, 251, 35, 21, 150, 250, 109, 217, 81, 205, 250, 35, 42, 201, 137, 213, 24, 221, 179, 89, 107, 61, 202, 132, 54, 73, 178, 252, 118, 241, 118, 240, 45 } });
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
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7751), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7750) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7950), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7952), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7953), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7956), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7957), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7958), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7959), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7960), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7965), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7966), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7967), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7968), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7969), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7970), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7972), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7973), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7974), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7975), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7976), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7977), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7978), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7980), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7981), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7983), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7984), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7986), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7987), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7988), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7992), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7993), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7994), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7995), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7996), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7997), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(7998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8001), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8002), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8003), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8005), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8006), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8007), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8008), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8010), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8012), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8013), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8013) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8014), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8015), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8016) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8018) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8020), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8020) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8321), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8322) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8542), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8543), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8861), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8862), new DateTime(2024, 9, 28, 4, 26, 1, 901, DateTimeKind.Utc).AddTicks(8862), new byte[] { 194, 213, 10, 63, 88, 105, 23, 80, 174, 2, 56, 185, 48, 66, 16, 161, 233, 122, 178, 52, 66, 176, 103, 79, 244, 216, 242, 229, 218, 171, 185, 237, 59, 155, 124, 20, 232, 166, 147, 142, 146, 154, 98, 184, 234, 99, 35, 198, 150, 234, 20, 140, 100, 243, 215, 127, 218, 185, 207, 95, 51, 142, 10, 149 }, new byte[] { 79, 163, 62, 141, 252, 84, 220, 132, 246, 208, 207, 45, 181, 208, 130, 12, 105, 44, 90, 21, 167, 96, 170, 175, 93, 187, 7, 131, 68, 97, 149, 92, 238, 213, 68, 54, 15, 90, 217, 63, 41, 116, 58, 97, 10, 96, 76, 217, 89, 163, 163, 77, 145, 198, 210, 161, 26, 129, 149, 97, 52, 122, 199, 242, 213, 234, 85, 130, 138, 118, 184, 155, 50, 46, 178, 136, 221, 25, 45, 201, 140, 3, 36, 86, 167, 211, 99, 236, 183, 87, 249, 179, 31, 25, 170, 195, 73, 115, 58, 233, 108, 163, 87, 91, 224, 80, 134, 1, 255, 52, 132, 130, 39, 6, 94, 51, 110, 58, 78, 89, 161, 160, 242, 130, 181, 90, 225, 39 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9886), new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 9, 28, 4, 26, 1, 903, DateTimeKind.Utc).AddTicks(9887), new byte[] { 188, 235, 74, 253, 5, 123, 129, 214, 124, 154, 211, 189, 181, 242, 227, 224, 250, 125, 33, 3, 72, 152, 94, 33, 49, 129, 52, 227, 29, 31, 207, 228, 158, 135, 26, 10, 72, 120, 56, 115, 116, 167, 72, 255, 192, 224, 189, 76, 125, 143, 84, 42, 82, 209, 147, 14, 155, 236, 156, 13, 154, 213, 215, 141 }, new byte[] { 254, 228, 216, 89, 139, 168, 155, 75, 183, 47, 104, 183, 118, 96, 111, 14, 105, 29, 76, 195, 97, 212, 54, 29, 13, 216, 143, 126, 15, 70, 186, 4, 46, 223, 253, 210, 246, 73, 145, 49, 13, 6, 64, 54, 73, 222, 241, 76, 144, 226, 41, 71, 33, 188, 217, 2, 248, 68, 152, 4, 13, 64, 220, 171, 19, 70, 137, 255, 28, 207, 139, 163, 187, 106, 22, 137, 227, 92, 127, 134, 90, 68, 55, 16, 109, 248, 158, 65, 4, 17, 213, 189, 151, 218, 86, 161, 81, 70, 122, 53, 51, 63, 157, 177, 80, 218, 61, 173, 24, 224, 219, 116, 250, 144, 38, 137, 30, 53, 228, 11, 191, 245, 105, 213, 134, 180, 27, 48 } });
        }
    }
}
