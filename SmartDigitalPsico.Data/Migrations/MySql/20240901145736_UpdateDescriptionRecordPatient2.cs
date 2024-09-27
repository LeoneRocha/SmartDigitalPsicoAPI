using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescriptionRecordPatient2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "PatientRecord",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 4000)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "Annotation",
                schema: "dbo",
                table: "PatientRecord",
                type: "text",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "PatientRecord",
                type: "text",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "Annotation",
                schema: "dbo",
                table: "PatientRecord",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 4000)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6549), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6552), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6773), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6774), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6773) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6775), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6776), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6777), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6778) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6779), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6781), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6782), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6781) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6783), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6783), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6785), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6785), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6785) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6786), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6787) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6789), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6789) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6790), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6791), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6791) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6792) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6794), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6795), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6796), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6798), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6800), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6801), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6802) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6803), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6806), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6808), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6807) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6811), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6813), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6815), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6816), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6817), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6816) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6818), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6818) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6822) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6823), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6824), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6824) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6825), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6826), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6826) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6827), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6828), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6828) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6830), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6829) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6831), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6831), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6831) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6833), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6834), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6835), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6835) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6836), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6837), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6839), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6840), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6870), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6870) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7085), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7086), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7086) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7401));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 9, 1, 14, 35, 23, 586, DateTimeKind.Utc).AddTicks(7605), new byte[] { 87, 134, 198, 50, 199, 130, 75, 130, 80, 49, 227, 255, 97, 143, 109, 169, 92, 252, 177, 232, 54, 120, 74, 105, 254, 44, 252, 150, 255, 84, 13, 135, 159, 147, 155, 177, 46, 47, 227, 243, 11, 14, 144, 12, 121, 178, 156, 100, 214, 112, 202, 156, 189, 159, 147, 21, 177, 115, 77, 46, 226, 23, 64, 35 }, new byte[] { 137, 55, 120, 244, 247, 58, 212, 27, 205, 250, 135, 101, 158, 77, 229, 2, 93, 231, 112, 104, 36, 212, 243, 23, 126, 8, 126, 25, 0, 101, 59, 128, 214, 15, 181, 182, 130, 96, 185, 242, 194, 47, 133, 137, 1, 147, 29, 163, 99, 223, 180, 129, 110, 94, 43, 199, 115, 225, 77, 199, 38, 205, 5, 81, 48, 80, 126, 162, 141, 252, 6, 76, 235, 45, 233, 218, 216, 194, 76, 125, 131, 180, 25, 53, 128, 253, 105, 51, 157, 88, 89, 77, 4, 97, 156, 64, 199, 110, 153, 235, 157, 47, 95, 140, 53, 10, 247, 128, 106, 154, 207, 219, 228, 67, 94, 111, 23, 159, 107, 46, 17, 124, 175, 11, 230, 117, 208, 1 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 1, 14, 35, 23, 588, DateTimeKind.Utc).AddTicks(8665), new DateTime(2024, 9, 1, 14, 35, 23, 588, DateTimeKind.Utc).AddTicks(8666), new DateTime(2024, 9, 1, 14, 35, 23, 588, DateTimeKind.Utc).AddTicks(8667), new byte[] { 54, 169, 92, 75, 104, 53, 99, 89, 188, 61, 244, 78, 159, 2, 16, 114, 210, 26, 175, 242, 183, 199, 213, 115, 233, 237, 134, 70, 93, 122, 80, 44, 103, 59, 225, 139, 225, 71, 5, 143, 50, 143, 33, 51, 184, 202, 87, 244, 107, 124, 26, 121, 109, 214, 28, 242, 214, 94, 100, 213, 30, 236, 87, 156 }, new byte[] { 221, 37, 70, 225, 117, 155, 253, 97, 50, 226, 138, 187, 10, 183, 67, 183, 54, 154, 17, 214, 156, 69, 197, 55, 161, 206, 210, 240, 225, 185, 201, 229, 207, 150, 206, 81, 131, 71, 0, 156, 177, 134, 181, 103, 140, 130, 132, 230, 147, 27, 42, 198, 234, 71, 203, 107, 220, 244, 182, 100, 54, 81, 107, 22, 247, 243, 212, 144, 146, 207, 151, 168, 249, 181, 45, 184, 126, 118, 23, 224, 74, 56, 38, 247, 75, 141, 161, 166, 180, 126, 135, 84, 231, 204, 112, 126, 108, 11, 19, 140, 226, 6, 229, 210, 240, 97, 15, 101, 124, 67, 174, 35, 23, 99, 221, 86, 54, 101, 174, 20, 210, 177, 67, 224, 84, 80, 161, 48 } });
        }
    }
}
