using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class PatientIntervalTimeMinutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "PatientIntervalTimeMinutes",
                schema: "dbo",
                table: "Medical",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(8077), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(8080), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(8080) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9350), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9351), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9351) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9355), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9358), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9362), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9362) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9364) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9373), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9375) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9387), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9391), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9391), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9394), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9396) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9398), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9398), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9398) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9416), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9418) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9419), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 10, 19, 14, 58, 22, 240, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 259, DateTimeKind.Utc).AddTicks(780), new DateTime(2024, 10, 19, 14, 58, 22, 259, DateTimeKind.Utc).AddTicks(782), new DateTime(2024, 10, 19, 14, 58, 22, 259, DateTimeKind.Utc).AddTicks(781) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 241, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 241, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PatientIntervalTimeMinutes" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6101), new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6102), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 248, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 248, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 248, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 251, DateTimeKind.Utc).AddTicks(513), new DateTime(2024, 10, 19, 14, 58, 22, 251, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 10, 19, 14, 58, 22, 251, DateTimeKind.Utc).AddTicks(515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4510));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(4512));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(9022), new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(9023), new DateTime(2024, 10, 19, 14, 58, 22, 253, DateTimeKind.Utc).AddTicks(9023), new byte[] { 223, 108, 158, 17, 174, 23, 245, 180, 225, 8, 55, 193, 27, 140, 102, 207, 119, 222, 243, 182, 153, 160, 147, 111, 119, 100, 149, 48, 50, 119, 249, 32, 143, 49, 116, 38, 223, 241, 26, 14, 43, 104, 111, 130, 178, 183, 89, 203, 197, 160, 217, 172, 11, 25, 204, 248, 17, 132, 156, 135, 91, 96, 14, 57 }, new byte[] { 236, 43, 42, 146, 149, 135, 4, 68, 135, 189, 84, 239, 74, 167, 102, 122, 107, 209, 210, 134, 185, 231, 200, 66, 235, 20, 100, 24, 91, 247, 50, 211, 168, 243, 56, 76, 57, 24, 69, 117, 15, 140, 5, 195, 71, 132, 10, 176, 109, 239, 224, 100, 17, 245, 141, 203, 215, 141, 49, 117, 74, 25, 44, 227, 96, 129, 231, 177, 81, 77, 124, 245, 40, 100, 240, 56, 51, 90, 176, 57, 33, 249, 24, 163, 183, 193, 234, 161, 233, 222, 248, 17, 20, 194, 201, 40, 219, 255, 216, 105, 90, 76, 165, 146, 148, 192, 9, 108, 208, 162, 195, 175, 231, 123, 60, 133, 246, 212, 135, 128, 14, 3, 170, 168, 211, 209, 208, 130 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 255, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 19, 14, 58, 22, 255, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 19, 14, 58, 22, 255, DateTimeKind.Utc).AddTicks(9816), new byte[] { 148, 113, 164, 117, 243, 196, 122, 65, 110, 199, 221, 87, 122, 20, 84, 221, 52, 38, 26, 10, 153, 83, 255, 137, 163, 181, 130, 166, 21, 126, 75, 117, 148, 66, 241, 229, 215, 21, 96, 81, 43, 5, 212, 153, 9, 91, 134, 171, 235, 192, 138, 84, 90, 2, 50, 43, 70, 100, 229, 0, 172, 165, 108, 56 }, new byte[] { 2, 125, 0, 174, 237, 150, 15, 206, 51, 140, 198, 161, 83, 15, 36, 43, 86, 15, 148, 32, 97, 127, 73, 139, 73, 79, 197, 153, 105, 92, 138, 6, 78, 2, 62, 78, 172, 46, 176, 111, 136, 112, 173, 223, 43, 219, 93, 167, 242, 153, 139, 122, 135, 65, 180, 206, 202, 5, 160, 54, 6, 244, 131, 96, 106, 31, 64, 95, 236, 54, 63, 101, 216, 249, 210, 114, 3, 190, 181, 180, 136, 118, 235, 144, 9, 141, 92, 205, 185, 197, 205, 107, 153, 129, 192, 175, 102, 242, 21, 12, 149, 214, 81, 120, 226, 93, 24, 135, 42, 129, 20, 184, 183, 110, 27, 249, 39, 204, 194, 62, 170, 246, 166, 166, 136, 242, 209, 158 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatientIntervalTimeMinutes",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3012), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3016), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4443), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4444), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4449), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4451), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4452), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4456), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4460), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4461), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4462), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4464), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4470), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4471), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4472), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4473), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4477), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4480), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4481), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4482), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4483), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4484), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4485), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4486), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4493), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1791), new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9317), new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7535), new byte[] { 217, 12, 184, 55, 110, 43, 8, 91, 126, 27, 46, 248, 188, 1, 28, 250, 66, 36, 58, 219, 38, 0, 29, 164, 198, 82, 168, 255, 125, 37, 53, 131, 251, 196, 29, 207, 222, 254, 252, 157, 111, 242, 63, 11, 10, 243, 159, 204, 176, 243, 6, 112, 159, 186, 9, 243, 175, 211, 205, 255, 233, 177, 2, 93 }, new byte[] { 106, 86, 98, 241, 153, 146, 22, 121, 255, 19, 125, 95, 157, 77, 120, 6, 184, 176, 183, 255, 101, 228, 166, 203, 196, 168, 56, 115, 245, 241, 25, 236, 25, 87, 3, 148, 200, 216, 55, 26, 231, 32, 170, 197, 98, 39, 234, 129, 40, 143, 159, 39, 213, 251, 2, 57, 229, 249, 233, 210, 108, 147, 113, 222, 140, 61, 198, 81, 168, 217, 165, 247, 223, 62, 152, 133, 232, 87, 20, 95, 116, 136, 182, 80, 239, 133, 214, 134, 71, 158, 73, 130, 212, 211, 217, 78, 50, 116, 81, 96, 180, 130, 119, 217, 201, 196, 193, 141, 194, 105, 89, 177, 103, 97, 113, 66, 35, 204, 240, 40, 175, 127, 250, 135, 131, 205, 184, 102 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9428), new byte[] { 141, 214, 16, 116, 62, 80, 254, 254, 25, 178, 204, 92, 237, 216, 112, 98, 253, 112, 85, 226, 129, 225, 5, 35, 226, 199, 0, 173, 237, 68, 146, 11, 151, 236, 199, 152, 210, 53, 248, 237, 57, 179, 11, 50, 73, 190, 160, 191, 225, 125, 115, 162, 101, 119, 150, 83, 199, 7, 60, 242, 5, 245, 90, 224 }, new byte[] { 69, 242, 26, 18, 47, 103, 159, 89, 194, 80, 137, 168, 118, 24, 130, 67, 110, 110, 65, 56, 112, 225, 74, 242, 156, 6, 212, 115, 83, 82, 155, 29, 160, 217, 64, 127, 120, 204, 227, 205, 166, 121, 111, 117, 178, 113, 81, 168, 21, 105, 221, 172, 122, 248, 64, 241, 204, 57, 245, 235, 141, 43, 202, 220, 196, 175, 116, 98, 243, 144, 130, 168, 150, 147, 59, 52, 72, 88, 46, 180, 126, 238, 248, 185, 197, 83, 162, 109, 77, 178, 111, 119, 255, 241, 65, 236, 118, 199, 220, 225, 190, 1, 222, 143, 132, 5, 234, 189, 116, 85, 9, 4, 70, 62, 109, 143, 84, 86, 174, 39, 226, 135, 30, 53, 224, 31, 90, 150 } });
        }
    }
}
