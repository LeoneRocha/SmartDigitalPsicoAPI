using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UpdateMedicalCalendarToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(3372) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4695), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4696), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4698), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4699), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4700), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4701), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4702), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4704), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4704), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4705), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4706), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4707), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4708), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4708) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4709), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4710), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4711), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4712), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4713), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4714), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4715), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4715), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4716), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4717), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4718), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4719), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4720), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4721), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4722), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4723), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4726), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4727), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4728), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4728), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4730) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4731), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4732), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4732) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4733), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4734), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4735), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4736), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4737), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4737), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4737) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4739) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4740), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4741), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4742), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4743), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4743) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4744), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4745), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4746), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4747), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4748), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4748), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4748) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4750), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4750), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4750) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4752), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4753), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4754) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4755), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4756), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4757), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4758), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4757) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4759) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4760), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4761), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4761) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4762), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4763), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4763) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4764), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4765), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4764) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4766), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(4766) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 929, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 10, 15, 0, 34, 16, 929, DateTimeKind.Utc).AddTicks(5669), new DateTime(2024, 10, 15, 0, 34, 16, 929, DateTimeKind.Utc).AddTicks(5669) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 911, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(1524), new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(1526), new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 918, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 921, DateTimeKind.Utc).AddTicks(5309), new DateTime(2024, 10, 15, 0, 34, 16, 921, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 10, 15, 0, 34, 16, 921, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 34, 16, 923, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 924, DateTimeKind.Utc).AddTicks(2129), new DateTime(2024, 10, 15, 0, 34, 16, 924, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 10, 15, 0, 34, 16, 924, DateTimeKind.Utc).AddTicks(2131), new byte[] { 76, 68, 86, 34, 206, 244, 23, 128, 33, 128, 18, 104, 85, 112, 93, 166, 182, 203, 92, 6, 229, 144, 16, 188, 214, 59, 97, 28, 8, 61, 155, 234, 141, 76, 9, 58, 42, 218, 205, 148, 150, 11, 118, 93, 224, 239, 206, 154, 218, 165, 127, 210, 171, 45, 5, 145, 172, 71, 72, 13, 253, 105, 248, 169 }, new byte[] { 11, 98, 249, 165, 201, 15, 70, 230, 241, 54, 240, 223, 29, 191, 197, 187, 193, 23, 232, 30, 53, 69, 231, 153, 152, 4, 12, 147, 40, 240, 181, 219, 74, 208, 29, 172, 161, 249, 73, 159, 228, 45, 57, 83, 16, 58, 107, 60, 79, 209, 24, 134, 8, 164, 187, 199, 35, 215, 31, 44, 128, 241, 34, 189, 187, 173, 153, 133, 232, 29, 191, 106, 237, 130, 44, 228, 117, 39, 20, 8, 79, 214, 231, 122, 229, 188, 78, 152, 223, 83, 43, 164, 208, 229, 140, 246, 47, 34, 173, 198, 167, 166, 199, 214, 87, 89, 219, 127, 77, 37, 7, 213, 166, 10, 223, 0, 119, 92, 51, 170, 250, 83, 73, 59, 191, 201, 36, 199 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 34, 16, 926, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 10, 15, 0, 34, 16, 926, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 10, 15, 0, 34, 16, 926, DateTimeKind.Utc).AddTicks(3251), new byte[] { 102, 251, 173, 14, 200, 44, 11, 201, 25, 193, 236, 193, 141, 0, 9, 29, 202, 172, 63, 219, 180, 164, 127, 236, 121, 100, 202, 147, 223, 12, 199, 169, 32, 3, 249, 69, 105, 61, 221, 58, 115, 159, 243, 53, 12, 242, 106, 24, 105, 61, 107, 102, 65, 172, 90, 180, 220, 112, 41, 140, 93, 136, 120, 168 }, new byte[] { 87, 37, 184, 205, 31, 108, 21, 68, 70, 184, 232, 201, 193, 66, 252, 22, 82, 19, 255, 89, 95, 88, 43, 180, 34, 182, 254, 19, 135, 151, 106, 245, 142, 230, 246, 41, 216, 234, 73, 233, 151, 255, 141, 56, 102, 136, 20, 80, 209, 117, 104, 216, 147, 32, 161, 140, 253, 8, 21, 157, 255, 202, 109, 175, 117, 208, 247, 186, 112, 131, 128, 20, 39, 164, 69, 159, 178, 79, 137, 121, 112, 43, 44, 117, 122, 81, 191, 185, 98, 11, 184, 159, 88, 18, 126, 202, 246, 199, 186, 120, 138, 64, 55, 34, 28, 55, 35, 251, 8, 151, 151, 229, 190, 31, 156, 1, 173, 69, 36, 253, 60, 47, 225, 41, 151, 119, 93, 136 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8637), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9901), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9902), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9909), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9910), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9911), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9912), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9913), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9914), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9915), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9916), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9917), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9920), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9921), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9922), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9923), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9924), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9925), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9927), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9931), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9932), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9933), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9934), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9935), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9936), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9940), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9941), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9942), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9943), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9973), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9975), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9976), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9977), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9978), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9982), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9983), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9984), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9985), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9986), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9988), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9989), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9990), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9991), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9993), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9994), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9995), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9997), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9998), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9999), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc), new DateTime(2024, 10, 14, 2, 45, 4, 766, DateTimeKind.Utc).AddTicks(9999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1), new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(1) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9542), new DateTime(2024, 10, 14, 2, 45, 4, 784, DateTimeKind.Utc).AddTicks(9541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 767, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6620), new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6621), new DateTime(2024, 10, 14, 2, 45, 4, 773, DateTimeKind.Utc).AddTicks(6621) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 774, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(409), new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(410), new DateTime(2024, 10, 14, 2, 45, 4, 777, DateTimeKind.Utc).AddTicks(411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6535), new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6536), new DateTime(2024, 10, 14, 2, 45, 4, 779, DateTimeKind.Utc).AddTicks(6537), new byte[] { 172, 58, 117, 34, 187, 226, 164, 3, 28, 237, 70, 46, 231, 107, 213, 125, 22, 162, 135, 111, 39, 227, 233, 220, 216, 87, 125, 92, 170, 72, 178, 187, 198, 105, 107, 0, 228, 178, 175, 17, 147, 163, 131, 112, 104, 58, 220, 147, 16, 210, 182, 192, 137, 206, 77, 2, 4, 39, 86, 135, 47, 75, 135, 246 }, new byte[] { 172, 103, 166, 243, 41, 162, 210, 71, 89, 125, 12, 242, 156, 29, 250, 116, 247, 34, 128, 118, 44, 5, 240, 2, 53, 59, 227, 169, 196, 209, 197, 2, 117, 197, 214, 87, 15, 199, 186, 191, 121, 231, 99, 88, 64, 25, 103, 109, 109, 234, 65, 101, 255, 127, 43, 224, 75, 51, 215, 121, 75, 128, 19, 59, 50, 37, 173, 68, 78, 123, 54, 239, 31, 36, 171, 141, 171, 244, 230, 210, 168, 173, 40, 119, 30, 208, 102, 41, 211, 151, 237, 165, 226, 58, 122, 211, 194, 15, 136, 142, 88, 208, 50, 230, 127, 43, 236, 96, 111, 207, 117, 208, 120, 127, 231, 190, 237, 116, 246, 69, 222, 2, 151, 239, 163, 179, 139, 181 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7643), new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7644), new DateTime(2024, 10, 14, 2, 45, 4, 781, DateTimeKind.Utc).AddTicks(7645), new byte[] { 246, 148, 222, 136, 27, 255, 10, 162, 78, 234, 133, 33, 6, 67, 205, 126, 249, 148, 118, 49, 63, 209, 70, 183, 98, 195, 97, 169, 48, 160, 118, 26, 30, 204, 174, 157, 168, 211, 54, 214, 56, 145, 143, 56, 125, 220, 248, 247, 132, 73, 68, 109, 31, 100, 248, 166, 8, 217, 232, 84, 99, 203, 68, 34 }, new byte[] { 234, 128, 108, 217, 248, 137, 209, 244, 105, 123, 21, 218, 112, 255, 10, 173, 24, 146, 182, 247, 11, 234, 44, 214, 93, 181, 204, 115, 240, 45, 198, 51, 118, 70, 125, 16, 97, 157, 150, 240, 152, 45, 35, 53, 186, 240, 53, 0, 175, 87, 70, 160, 238, 169, 197, 92, 23, 13, 243, 27, 145, 179, 71, 145, 210, 166, 113, 171, 217, 193, 26, 33, 99, 170, 16, 96, 74, 117, 19, 192, 165, 25, 133, 187, 93, 190, 176, 201, 4, 220, 233, 32, 64, 171, 112, 181, 176, 2, 236, 210, 26, 251, 70, 7, 149, 223, 19, 44, 143, 181, 151, 241, 122, 143, 206, 131, 32, 121, 229, 239, 10, 92, 162, 49, 67, 205, 128, 188 } });
        }
    }
}
