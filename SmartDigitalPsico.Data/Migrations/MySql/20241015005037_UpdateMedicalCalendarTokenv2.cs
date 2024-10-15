using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UpdateMedicalCalendarTokenv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_Title_Inc_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar");

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
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8591), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8594), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(8593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9805), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9805) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9807), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9808), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9807) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9809), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9810), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9809) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9811), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9812), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9811) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9813), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9814), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9818), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9819), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9820), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9821), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9822), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9823), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9825), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9824) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9826), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9827), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9828) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9829), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9830), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9830) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9831), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9832), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9832) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9833), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9834), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9835), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9836), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9835) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9839) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9841), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9841) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9842), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9843), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9844), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9845), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9849), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9851), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9852), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9854), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9860), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9862), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9889), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9891), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9892), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9893), new DateTime(2024, 10, 15, 0, 50, 36, 736, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6819), new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6820), new DateTime(2024, 10, 15, 0, 50, 36, 754, DateTimeKind.Utc).AddTicks(6820) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 737, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 737, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9360));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 743, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7901), new DateTime(2024, 10, 15, 0, 50, 36, 746, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 748, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3935), new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3936), new DateTime(2024, 10, 15, 0, 50, 36, 749, DateTimeKind.Utc).AddTicks(3936), new byte[] { 44, 243, 62, 250, 227, 174, 20, 78, 132, 120, 21, 188, 232, 73, 124, 88, 2, 152, 172, 83, 18, 7, 65, 145, 46, 8, 168, 47, 10, 156, 124, 156, 21, 200, 231, 132, 90, 82, 251, 11, 16, 140, 170, 182, 25, 93, 172, 214, 242, 31, 111, 65, 69, 63, 55, 10, 174, 132, 140, 137, 44, 22, 89, 159 }, new byte[] { 20, 194, 29, 93, 115, 118, 0, 58, 159, 97, 94, 210, 23, 0, 154, 113, 8, 166, 156, 132, 221, 2, 64, 39, 92, 28, 175, 201, 194, 215, 137, 169, 161, 177, 224, 224, 50, 106, 205, 74, 173, 81, 7, 149, 217, 149, 14, 156, 191, 216, 187, 175, 86, 110, 242, 70, 65, 170, 202, 185, 254, 30, 123, 149, 160, 252, 234, 33, 164, 145, 251, 249, 214, 185, 174, 237, 62, 219, 171, 193, 213, 50, 233, 85, 147, 250, 154, 165, 223, 219, 2, 223, 80, 5, 171, 191, 52, 82, 167, 54, 184, 96, 26, 116, 1, 146, 187, 214, 252, 213, 103, 208, 14, 24, 237, 67, 97, 83, 220, 224, 243, 24, 242, 50, 176, 161, 39, 122 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4951), new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4952), new DateTime(2024, 10, 15, 0, 50, 36, 751, DateTimeKind.Utc).AddTicks(4952), new byte[] { 104, 186, 218, 255, 170, 105, 158, 149, 134, 50, 210, 67, 173, 18, 150, 175, 45, 119, 13, 129, 247, 31, 222, 245, 83, 154, 74, 232, 155, 206, 146, 99, 229, 203, 115, 142, 244, 102, 92, 112, 56, 232, 42, 131, 127, 135, 26, 51, 107, 109, 254, 113, 146, 210, 67, 20, 21, 89, 92, 219, 186, 247, 205, 180 }, new byte[] { 52, 233, 172, 248, 112, 42, 10, 212, 236, 154, 95, 133, 10, 139, 66, 162, 142, 134, 189, 118, 241, 69, 61, 238, 242, 197, 160, 250, 211, 105, 33, 109, 9, 148, 121, 132, 143, 30, 174, 17, 200, 111, 72, 242, 192, 27, 189, 198, 194, 53, 52, 31, 124, 63, 224, 190, 153, 57, 233, 77, 74, 91, 74, 73, 64, 198, 52, 122, 119, 199, 118, 37, 77, 164, 92, 245, 183, 239, 46, 133, 201, 225, 153, 119, 106, 196, 7, 215, 18, 115, 163, 53, 109, 177, 147, 43, 207, 60, 78, 115, 86, 26, 229, 172, 77, 178, 211, 71, 181, 202, 18, 170, 99, 215, 226, 132, 178, 188, 12, 47, 206, 33, 207, 93, 252, 113, 75, 173 } });

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_Inc_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "TokenRecurrence");

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                columns: new[] { "TokenRecurrence", "PatientId", "MedicalId", "StartDateTime", "EndDateTime" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Idx_TokenRecurrence_Inc_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar");

            migrationBuilder.DropIndex(
                name: "Idx_TokenRecurrence_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar");

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

            migrationBuilder.CreateIndex(
                name: "Idx_Title_Inc_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "Idx_Title_PatientId_MedicalId_StartDateTime_EndDateTime",
                schema: "dbo",
                table: "MedicalCalendar",
                columns: new[] { "Title", "PatientId", "MedicalId", "StartDateTime", "EndDateTime" });
        }
    }
}
