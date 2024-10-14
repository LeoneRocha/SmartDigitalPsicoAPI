using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWorkv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2859), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(2861) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4248), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4249), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4248) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4251) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4256), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4257), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4256) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4258), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4259), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4258) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4260) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4262) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4264) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4265), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4266), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4266) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4267), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4268), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4268) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4269), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4270), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4269) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4271), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4272), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4271) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4273) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4275) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4277), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4277) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4279), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4279) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4280), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4281), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4280) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4282) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4284) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4285), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4286), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4286) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4288), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4288) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4290), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4293) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4295), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4296), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4295) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4297) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4299) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4301) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4303), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4305), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4330), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4331), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4332), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4333), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4334), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4335), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4336), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4340) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4341), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4342), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4342) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4343), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4344), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4344) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4345), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4346), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347), new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6645), new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6646), new DateTime(2024, 10, 14, 1, 43, 58, 900, DateTimeKind.Utc).AddTicks(6646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 882, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2797), new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2800), new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(2800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 889, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6929), new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 10, 14, 1, 43, 58, 892, DateTimeKind.Utc).AddTicks(6930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(8770));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 43, 58, 894, DateTimeKind.Utc).AddTicks(9448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 10, 14, 1, 43, 58, 895, DateTimeKind.Utc).AddTicks(3373), new byte[] { 110, 92, 171, 203, 164, 134, 62, 219, 17, 94, 109, 192, 134, 247, 128, 75, 80, 30, 123, 21, 42, 59, 173, 110, 93, 74, 56, 91, 88, 130, 188, 129, 49, 21, 75, 208, 214, 151, 172, 188, 231, 136, 27, 153, 211, 48, 36, 97, 237, 64, 208, 128, 214, 0, 79, 86, 1, 89, 125, 64, 252, 202, 25, 202 }, new byte[] { 54, 114, 188, 27, 130, 156, 87, 63, 252, 70, 114, 217, 219, 238, 135, 104, 79, 243, 127, 10, 72, 70, 180, 253, 25, 222, 200, 58, 115, 244, 76, 126, 56, 91, 176, 104, 128, 179, 39, 113, 195, 217, 248, 164, 26, 41, 51, 106, 122, 153, 30, 249, 114, 57, 122, 196, 147, 39, 2, 0, 116, 118, 191, 225, 95, 148, 156, 160, 24, 29, 168, 183, 231, 174, 140, 60, 99, 166, 187, 174, 151, 109, 213, 167, 34, 112, 145, 63, 203, 12, 37, 194, 149, 189, 155, 186, 65, 151, 154, 9, 238, 106, 199, 116, 254, 76, 169, 124, 83, 177, 180, 210, 105, 123, 220, 175, 30, 112, 55, 20, 149, 3, 16, 209, 15, 27, 143, 87 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4963), new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4964), new DateTime(2024, 10, 14, 1, 43, 58, 897, DateTimeKind.Utc).AddTicks(4964), new byte[] { 156, 54, 139, 173, 159, 108, 159, 177, 156, 184, 254, 13, 27, 100, 155, 204, 232, 137, 216, 74, 248, 49, 145, 51, 145, 207, 141, 226, 99, 83, 247, 100, 20, 144, 127, 119, 25, 183, 247, 50, 204, 191, 109, 53, 254, 107, 135, 90, 140, 197, 81, 73, 24, 22, 208, 23, 175, 135, 74, 158, 9, 133, 72, 183 }, new byte[] { 228, 237, 182, 176, 223, 238, 105, 31, 185, 28, 106, 236, 125, 189, 52, 157, 163, 46, 118, 90, 248, 38, 76, 209, 114, 224, 135, 134, 139, 36, 188, 30, 205, 165, 120, 123, 62, 245, 18, 15, 117, 9, 137, 168, 34, 17, 196, 80, 37, 90, 100, 35, 116, 77, 166, 182, 171, 166, 39, 7, 203, 50, 85, 126, 168, 70, 80, 67, 99, 159, 239, 156, 56, 207, 8, 51, 174, 74, 239, 64, 198, 110, 59, 203, 115, 138, 110, 23, 221, 182, 45, 133, 244, 44, 59, 173, 205, 17, 26, 77, 108, 96, 125, 180, 93, 157, 70, 160, 187, 170, 83, 93, 202, 163, 255, 218, 28, 30, 207, 26, 251, 240, 2, 251, 145, 253, 222, 80 } });

            migrationBuilder.CreateIndex(
                name: "Idx_Title_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                columns: new[] { "Title", "PatientId", "MedicalId", "StartDateTime", "EndDateTime" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_Title_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2572), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2578), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3812) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3814) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3816) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3818) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3820), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3822), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3826), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3827), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3828), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3829), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3828) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3831), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3833), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3834), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3835), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3836), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3837), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3838), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3840), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3875), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3876), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3877), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3878), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3879), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3880), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3882), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3883), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3883) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3884), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3885), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3886), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3890) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3892), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3894), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3898), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3899), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3900), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3901), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3902), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3903), new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2309), new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 10, 14, 1, 32, 34, 976, DateTimeKind.Utc).AddTicks(2310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 958, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9358), new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 10, 14, 1, 32, 34, 964, DateTimeKind.Utc).AddTicks(9360) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 965, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3115), new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3116), new DateTime(2024, 10, 14, 1, 32, 34, 968, DateTimeKind.Utc).AddTicks(3116) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9168), new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9169), new DateTime(2024, 10, 14, 1, 32, 34, 970, DateTimeKind.Utc).AddTicks(9170), new byte[] { 240, 206, 132, 243, 213, 172, 179, 20, 91, 206, 44, 95, 112, 206, 129, 48, 235, 74, 211, 60, 71, 111, 157, 128, 71, 195, 195, 170, 205, 11, 191, 228, 228, 66, 30, 232, 14, 135, 112, 238, 244, 204, 236, 66, 249, 6, 125, 150, 168, 32, 195, 48, 31, 214, 135, 238, 123, 80, 46, 134, 226, 234, 51, 180 }, new byte[] { 96, 34, 61, 167, 114, 195, 189, 165, 160, 78, 47, 205, 130, 10, 126, 40, 26, 0, 251, 159, 107, 223, 250, 79, 144, 57, 50, 246, 187, 53, 9, 112, 16, 147, 22, 146, 98, 182, 118, 133, 184, 84, 63, 97, 171, 110, 75, 218, 51, 106, 100, 54, 178, 94, 255, 76, 237, 227, 105, 137, 20, 83, 37, 30, 122, 118, 146, 122, 108, 92, 177, 172, 222, 48, 71, 225, 145, 231, 142, 124, 115, 216, 115, 34, 177, 93, 237, 101, 195, 91, 238, 202, 81, 63, 183, 114, 52, 175, 224, 15, 149, 72, 187, 216, 99, 164, 182, 175, 211, 210, 132, 39, 235, 254, 43, 122, 57, 230, 103, 182, 28, 161, 89, 119, 22, 3, 231, 110 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(85), new DateTime(2024, 10, 14, 1, 32, 34, 973, DateTimeKind.Utc).AddTicks(86), new byte[] { 250, 44, 220, 146, 173, 162, 138, 111, 252, 14, 183, 6, 185, 107, 201, 200, 114, 189, 156, 63, 62, 212, 39, 57, 4, 178, 209, 72, 40, 89, 195, 96, 25, 121, 241, 180, 182, 126, 169, 106, 146, 188, 140, 251, 1, 188, 84, 124, 62, 128, 226, 200, 247, 219, 184, 156, 29, 62, 75, 69, 169, 196, 149, 65 }, new byte[] { 135, 6, 80, 185, 19, 60, 48, 36, 33, 81, 99, 111, 150, 53, 36, 173, 74, 167, 76, 72, 77, 235, 78, 20, 20, 84, 115, 108, 80, 61, 173, 37, 212, 96, 38, 28, 244, 150, 61, 221, 127, 249, 88, 169, 109, 229, 170, 137, 129, 52, 222, 63, 50, 118, 59, 168, 98, 108, 177, 38, 126, 180, 74, 33, 35, 83, 40, 228, 185, 82, 110, 32, 240, 204, 241, 60, 233, 216, 38, 229, 162, 130, 81, 49, 184, 69, 96, 108, 11, 115, 183, 224, 141, 46, 224, 55, 186, 100, 69, 183, 69, 132, 175, 163, 171, 215, 254, 52, 181, 22, 177, 115, 134, 216, 118, 9, 123, 47, 138, 238, 130, 190, 50, 13, 37, 182, 196, 179 } });
        }
    }
}
