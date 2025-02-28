using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRules : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationRules",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    IsEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IntervalType = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    IntervalValue = table.Column<int>(type: "int", nullable: false),
                    IsBefore = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ENotificationServiceType = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationRules", x => x.Id);
                })
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

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRules_MedicalId",
                schema: "dbo",
                table: "NotificationRules",
                column: "MedicalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationRules",
                schema: "dbo");

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
        }
    }
}
