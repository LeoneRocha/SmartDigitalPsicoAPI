using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDescriptionRecordPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
