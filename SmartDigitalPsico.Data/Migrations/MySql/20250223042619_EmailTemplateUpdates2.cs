using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class EmailTemplateUpdates2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TagApi",
                schema: "dbo",
                table: "EmailTemplate",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2094), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2097), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(2097) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3464), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3466), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3468), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3469), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3470), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3471), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3472), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3473), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3474), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3475), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3476), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3477), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3478), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3479), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3488), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3489), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3490), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3491), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3492), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3493), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3497), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3498), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3499), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3500), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3501), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3502), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3504), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3505), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3506), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3507), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3508), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3509), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3513), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3514), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3515), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3516), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3517), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3518), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3522), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3523), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3542), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3543), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3544), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3545), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3546), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3547), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3547) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3548), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3553), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3555), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3556), new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(3556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "TagApi" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4944), new DateTime(2025, 2, 23, 4, 26, 19, 17, DateTimeKind.Utc).AddTicks(4943), "" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 990, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3962), new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3963), new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 18, 997, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9835), new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 2, 23, 4, 26, 19, 0, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 4, 26, 19, 9, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6791), new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6792), new DateTime(2025, 2, 23, 4, 26, 19, 10, DateTimeKind.Utc).AddTicks(6793), new byte[] { 189, 186, 125, 224, 79, 67, 59, 105, 238, 192, 173, 106, 100, 43, 126, 192, 11, 141, 221, 56, 162, 197, 249, 3, 223, 181, 199, 37, 168, 21, 30, 78, 185, 187, 109, 112, 120, 47, 46, 14, 107, 120, 130, 44, 197, 159, 8, 82, 210, 18, 26, 67, 12, 83, 229, 174, 49, 222, 13, 186, 204, 98, 187, 21 }, new byte[] { 53, 198, 134, 31, 133, 226, 45, 70, 117, 66, 244, 25, 246, 207, 98, 23, 14, 96, 9, 18, 163, 148, 123, 22, 99, 99, 114, 10, 238, 83, 123, 8, 116, 191, 132, 173, 52, 214, 247, 202, 111, 234, 75, 222, 230, 132, 184, 142, 119, 116, 109, 47, 125, 200, 220, 126, 43, 0, 178, 192, 144, 92, 215, 212, 184, 31, 245, 58, 232, 139, 124, 226, 71, 109, 85, 31, 61, 111, 69, 139, 52, 141, 66, 109, 90, 64, 230, 35, 38, 198, 64, 88, 21, 122, 56, 216, 175, 125, 117, 85, 152, 80, 250, 111, 216, 79, 92, 163, 250, 112, 238, 212, 64, 194, 119, 90, 146, 167, 130, 24, 115, 120, 137, 187, 190, 10, 224, 36 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8087), new DateTime(2025, 2, 23, 4, 26, 19, 13, DateTimeKind.Utc).AddTicks(8088), new byte[] { 18, 62, 9, 16, 31, 87, 4, 241, 189, 29, 221, 136, 114, 232, 53, 196, 10, 78, 163, 200, 222, 153, 228, 47, 205, 208, 150, 31, 203, 230, 192, 89, 201, 58, 38, 207, 52, 136, 63, 9, 221, 5, 244, 200, 234, 205, 178, 82, 191, 223, 112, 176, 123, 200, 167, 55, 47, 220, 15, 235, 219, 194, 17, 112 }, new byte[] { 141, 108, 0, 187, 65, 32, 49, 119, 117, 207, 70, 99, 56, 65, 150, 166, 154, 244, 49, 128, 13, 100, 198, 198, 188, 9, 188, 201, 77, 98, 2, 173, 29, 247, 25, 85, 76, 176, 180, 62, 212, 215, 189, 245, 220, 88, 229, 102, 183, 160, 21, 172, 231, 113, 156, 214, 48, 203, 136, 125, 204, 132, 155, 7, 229, 165, 143, 4, 133, 213, 238, 117, 89, 70, 92, 106, 58, 139, 239, 151, 229, 160, 41, 69, 9, 169, 128, 203, 61, 133, 253, 95, 155, 75, 141, 212, 212, 196, 178, 86, 120, 168, 225, 189, 53, 108, 176, 2, 210, 219, 154, 41, 188, 111, 141, 58, 114, 203, 204, 187, 223, 157, 145, 198, 32, 17, 54, 252 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TagApi",
                schema: "dbo",
                table: "EmailTemplate");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2296), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3886), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3887), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3890), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3891), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3892), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3893), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3898), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3899), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3900), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3902), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3903), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3939), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3940), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3941), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3942), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3943), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3944), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3948), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3949), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3951), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3952), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3953), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3954), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3955), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3957), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3958), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3959), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3961), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3962), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3963), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3964), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3968), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3969), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3970), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3971), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3972), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3973), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3977), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3978), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3982), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(139), new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2389), new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2391), new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5503), new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5504), new byte[] { 122, 58, 243, 95, 239, 142, 159, 9, 46, 36, 246, 114, 101, 89, 236, 110, 215, 211, 169, 70, 177, 25, 90, 169, 115, 215, 141, 189, 150, 217, 170, 16, 43, 142, 148, 8, 66, 58, 242, 169, 79, 11, 47, 94, 209, 109, 152, 203, 133, 110, 85, 60, 185, 249, 117, 36, 178, 83, 17, 239, 45, 177, 153, 26 }, new byte[] { 198, 117, 146, 194, 119, 21, 223, 2, 199, 172, 142, 173, 173, 59, 141, 192, 25, 231, 18, 43, 93, 69, 87, 15, 227, 169, 24, 172, 5, 234, 33, 226, 212, 49, 63, 113, 59, 216, 249, 26, 76, 223, 26, 206, 50, 239, 123, 146, 98, 0, 170, 206, 63, 171, 237, 126, 83, 163, 11, 84, 223, 86, 133, 134, 198, 201, 243, 121, 178, 202, 43, 235, 202, 133, 188, 188, 215, 22, 11, 181, 7, 159, 36, 101, 19, 226, 33, 20, 248, 175, 197, 210, 65, 138, 118, 184, 177, 211, 145, 218, 17, 27, 58, 215, 78, 125, 242, 240, 216, 40, 98, 169, 239, 241, 216, 205, 45, 41, 97, 243, 67, 162, 191, 109, 60, 186, 172, 221 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8221), new byte[] { 91, 189, 154, 49, 194, 49, 39, 166, 161, 181, 33, 40, 49, 219, 207, 58, 35, 47, 130, 195, 139, 247, 153, 198, 173, 229, 63, 96, 156, 88, 47, 75, 36, 154, 229, 162, 83, 210, 158, 52, 118, 227, 93, 25, 139, 91, 252, 254, 187, 192, 185, 28, 101, 37, 132, 156, 28, 183, 124, 24, 101, 204, 95, 57 }, new byte[] { 185, 91, 137, 204, 156, 194, 2, 115, 9, 21, 84, 57, 76, 156, 35, 121, 113, 184, 81, 176, 15, 74, 121, 52, 67, 153, 94, 187, 165, 42, 154, 0, 92, 179, 164, 26, 95, 47, 28, 172, 5, 153, 132, 90, 33, 92, 49, 112, 9, 82, 113, 91, 209, 116, 154, 1, 104, 55, 39, 93, 74, 79, 104, 186, 223, 83, 168, 170, 131, 121, 153, 181, 52, 196, 50, 89, 158, 18, 62, 152, 159, 182, 6, 183, 41, 165, 164, 227, 210, 75, 185, 84, 23, 98, 243, 254, 87, 137, 152, 119, 162, 153, 89, 119, 233, 208, 42, 143, 104, 160, 4, 235, 13, 199, 74, 97, 97, 252, 200, 235, 200, 149, 165, 105, 228, 0, 223, 35 } });
        }
    }
}
