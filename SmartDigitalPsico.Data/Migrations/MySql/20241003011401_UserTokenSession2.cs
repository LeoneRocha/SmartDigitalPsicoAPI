using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UserTokenSession2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                schema: "dbo",
                table: "UserTokenSession",
                type: "text",
                maxLength: 4000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                schema: "dbo",
                table: "UserTokenSession",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RefreshToken",
                schema: "dbo",
                table: "UserTokenSession",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldMaxLength: 4000)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "AccessToken",
                schema: "dbo",
                table: "UserTokenSession",
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
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(477), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(478), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(480), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(494), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(516), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(554), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(557), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(563), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(566), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4644), new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6281), new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6282), new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3986), new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3987), new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1371), new byte[] { 232, 225, 180, 31, 242, 194, 48, 50, 8, 226, 183, 182, 172, 192, 138, 113, 160, 162, 237, 254, 58, 172, 66, 232, 188, 44, 207, 16, 100, 36, 80, 5, 168, 243, 27, 26, 134, 157, 32, 199, 187, 243, 214, 170, 216, 101, 120, 6, 69, 223, 29, 27, 154, 199, 252, 89, 147, 198, 115, 165, 60, 58, 195, 114 }, new byte[] { 190, 248, 8, 58, 43, 120, 2, 15, 249, 3, 98, 213, 204, 126, 82, 222, 174, 170, 58, 241, 199, 40, 33, 67, 202, 132, 112, 193, 32, 47, 30, 156, 72, 23, 228, 141, 183, 106, 125, 118, 200, 252, 189, 105, 237, 157, 50, 236, 57, 210, 153, 24, 133, 66, 120, 240, 80, 237, 254, 86, 255, 73, 179, 196, 240, 73, 43, 253, 41, 24, 10, 1, 252, 197, 64, 0, 233, 193, 192, 93, 20, 255, 123, 158, 209, 108, 251, 18, 230, 210, 105, 70, 35, 124, 108, 67, 86, 166, 106, 219, 248, 175, 228, 85, 25, 163, 217, 28, 175, 22, 127, 37, 151, 209, 174, 170, 148, 148, 101, 11, 186, 148, 81, 121, 7, 212, 39, 167 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3291), new byte[] { 136, 215, 65, 222, 200, 6, 170, 62, 194, 234, 181, 28, 135, 197, 38, 158, 28, 239, 35, 113, 54, 45, 247, 143, 37, 151, 235, 224, 143, 213, 170, 67, 144, 119, 129, 175, 167, 245, 226, 89, 250, 85, 1, 51, 213, 65, 72, 228, 202, 113, 230, 22, 65, 38, 17, 14, 105, 250, 63, 75, 122, 10, 185, 16 }, new byte[] { 139, 11, 160, 127, 192, 46, 153, 97, 186, 61, 75, 95, 59, 62, 11, 82, 17, 172, 53, 211, 84, 201, 112, 88, 90, 161, 94, 243, 57, 74, 150, 140, 92, 47, 215, 248, 108, 182, 116, 88, 141, 254, 164, 28, 85, 228, 75, 60, 213, 60, 148, 10, 142, 241, 164, 232, 120, 118, 52, 179, 4, 133, 209, 176, 78, 27, 19, 147, 210, 180, 46, 194, 198, 80, 100, 210, 132, 100, 191, 179, 21, 196, 99, 234, 112, 113, 235, 69, 143, 224, 130, 11, 51, 185, 67, 81, 42, 56, 89, 112, 59, 108, 79, 55, 26, 45, 114, 39, 26, 212, 124, 34, 44, 239, 4, 70, 147, 125, 217, 248, 83, 155, 0, 151, 82, 219, 175, 119 } });
        }
    }
}
