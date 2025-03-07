using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationTemplateV2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "NotificationTemplateType",
                schema: "dbo",
                table: "NotificationTemplate",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);

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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "Name", "PatientIntervalTimeMinutes" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 3, 6, 23, 27, 12, 897, DateTimeKind.Utc).AddTicks(1460), "Dr. Gabriel Monteiro", (byte)60 });

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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(890), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(891), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(891), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(921), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(921), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(923), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(924), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(924), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(926), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(927), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(928), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(928), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(929), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(930), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(930), (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "NotificationTemplateType" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(931), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(932), new DateTime(2025, 3, 6, 23, 27, 12, 905, DateTimeKind.Utc).AddTicks(932), (byte)0 });

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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "Name", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8863), new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8864), new DateTime(2025, 3, 6, 23, 27, 12, 914, DateTimeKind.Utc).AddTicks(8864), "Dr. Gabriel Monteiro", new byte[] { 197, 231, 108, 99, 83, 3, 47, 69, 244, 252, 224, 141, 165, 32, 22, 190, 163, 21, 137, 159, 167, 187, 176, 163, 121, 103, 191, 237, 249, 152, 255, 142, 82, 18, 188, 67, 162, 216, 144, 53, 114, 206, 127, 59, 142, 241, 155, 183, 82, 85, 108, 71, 233, 194, 4, 57, 97, 4, 78, 205, 130, 231, 244, 20 }, new byte[] { 42, 45, 74, 168, 255, 159, 193, 112, 218, 103, 28, 19, 213, 104, 100, 53, 181, 151, 253, 186, 139, 92, 53, 42, 249, 160, 136, 50, 122, 193, 49, 194, 171, 7, 80, 76, 85, 11, 221, 68, 194, 72, 161, 145, 79, 63, 15, 33, 173, 60, 35, 82, 245, 141, 82, 65, 142, 236, 48, 107, 133, 134, 27, 19, 241, 250, 30, 47, 67, 132, 156, 242, 29, 220, 209, 155, 175, 4, 15, 95, 14, 129, 237, 59, 135, 168, 110, 29, 6, 155, 173, 223, 8, 208, 124, 137, 134, 15, 173, 228, 91, 254, 183, 214, 58, 100, 219, 141, 62, 203, 29, 13, 190, 204, 30, 253, 230, 46, 128, 211, 227, 146, 154, 42, 118, 193, 80, 183 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NotificationTemplateType",
                schema: "dbo",
                table: "NotificationTemplate");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(2561), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7969), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7971), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7972), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7973), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7974), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7975), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7976), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7977), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7978), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7979), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7980), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7981), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7982), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7983), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7984), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7986), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7986), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7987), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7988), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7989), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7990), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7991), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7992), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7993), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7994), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7995), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7996), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7997), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7997), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(7999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8000), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8001), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8002), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8003), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8004), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8005), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8006), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8007), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8008), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8008) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8010), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8011), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8012), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8013), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8014), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8015), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8016), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8017), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8018), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8019), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8021), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8021), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8022), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8023), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8023) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8024), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8025), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8025) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8026), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8027), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8028), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8029), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8030), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8030), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8032), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8032), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8033), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8034), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8035), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8036), new DateTime(2025, 3, 6, 23, 15, 4, 678, DateTimeKind.Utc).AddTicks(8036) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 679, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 679, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6602));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 682, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "Name", "PatientIntervalTimeMinutes" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9160), new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9161), new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9161), "Medical MOCK ", (byte)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4725), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4726), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4727), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4732), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7297), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7298), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7298) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7300), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7302), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7307), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7308) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7309), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7310) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2968), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2970), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2989), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2994), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2994), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2998), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(2998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3002), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3002), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3006), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3006), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3009), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3010), new DateTime(2025, 3, 6, 23, 15, 4, 700, DateTimeKind.Utc).AddTicks(3010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2684));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2687));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 15, 4, 703, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 704, DateTimeKind.Utc).AddTicks(3774), new DateTime(2025, 3, 6, 23, 15, 4, 704, DateTimeKind.Utc).AddTicks(3775), new DateTime(2025, 3, 6, 23, 15, 4, 704, DateTimeKind.Utc).AddTicks(3775), new byte[] { 27, 58, 207, 207, 121, 41, 255, 161, 73, 52, 21, 66, 130, 214, 216, 235, 151, 208, 109, 57, 45, 128, 161, 7, 236, 137, 228, 67, 207, 168, 69, 86, 11, 98, 215, 8, 242, 218, 235, 48, 131, 178, 28, 213, 148, 48, 44, 148, 161, 0, 22, 139, 232, 111, 3, 136, 227, 16, 120, 194, 120, 229, 143, 123 }, new byte[] { 95, 172, 18, 174, 247, 8, 162, 21, 125, 174, 228, 98, 122, 19, 246, 162, 208, 140, 60, 48, 155, 12, 40, 138, 179, 73, 47, 96, 81, 76, 40, 170, 180, 77, 196, 80, 139, 87, 25, 248, 119, 127, 30, 47, 13, 235, 47, 64, 156, 32, 91, 206, 186, 208, 26, 50, 108, 249, 156, 191, 243, 42, 140, 22, 29, 68, 234, 128, 61, 15, 43, 165, 206, 66, 172, 123, 79, 200, 66, 196, 236, 21, 108, 89, 223, 72, 153, 228, 6, 192, 183, 14, 217, 138, 93, 59, 41, 195, 73, 36, 193, 11, 121, 97, 98, 123, 230, 166, 83, 229, 226, 232, 170, 53, 236, 173, 85, 18, 138, 39, 166, 157, 240, 112, 61, 181, 31, 54 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "Name", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5010), "User Medical", new byte[] { 126, 115, 177, 74, 5, 224, 242, 63, 57, 153, 8, 79, 231, 125, 80, 227, 172, 27, 173, 184, 195, 250, 61, 162, 1, 2, 98, 205, 111, 157, 216, 91, 56, 154, 121, 109, 231, 14, 97, 35, 203, 119, 169, 185, 124, 184, 224, 16, 18, 184, 135, 42, 211, 9, 220, 230, 219, 29, 120, 82, 53, 118, 1, 42 }, new byte[] { 126, 79, 141, 235, 190, 253, 255, 132, 251, 192, 103, 246, 226, 108, 45, 101, 134, 24, 211, 174, 30, 249, 228, 136, 67, 168, 72, 194, 179, 159, 174, 94, 102, 70, 124, 193, 63, 41, 193, 83, 253, 79, 169, 249, 242, 185, 226, 111, 226, 122, 96, 72, 230, 128, 48, 238, 76, 223, 28, 119, 148, 237, 28, 126, 184, 72, 132, 251, 105, 177, 109, 31, 214, 249, 64, 52, 1, 148, 94, 246, 13, 114, 138, 214, 44, 39, 131, 156, 2, 169, 69, 255, 178, 163, 96, 30, 107, 61, 55, 66, 106, 157, 248, 171, 79, 14, 203, 101, 213, 6, 36, 94, 90, 243, 124, 101, 94, 8, 172, 55, 214, 152, 135, 182, 230, 162, 46, 143 } });
        }
    }
}
