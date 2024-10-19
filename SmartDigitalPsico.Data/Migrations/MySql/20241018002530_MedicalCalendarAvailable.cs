using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalCalendarAvailable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReasonCancellation",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "text",
                maxLength: 1000,
                nullable: true)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(4191), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(4193), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(4193) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5470), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5471), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5473), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5474), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5475), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5477), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5478), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5483), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5484), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5485), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5488), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5503), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5509), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5509), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5511), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5513), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5515), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5519), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5521), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5523), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5524), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5528), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5529), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5531), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5531) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5533), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5534), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5535), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5536), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5536), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5538), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5538) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5540) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5541), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 313, DateTimeKind.Utc).AddTicks(2381), new DateTime(2024, 10, 18, 0, 25, 30, 313, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 10, 18, 0, 25, 30, 313, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 294, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 301, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 304, DateTimeKind.Utc).AddTicks(9498), new DateTime(2024, 10, 18, 0, 25, 30, 304, DateTimeKind.Utc).AddTicks(9499), new DateTime(2024, 10, 18, 0, 25, 30, 304, DateTimeKind.Utc).AddTicks(9500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(3168));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(7245), new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(7246), new DateTime(2024, 10, 18, 0, 25, 30, 307, DateTimeKind.Utc).AddTicks(7247), new byte[] { 156, 152, 176, 145, 46, 102, 45, 248, 2, 247, 113, 161, 241, 61, 28, 129, 80, 41, 54, 85, 72, 24, 242, 56, 49, 25, 77, 77, 149, 28, 29, 216, 87, 127, 204, 161, 24, 170, 213, 223, 98, 247, 99, 120, 184, 147, 132, 81, 199, 201, 61, 208, 195, 127, 68, 217, 100, 140, 255, 1, 69, 114, 87, 53 }, new byte[] { 10, 191, 69, 96, 10, 66, 29, 227, 201, 69, 29, 187, 191, 85, 130, 154, 7, 56, 58, 209, 50, 41, 52, 227, 68, 65, 202, 111, 159, 176, 121, 42, 169, 87, 101, 193, 166, 160, 244, 57, 233, 19, 154, 120, 134, 207, 100, 170, 113, 235, 22, 157, 242, 46, 163, 204, 99, 117, 153, 151, 8, 156, 83, 19, 63, 237, 170, 181, 229, 245, 47, 14, 195, 166, 81, 241, 230, 4, 51, 41, 161, 123, 86, 149, 2, 231, 157, 111, 5, 216, 244, 54, 245, 87, 45, 120, 115, 60, 120, 15, 52, 159, 197, 75, 204, 25, 86, 120, 117, 11, 212, 46, 28, 29, 80, 20, 2, 218, 42, 96, 42, 25, 222, 234, 13, 46, 66, 253 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 18, 0, 25, 30, 309, DateTimeKind.Utc).AddTicks(8612), new DateTime(2024, 10, 18, 0, 25, 30, 309, DateTimeKind.Utc).AddTicks(8613), new DateTime(2024, 10, 18, 0, 25, 30, 309, DateTimeKind.Utc).AddTicks(8614), new byte[] { 141, 63, 8, 156, 230, 103, 204, 165, 51, 98, 89, 19, 21, 74, 180, 38, 173, 246, 253, 233, 191, 230, 219, 188, 116, 95, 72, 47, 37, 216, 81, 146, 70, 122, 15, 78, 157, 31, 4, 69, 108, 4, 58, 125, 220, 208, 170, 6, 200, 108, 63, 53, 214, 160, 235, 28, 196, 114, 38, 170, 52, 249, 139, 93 }, new byte[] { 246, 162, 111, 136, 13, 131, 70, 216, 206, 36, 126, 120, 74, 104, 70, 94, 143, 254, 163, 111, 149, 62, 127, 39, 158, 204, 75, 95, 179, 137, 79, 109, 170, 52, 244, 5, 88, 111, 50, 246, 143, 40, 35, 111, 249, 142, 189, 152, 129, 164, 254, 9, 226, 246, 167, 171, 221, 64, 81, 15, 33, 109, 94, 150, 34, 30, 28, 22, 192, 161, 111, 153, 237, 115, 80, 190, 1, 84, 219, 139, 223, 176, 31, 222, 62, 66, 191, 132, 55, 151, 203, 68, 30, 93, 109, 135, 255, 115, 35, 16, 198, 81, 51, 162, 74, 228, 54, 61, 71, 98, 87, 108, 138, 254, 157, 72, 211, 121, 231, 106, 128, 141, 225, 77, 185, 214, 158, 231 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReasonCancellation",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9805), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9809), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9811), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9813), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9814), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9818), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9821), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9822), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9826), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9829), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9832), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9833), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9835), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9836), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9841), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9842), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9843), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9844), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9849), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9851), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9852), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9854), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9862), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9893), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 737, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 737, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7901), new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3935), new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3936), new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3936), new byte[] { 44, 243, 62, 250, 227, 174, 20, 78, 132, 120, 21, 188, 232, 73, 124, 88, 2, 152, 172, 83, 18, 7, 65, 145, 46, 8, 168, 47, 10, 156, 124, 156, 21, 200, 231, 132, 90, 82, 251, 11, 16, 140, 170, 182, 25, 93, 172, 214, 242, 31, 111, 65, 69, 63, 55, 10, 174, 132, 140, 137, 44, 22, 89, 159 }, new byte[] { 20, 194, 29, 93, 115, 118, 0, 58, 159, 97, 94, 210, 23, 0, 154, 113, 8, 166, 156, 132, 221, 2, 64, 39, 92, 28, 175, 201, 194, 215, 137, 169, 161, 177, 224, 224, 50, 106, 205, 74, 173, 81, 7, 149, 217, 149, 14, 156, 191, 216, 187, 175, 86, 110, 242, 70, 65, 170, 202, 185, 254, 30, 123, 149, 160, 252, 234, 33, 164, 145, 251, 249, 214, 185, 174, 237, 62, 219, 171, 193, 213, 50, 233, 85, 147, 250, 154, 165, 223, 219, 2, 223, 80, 5, 171, 191, 52, 82, 167, 54, 184, 96, 26, 116, 1, 146, 187, 214, 252, 213, 103, 208, 14, 24, 237, 67, 97, 83, 220, 224, 243, 24, 242, 50, 176, 161, 39, 122 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4951), new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4952), new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4952), new byte[] { 104, 186, 218, 255, 170, 105, 158, 149, 134, 50, 210, 67, 173, 18, 150, 175, 45, 119, 13, 129, 247, 31, 222, 245, 83, 154, 74, 232, 155, 206, 146, 99, 229, 203, 115, 142, 244, 102, 92, 112, 56, 232, 42, 131, 127, 135, 26, 51, 107, 109, 254, 113, 146, 210, 67, 20, 21, 89, 92, 219, 186, 247, 205, 180 }, new byte[] { 52, 233, 172, 248, 112, 42, 10, 212, 236, 154, 95, 133, 10, 139, 66, 162, 142, 134, 189, 118, 241, 69, 61, 238, 242, 197, 160, 250, 211, 105, 33, 109, 9, 148, 121, 132, 143, 30, 174, 17, 200, 111, 72, 242, 192, 27, 189, 198, 194, 53, 52, 31, 124, 63, 224, 190, 153, 57, 233, 77, 74, 91, 74, 73, 64, 198, 52, 122, 119, 199, 118, 37, 77, 164, 92, 245, 183, 239, 46, 133, 201, 225, 153, 119, 106, 196, 7, 215, 18, 115, 163, 53, 109, 177, 147, 43, 207, 60, 78, 115, 86, 26, 229, 172, 77, 178, 211, 71, 181, 202, 18, 170, 99, 215, 226, 132, 178, 188, 12, 47, 206, 33, 207, 93, 252, 113, 75, 173 } });
        }
    }
}
