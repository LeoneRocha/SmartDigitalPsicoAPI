using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateConfig_01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "FilePath",
                keyValue: null,
                column: "FilePath",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(2083)",
                maxLength: 2083,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2083)",
                oldMaxLength: 2083,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "FileName",
                keyValue: null,
                column: "FileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "FileExtension",
                keyValue: null,
                column: "FileExtension",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FileData",
                schema: "dbo",
                table: "PatientFile",
                type: "longblob",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "FileContentType",
                keyValue: null,
                column: "FileContentType",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileContentType",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "PatientFile",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MedicalFile",
                keyColumn: "FilePath",
                keyValue: null,
                column: "FilePath",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(2083)",
                maxLength: 2083,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2083)",
                oldMaxLength: 2083,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MedicalFile",
                keyColumn: "FileName",
                keyValue: null,
                column: "FileName",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MedicalFile",
                keyColumn: "FileExtension",
                keyValue: null,
                column: "FileExtension",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FileData",
                schema: "dbo",
                table: "MedicalFile",
                type: "longblob",
                nullable: false,
                defaultValue: new byte[0],
                oldClrType: typeof(byte[]),
                oldType: "longblob",
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MedicalFile",
                keyColumn: "FileContentType",
                keyValue: null,
                column: "FileContentType",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "FileContentType",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "MedicalFile",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4285), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4509), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4510), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4511), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4513), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4514), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4516), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4517), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4518), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4519), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4520), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4521), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4522), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4524), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4525), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4526), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4527), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4529), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4530), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4531), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4533), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4534), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4535), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4536), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4537), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4538), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4543), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4545), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4546), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4547), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4550) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4551), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4552), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4552) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4553), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4554), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4555), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4556), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4558), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4559) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4560), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4561), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4561) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4562), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4563), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4564), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4565), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4568) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4569), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4570) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4571), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4572), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4572) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4573), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4574), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4575) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4577) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5047), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5048), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5048) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5402), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5402), new DateTime(2024, 5, 17, 21, 10, 34, 196, DateTimeKind.Utc).AddTicks(5403), new byte[] { 40, 81, 149, 136, 146, 66, 3, 174, 24, 187, 107, 158, 213, 66, 192, 245, 139, 176, 197, 190, 78, 211, 165, 31, 109, 81, 5, 227, 111, 221, 243, 180, 166, 75, 135, 251, 62, 18, 110, 71, 88, 67, 96, 200, 175, 197, 134, 44, 115, 145, 234, 15, 250, 158, 240, 147, 57, 234, 219, 91, 124, 145, 100, 63 }, new byte[] { 20, 236, 213, 214, 25, 41, 228, 250, 201, 108, 85, 80, 92, 99, 4, 37, 146, 128, 152, 38, 161, 136, 121, 255, 39, 239, 28, 117, 235, 41, 65, 226, 226, 252, 74, 112, 139, 218, 76, 16, 238, 2, 70, 38, 68, 80, 1, 160, 47, 254, 243, 127, 173, 99, 70, 23, 104, 100, 226, 170, 168, 129, 114, 15, 125, 89, 129, 117, 141, 221, 138, 89, 182, 152, 251, 221, 196, 187, 85, 175, 91, 16, 164, 50, 129, 101, 232, 62, 232, 20, 83, 207, 89, 75, 183, 3, 195, 130, 51, 240, 158, 30, 193, 217, 97, 123, 112, 180, 145, 13, 4, 212, 184, 212, 42, 108, 198, 224, 198, 99, 25, 181, 33, 41, 67, 13, 137, 41 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6400), new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6401), new DateTime(2024, 5, 17, 21, 10, 34, 198, DateTimeKind.Utc).AddTicks(6401), new byte[] { 32, 55, 201, 105, 148, 233, 94, 195, 37, 131, 12, 27, 120, 146, 20, 201, 234, 101, 52, 2, 65, 178, 48, 149, 11, 166, 231, 7, 126, 215, 167, 254, 48, 148, 125, 255, 44, 86, 91, 51, 222, 82, 117, 91, 185, 193, 195, 82, 29, 119, 199, 61, 85, 21, 92, 170, 241, 250, 16, 184, 129, 32, 67, 245 }, new byte[] { 60, 222, 108, 37, 192, 117, 177, 61, 244, 61, 203, 187, 134, 2, 243, 77, 128, 178, 157, 84, 232, 173, 110, 16, 145, 120, 74, 148, 155, 17, 69, 45, 42, 248, 247, 87, 191, 175, 169, 173, 150, 254, 95, 5, 88, 207, 108, 186, 176, 194, 57, 6, 39, 16, 214, 223, 49, 201, 118, 41, 162, 142, 121, 161, 87, 207, 205, 89, 125, 46, 118, 105, 18, 58, 47, 26, 240, 202, 175, 48, 95, 42, 125, 15, 249, 87, 97, 51, 187, 101, 133, 238, 18, 32, 159, 226, 157, 243, 229, 254, 216, 26, 75, 20, 2, 157, 49, 198, 103, 209, 66, 140, 222, 100, 138, 57, 190, 2, 241, 42, 222, 212, 8, 200, 215, 245, 208, 188 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(2083)",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2083)",
                oldMaxLength: 2083)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FileData",
                schema: "dbo",
                table: "PatientFile",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob");

            migrationBuilder.AlterColumn<string>(
                name: "FileContentType",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "PatientFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(2083)",
                maxLength: 2083,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2083)",
                oldMaxLength: 2083)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "FileName",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "FileExtension",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(3)",
                oldMaxLength: 3)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<byte[]>(
                name: "FileData",
                schema: "dbo",
                table: "MedicalFile",
                type: "longblob",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "longblob");

            migrationBuilder.AlterColumn<string>(
                name: "FileContentType",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "dbo",
                table: "MedicalFile",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6739), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6742), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6741) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6962), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6965), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6968), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6977), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6979), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6982), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6995), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(6999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7001), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7002), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7003) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7038), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7039) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7041), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7042), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7041) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7047) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7048), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7049), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7050), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7051), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7051) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7052), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7053), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7053) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7054), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7055), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7055) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7056), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7057) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7058), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7059), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7060), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7061), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7060) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7062), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7063), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7062) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7064), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7065), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7064) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7300), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7301), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7301) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7396));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7664));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7666));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7669));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 4, 20, 22, 12, 44, 260, DateTimeKind.Utc).AddTicks(7890), new byte[] { 48, 102, 156, 40, 24, 42, 10, 13, 168, 133, 239, 28, 223, 76, 106, 9, 167, 164, 145, 32, 63, 211, 239, 124, 2, 193, 251, 88, 195, 96, 70, 62, 91, 112, 11, 198, 254, 113, 204, 141, 140, 222, 191, 176, 133, 199, 254, 199, 189, 27, 67, 39, 77, 11, 75, 244, 213, 80, 143, 163, 178, 242, 222, 203 }, new byte[] { 80, 116, 215, 198, 74, 250, 129, 182, 21, 91, 53, 7, 249, 131, 141, 134, 62, 79, 74, 102, 129, 164, 5, 216, 85, 200, 240, 230, 144, 3, 164, 197, 171, 18, 2, 185, 61, 104, 23, 160, 152, 94, 195, 101, 40, 240, 134, 88, 168, 121, 186, 161, 39, 150, 3, 59, 13, 216, 63, 231, 166, 249, 142, 165, 106, 247, 200, 57, 123, 96, 207, 245, 212, 145, 241, 49, 34, 184, 175, 67, 190, 49, 227, 23, 121, 200, 4, 12, 1, 156, 77, 240, 197, 32, 123, 175, 29, 212, 81, 185, 242, 124, 4, 34, 212, 1, 236, 150, 237, 219, 54, 214, 28, 22, 141, 71, 34, 124, 128, 15, 244, 243, 144, 71, 40, 174, 218, 220 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 20, 22, 12, 44, 262, DateTimeKind.Utc).AddTicks(8895), new byte[] { 58, 204, 104, 212, 99, 234, 183, 251, 247, 20, 63, 107, 158, 244, 54, 15, 129, 219, 197, 175, 111, 224, 90, 143, 155, 56, 239, 147, 12, 235, 29, 234, 50, 43, 178, 129, 51, 50, 154, 135, 35, 140, 238, 117, 144, 240, 19, 187, 204, 236, 17, 184, 181, 53, 5, 69, 18, 246, 251, 56, 161, 127, 234, 203 }, new byte[] { 159, 235, 88, 217, 15, 119, 14, 38, 64, 79, 111, 251, 167, 117, 7, 242, 1, 53, 208, 185, 227, 255, 134, 81, 15, 41, 222, 135, 161, 37, 238, 64, 239, 14, 205, 209, 32, 127, 40, 24, 25, 133, 121, 76, 92, 160, 159, 60, 250, 69, 255, 236, 119, 115, 62, 184, 242, 247, 190, 207, 14, 77, 38, 209, 9, 168, 91, 113, 116, 74, 193, 29, 50, 236, 153, 25, 150, 165, 96, 162, 239, 141, 124, 14, 159, 112, 65, 80, 124, 231, 102, 27, 30, 47, 45, 62, 176, 229, 144, 0, 203, 156, 227, 16, 212, 97, 117, 39, 199, 233, 239, 20, 174, 156, 190, 227, 138, 76, 225, 242, 210, 242, 190, 205, 4, 27, 248, 146 } });
        }
    }
}
