using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9143), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9362), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9387), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9394), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9419), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9422), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9425), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9664), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9665), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(214), new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(214), new byte[] { 43, 90, 72, 136, 185, 4, 179, 148, 9, 192, 146, 179, 122, 240, 200, 72, 217, 247, 240, 16, 87, 178, 46, 60, 242, 245, 233, 146, 252, 136, 95, 36, 80, 219, 213, 92, 28, 88, 198, 1, 11, 129, 84, 231, 241, 10, 8, 153, 171, 231, 236, 118, 112, 131, 172, 246, 232, 202, 126, 217, 162, 7, 199, 108 }, new byte[] { 217, 90, 136, 49, 219, 211, 212, 83, 205, 51, 112, 160, 187, 132, 144, 76, 131, 1, 11, 0, 193, 202, 193, 26, 63, 161, 169, 141, 107, 227, 85, 242, 89, 2, 102, 64, 160, 205, 211, 118, 245, 118, 228, 103, 134, 46, 125, 118, 208, 117, 234, 66, 188, 165, 73, 67, 28, 169, 127, 233, 8, 222, 149, 104, 129, 187, 189, 44, 30, 114, 59, 240, 9, 82, 180, 239, 147, 236, 112, 60, 171, 176, 224, 128, 86, 193, 96, 135, 35, 207, 179, 204, 47, 71, 143, 136, 21, 108, 201, 175, 171, 212, 160, 110, 0, 161, 175, 141, 188, 208, 112, 79, 2, 47, 111, 102, 158, 212, 56, 20, 50, 221, 123, 103, 242, 121, 61, 151 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2171), new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2172), new byte[] { 41, 112, 42, 185, 7, 76, 41, 48, 238, 32, 240, 115, 197, 186, 3, 39, 26, 64, 151, 73, 218, 200, 56, 116, 145, 94, 111, 208, 221, 219, 8, 80, 129, 14, 109, 56, 157, 114, 156, 172, 80, 171, 206, 130, 213, 91, 24, 91, 94, 24, 143, 111, 248, 154, 148, 54, 163, 243, 96, 27, 83, 227, 118, 224 }, new byte[] { 106, 84, 134, 119, 185, 195, 53, 222, 224, 7, 51, 167, 162, 98, 143, 109, 144, 186, 67, 63, 77, 248, 9, 136, 220, 248, 18, 23, 30, 238, 168, 212, 80, 152, 40, 100, 141, 84, 27, 130, 190, 156, 61, 179, 57, 5, 33, 147, 57, 154, 245, 2, 40, 128, 0, 119, 237, 118, 31, 22, 11, 99, 93, 82, 163, 134, 211, 124, 172, 137, 135, 67, 66, 105, 217, 136, 205, 110, 108, 143, 220, 19, 52, 124, 31, 139, 92, 64, 144, 197, 112, 140, 235, 148, 239, 14, 77, 47, 216, 15, 132, 208, 40, 123, 12, 110, 70, 210, 149, 36, 185, 153, 75, 29, 94, 96, 229, 217, 244, 199, 248, 208, 49, 103, 237, 129, 5, 176 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1182), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1184), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1185) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1188), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1190), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1191) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1193), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1194), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1195), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1194) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1196) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1198) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1199), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1200), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1200) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1201), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1202), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1202) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1203), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1204), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1203) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1208), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1209), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1210), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1211), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1211) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1212), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1213), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1214), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1215), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1219), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1220), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1221), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1222), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1223), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1224), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1228), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1229), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1230), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1231), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1230) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1232), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1233), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1235), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1237), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1238), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1239), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1240), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1239) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1243) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1245), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1246), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1247), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1246) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1248), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1249), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1248) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1250) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1252) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1630));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2072), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2073), new DateTime(2024, 9, 26, 1, 3, 55, 953, DateTimeKind.Utc).AddTicks(2073), new byte[] { 164, 245, 215, 24, 1, 109, 33, 79, 246, 83, 63, 196, 249, 35, 155, 252, 192, 111, 96, 121, 24, 7, 148, 56, 29, 110, 246, 234, 186, 153, 54, 244, 9, 133, 124, 139, 132, 126, 52, 99, 83, 33, 194, 56, 152, 107, 252, 113, 83, 47, 105, 102, 146, 86, 204, 180, 228, 172, 55, 64, 62, 152, 156, 227 }, new byte[] { 22, 242, 254, 149, 229, 53, 136, 34, 47, 37, 153, 203, 151, 95, 192, 22, 6, 19, 121, 235, 240, 231, 71, 159, 122, 173, 53, 184, 161, 213, 16, 8, 8, 15, 95, 78, 231, 164, 186, 184, 216, 181, 96, 64, 221, 157, 224, 143, 8, 182, 122, 204, 138, 32, 106, 134, 237, 3, 110, 244, 148, 8, 217, 145, 172, 79, 20, 45, 91, 207, 207, 184, 29, 97, 0, 96, 0, 33, 240, 113, 236, 27, 252, 74, 72, 60, 93, 165, 120, 88, 255, 208, 191, 202, 48, 95, 147, 222, 252, 31, 85, 233, 42, 16, 247, 240, 247, 252, 44, 214, 38, 151, 228, 255, 49, 54, 49, 113, 91, 152, 251, 97, 66, 64, 139, 199, 252, 39 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3427), new DateTime(2024, 9, 26, 1, 3, 55, 955, DateTimeKind.Utc).AddTicks(3427), new byte[] { 148, 207, 224, 4, 83, 206, 219, 43, 9, 112, 228, 134, 121, 28, 41, 25, 171, 241, 91, 84, 90, 189, 5, 228, 75, 69, 25, 198, 26, 146, 188, 174, 165, 20, 18, 59, 76, 246, 36, 86, 68, 188, 83, 160, 142, 8, 184, 8, 186, 228, 14, 193, 220, 19, 167, 52, 141, 248, 152, 238, 211, 18, 181, 113 }, new byte[] { 46, 207, 133, 200, 121, 171, 210, 194, 162, 74, 3, 213, 6, 121, 46, 158, 245, 18, 105, 78, 126, 146, 7, 183, 38, 97, 225, 152, 124, 26, 16, 184, 32, 93, 182, 134, 129, 173, 12, 137, 30, 206, 223, 162, 77, 58, 98, 74, 138, 51, 170, 158, 159, 11, 80, 254, 245, 219, 209, 176, 227, 221, 167, 197, 198, 41, 12, 64, 75, 181, 248, 171, 219, 139, 217, 212, 146, 124, 158, 206, 138, 63, 55, 255, 128, 92, 191, 87, 109, 92, 192, 162, 62, 80, 157, 142, 184, 63, 135, 212, 131, 24, 133, 55, 16, 54, 104, 82, 62, 237, 154, 5, 167, 239, 90, 170, 250, 193, 213, 242, 162, 104, 47, 140, 23, 122, 131, 7 } });
        }
    }
}
