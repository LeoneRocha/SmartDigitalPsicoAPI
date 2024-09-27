using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRecordPatientStorage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TableStorageRowKey",
                schema: "dbo",
                table: "PatientRecord",
                type: "varchar(40)",
                maxLength: 40,
                nullable: true)
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7556), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7561), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7562), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7563), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7564), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7565), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7566), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7570), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7571), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7572), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7573), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7574), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7575), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7579), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7582), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7583), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7584), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7585), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7586), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7591), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7594), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7595), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7597), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7598), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7601), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7602), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7603), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7606), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7609), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7610), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7611), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8049), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8050), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8403), new byte[] { 152, 50, 41, 84, 26, 37, 212, 92, 190, 139, 234, 239, 208, 182, 64, 204, 167, 228, 197, 58, 205, 13, 209, 200, 198, 94, 161, 86, 65, 197, 69, 171, 48, 217, 140, 98, 50, 105, 127, 137, 140, 53, 2, 82, 96, 225, 252, 211, 144, 11, 35, 81, 141, 32, 188, 0, 205, 111, 210, 248, 0, 78, 51, 209 }, new byte[] { 233, 32, 7, 29, 98, 119, 3, 42, 86, 226, 68, 186, 215, 204, 222, 189, 241, 162, 236, 112, 141, 100, 86, 190, 188, 167, 162, 45, 150, 205, 183, 134, 77, 30, 211, 137, 160, 177, 134, 186, 82, 149, 89, 214, 150, 243, 106, 151, 239, 244, 105, 51, 25, 126, 55, 90, 248, 121, 25, 21, 16, 229, 107, 119, 110, 45, 71, 22, 145, 252, 218, 52, 239, 183, 188, 63, 179, 169, 98, 245, 176, 160, 3, 232, 158, 123, 252, 93, 219, 213, 167, 42, 33, 195, 99, 16, 45, 221, 248, 135, 122, 130, 134, 76, 33, 38, 134, 10, 114, 50, 213, 124, 88, 147, 84, 57, 17, 95, 134, 98, 146, 177, 243, 44, 255, 254, 152, 250 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9867), new byte[] { 232, 218, 129, 65, 70, 129, 54, 240, 235, 166, 47, 18, 100, 60, 230, 219, 217, 108, 30, 115, 121, 148, 191, 199, 209, 121, 24, 232, 202, 201, 45, 29, 11, 26, 250, 76, 37, 140, 89, 85, 143, 221, 31, 129, 33, 126, 166, 72, 41, 157, 205, 11, 186, 130, 168, 38, 14, 132, 122, 209, 127, 225, 135, 178 }, new byte[] { 235, 69, 150, 153, 209, 63, 84, 112, 47, 101, 174, 88, 208, 216, 138, 166, 247, 181, 146, 103, 178, 158, 71, 17, 132, 58, 128, 186, 202, 215, 63, 120, 123, 100, 149, 68, 84, 41, 74, 30, 34, 84, 21, 254, 44, 167, 250, 54, 237, 142, 45, 109, 241, 191, 87, 44, 170, 55, 0, 59, 73, 113, 149, 225, 174, 194, 122, 92, 50, 157, 204, 246, 187, 78, 181, 16, 98, 250, 156, 148, 170, 236, 132, 211, 111, 57, 18, 223, 104, 44, 227, 104, 161, 6, 125, 228, 54, 143, 234, 75, 161, 13, 76, 109, 196, 59, 130, 87, 180, 123, 205, 190, 244, 56, 158, 140, 0, 92, 35, 241, 131, 221, 34, 83, 221, 120, 16, 113 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TableStorageRowKey",
                schema: "dbo",
                table: "PatientRecord");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5438), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5445), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5655), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5656), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5658), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5659), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5660), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5661), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5662), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5663), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5664), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5665), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5666), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5666), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5669), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5670), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5671), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5672), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5671) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5673), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5674), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5673) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5675), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5676), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5675) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5677), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5678), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5679), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5681), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5682), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5683), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5684), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5684), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5684) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5687), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5688), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5689), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5690), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5691), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5693), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5694), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5695), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5695) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5696), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5697), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5698), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5700), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5733), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5734), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5735), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5736) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5737), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5738), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5739), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5740), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5741), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5742), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5743), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5743), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5743) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5745), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5745), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5745) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5746), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5747), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5748), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5749), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5750), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5751), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5750) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5753), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5752) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5754), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5754), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5755), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5756), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5756) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5757), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5758) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6190), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6191), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6191) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6387));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 9, 1, 14, 57, 35, 555, DateTimeKind.Utc).AddTicks(6500), new byte[] { 240, 188, 120, 55, 121, 24, 13, 33, 23, 70, 62, 66, 78, 250, 207, 5, 194, 27, 150, 246, 69, 237, 110, 85, 135, 62, 27, 94, 76, 141, 101, 141, 186, 164, 31, 97, 108, 100, 235, 99, 68, 82, 6, 232, 237, 110, 19, 125, 89, 1, 91, 172, 243, 36, 86, 47, 190, 203, 153, 21, 254, 83, 24, 42 }, new byte[] { 208, 218, 106, 177, 21, 87, 124, 189, 30, 65, 178, 33, 125, 167, 168, 148, 228, 169, 241, 91, 5, 96, 32, 68, 52, 88, 134, 220, 80, 213, 9, 16, 141, 7, 39, 152, 10, 225, 151, 239, 41, 247, 140, 61, 52, 73, 221, 164, 164, 200, 97, 4, 52, 20, 31, 224, 56, 67, 254, 96, 28, 225, 86, 25, 123, 209, 147, 114, 18, 195, 71, 144, 6, 160, 232, 146, 111, 10, 190, 172, 248, 35, 200, 60, 151, 15, 201, 203, 112, 195, 13, 103, 193, 114, 137, 10, 244, 234, 238, 187, 33, 133, 12, 88, 114, 32, 148, 49, 61, 149, 2, 215, 103, 7, 61, 214, 179, 190, 153, 116, 246, 69, 107, 81, 83, 67, 110, 49 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 57, 35, 557, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 9, 1, 14, 57, 35, 557, DateTimeKind.Utc).AddTicks(7308), new DateTime(2024, 9, 1, 14, 57, 35, 557, DateTimeKind.Utc).AddTicks(7309), new byte[] { 167, 196, 19, 253, 106, 137, 147, 13, 68, 99, 222, 81, 189, 138, 143, 49, 49, 191, 8, 63, 10, 69, 32, 168, 63, 6, 153, 115, 237, 56, 124, 142, 184, 140, 247, 72, 211, 109, 63, 198, 198, 88, 128, 239, 167, 37, 79, 95, 38, 56, 247, 109, 170, 254, 112, 169, 240, 121, 185, 174, 6, 85, 179, 126 }, new byte[] { 160, 30, 255, 134, 185, 19, 142, 211, 60, 17, 169, 186, 90, 121, 79, 130, 89, 55, 190, 203, 162, 74, 159, 88, 101, 160, 23, 9, 253, 105, 163, 185, 82, 26, 162, 159, 175, 74, 145, 243, 166, 188, 119, 124, 177, 78, 78, 188, 106, 143, 102, 60, 255, 41, 72, 152, 46, 1, 193, 120, 40, 225, 142, 90, 3, 169, 249, 143, 164, 157, 88, 85, 81, 143, 27, 204, 159, 247, 242, 16, 244, 0, 82, 212, 13, 49, 36, 233, 143, 226, 5, 140, 121, 223, 10, 244, 188, 82, 199, 88, 197, 81, 211, 199, 184, 236, 20, 85, 72, 149, 84, 77, 58, 158, 179, 124, 15, 182, 250, 147, 76, 128, 186, 242, 235, 201, 28, 40 } });
        }
    }
}
