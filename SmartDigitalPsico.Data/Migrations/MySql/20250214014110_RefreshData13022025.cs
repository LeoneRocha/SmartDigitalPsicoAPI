using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class RefreshData13022025 : Migration
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
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8451), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8454), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9812), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9817), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9819), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9820), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9821), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9822), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9828), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9829), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9830), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9831), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9832), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9833), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9835), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9837), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9844), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9849), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9863), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9866), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9868), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9875), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9878), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9880), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9881), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9883), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9884), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8319), new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 159, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 159, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1516), new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1518), new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7302), new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4715), new byte[] { 0, 111, 14, 25, 223, 39, 19, 195, 27, 162, 189, 60, 187, 245, 98, 186, 212, 176, 14, 3, 186, 252, 107, 74, 205, 5, 86, 247, 120, 188, 159, 38, 201, 185, 208, 85, 147, 49, 160, 192, 0, 214, 93, 212, 85, 231, 238, 235, 126, 30, 182, 208, 243, 120, 225, 201, 26, 59, 103, 1, 46, 243, 161, 66 }, new byte[] { 117, 107, 59, 5, 199, 203, 156, 78, 19, 79, 184, 174, 211, 244, 23, 250, 113, 95, 98, 41, 100, 144, 21, 229, 43, 175, 144, 16, 97, 108, 82, 105, 31, 6, 140, 233, 135, 246, 244, 208, 135, 237, 188, 245, 11, 131, 159, 230, 90, 190, 134, 188, 29, 146, 88, 86, 191, 60, 196, 89, 0, 153, 240, 116, 240, 212, 51, 203, 2, 26, 133, 235, 199, 12, 40, 173, 154, 40, 61, 17, 251, 37, 143, 208, 65, 77, 158, 109, 175, 192, 150, 151, 84, 215, 239, 215, 237, 150, 8, 207, 158, 183, 155, 218, 215, 32, 13, 140, 91, 52, 53, 119, 238, 132, 251, 9, 52, 14, 154, 183, 176, 142, 214, 27, 51, 167, 28, 141 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6469), new byte[] { 203, 199, 175, 122, 115, 202, 221, 154, 191, 240, 48, 205, 55, 85, 94, 178, 233, 76, 253, 26, 9, 137, 76, 158, 21, 106, 47, 54, 82, 54, 134, 117, 122, 111, 130, 42, 248, 237, 214, 78, 231, 217, 1, 63, 5, 176, 14, 103, 43, 56, 95, 140, 183, 231, 154, 231, 230, 129, 237, 147, 24, 104, 94, 144 }, new byte[] { 95, 240, 231, 216, 64, 58, 247, 216, 21, 113, 137, 78, 25, 70, 228, 240, 254, 173, 48, 179, 101, 211, 48, 4, 154, 111, 228, 251, 89, 83, 144, 240, 250, 53, 186, 194, 56, 234, 222, 232, 100, 212, 195, 36, 120, 206, 7, 205, 92, 149, 25, 136, 119, 18, 185, 39, 1, 171, 32, 160, 220, 162, 208, 202, 133, 141, 236, 169, 57, 95, 72, 186, 175, 181, 10, 205, 4, 252, 239, 65, 106, 175, 88, 201, 214, 48, 189, 122, 6, 222, 189, 238, 218, 114, 232, 137, 239, 147, 155, 38, 115, 167, 74, 213, 214, 215, 209, 185, 206, 253, 248, 80, 29, 24, 59, 102, 77, 219, 47, 233, 159, 206, 163, 77, 115, 16, 193, 176 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5866), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5870), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(5869) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7309), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7312) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7313), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7314), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7315), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7316), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7317), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7318), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7319), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7320), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7321), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7322), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7321) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7323), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7324), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7325), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7326), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7325) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7327), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7328), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7332), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7333), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7334), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7335), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7335) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7336), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7337), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7337) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7338), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7339), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7338) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7340), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7341), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7342), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7343), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7342) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7344), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7345), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7344) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7346) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7348) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7352) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7353), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7354), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7355), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7356), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7356) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7357), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7358), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7358) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7359), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7360), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7359) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7361), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7362), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7363), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7364), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7369) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7370), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7371), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7372), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7373), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7374), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7375), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7375) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7376), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7377), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7378), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7379), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380), new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(17), new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(26), new DateTime(2025, 2, 8, 14, 43, 30, 766, DateTimeKind.Utc).AddTicks(25) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 739, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(11), new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(14), new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(14) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4934));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 747, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5661), new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5663), new DateTime(2025, 2, 8, 14, 43, 30, 750, DateTimeKind.Utc).AddTicks(5663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8466));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 8, 14, 43, 30, 752, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3056), new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3057), new DateTime(2025, 2, 8, 14, 43, 30, 753, DateTimeKind.Utc).AddTicks(3057), new byte[] { 69, 160, 89, 71, 45, 232, 92, 185, 21, 25, 131, 253, 159, 56, 199, 219, 50, 214, 50, 19, 123, 7, 92, 195, 23, 248, 250, 221, 162, 39, 111, 169, 33, 36, 73, 120, 169, 103, 152, 54, 143, 234, 180, 45, 132, 134, 219, 183, 94, 96, 174, 29, 87, 2, 26, 248, 192, 20, 134, 72, 139, 70, 177, 16 }, new byte[] { 16, 80, 83, 252, 135, 72, 31, 250, 206, 182, 152, 127, 61, 233, 74, 7, 20, 212, 252, 64, 41, 56, 226, 75, 89, 126, 192, 178, 117, 113, 170, 227, 191, 176, 39, 167, 126, 224, 194, 76, 38, 210, 3, 199, 86, 216, 133, 178, 212, 165, 126, 113, 249, 176, 242, 226, 6, 115, 16, 185, 206, 107, 186, 150, 25, 185, 62, 47, 219, 150, 96, 91, 186, 254, 206, 247, 153, 159, 147, 1, 227, 215, 101, 110, 18, 109, 137, 65, 202, 103, 77, 194, 85, 160, 126, 39, 160, 205, 71, 103, 7, 81, 66, 31, 39, 133, 78, 215, 26, 77, 141, 203, 128, 1, 178, 203, 7, 145, 198, 49, 243, 248, 238, 255, 21, 99, 66, 127 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4334), new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4335), new DateTime(2025, 2, 8, 14, 43, 30, 755, DateTimeKind.Utc).AddTicks(4335), new byte[] { 78, 191, 84, 162, 17, 181, 170, 128, 49, 198, 216, 230, 2, 138, 202, 150, 241, 169, 19, 248, 78, 138, 125, 60, 213, 248, 125, 106, 163, 157, 248, 103, 114, 157, 128, 202, 160, 69, 175, 121, 52, 59, 177, 114, 222, 140, 152, 168, 195, 118, 152, 95, 216, 104, 173, 155, 100, 71, 183, 21, 12, 129, 181, 20 }, new byte[] { 31, 91, 97, 144, 157, 100, 35, 30, 108, 190, 13, 0, 108, 150, 61, 175, 220, 16, 194, 38, 85, 203, 131, 220, 192, 3, 206, 3, 151, 3, 148, 154, 166, 220, 71, 161, 23, 104, 139, 184, 189, 29, 90, 219, 88, 196, 13, 218, 170, 239, 143, 90, 33, 102, 218, 69, 232, 125, 155, 129, 90, 120, 13, 212, 180, 71, 237, 139, 217, 9, 151, 50, 156, 21, 173, 11, 11, 106, 192, 236, 58, 233, 126, 50, 35, 29, 150, 93, 89, 207, 31, 158, 178, 229, 196, 251, 83, 187, 37, 207, 248, 214, 177, 148, 213, 236, 161, 150, 33, 127, 32, 108, 100, 29, 114, 94, 120, 9, 174, 134, 184, 168, 7, 184, 71, 35, 85, 6 } });
        }
    }
}
