using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFileTableCloud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileBlobName",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<string>(
                name: "FileCloudContainer",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<string>(
                name: "FileBlobName",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.AddColumn<string>(
                name: "FileCloudContainer",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 665, DateTimeKind.Utc).AddTicks(9953), new DateTime(2024, 8, 10, 15, 40, 33, 665, DateTimeKind.Utc).AddTicks(9960), new DateTime(2024, 8, 10, 15, 40, 33, 665, DateTimeKind.Utc).AddTicks(9959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(196), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(197), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(196) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(198), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(199), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(199) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(200), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(201) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(202), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(203), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(202) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(204), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(204), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(204) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(206), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(206), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(207), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(208), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(209), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(210), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(211), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(212), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(211) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(214), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(213) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(215), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(215) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(216), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(218), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(219), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(220), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(221), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(220) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(222), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(222) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(223), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(224), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(224) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(225), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(227), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(227) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(229) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(230), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(231), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(232), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(233), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(236), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(236), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(238), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(239), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(240), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(239) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(241) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(243), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(243), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(244), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(245), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(245) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(246), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(247), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(246) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(248), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(248), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(248) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(250) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(251), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(252), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(252) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(254), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(255) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(256), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(257), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(257) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(258), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(259), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(259) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(260), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(262), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(262), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(263), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(474), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(475), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(806));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 8, 10, 15, 40, 33, 666, DateTimeKind.Utc).AddTicks(1019), new byte[] { 26, 167, 174, 18, 38, 8, 251, 223, 211, 26, 83, 165, 177, 116, 121, 99, 242, 229, 164, 95, 116, 38, 81, 150, 65, 199, 227, 246, 72, 44, 216, 226, 44, 136, 201, 170, 83, 85, 8, 95, 252, 240, 238, 172, 109, 15, 46, 222, 226, 67, 152, 83, 205, 202, 212, 102, 184, 93, 154, 165, 93, 132, 238, 31 }, new byte[] { 56, 73, 245, 63, 5, 216, 3, 109, 219, 94, 43, 124, 228, 60, 230, 179, 135, 208, 133, 59, 140, 115, 9, 149, 174, 158, 176, 221, 216, 173, 159, 35, 82, 2, 25, 40, 245, 192, 128, 245, 107, 57, 219, 57, 58, 141, 59, 202, 146, 221, 157, 99, 237, 30, 73, 191, 207, 30, 195, 25, 110, 131, 81, 39, 190, 110, 187, 13, 138, 185, 140, 39, 45, 235, 191, 93, 176, 1, 94, 90, 241, 26, 36, 0, 11, 90, 32, 239, 158, 222, 105, 16, 80, 91, 131, 243, 95, 135, 96, 195, 189, 185, 15, 43, 212, 201, 57, 63, 12, 56, 89, 69, 27, 141, 213, 60, 176, 246, 78, 195, 218, 54, 20, 77, 80, 215, 182, 175 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 8, 10, 15, 40, 33, 668, DateTimeKind.Utc).AddTicks(1895), new DateTime(2024, 8, 10, 15, 40, 33, 668, DateTimeKind.Utc).AddTicks(1896), new DateTime(2024, 8, 10, 15, 40, 33, 668, DateTimeKind.Utc).AddTicks(1896), new byte[] { 96, 111, 184, 206, 206, 85, 194, 174, 166, 124, 82, 183, 163, 112, 66, 223, 171, 54, 47, 164, 16, 15, 95, 247, 10, 109, 89, 116, 10, 183, 21, 238, 30, 176, 239, 21, 87, 181, 137, 94, 227, 36, 238, 179, 6, 105, 199, 199, 155, 164, 239, 27, 67, 172, 104, 56, 130, 63, 127, 47, 53, 174, 110, 130 }, new byte[] { 221, 115, 222, 239, 53, 85, 13, 243, 45, 145, 254, 181, 39, 233, 70, 161, 211, 207, 114, 11, 7, 57, 242, 173, 227, 245, 44, 141, 85, 209, 79, 64, 74, 219, 222, 198, 203, 194, 56, 5, 161, 205, 27, 246, 67, 192, 160, 72, 186, 36, 150, 227, 14, 194, 7, 130, 219, 16, 88, 118, 135, 110, 86, 14, 167, 85, 138, 168, 58, 214, 70, 89, 225, 5, 101, 202, 139, 229, 172, 242, 188, 175, 253, 14, 228, 22, 68, 203, 64, 172, 182, 36, 0, 51, 116, 159, 143, 183, 108, 54, 144, 12, 246, 109, 171, 173, 170, 95, 242, 83, 153, 158, 246, 196, 50, 95, 94, 95, 84, 100, 216, 196, 13, 47, 201, 190, 21, 186 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileBlobName",
                schema: "dbo",
                table: "PatientFile");

            migrationBuilder.DropColumn(
                name: "FileCloudContainer",
                schema: "dbo",
                table: "PatientFile");

            migrationBuilder.DropColumn(
                name: "FileBlobName",
                schema: "dbo",
                table: "MedicalFile");

            migrationBuilder.DropColumn(
                name: "FileCloudContainer",
                schema: "dbo",
                table: "MedicalFile");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1450), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1451), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1452), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1453), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1454), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1455), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1459), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1473), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1478), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1486), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1488), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1490), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1964), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2277), new byte[] { 58, 207, 111, 72, 252, 192, 199, 184, 24, 102, 2, 173, 173, 25, 128, 135, 4, 82, 133, 100, 101, 104, 248, 176, 63, 122, 42, 187, 31, 16, 253, 44, 76, 17, 242, 44, 189, 196, 105, 178, 183, 137, 20, 133, 9, 175, 113, 199, 225, 220, 122, 97, 22, 141, 55, 45, 156, 182, 37, 69, 250, 219, 220, 126 }, new byte[] { 253, 173, 26, 3, 16, 153, 242, 244, 231, 38, 110, 50, 0, 0, 17, 78, 116, 95, 159, 83, 37, 224, 135, 169, 175, 209, 236, 246, 5, 155, 108, 242, 36, 20, 67, 43, 239, 25, 96, 86, 255, 47, 107, 17, 1, 24, 143, 213, 98, 255, 75, 84, 87, 61, 87, 66, 148, 24, 119, 241, 142, 192, 54, 137, 36, 213, 44, 109, 1, 79, 47, 223, 209, 178, 44, 243, 195, 127, 11, 219, 123, 80, 201, 59, 93, 128, 124, 212, 134, 75, 112, 238, 154, 226, 180, 31, 112, 40, 250, 68, 185, 255, 42, 16, 218, 63, 129, 91, 31, 165, 62, 106, 52, 238, 206, 241, 190, 166, 57, 47, 255, 75, 80, 186, 26, 155, 209, 160 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3549), new byte[] { 96, 80, 188, 98, 100, 82, 95, 88, 141, 18, 48, 218, 104, 237, 9, 254, 20, 138, 98, 197, 208, 62, 194, 41, 119, 196, 154, 251, 167, 12, 92, 199, 145, 183, 58, 231, 195, 39, 9, 7, 214, 60, 206, 20, 238, 19, 220, 37, 253, 229, 255, 113, 78, 8, 132, 185, 204, 174, 85, 133, 217, 205, 135, 149 }, new byte[] { 217, 114, 226, 84, 148, 221, 241, 251, 211, 223, 51, 109, 174, 101, 30, 42, 62, 171, 150, 226, 58, 56, 117, 95, 131, 188, 3, 108, 186, 70, 1, 195, 2, 88, 22, 84, 155, 122, 96, 207, 31, 184, 198, 170, 92, 61, 126, 4, 181, 70, 114, 177, 133, 47, 222, 254, 117, 100, 225, 216, 172, 113, 230, 38, 74, 222, 30, 192, 167, 129, 41, 116, 139, 96, 188, 212, 156, 113, 219, 48, 254, 148, 16, 184, 247, 106, 143, 20, 178, 185, 113, 168, 138, 149, 135, 37, 149, 153, 137, 234, 80, 203, 118, 199, 233, 253, 234, 190, 49, 220, 168, 245, 37, 47, 232, 103, 137, 97, 76, 80, 10, 242, 117, 173, 8, 129, 184, 209 } });
        }
    }
}
