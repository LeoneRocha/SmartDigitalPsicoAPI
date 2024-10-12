using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UpdateMedicalCalendar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "StartDateTime");

            migrationBuilder.RenameColumn(
                name: "PushedCalendar",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "IsPushedCalendar");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "RecurrenceEndDate");

            migrationBuilder.RenameColumn(
                name: "ColorCategory",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "ColorCategoryHexa");

            migrationBuilder.RenameColumn(
                name: "AllDay",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "IsAllDay");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "text",
                maxLength: 1000,
                nullable: false)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "datetime(6)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<int>(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecurrenceDays",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<int>(
                name: "RecurrenceType",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5451), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5478), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5483), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5484), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5485), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5488), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5503), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5508), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5509), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5511), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5513), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5519), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5521), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5526), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5528), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5529), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5531), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5533), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5534), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5535), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5536), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5538), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5541), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5543), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5373), new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5374), new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3800), new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3801), new byte[] { 152, 167, 23, 220, 236, 251, 14, 36, 118, 212, 182, 46, 149, 247, 63, 8, 31, 147, 144, 182, 13, 99, 65, 53, 107, 157, 245, 101, 152, 255, 110, 119, 2, 94, 88, 231, 46, 117, 79, 105, 36, 63, 248, 172, 204, 106, 37, 112, 169, 75, 136, 107, 227, 250, 185, 116, 251, 81, 48, 151, 24, 30, 161, 22 }, new byte[] { 243, 55, 23, 190, 113, 88, 155, 171, 92, 202, 5, 126, 137, 190, 61, 148, 34, 43, 209, 244, 152, 57, 252, 80, 226, 246, 111, 163, 169, 31, 16, 94, 178, 71, 173, 107, 251, 220, 170, 190, 45, 42, 189, 62, 47, 235, 40, 156, 89, 220, 184, 27, 140, 13, 32, 154, 162, 34, 6, 26, 31, 6, 163, 14, 221, 49, 74, 25, 229, 253, 3, 151, 233, 171, 249, 188, 230, 2, 186, 147, 162, 242, 98, 193, 221, 46, 23, 145, 114, 215, 76, 91, 242, 145, 156, 1, 78, 207, 162, 60, 63, 35, 243, 123, 227, 236, 131, 227, 102, 198, 125, 207, 75, 108, 88, 68, 34, 142, 215, 71, 28, 142, 3, 174, 249, 161, 231, 16 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4713), new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4714), new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4714), new byte[] { 8, 39, 44, 104, 88, 1, 63, 10, 251, 166, 205, 125, 64, 21, 252, 122, 126, 201, 62, 123, 179, 211, 170, 243, 135, 225, 116, 153, 140, 221, 131, 139, 159, 57, 2, 231, 111, 19, 86, 1, 186, 230, 138, 29, 205, 165, 237, 89, 49, 54, 177, 70, 14, 193, 86, 201, 139, 191, 215, 238, 16, 247, 39, 183 }, new byte[] { 81, 0, 142, 169, 190, 35, 105, 16, 247, 99, 129, 42, 186, 136, 26, 243, 46, 8, 167, 188, 201, 10, 0, 163, 243, 160, 138, 48, 3, 50, 132, 95, 251, 217, 180, 28, 173, 142, 120, 118, 163, 145, 93, 19, 25, 32, 123, 73, 77, 224, 175, 216, 128, 185, 228, 187, 179, 170, 237, 20, 57, 22, 52, 101, 29, 18, 169, 59, 84, 113, 137, 248, 157, 216, 20, 36, 156, 81, 88, 204, 154, 91, 110, 72, 123, 75, 62, 176, 196, 17, 165, 98, 14, 201, 253, 202, 250, 223, 94, 182, 217, 225, 198, 158, 99, 226, 120, 51, 182, 165, 50, 43, 42, 98, 229, 244, 53, 255, 43, 175, 246, 188, 159, 157, 93, 245, 72, 108 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropColumn(
                name: "EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropColumn(
                name: "RecurrenceCount",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropColumn(
                name: "RecurrenceDays",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropColumn(
                name: "RecurrenceType",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "RecurrenceEndDate",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "IsPushedCalendar",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "PushedCalendar");

            migrationBuilder.RenameColumn(
                name: "IsAllDay",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "AllDay");

            migrationBuilder.RenameColumn(
                name: "ColorCategoryHexa",
                schema: "dbo",
                table: "MedicalCalendar",
                newName: "ColorCategory");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(6918), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(6921), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(6921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8217), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8218), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8217) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8219), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8220), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8221), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8222), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8223), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8224), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8225), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8227), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8227), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8228), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8229), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8230), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8231), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8232), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8233), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8233) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8234), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8235), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8236), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8237), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8240), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8240) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8241), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8242), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8242) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8243), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8244), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8244) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8245), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8247), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8248), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8247) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8249), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8249) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8251), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8251), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8252), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8254), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8255) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8256), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8256) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8258), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8259), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8260), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8262), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8262), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8263), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8264), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8265), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8266), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8266) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8267), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8268), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8268) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8269), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8270), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8270) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8271), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8272), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8271) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8273), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8274), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8275), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8275), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8275) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8277), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8277), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8277) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8278), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8279), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8279) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8280), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8281), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8282), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8283), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8282) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8314), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8314) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8316), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8317), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8318), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 688, DateTimeKind.Utc).AddTicks(3282), new DateTime(2024, 10, 3, 1, 14, 0, 688, DateTimeKind.Utc).AddTicks(3284), new DateTime(2024, 10, 3, 1, 14, 0, 688, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 669, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(4681), new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(4682), new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(4682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 676, DateTimeKind.Utc).AddTicks(9159));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 679, DateTimeKind.Utc).AddTicks(9126), new DateTime(2024, 10, 3, 1, 14, 0, 679, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 10, 3, 1, 14, 0, 679, DateTimeKind.Utc).AddTicks(9127) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1582));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1583));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1584));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2211));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(2213));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(6186), new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(6187), new DateTime(2024, 10, 3, 1, 14, 0, 682, DateTimeKind.Utc).AddTicks(6188), new byte[] { 126, 132, 155, 77, 186, 233, 128, 239, 172, 199, 246, 117, 12, 81, 172, 144, 50, 7, 246, 204, 146, 235, 137, 199, 206, 21, 75, 236, 198, 229, 122, 44, 193, 193, 123, 99, 76, 3, 100, 185, 46, 117, 178, 149, 187, 230, 232, 140, 152, 128, 37, 237, 149, 251, 99, 104, 23, 46, 105, 239, 94, 112, 166, 220 }, new byte[] { 52, 183, 64, 132, 247, 140, 57, 248, 3, 251, 86, 161, 121, 21, 36, 197, 77, 55, 18, 157, 1, 212, 102, 158, 214, 247, 23, 176, 191, 163, 77, 92, 116, 63, 78, 119, 131, 228, 56, 85, 15, 237, 139, 219, 96, 13, 197, 146, 73, 116, 65, 28, 136, 118, 224, 246, 42, 193, 71, 103, 242, 132, 46, 2, 179, 61, 49, 244, 100, 233, 213, 127, 76, 36, 172, 246, 187, 175, 245, 121, 80, 82, 35, 41, 198, 149, 16, 150, 41, 72, 144, 165, 122, 69, 90, 180, 148, 4, 42, 138, 250, 142, 255, 179, 78, 252, 210, 106, 203, 144, 145, 115, 27, 241, 205, 11, 210, 139, 56, 107, 28, 36, 24, 29, 82, 118, 207, 216 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 3, 1, 14, 0, 685, DateTimeKind.Utc).AddTicks(735), new DateTime(2024, 10, 3, 1, 14, 0, 685, DateTimeKind.Utc).AddTicks(737), new DateTime(2024, 10, 3, 1, 14, 0, 685, DateTimeKind.Utc).AddTicks(737), new byte[] { 124, 137, 184, 75, 149, 147, 24, 165, 238, 208, 92, 235, 115, 25, 181, 171, 196, 12, 31, 109, 135, 243, 32, 28, 31, 181, 116, 140, 18, 190, 170, 222, 184, 195, 210, 23, 24, 31, 16, 246, 164, 133, 0, 55, 251, 237, 151, 89, 187, 42, 244, 100, 158, 204, 221, 179, 33, 123, 244, 174, 147, 55, 141, 159 }, new byte[] { 92, 70, 196, 130, 236, 5, 156, 100, 56, 219, 133, 34, 25, 215, 13, 52, 237, 57, 143, 151, 249, 51, 165, 242, 0, 96, 81, 232, 195, 108, 215, 80, 227, 97, 192, 105, 97, 124, 182, 187, 76, 147, 177, 68, 225, 150, 61, 245, 93, 245, 54, 148, 214, 104, 8, 184, 33, 249, 111, 194, 133, 246, 164, 103, 33, 76, 137, 154, 10, 152, 153, 19, 205, 59, 231, 130, 26, 170, 174, 16, 73, 27, 232, 209, 149, 71, 155, 63, 60, 183, 165, 202, 96, 12, 31, 191, 170, 193, 206, 98, 137, 164, 242, 207, 160, 94, 42, 250, 189, 202, 161, 96, 171, 14, 61, 254, 18, 57, 209, 226, 222, 187, 121, 178, 167, 2, 71, 32 } });
        }
    }
}
