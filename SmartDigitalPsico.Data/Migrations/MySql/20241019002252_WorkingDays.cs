using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class WorkingDays : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkingDays",
                schema: "dbo",
                table: "Medical",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3012), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3016), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(3015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4441), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4443), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4442) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4444), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4445), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4446), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4447), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4448), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4449), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4451), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4452), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4453), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4456), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4459), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4460), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4461), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4462), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4463), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4464), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4470), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4471), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4472), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4473), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4475), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4476), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4477), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4480), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4481), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4482), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4483), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4484), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4485), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4486), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4487), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4488), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4490), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4493), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4494), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4499), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4508), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1791), new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1793), new DateTime(2024, 10, 19, 0, 22, 51, 735, DateTimeKind.Utc).AddTicks(1792) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(5264));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 716, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "WorkingDays" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(4498), "1,2,3,4,5,6" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 723, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9317), new DateTime(2024, 10, 19, 0, 22, 51, 726, DateTimeKind.Utc).AddTicks(9318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(3542));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7534), new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7535), new DateTime(2024, 10, 19, 0, 22, 51, 729, DateTimeKind.Utc).AddTicks(7535), new byte[] { 217, 12, 184, 55, 110, 43, 8, 91, 126, 27, 46, 248, 188, 1, 28, 250, 66, 36, 58, 219, 38, 0, 29, 164, 198, 82, 168, 255, 125, 37, 53, 131, 251, 196, 29, 207, 222, 254, 252, 157, 111, 242, 63, 11, 10, 243, 159, 204, 176, 243, 6, 112, 159, 186, 9, 243, 175, 211, 205, 255, 233, 177, 2, 93 }, new byte[] { 106, 86, 98, 241, 153, 146, 22, 121, 255, 19, 125, 95, 157, 77, 120, 6, 184, 176, 183, 255, 101, 228, 166, 203, 196, 168, 56, 115, 245, 241, 25, 236, 25, 87, 3, 148, 200, 216, 55, 26, 231, 32, 170, 197, 98, 39, 234, 129, 40, 143, 159, 39, 213, 251, 2, 57, 229, 249, 233, 210, 108, 147, 113, 222, 140, 61, 198, 81, 168, 217, 165, 247, 223, 62, 152, 133, 232, 87, 20, 95, 116, 136, 182, 80, 239, 133, 214, 134, 71, 158, 73, 130, 212, 211, 217, 78, 50, 116, 81, 96, 180, 130, 119, 217, 201, 196, 193, 141, 194, 105, 89, 177, 103, 97, 113, 66, 35, 204, 240, 40, 175, 127, 250, 135, 131, 205, 184, 102 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9426), new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9427), new DateTime(2024, 10, 19, 0, 22, 51, 731, DateTimeKind.Utc).AddTicks(9428), new byte[] { 141, 214, 16, 116, 62, 80, 254, 254, 25, 178, 204, 92, 237, 216, 112, 98, 253, 112, 85, 226, 129, 225, 5, 35, 226, 199, 0, 173, 237, 68, 146, 11, 151, 236, 199, 152, 210, 53, 248, 237, 57, 179, 11, 50, 73, 190, 160, 191, 225, 125, 115, 162, 101, 119, 150, 83, 199, 7, 60, 242, 5, 245, 90, 224 }, new byte[] { 69, 242, 26, 18, 47, 103, 159, 89, 194, 80, 137, 168, 118, 24, 130, 67, 110, 110, 65, 56, 112, 225, 74, 242, 156, 6, 212, 115, 83, 82, 155, 29, 160, 217, 64, 127, 120, 204, 227, 205, 166, 121, 111, 117, 178, 113, 81, 168, 21, 105, 221, 172, 122, 248, 64, 241, 204, 57, 245, 235, 141, 43, 202, 220, 196, 175, 116, 98, 243, 144, 130, 168, 150, 147, 59, 52, 72, 88, 46, 180, 126, 238, 248, 185, 197, 83, 162, 109, 77, 178, 111, 119, 255, 241, 65, 236, 118, 199, 220, 225, 190, 1, 222, 143, 132, 5, 234, 189, 116, 85, 9, 4, 70, 62, 109, 143, 84, 86, 174, 39, 226, 135, 30, 53, 224, 31, 90, 150 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkingDays",
                schema: "dbo",
                table: "Medical");

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
    }
}
