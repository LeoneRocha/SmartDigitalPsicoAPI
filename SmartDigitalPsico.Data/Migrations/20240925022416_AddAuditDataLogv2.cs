using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv2 : Migration
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
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8143), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8353), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8355), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8357), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8358), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8359), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8361), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8362), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8363), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8364), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8368), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8369), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8372), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8373), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8374), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8375), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8376), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8378), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8385), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8386), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8392), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8393), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8396), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8399), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8401), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8411), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8412), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8413), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8414), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8416), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8417), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8418), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8419), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8421), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8422), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8423), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8424), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8425), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8426), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8646), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9238), new byte[] { 202, 60, 15, 105, 181, 91, 134, 70, 79, 49, 249, 150, 1, 113, 89, 26, 196, 15, 254, 152, 88, 213, 209, 199, 60, 59, 28, 190, 149, 16, 232, 17, 115, 26, 178, 107, 220, 185, 27, 8, 227, 243, 97, 22, 78, 66, 95, 188, 9, 250, 251, 174, 201, 162, 114, 180, 217, 32, 9, 182, 78, 221, 99, 201 }, new byte[] { 164, 67, 163, 162, 226, 139, 1, 9, 81, 87, 253, 115, 221, 129, 249, 132, 109, 213, 73, 129, 25, 224, 42, 35, 88, 156, 51, 75, 33, 31, 246, 205, 146, 110, 156, 146, 230, 150, 1, 224, 138, 62, 43, 35, 250, 200, 18, 172, 33, 203, 23, 208, 99, 42, 24, 165, 177, 121, 255, 25, 23, 45, 26, 110, 230, 111, 176, 136, 215, 88, 69, 55, 243, 70, 19, 64, 236, 155, 202, 213, 105, 167, 234, 146, 91, 2, 41, 220, 154, 3, 72, 24, 186, 107, 208, 225, 221, 14, 221, 121, 132, 42, 250, 203, 125, 216, 59, 182, 138, 24, 167, 253, 162, 116, 180, 221, 62, 241, 126, 17, 69, 45, 73, 45, 132, 55, 32, 127 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(726), new byte[] { 181, 219, 196, 6, 106, 129, 91, 189, 20, 197, 178, 199, 77, 35, 216, 33, 34, 246, 234, 85, 108, 217, 25, 5, 250, 59, 181, 205, 188, 126, 32, 206, 31, 168, 10, 69, 213, 208, 132, 188, 219, 70, 153, 153, 85, 77, 60, 150, 83, 2, 0, 76, 86, 234, 176, 151, 12, 139, 19, 62, 147, 171, 155, 176 }, new byte[] { 215, 98, 101, 170, 208, 158, 207, 16, 213, 83, 93, 107, 195, 190, 82, 117, 12, 81, 64, 16, 42, 155, 118, 51, 87, 135, 6, 196, 173, 199, 207, 71, 219, 154, 161, 182, 196, 223, 94, 216, 248, 97, 44, 116, 154, 162, 88, 207, 143, 169, 104, 127, 182, 173, 117, 40, 65, 144, 94, 179, 211, 5, 116, 70, 243, 30, 105, 59, 46, 241, 164, 13, 151, 17, 164, 49, 101, 99, 119, 164, 39, 219, 102, 130, 165, 113, 152, 127, 49, 123, 116, 188, 155, 76, 149, 30, 196, 62, 50, 175, 41, 252, 48, 208, 225, 140, 200, 240, 12, 215, 64, 63, 27, 218, 205, 66, 197, 220, 149, 33, 189, 139, 152, 81, 230, 28, 208, 187 } });

            migrationBuilder.CreateIndex(
                name: "Idx_AuditDataEntityLog_TableName_Operation_Inc_",
                schema: "dbo",
                table: "AuditDataEntityLog",
                columns: new[] { "TableName", "Operation" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_AuditDataEntityLog_TableName_Operation_Inc_",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1454), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1457), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1688), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1689), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1694), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1699), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1705), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1707), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1711), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1713), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1714), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1715), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1720), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1723), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1726), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1727), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1728), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1731), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1735), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1737), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1739), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1745), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1746), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1747), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1748), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1749), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1756), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1758), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1759), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1991), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2597), new byte[] { 87, 75, 213, 69, 196, 68, 155, 65, 100, 123, 34, 87, 95, 109, 85, 246, 95, 11, 16, 193, 136, 14, 218, 182, 25, 164, 66, 108, 22, 42, 143, 17, 251, 84, 151, 227, 47, 51, 203, 22, 184, 205, 189, 145, 32, 33, 136, 221, 224, 100, 120, 13, 147, 216, 72, 150, 126, 136, 49, 137, 139, 120, 230, 129 }, new byte[] { 115, 166, 165, 82, 12, 192, 15, 77, 222, 250, 74, 116, 144, 39, 117, 160, 123, 157, 0, 111, 254, 181, 140, 251, 151, 26, 64, 31, 204, 145, 218, 136, 255, 203, 96, 164, 150, 9, 152, 239, 35, 78, 118, 24, 243, 152, 35, 86, 228, 219, 62, 222, 27, 219, 86, 175, 123, 143, 58, 102, 109, 238, 188, 36, 39, 158, 46, 9, 78, 246, 59, 252, 73, 187, 192, 132, 211, 186, 252, 78, 245, 185, 165, 55, 70, 60, 35, 153, 218, 201, 222, 59, 235, 26, 40, 115, 159, 61, 164, 90, 178, 149, 146, 155, 59, 166, 230, 95, 216, 182, 81, 16, 135, 248, 34, 28, 30, 78, 58, 1, 185, 131, 255, 2, 83, 179, 91, 181 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3914), new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3916), new byte[] { 142, 213, 105, 194, 230, 130, 97, 47, 142, 107, 238, 115, 190, 237, 63, 223, 125, 84, 207, 244, 182, 151, 58, 62, 90, 96, 128, 40, 31, 203, 92, 101, 47, 181, 152, 61, 47, 162, 226, 184, 170, 40, 230, 143, 200, 160, 220, 33, 46, 240, 78, 67, 106, 195, 117, 45, 119, 16, 6, 89, 88, 207, 117, 220 }, new byte[] { 195, 116, 110, 73, 203, 181, 114, 141, 165, 137, 85, 203, 254, 55, 153, 60, 170, 161, 8, 48, 250, 236, 100, 154, 32, 94, 61, 138, 228, 190, 102, 10, 77, 53, 73, 39, 8, 245, 102, 101, 195, 150, 109, 219, 187, 140, 193, 71, 236, 146, 42, 31, 14, 46, 186, 97, 232, 94, 48, 2, 2, 164, 252, 108, 212, 159, 71, 135, 180, 109, 29, 117, 82, 81, 237, 167, 95, 226, 131, 84, 185, 169, 150, 34, 204, 104, 186, 154, 28, 45, 242, 63, 179, 163, 218, 203, 176, 118, 144, 114, 171, 236, 235, 193, 37, 30, 61, 19, 169, 228, 185, 73, 164, 193, 91, 194, 35, 216, 255, 252, 35, 225, 6, 205, 123, 61, 61, 232 } });
        }
    }
}
