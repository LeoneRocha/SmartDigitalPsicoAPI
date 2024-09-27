using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .Annotation("Relational:ColumnOrder", 0)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastAccessDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .Annotation("Relational:ColumnOrder", 0)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastAccessDate",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4228), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4231), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4231) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4491), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4492), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4495), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4496), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4497), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4498), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4502), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4503), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4504), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4506), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4522), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4537), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4540), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4547), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4549), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4556), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4558), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4562), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4571), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4578), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4579), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4580), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4886), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4887), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(4888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5152), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5153), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5548), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5549), new DateTime(2024, 9, 26, 1, 34, 45, 608, DateTimeKind.Utc).AddTicks(5549), new byte[] { 80, 232, 90, 64, 28, 253, 160, 195, 126, 250, 157, 211, 209, 147, 252, 169, 95, 214, 249, 181, 78, 253, 102, 230, 194, 123, 226, 71, 64, 147, 41, 124, 129, 0, 20, 58, 137, 0, 33, 180, 241, 32, 5, 255, 72, 13, 248, 94, 64, 228, 180, 180, 241, 250, 250, 8, 52, 224, 9, 121, 164, 124, 73, 31 }, new byte[] { 136, 125, 6, 203, 230, 237, 28, 39, 107, 107, 16, 138, 91, 167, 30, 179, 248, 193, 237, 142, 170, 180, 23, 94, 132, 203, 211, 170, 16, 104, 184, 54, 17, 128, 69, 254, 187, 233, 54, 28, 210, 21, 225, 25, 201, 160, 60, 178, 57, 52, 61, 152, 218, 157, 226, 235, 15, 142, 77, 190, 181, 175, 53, 200, 204, 142, 33, 33, 101, 61, 120, 52, 87, 107, 53, 34, 232, 55, 208, 152, 205, 248, 134, 128, 44, 153, 83, 216, 54, 235, 85, 127, 166, 252, 94, 195, 7, 29, 221, 145, 24, 136, 198, 177, 37, 242, 26, 217, 166, 186, 1, 252, 229, 49, 53, 231, 199, 157, 87, 149, 160, 79, 49, 15, 252, 127, 186, 147 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8186), new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8187), new DateTime(2024, 9, 26, 1, 34, 45, 610, DateTimeKind.Utc).AddTicks(8187), new byte[] { 223, 98, 181, 34, 243, 37, 195, 15, 219, 164, 34, 247, 5, 129, 173, 17, 125, 37, 70, 133, 13, 103, 194, 152, 144, 199, 166, 102, 26, 178, 247, 243, 62, 3, 23, 230, 103, 18, 100, 150, 213, 116, 212, 38, 139, 196, 3, 235, 141, 96, 235, 227, 115, 43, 137, 146, 98, 63, 171, 252, 123, 64, 222, 57 }, new byte[] { 162, 166, 217, 76, 29, 162, 105, 251, 50, 150, 13, 230, 247, 234, 192, 125, 203, 29, 245, 3, 217, 198, 22, 87, 133, 210, 199, 51, 214, 12, 61, 167, 158, 220, 200, 193, 161, 88, 65, 180, 249, 133, 188, 52, 212, 230, 127, 207, 52, 193, 155, 141, 198, 227, 189, 139, 255, 112, 87, 140, 86, 50, 55, 184, 204, 126, 97, 213, 5, 70, 46, 178, 24, 36, 33, 217, 125, 159, 221, 217, 176, 105, 43, 43, 89, 123, 12, 66, 79, 119, 122, 162, 57, 70, 52, 155, 25, 33, 118, 78, 22, 113, 197, 90, 202, 43, 199, 74, 84, 143, 164, 104, 45, 204, 63, 158, 79, 23, 157, 110, 66, 27, 98, 110, 120, 63, 123, 147 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "LastAccessDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.DropColumn(
                name: "LastAccessDate",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "dbo",
                table: "AuditDataEntityLog");

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<bool>(
                name: "Enable",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                schema: "dbo",
                table: "AuditDataEntityLog",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9140), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9143), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9354), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9354) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9357) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9359), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9359) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9362), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9366), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9367), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9371), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9372) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9380), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9381) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9384), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9387), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9387) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9389), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9394), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9394) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9410), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9412), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9411) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9413), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9413) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9415) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9418), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9419), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9420), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9422), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9423), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9422) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9424), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9425), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9424) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9664), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9665), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9775));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9880), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9881), new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9988));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9991));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 845, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(214), new DateTime(2024, 9, 26, 1, 24, 7, 846, DateTimeKind.Utc).AddTicks(214), new byte[] { 43, 90, 72, 136, 185, 4, 179, 148, 9, 192, 146, 179, 122, 240, 200, 72, 217, 247, 240, 16, 87, 178, 46, 60, 242, 245, 233, 146, 252, 136, 95, 36, 80, 219, 213, 92, 28, 88, 198, 1, 11, 129, 84, 231, 241, 10, 8, 153, 171, 231, 236, 118, 112, 131, 172, 246, 232, 202, 126, 217, 162, 7, 199, 108 }, new byte[] { 217, 90, 136, 49, 219, 211, 212, 83, 205, 51, 112, 160, 187, 132, 144, 76, 131, 1, 11, 0, 193, 202, 193, 26, 63, 161, 169, 141, 107, 227, 85, 242, 89, 2, 102, 64, 160, 205, 211, 118, 245, 118, 228, 103, 134, 46, 125, 118, 208, 117, 234, 66, 188, 165, 73, 67, 28, 169, 127, 233, 8, 222, 149, 104, 129, 187, 189, 44, 30, 114, 59, 240, 9, 82, 180, 239, 147, 236, 112, 60, 171, 176, 224, 128, 86, 193, 96, 135, 35, 207, 179, 204, 47, 71, 143, 136, 21, 108, 201, 175, 171, 212, 160, 110, 0, 161, 175, 141, 188, 208, 112, 79, 2, 47, 111, 102, 158, 212, 56, 20, 50, 221, 123, 103, 242, 121, 61, 151 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2171), new DateTime(2024, 9, 26, 1, 24, 7, 848, DateTimeKind.Utc).AddTicks(2172), new byte[] { 41, 112, 42, 185, 7, 76, 41, 48, 238, 32, 240, 115, 197, 186, 3, 39, 26, 64, 151, 73, 218, 200, 56, 116, 145, 94, 111, 208, 221, 219, 8, 80, 129, 14, 109, 56, 157, 114, 156, 172, 80, 171, 206, 130, 213, 91, 24, 91, 94, 24, 143, 111, 248, 154, 148, 54, 163, 243, 96, 27, 83, 227, 118, 224 }, new byte[] { 106, 84, 134, 119, 185, 195, 53, 222, 224, 7, 51, 167, 162, 98, 143, 109, 144, 186, 67, 63, 77, 248, 9, 136, 220, 248, 18, 23, 30, 238, 168, 212, 80, 152, 40, 100, 141, 84, 27, 130, 190, 156, 61, 179, 57, 5, 33, 147, 57, 154, 245, 2, 40, 128, 0, 119, 237, 118, 31, 22, 11, 99, 93, 82, 163, 134, 211, 124, 172, 137, 135, 67, 66, 105, 217, 136, 205, 110, 108, 143, 220, 19, 52, 124, 31, 139, 92, 64, 144, 197, 112, 140, 235, 148, 239, 14, 77, 47, 216, 15, 132, 208, 40, 123, 12, 110, 70, 210, 149, 36, 185, 153, 75, 29, 94, 96, 229, 217, 244, 199, 248, 208, 49, 103, 237, 129, 5, 176 } });
        }
    }
}
