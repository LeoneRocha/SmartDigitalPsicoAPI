using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRules2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<short>(
                name: "IntervalType",
                schema: "dbo",
                table: "NotificationRules",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8956), new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8959), new DateTime(2025, 2, 28, 0, 3, 5, 471, DateTimeKind.Utc).AddTicks(8959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4312), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4313), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4313) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4315), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4316), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4315) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4317), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4318), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4319), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4322), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4321) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4327), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4328), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4329), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4330), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4331), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4330) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4332), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4333), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4332) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4334) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4336), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4336) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4337), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4338), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4339), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4340), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4339) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4341), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4342), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4341) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4343) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4345) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4346), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4347), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4347) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4348), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4349), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4348) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4350), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4351), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4382), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4383), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4384), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4385), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4386), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4387), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4391), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4392), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4393), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4394), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4395), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4396), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4400), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4401), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4402), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4403), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4404), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4405), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4407), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4408), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4409), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4410), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4411), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4412), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4413), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4414), new DateTime(2025, 2, 28, 0, 3, 5, 472, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5741), new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5743), new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(5742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 473, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(123), new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(124), new DateTime(2025, 2, 28, 0, 3, 5, 483, DateTimeKind.Utc).AddTicks(124) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 486, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5081), new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5082), new DateTime(2025, 2, 28, 0, 3, 5, 489, DateTimeKind.Utc).AddTicks(5082) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5512));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 492, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1402));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6362), new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6363), new DateTime(2025, 2, 28, 0, 3, 5, 493, DateTimeKind.Utc).AddTicks(6363), new byte[] { 159, 136, 85, 54, 178, 254, 92, 207, 29, 81, 93, 85, 39, 155, 149, 165, 177, 41, 116, 173, 186, 205, 177, 131, 190, 251, 83, 85, 197, 0, 4, 88, 90, 243, 172, 218, 61, 213, 235, 125, 192, 171, 23, 79, 176, 154, 129, 185, 29, 1, 129, 222, 201, 238, 33, 180, 134, 170, 247, 89, 157, 126, 193, 124 }, new byte[] { 164, 124, 197, 171, 16, 229, 64, 253, 199, 206, 212, 242, 11, 137, 119, 229, 159, 81, 92, 184, 102, 164, 32, 16, 221, 108, 134, 13, 55, 81, 34, 69, 189, 84, 210, 119, 15, 144, 6, 54, 158, 245, 192, 103, 154, 86, 149, 114, 31, 94, 127, 71, 109, 131, 29, 79, 223, 111, 222, 201, 28, 23, 231, 200, 110, 3, 227, 119, 123, 238, 151, 165, 11, 154, 71, 37, 247, 187, 198, 28, 249, 81, 48, 125, 78, 6, 61, 188, 3, 241, 158, 101, 213, 196, 130, 132, 48, 221, 106, 110, 92, 245, 131, 73, 120, 125, 125, 81, 157, 4, 47, 85, 94, 33, 245, 104, 175, 39, 173, 96, 9, 182, 14, 80, 119, 46, 196, 34 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8253), new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8254), new DateTime(2025, 2, 28, 0, 3, 5, 495, DateTimeKind.Utc).AddTicks(8254), new byte[] { 202, 10, 20, 218, 215, 107, 171, 36, 144, 165, 20, 230, 166, 72, 248, 142, 222, 20, 121, 111, 21, 109, 103, 45, 94, 161, 115, 206, 25, 235, 14, 36, 113, 196, 12, 39, 235, 61, 114, 166, 132, 27, 6, 39, 20, 94, 79, 8, 212, 250, 41, 159, 96, 245, 185, 246, 138, 222, 72, 133, 69, 123, 156, 149 }, new byte[] { 168, 152, 214, 146, 65, 85, 223, 10, 6, 248, 74, 79, 212, 16, 56, 106, 63, 230, 168, 119, 146, 158, 35, 250, 248, 17, 207, 145, 122, 66, 44, 115, 194, 172, 115, 92, 196, 130, 159, 242, 150, 187, 67, 132, 185, 138, 123, 225, 148, 207, 18, 99, 94, 66, 181, 69, 95, 196, 32, 154, 25, 120, 32, 143, 101, 156, 55, 217, 179, 208, 32, 86, 239, 74, 241, 12, 102, 55, 172, 190, 108, 132, 163, 211, 19, 60, 49, 167, 250, 4, 56, 59, 114, 99, 15, 119, 211, 207, 6, 46, 13, 32, 229, 184, 9, 211, 182, 157, 226, 204, 184, 229, 164, 174, 88, 124, 35, 163, 189, 12, 61, 185, 160, 70, 156, 163, 123, 178 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "IntervalType",
                schema: "dbo",
                table: "NotificationRules",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(1370), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(1373), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6698), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6701), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6702), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6703), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6704), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6705), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6706), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6705) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6707), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6708), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6709), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6711), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6712), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6713), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6714), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6715), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6716), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6717), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6718), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6719), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6720), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6722), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6722), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6723), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6724), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6725), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6726), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6727), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6728), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6729), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6729), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6731), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6732), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6733), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6734), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6735), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6736), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6737), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6736) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6738), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6739), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6740), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6740), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6742), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6742), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6743), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6744), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6745), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6746), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6747), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6748), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6748) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6749), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6750), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6751), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6751), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6753), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6753), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6753) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6754), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6755), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6756), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6757), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6757) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6758), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6759), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6758) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6760), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6761), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6760) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6762), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6762), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6762) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6764), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6764), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6765), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6766), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6766) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6767), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6768), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6767) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6769), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6770), new DateTime(2025, 2, 27, 23, 51, 30, 615, DateTimeKind.Utc).AddTicks(6769) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 616, DateTimeKind.Utc).AddTicks(7217), new DateTime(2025, 2, 27, 23, 51, 30, 616, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 2, 27, 23, 51, 30, 616, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 616, DateTimeKind.Utc).AddTicks(8929));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 616, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 626, DateTimeKind.Utc).AddTicks(2257), new DateTime(2025, 2, 27, 23, 51, 30, 626, DateTimeKind.Utc).AddTicks(2258), new DateTime(2025, 2, 27, 23, 51, 30, 626, DateTimeKind.Utc).AddTicks(2259) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 629, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 629, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 629, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 632, DateTimeKind.Utc).AddTicks(7596), new DateTime(2025, 2, 27, 23, 51, 30, 632, DateTimeKind.Utc).AddTicks(7597), new DateTime(2025, 2, 27, 23, 51, 30, 632, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 27, 23, 51, 30, 636, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 637, DateTimeKind.Utc).AddTicks(1697), new DateTime(2025, 2, 27, 23, 51, 30, 637, DateTimeKind.Utc).AddTicks(1698), new DateTime(2025, 2, 27, 23, 51, 30, 637, DateTimeKind.Utc).AddTicks(1698), new byte[] { 230, 23, 181, 128, 0, 175, 20, 244, 187, 109, 44, 188, 9, 166, 57, 6, 160, 226, 100, 50, 135, 30, 166, 86, 36, 55, 179, 180, 105, 110, 183, 83, 218, 26, 222, 34, 34, 98, 197, 147, 230, 59, 178, 79, 79, 46, 99, 8, 22, 116, 238, 161, 9, 119, 50, 129, 217, 42, 216, 131, 38, 53, 166, 139 }, new byte[] { 249, 175, 219, 98, 168, 17, 106, 137, 202, 176, 83, 173, 193, 200, 44, 78, 17, 187, 80, 125, 11, 51, 67, 110, 88, 29, 99, 27, 44, 20, 190, 105, 66, 75, 108, 36, 210, 69, 137, 75, 169, 18, 232, 184, 206, 79, 210, 88, 63, 36, 253, 249, 103, 110, 253, 232, 181, 104, 195, 169, 53, 211, 62, 178, 209, 80, 134, 28, 17, 207, 217, 254, 111, 125, 65, 104, 210, 139, 129, 85, 55, 132, 90, 247, 171, 195, 146, 19, 181, 10, 122, 23, 173, 23, 220, 34, 204, 117, 199, 199, 251, 79, 37, 148, 76, 69, 204, 21, 82, 161, 96, 52, 167, 48, 67, 98, 176, 74, 180, 210, 87, 114, 25, 118, 102, 29, 19, 8 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 27, 23, 51, 30, 639, DateTimeKind.Utc).AddTicks(3072), new DateTime(2025, 2, 27, 23, 51, 30, 639, DateTimeKind.Utc).AddTicks(3073), new DateTime(2025, 2, 27, 23, 51, 30, 639, DateTimeKind.Utc).AddTicks(3074), new byte[] { 186, 72, 233, 194, 223, 114, 235, 138, 166, 181, 181, 153, 223, 146, 137, 71, 75, 140, 133, 156, 15, 56, 18, 218, 92, 176, 8, 138, 149, 240, 187, 37, 49, 138, 174, 59, 171, 189, 42, 114, 212, 161, 160, 166, 34, 83, 239, 44, 40, 105, 202, 200, 158, 74, 124, 139, 62, 180, 255, 92, 27, 119, 206, 200 }, new byte[] { 184, 25, 63, 4, 125, 248, 63, 163, 26, 27, 43, 133, 5, 172, 107, 187, 162, 129, 84, 222, 151, 7, 8, 227, 212, 128, 30, 115, 14, 242, 85, 159, 38, 163, 148, 144, 137, 205, 65, 111, 57, 88, 189, 225, 11, 80, 17, 219, 152, 149, 34, 110, 71, 236, 191, 116, 146, 179, 162, 66, 173, 116, 88, 175, 201, 243, 251, 77, 221, 100, 221, 87, 62, 211, 6, 86, 18, 115, 26, 99, 145, 231, 206, 184, 164, 28, 73, 1, 213, 142, 233, 48, 28, 37, 162, 132, 45, 131, 196, 240, 182, 150, 76, 43, 125, 78, 179, 157, 90, 209, 234, 97, 103, 169, 37, 59, 100, 52, 55, 124, 153, 208, 92, 63, 127, 0, 188, 55 } });
        }
    }
}
