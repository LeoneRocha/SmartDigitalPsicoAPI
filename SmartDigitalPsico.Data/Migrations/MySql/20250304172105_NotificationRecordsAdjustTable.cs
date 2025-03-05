using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecordsAdjustTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "UrlRootManager" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2913), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2916), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(2916), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8215), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8216), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8218), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8219), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8222), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8223), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8224), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8225), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8226), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8227), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8228), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8229), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8230), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8231), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8232), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8233), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8234), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8235), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8236), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8237), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8238), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8239), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8240), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8241), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8244), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8245), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8250), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8251), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8252), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8255), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8256), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8257), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8257) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8258), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8259), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8260), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8261), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8262), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8263), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8264), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8265), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8266), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8267), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8272) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8273), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8274), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8275), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8276), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8276) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8277), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8278), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8279), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8280), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8283) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8287) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8288), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8289), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8290), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8291), new DateTime(2025, 3, 4, 17, 21, 5, 173, DateTimeKind.Utc).AddTicks(8291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8800), new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8801), new DateTime(2025, 3, 4, 17, 21, 5, 174, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 175, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 175, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9460));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9462));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 177, DateTimeKind.Utc).AddTicks(9465));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1425), new DateTime(2025, 3, 4, 17, 21, 5, 184, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5908), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5910), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5912), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5913), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5915), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5916), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5921), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5944), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5945), new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 191, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9595), new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9596), new DateTime(2025, 3, 4, 17, 21, 5, 194, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8946));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 197, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4699));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9718), new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9719), new DateTime(2025, 3, 4, 17, 21, 5, 198, DateTimeKind.Utc).AddTicks(9719), new byte[] { 31, 217, 93, 145, 252, 55, 227, 212, 66, 220, 214, 194, 251, 248, 57, 247, 130, 83, 64, 86, 242, 221, 110, 125, 125, 210, 88, 153, 202, 43, 121, 129, 248, 37, 126, 56, 20, 238, 161, 186, 148, 14, 233, 225, 246, 46, 40, 148, 9, 1, 38, 99, 88, 111, 188, 145, 223, 210, 232, 73, 199, 157, 28, 204 }, new byte[] { 37, 202, 62, 221, 88, 236, 15, 31, 77, 204, 41, 231, 242, 122, 165, 98, 136, 74, 74, 173, 159, 192, 118, 108, 141, 143, 105, 68, 27, 77, 187, 11, 182, 220, 244, 209, 136, 36, 183, 88, 240, 207, 195, 153, 112, 217, 201, 68, 67, 125, 227, 111, 255, 60, 48, 253, 114, 46, 107, 40, 51, 134, 84, 191, 5, 43, 108, 70, 9, 148, 118, 20, 35, 55, 143, 0, 138, 187, 30, 223, 3, 168, 118, 252, 238, 55, 149, 68, 72, 56, 196, 102, 205, 0, 83, 197, 142, 94, 143, 116, 72, 225, 243, 245, 181, 202, 19, 125, 223, 204, 28, 207, 42, 174, 130, 75, 158, 29, 211, 15, 33, 20, 44, 198, 22, 5, 214, 207 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(659), new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(660), new DateTime(2025, 3, 4, 17, 21, 5, 201, DateTimeKind.Utc).AddTicks(660), new byte[] { 216, 242, 12, 204, 194, 121, 138, 74, 66, 201, 190, 2, 166, 244, 104, 171, 111, 49, 104, 154, 164, 110, 158, 232, 158, 109, 126, 157, 99, 53, 138, 82, 249, 47, 39, 8, 173, 219, 154, 47, 105, 7, 134, 34, 81, 228, 238, 182, 106, 0, 179, 166, 225, 65, 166, 136, 85, 103, 153, 234, 95, 158, 241, 219 }, new byte[] { 132, 39, 84, 104, 248, 141, 218, 27, 67, 122, 50, 220, 217, 65, 6, 233, 202, 184, 0, 209, 130, 207, 86, 235, 142, 215, 170, 48, 243, 89, 228, 165, 95, 206, 27, 123, 110, 233, 185, 69, 86, 14, 30, 109, 13, 190, 60, 228, 208, 80, 229, 252, 246, 83, 222, 13, 58, 251, 30, 155, 247, 158, 10, 12, 148, 27, 153, 222, 44, 243, 208, 17, 143, 81, 112, 71, 7, 111, 118, 83, 169, 34, 163, 135, 240, 159, 73, 184, 253, 254, 42, 219, 41, 182, 246, 130, 37, 151, 162, 189, 164, 3, 26, 142, 168, 85, 37, 95, 174, 218, 100, 23, 11, 153, 85, 75, 202, 218, 88, 30, 5, 15, 57, 48, 75, 117, 81, 194 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "UrlRootManager" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8765), new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8768), new DateTime(2025, 3, 3, 2, 37, 38, 446, DateTimeKind.Utc).AddTicks(8767), "https://smartdigitalpsicoui-staging.azurewebsites.net/" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3978), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3982), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3983), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3984), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3985), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3986), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3987), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3995), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4000), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4002), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4003), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4009), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4011), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4013) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4015), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4016), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4017), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4018), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4019), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4020), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4022), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4023), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4023) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4024), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4025), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4025) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4026), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4027), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4031), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4032), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4033), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4034), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4035), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4036), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4035) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4037), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4038), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4037) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4040), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4041), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4042), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4044), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4044) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4046), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4046) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 3, 2, 37, 38, 447, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5136), new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5138), new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(5137) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 448, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 452, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9534), new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9535), new DateTime(2025, 3, 3, 2, 37, 38, 458, DateTimeKind.Utc).AddTicks(9536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(6997), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7000), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7002), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7003), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7005), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7006), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7012), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7013), new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(7012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 466, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1715), new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1716), new DateTime(2025, 3, 3, 2, 37, 38, 470, DateTimeKind.Utc).AddTicks(1716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3083));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9187));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9191));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 2, 37, 38, 473, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4308), new DateTime(2025, 3, 3, 2, 37, 38, 474, DateTimeKind.Utc).AddTicks(4309), new byte[] { 201, 177, 3, 181, 61, 126, 159, 177, 151, 37, 63, 16, 177, 176, 32, 141, 166, 136, 46, 217, 152, 62, 222, 40, 220, 50, 178, 230, 212, 136, 51, 254, 177, 151, 243, 149, 16, 158, 197, 212, 97, 238, 222, 92, 201, 197, 46, 252, 114, 147, 14, 6, 117, 174, 150, 58, 166, 73, 172, 242, 24, 248, 50, 137 }, new byte[] { 142, 10, 186, 83, 210, 212, 135, 86, 64, 131, 222, 3, 163, 61, 59, 65, 198, 192, 228, 169, 184, 77, 114, 235, 219, 8, 5, 15, 109, 62, 12, 96, 26, 224, 99, 85, 179, 153, 213, 103, 68, 220, 83, 88, 77, 87, 51, 157, 193, 190, 56, 154, 22, 64, 95, 95, 253, 64, 179, 212, 80, 90, 121, 60, 56, 94, 11, 176, 122, 11, 170, 57, 113, 159, 66, 163, 65, 83, 238, 27, 233, 158, 156, 143, 73, 181, 127, 93, 245, 196, 112, 94, 87, 52, 242, 165, 87, 113, 193, 46, 35, 151, 220, 83, 91, 13, 167, 199, 178, 34, 249, 166, 252, 255, 24, 71, 24, 136, 109, 254, 208, 19, 237, 111, 221, 135, 1, 37 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6379), new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6380), new DateTime(2025, 3, 3, 2, 37, 38, 476, DateTimeKind.Utc).AddTicks(6380), new byte[] { 7, 184, 208, 237, 231, 156, 227, 29, 104, 143, 15, 201, 211, 254, 223, 150, 116, 8, 245, 30, 69, 45, 133, 198, 251, 69, 171, 5, 249, 231, 102, 156, 107, 161, 17, 149, 203, 209, 222, 63, 100, 230, 142, 50, 64, 252, 61, 210, 200, 231, 192, 182, 172, 178, 4, 202, 161, 42, 152, 36, 90, 219, 251, 126 }, new byte[] { 246, 168, 236, 41, 179, 238, 137, 163, 10, 187, 235, 217, 183, 57, 203, 185, 158, 83, 17, 69, 104, 64, 25, 185, 212, 152, 45, 69, 175, 204, 143, 244, 33, 128, 178, 88, 124, 201, 76, 210, 211, 204, 30, 149, 164, 227, 222, 44, 19, 243, 56, 172, 85, 169, 111, 112, 231, 83, 64, 221, 93, 146, 249, 28, 152, 167, 168, 242, 99, 61, 205, 127, 86, 190, 144, 158, 96, 193, 155, 45, 30, 200, 221, 65, 99, 209, 147, 174, 241, 237, 90, 206, 86, 14, 178, 1, 96, 219, 70, 138, 170, 187, 176, 151, 136, 231, 93, 91, 145, 247, 142, 192, 254, 51, 90, 138, 11, 127, 250, 60, 156, 111, 108, 52, 75, 169, 36, 76 } });

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
