using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UpdateReccurenceDays : Migration
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
                oldClrType: typeof(byte),
                oldType: "tinyint unsigned",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5870), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7309), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7314), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7317), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7327), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7328), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7332), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7333), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7334), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7336), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7339), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7340), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7341), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7342), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7343), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7344), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7353), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7357), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7361), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7363), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7370), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7371), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7372), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7373), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7374), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7375), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7376), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7377), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7379), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(17), new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(26), new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(11), new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(14), new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5663), new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3056), new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3057), new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3057), new byte[] { 69, 160, 89, 71, 45, 232, 92, 185, 21, 25, 131, 253, 159, 56, 199, 219, 50, 214, 50, 19, 123, 7, 92, 195, 23, 248, 250, 221, 162, 39, 111, 169, 33, 36, 73, 120, 169, 103, 152, 54, 143, 234, 180, 45, 132, 134, 219, 183, 94, 96, 174, 29, 87, 2, 26, 248, 192, 20, 134, 72, 139, 70, 177, 16 }, new byte[] { 16, 80, 83, 252, 135, 72, 31, 250, 206, 182, 152, 127, 61, 233, 74, 7, 20, 212, 252, 64, 41, 56, 226, 75, 89, 126, 192, 178, 117, 113, 170, 227, 191, 176, 39, 167, 126, 224, 194, 76, 38, 210, 3, 199, 86, 216, 133, 178, 212, 165, 126, 113, 249, 176, 242, 226, 6, 115, 16, 185, 206, 107, 186, 150, 25, 185, 62, 47, 219, 150, 96, 91, 186, 254, 206, 247, 153, 159, 147, 1, 227, 215, 101, 110, 18, 109, 137, 65, 202, 103, 77, 194, 85, 160, 126, 39, 160, 205, 71, 103, 7, 81, 66, 31, 39, 133, 78, 215, 26, 77, 141, 203, 128, 1, 178, 203, 7, 145, 198, 49, 243, 248, 238, 255, 21, 99, 66, 127 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4335), new byte[] { 78, 191, 84, 162, 17, 181, 170, 128, 49, 198, 216, 230, 2, 138, 202, 150, 241, 169, 19, 248, 78, 138, 125, 60, 213, 248, 125, 106, 163, 157, 248, 103, 114, 157, 128, 202, 160, 69, 175, 121, 52, 59, 177, 114, 222, 140, 152, 168, 195, 118, 152, 95, 216, 104, 173, 155, 100, 71, 183, 21, 12, 129, 181, 20 }, new byte[] { 31, 91, 97, 144, 157, 100, 35, 30, 108, 190, 13, 0, 108, 150, 61, 175, 220, 16, 194, 38, 85, 203, 131, 220, 192, 3, 206, 3, 151, 3, 148, 154, 166, 220, 71, 161, 23, 104, 139, 184, 189, 29, 90, 219, 88, 196, 13, 218, 170, 239, 143, 90, 33, 102, 218, 69, 232, 125, 155, 129, 90, 120, 13, 212, 180, 71, 237, 139, 217, 9, 151, 50, 156, 21, 173, 11, 11, 106, 192, 236, 58, 233, 126, 50, 35, 29, 150, 93, 89, 207, 31, 158, 178, 229, 196, 251, 83, 187, 37, 207, 248, 214, 177, 148, 213, 236, 161, 150, 33, 127, 32, 108, 100, 29, 114, 94, 120, 9, 174, 134, 184, 168, 7, 184, 71, 35, 85, 6 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "tinyint unsigned",
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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6101), new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 10, 19, 14, 58, 22, 247, DateTimeKind.Utc).AddTicks(6102) });

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
    }
}
