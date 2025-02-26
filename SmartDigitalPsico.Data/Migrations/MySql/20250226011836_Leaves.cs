using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class Leaves : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "MedicalSettings",
                newName: "MedicalSettings",
                newSchema: "dbo");

            migrationBuilder.AlterTable(
                name: "MedicalSettings",
                schema: "dbo")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<DateTime>(
                name: "GoogleTokenExpiry",
                schema: "dbo",
                table: "MedicalSettings",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleRefreshToken",
                schema: "dbo",
                table: "MedicalSettings",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleCalendarId",
                schema: "dbo",
                table: "MedicalSettings",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleAccessToken",
                schema: "dbo",
                table: "MedicalSettings",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "latin1")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<long>(
                name: "MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Leaves",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IsRecurring = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leaves_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 90, DateTimeKind.Utc).AddTicks(5291), new DateTime(2025, 2, 26, 1, 18, 36, 90, DateTimeKind.Utc).AddTicks(5295), new DateTime(2025, 2, 26, 1, 18, 36, 90, DateTimeKind.Utc).AddTicks(5294) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(513), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(514), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(516), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(517), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(518), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(519), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(520), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(521), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(522), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(522) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(524), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(524) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(525), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(526), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(527), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(528), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(529), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(530), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(529) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(531), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(531), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(531) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(533), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(533), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(533) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(534), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(535), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(536), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(537), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(536) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(538), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(539), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(538) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(540), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(540), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(542), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(542), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(542) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(543), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(544), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(544) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(545), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(546), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(547), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(548), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(549), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(551), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(552), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(553), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(554), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(555), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(556), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(557), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(558), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(559), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(560), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(560), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(561), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(562), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(563), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(564), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(565), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(566), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(565) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(567), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(568), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(569), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(569), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(569) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(570), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(571), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(572), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(573), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(574), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(575), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(574) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(576), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(576), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(576) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(578), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(578), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(579), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(580), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(581), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(582), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(581) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(583), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(584), new DateTime(2025, 2, 26, 1, 18, 36, 91, DateTimeKind.Utc).AddTicks(583) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 92, DateTimeKind.Utc).AddTicks(1085), new DateTime(2025, 2, 26, 1, 18, 36, 92, DateTimeKind.Utc).AddTicks(1086), new DateTime(2025, 2, 26, 1, 18, 36, 92, DateTimeKind.Utc).AddTicks(1086) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 92, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 92, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 101, DateTimeKind.Utc).AddTicks(7134), new DateTime(2025, 2, 26, 1, 18, 36, 101, DateTimeKind.Utc).AddTicks(7135), new DateTime(2025, 2, 26, 1, 18, 36, 101, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 103, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 103, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 103, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 107, DateTimeKind.Utc).AddTicks(1520), new DateTime(2025, 2, 26, 1, 18, 36, 107, DateTimeKind.Utc).AddTicks(1521), new DateTime(2025, 2, 26, 1, 18, 36, 107, DateTimeKind.Utc).AddTicks(1522) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8025));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 26, 1, 18, 36, 110, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 111, DateTimeKind.Utc).AddTicks(3363), new DateTime(2025, 2, 26, 1, 18, 36, 111, DateTimeKind.Utc).AddTicks(3364), new DateTime(2025, 2, 26, 1, 18, 36, 111, DateTimeKind.Utc).AddTicks(3365), new byte[] { 205, 114, 184, 224, 209, 232, 99, 15, 107, 205, 233, 132, 162, 233, 149, 17, 124, 185, 226, 47, 20, 25, 122, 47, 172, 35, 128, 235, 68, 228, 130, 23, 99, 213, 249, 227, 56, 187, 69, 170, 217, 143, 6, 34, 212, 93, 65, 38, 60, 2, 204, 153, 144, 107, 135, 150, 118, 158, 91, 207, 158, 211, 233, 193 }, new byte[] { 32, 36, 54, 174, 179, 3, 255, 129, 247, 151, 100, 53, 198, 206, 57, 32, 242, 20, 244, 57, 65, 21, 41, 151, 141, 68, 7, 4, 224, 204, 67, 255, 118, 221, 177, 242, 84, 73, 49, 249, 133, 37, 110, 196, 7, 45, 41, 109, 97, 205, 158, 207, 253, 99, 82, 120, 46, 156, 246, 37, 226, 120, 55, 37, 211, 40, 153, 147, 42, 102, 199, 248, 201, 165, 185, 207, 11, 181, 105, 106, 171, 51, 69, 64, 114, 73, 18, 246, 252, 227, 60, 87, 96, 115, 194, 35, 201, 211, 102, 98, 233, 200, 164, 165, 38, 190, 1, 68, 97, 210, 18, 232, 157, 92, 216, 206, 191, 188, 109, 17, 195, 74, 243, 53, 67, 82, 209, 32 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 26, 1, 18, 36, 113, DateTimeKind.Utc).AddTicks(4653), new DateTime(2025, 2, 26, 1, 18, 36, 113, DateTimeKind.Utc).AddTicks(4653), new DateTime(2025, 2, 26, 1, 18, 36, 113, DateTimeKind.Utc).AddTicks(4654), new byte[] { 27, 185, 49, 44, 251, 93, 13, 27, 190, 212, 147, 225, 80, 24, 131, 85, 71, 109, 71, 6, 89, 138, 81, 250, 135, 190, 91, 47, 114, 254, 50, 199, 62, 53, 221, 246, 144, 33, 80, 104, 92, 178, 169, 227, 62, 224, 222, 98, 38, 90, 84, 8, 34, 143, 64, 14, 131, 90, 196, 76, 224, 136, 205, 68 }, new byte[] { 0, 39, 149, 121, 20, 240, 109, 126, 136, 6, 145, 170, 77, 3, 217, 79, 160, 19, 85, 239, 30, 94, 94, 164, 251, 167, 31, 219, 255, 176, 168, 28, 92, 184, 191, 103, 229, 69, 80, 89, 228, 255, 8, 42, 172, 2, 143, 142, 103, 17, 102, 27, 146, 24, 74, 131, 52, 27, 125, 201, 46, 251, 240, 135, 217, 220, 177, 70, 248, 37, 93, 181, 141, 135, 231, 48, 104, 37, 96, 132, 124, 218, 201, 215, 75, 120, 14, 245, 22, 15, 45, 143, 87, 71, 136, 200, 0, 30, 53, 210, 172, 149, 55, 43, 69, 70, 214, 6, 162, 3, 244, 200, 114, 63, 38, 91, 17, 41, 84, 212, 62, 178, 56, 67, 151, 38, 94, 70 } });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSettings_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId1");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_MedicalId",
                schema: "dbo",
                table: "Leaves",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_StartDate_EndDate",
                schema: "dbo",
                table: "Leaves",
                columns: new[] { "StartDate", "EndDate" });

            migrationBuilder.AddForeignKey(
                name: "FK_MedicalSettings_Medical_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings",
                column: "MedicalId1",
                principalSchema: "dbo",
                principalTable: "Medical",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicalSettings_Medical_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");

            migrationBuilder.DropTable(
                name: "Leaves",
                schema: "dbo");

            migrationBuilder.DropIndex(
                name: "IX_MedicalSettings_MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");

            migrationBuilder.DropColumn(
                name: "MedicalId1",
                schema: "dbo",
                table: "MedicalSettings");

            migrationBuilder.RenameTable(
                name: "MedicalSettings",
                schema: "dbo",
                newName: "MedicalSettings");

            migrationBuilder.AlterTable(
                name: "MedicalSettings")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "GoogleTokenExpiry",
                table: "MedicalSettings",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleRefreshToken",
                table: "MedicalSettings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleCalendarId",
                table: "MedicalSettings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.AlterColumn<string>(
                name: "GoogleAccessToken",
                table: "MedicalSettings",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1039), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1042), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(1042) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2631), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2632), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2634), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2635), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2634) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2636), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2637), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2638), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2639), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2638) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2640) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2642) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2643), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2644), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2645), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2646), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2647), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2648), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2649), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2650), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2649) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2651) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2653) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2654), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2655), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2656), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2657), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2658), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2659), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2660), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2661), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2662) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2665), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2666), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2667), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2668), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2669), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2670), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2669) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2671), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2671) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2703), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2704), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2705) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2708), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2709), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2710), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2711), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2710) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2712), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2713), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2712) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2716) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2717), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2718), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2719), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2720), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2721), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2722), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2723), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2724), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2723) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2725) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2726), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2727), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2728), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2729), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2730), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2731), new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(2731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 2, 23, 17, 48, 54, 139, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(3611));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 115, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 2, 23, 17, 48, 54, 122, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 123, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8181), new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8182), new DateTime(2025, 2, 23, 17, 48, 54, 126, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(2802));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(7998), new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(7999), new DateTime(2025, 2, 23, 17, 48, 54, 129, DateTimeKind.Utc).AddTicks(8000), new byte[] { 156, 6, 237, 178, 136, 153, 22, 116, 205, 10, 228, 134, 247, 7, 83, 144, 198, 163, 200, 9, 24, 166, 115, 88, 147, 117, 52, 44, 205, 72, 169, 70, 235, 118, 51, 128, 221, 175, 79, 8, 55, 184, 53, 207, 41, 230, 50, 77, 11, 171, 37, 175, 22, 235, 156, 44, 245, 210, 125, 206, 203, 171, 26, 57 }, new byte[] { 188, 219, 239, 212, 192, 91, 91, 98, 87, 75, 3, 184, 166, 25, 9, 70, 49, 175, 223, 28, 194, 198, 125, 159, 54, 159, 26, 83, 104, 175, 200, 196, 63, 60, 158, 239, 163, 97, 173, 10, 232, 95, 63, 181, 145, 151, 190, 208, 152, 12, 12, 238, 254, 5, 8, 2, 212, 67, 195, 156, 233, 152, 37, 61, 89, 57, 168, 143, 218, 180, 4, 47, 97, 143, 93, 119, 29, 245, 71, 32, 148, 149, 189, 61, 241, 118, 117, 49, 99, 252, 227, 198, 106, 86, 120, 63, 157, 81, 80, 44, 68, 119, 223, 198, 192, 30, 223, 159, 169, 191, 9, 5, 128, 45, 87, 139, 203, 40, 63, 165, 212, 65, 42, 221, 106, 104, 216, 150 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(703), new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(705), new DateTime(2025, 2, 23, 17, 48, 54, 132, DateTimeKind.Utc).AddTicks(705), new byte[] { 79, 102, 197, 196, 51, 64, 228, 81, 32, 39, 219, 192, 201, 143, 86, 213, 62, 56, 28, 79, 44, 249, 213, 50, 35, 153, 54, 69, 162, 223, 188, 105, 203, 47, 31, 12, 242, 56, 2, 199, 239, 148, 251, 151, 205, 235, 175, 136, 45, 74, 127, 39, 102, 205, 107, 250, 173, 140, 162, 137, 29, 121, 22, 81 }, new byte[] { 178, 179, 167, 11, 14, 16, 74, 131, 0, 212, 240, 252, 125, 209, 236, 21, 18, 87, 244, 2, 161, 47, 19, 85, 196, 217, 157, 77, 192, 24, 59, 192, 207, 29, 219, 157, 158, 104, 155, 129, 131, 169, 195, 56, 1, 168, 177, 16, 149, 22, 93, 96, 152, 199, 97, 205, 155, 119, 47, 88, 70, 243, 126, 24, 204, 40, 107, 43, 24, 35, 64, 118, 103, 123, 207, 204, 46, 27, 184, 8, 107, 126, 182, 97, 84, 154, 48, 227, 128, 91, 9, 206, 198, 92, 196, 30, 198, 167, 208, 79, 104, 182, 146, 204, 36, 129, 161, 102, 188, 141, 43, 248, 48, 120, 233, 60, 206, 72, 8, 205, 157, 184, 133, 56, 2, 16, 156, 187 } });
        }
    }
}
