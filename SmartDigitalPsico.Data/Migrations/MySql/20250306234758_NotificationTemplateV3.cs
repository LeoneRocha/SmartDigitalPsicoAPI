using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationTemplateV3 : Migration
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
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8950), new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8954), new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4655), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4664), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4666), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4671), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4673), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4675), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4682), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4683), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4684), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4686), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4687), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4689), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4694), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4695), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4701), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4703), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4706), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4708), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4709), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4710), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4715), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4718), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4725), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4726), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4727), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4728), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4734), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 703, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 703, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9073), new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3286), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3289), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3291), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3292), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3294), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3299), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6648), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6652), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6654), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6656), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6657), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4943), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4970), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4970), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4976), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1290), new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1291), new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1292), new byte[] { 70, 29, 171, 242, 170, 46, 91, 177, 239, 144, 188, 38, 251, 134, 82, 136, 123, 63, 159, 102, 159, 128, 246, 230, 124, 153, 66, 41, 142, 217, 123, 224, 20, 249, 162, 247, 223, 49, 145, 196, 225, 201, 60, 9, 67, 255, 205, 198, 137, 141, 231, 20, 104, 25, 80, 251, 97, 153, 182, 57, 46, 123, 214, 198 }, new byte[] { 252, 203, 85, 134, 251, 98, 255, 141, 7, 141, 2, 233, 70, 99, 100, 55, 78, 60, 45, 24, 225, 212, 230, 247, 91, 91, 103, 32, 191, 86, 107, 163, 14, 4, 57, 58, 234, 85, 55, 68, 66, 219, 166, 100, 19, 92, 27, 75, 116, 95, 54, 131, 58, 176, 251, 121, 152, 223, 22, 151, 141, 60, 159, 20, 134, 195, 134, 176, 79, 78, 110, 112, 207, 14, 154, 140, 102, 44, 134, 157, 27, 232, 137, 58, 77, 174, 11, 38, 209, 206, 213, 254, 117, 244, 13, 165, 73, 95, 27, 173, 148, 18, 98, 29, 108, 88, 159, 61, 190, 119, 188, 66, 167, 111, 49, 217, 92, 48, 128, 63, 52, 69, 133, 42, 220, 139, 162, 187 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3106), new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3107), new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3108), new byte[] { 217, 199, 221, 91, 77, 203, 215, 117, 66, 42, 88, 254, 100, 109, 86, 142, 118, 44, 150, 233, 205, 181, 126, 177, 48, 76, 185, 29, 55, 206, 235, 42, 163, 167, 85, 160, 25, 182, 230, 176, 18, 80, 28, 54, 186, 188, 142, 240, 52, 93, 23, 92, 111, 164, 134, 233, 174, 198, 40, 253, 92, 121, 132, 26 }, new byte[] { 250, 73, 224, 250, 97, 197, 157, 63, 35, 41, 188, 165, 15, 198, 4, 166, 127, 89, 216, 157, 185, 25, 72, 165, 114, 140, 21, 80, 87, 135, 117, 196, 132, 166, 223, 158, 162, 155, 146, 111, 46, 33, 154, 110, 124, 5, 70, 74, 66, 171, 198, 146, 249, 199, 62, 223, 78, 247, 37, 16, 38, 182, 254, 132, 91, 182, 126, 54, 253, 127, 113, 191, 1, 27, 107, 115, 126, 86, 87, 70, 94, 244, 36, 111, 35, 251, 121, 153, 250, 59, 233, 159, 182, 53, 232, 200, 197, 164, 107, 172, 160, 107, 134, 125, 186, 130, 33, 44, 58, 15, 185, 172, 106, 26, 174, 127, 114, 73, 50, 116, 241, 160, 76, 249, 44, 235, 91, 181 } });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Unique",
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Language", "TagApi" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Unique",
                schema: "dbo",
                table: "NotificationTemplate");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(3266), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(3274), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8585), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8587), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8587) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8589), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8589), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8589) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8591), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8591), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8591) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8593), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8593), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8595), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8595), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8595) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8596), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8597), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8597) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8598), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8599), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8600), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8601), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8600) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8602), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8602) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8604), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8604), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8604) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8605), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8606), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8606) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8607), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8608), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8607) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8609), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8610), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8609) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8611), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8611) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8613), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8613) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8614), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8615), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8615) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8617), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8616) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8618), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8619), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8618) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8620) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8622), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8622) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8623), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8624), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8624) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8625), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8626), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8625) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8627), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8628), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8627) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8655), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8656), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8657), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8658), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8659), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8660), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8659) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8661), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8663), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8664), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8665), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8666), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8667), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8668), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8669), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8670), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8671), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8672), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8673), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8674), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8675), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8676), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8677), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8678), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8679), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8680), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8682), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 3, 6, 23, 27, 12, 886, DateTimeKind.Utc).AddTicks(8683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 887, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 887, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 890, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7843), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7844), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7844) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7847), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7848), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7847) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7850), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7850), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7852), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7853), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7853) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7854), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7855), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7855) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7857), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7858), new DateTime(2025, 3, 6, 23, 27, 12, 904, DateTimeKind.Utc).AddTicks(7858) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(891), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(921), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(923), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(924), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(927), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(928), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(929), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(931), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(932), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(2764));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4891), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4892), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4906), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4906), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4907) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4911), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4911), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4915), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4915), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4918), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4919), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4922), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4923), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4926), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4926), new DateTime(2025, 3, 6, 23, 27, 12, 908, DateTimeKind.Utc).AddTicks(4926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 911, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(6864), new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(6865), new DateTime(2025, 3, 6, 23, 27, 12, 912, DateTimeKind.Utc).AddTicks(6866), new byte[] { 244, 201, 64, 146, 140, 168, 43, 140, 212, 243, 159, 124, 94, 180, 183, 43, 76, 48, 53, 230, 131, 254, 79, 8, 30, 71, 3, 15, 255, 30, 126, 79, 27, 40, 30, 132, 84, 252, 102, 192, 223, 210, 55, 49, 180, 54, 197, 115, 221, 28, 7, 113, 81, 37, 137, 233, 47, 215, 88, 176, 60, 72, 45, 117 }, new byte[] { 21, 67, 225, 82, 185, 33, 170, 230, 27, 220, 76, 248, 95, 216, 53, 222, 83, 249, 125, 141, 124, 113, 70, 40, 53, 170, 58, 37, 128, 31, 72, 208, 145, 47, 238, 19, 24, 145, 133, 75, 155, 69, 66, 198, 161, 11, 159, 55, 54, 62, 110, 215, 40, 45, 115, 83, 118, 116, 175, 242, 87, 127, 46, 245, 32, 149, 251, 5, 44, 170, 54, 200, 95, 195, 137, 36, 32, 78, 200, 214, 48, 97, 139, 131, 22, 78, 10, 229, 76, 212, 228, 181, 111, 155, 153, 250, 120, 221, 146, 183, 81, 243, 111, 249, 31, 56, 240, 175, 20, 238, 172, 108, 55, 78, 60, 55, 143, 155, 102, 50, 240, 204, 115, 174, 14, 29, 97, 206 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8864), new byte[] { 197, 231, 108, 99, 83, 3, 47, 69, 244, 252, 224, 141, 165, 32, 22, 190, 163, 21, 137, 159, 167, 187, 176, 163, 121, 103, 191, 237, 249, 152, 255, 142, 82, 18, 188, 67, 162, 216, 144, 53, 114, 206, 127, 59, 142, 241, 155, 183, 82, 85, 108, 71, 233, 194, 4, 57, 97, 4, 78, 205, 130, 231, 244, 20 }, new byte[] { 42, 45, 74, 168, 255, 159, 193, 112, 218, 103, 28, 19, 213, 104, 100, 53, 181, 151, 253, 186, 139, 92, 53, 42, 249, 160, 136, 50, 122, 193, 49, 194, 171, 7, 80, 76, 85, 11, 221, 68, 194, 72, 161, 145, 79, 63, 15, 33, 173, 60, 35, 82, 245, 141, 82, 65, 142, 236, 48, 107, 133, 134, 27, 19, 241, 250, 30, 47, 67, 132, 156, 242, 29, 220, 209, 155, 175, 4, 15, 95, 14, 129, 237, 59, 135, 168, 110, 29, 6, 155, 173, 223, 8, 208, 124, 137, 134, 15, 173, 228, 91, 254, 183, 214, 58, 100, 219, 141, 62, 203, 29, 13, 190, 204, 30, 253, 230, 46, 128, 211, 227, 146, 154, 42, 118, 193, 80, 183 } });
        }
    }
}
