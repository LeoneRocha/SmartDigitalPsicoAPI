using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationRecords",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalCalendarId = table.Column<long>(type: "bigint", nullable: true),
                    NotificationRules = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                        column: x => x.MedicalCalendarId,
                        principalSchema: "dbo",
                        principalTable: "MedicalCalendar",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2809), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(2812) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7894), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7896), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7896) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7897), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7898), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7898) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7905), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7906), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7907), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7908), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7909), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7910), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7909) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7911), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7912), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7911) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7916), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7917), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7918), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7919), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7920), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7921), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7922), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7923), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7922) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7927), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7928), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7929), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7930), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7931), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7932), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7933), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7934), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7935) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7938), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7939), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7940), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7941), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7942), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7943), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7944), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7945), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7944) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7946) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7949), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7950), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7950) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7951), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7952), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7953), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7954), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7955) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7957) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7958), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7959), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7960), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7961), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7962), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7963), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7964), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7965), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7966), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7967), new DateTime(2025, 3, 1, 16, 19, 37, 874, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8526), new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8527), new DateTime(2025, 3, 1, 16, 19, 37, 875, DateTimeKind.Utc).AddTicks(8527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 876, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 876, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2156), new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2157), new DateTime(2025, 3, 1, 16, 19, 37, 885, DateTimeKind.Utc).AddTicks(2158) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 892, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4772), new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4773), new DateTime(2025, 3, 1, 16, 19, 37, 895, DateTimeKind.Utc).AddTicks(4774) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 898, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 1, 16, 19, 37, 899, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(603), new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(604), new DateTime(2025, 3, 1, 16, 19, 37, 900, DateTimeKind.Utc).AddTicks(605), new byte[] { 50, 111, 107, 89, 62, 206, 44, 29, 25, 243, 49, 174, 183, 250, 24, 98, 137, 144, 161, 156, 144, 4, 179, 249, 171, 74, 157, 197, 178, 6, 67, 162, 192, 118, 11, 105, 224, 68, 186, 241, 204, 212, 43, 72, 67, 11, 145, 117, 94, 51, 217, 128, 135, 92, 162, 176, 17, 21, 81, 162, 58, 35, 142, 66 }, new byte[] { 65, 34, 62, 220, 82, 201, 199, 170, 114, 168, 18, 87, 64, 219, 68, 141, 160, 113, 88, 125, 137, 220, 33, 174, 117, 85, 163, 241, 247, 22, 140, 129, 153, 211, 133, 98, 140, 236, 226, 166, 5, 63, 36, 65, 8, 36, 15, 54, 181, 204, 69, 221, 163, 196, 24, 140, 44, 125, 67, 196, 100, 167, 213, 156, 0, 56, 185, 87, 173, 20, 162, 49, 122, 89, 114, 84, 60, 131, 68, 183, 138, 115, 71, 203, 127, 246, 107, 220, 168, 64, 118, 120, 155, 5, 242, 69, 72, 204, 42, 230, 78, 35, 239, 2, 10, 3, 170, 224, 115, 206, 167, 146, 174, 184, 234, 169, 185, 34, 218, 249, 129, 91, 230, 164, 93, 116, 48, 158 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7538), new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7539), new DateTime(2025, 3, 1, 16, 19, 37, 902, DateTimeKind.Utc).AddTicks(7539), new byte[] { 228, 165, 115, 56, 235, 83, 168, 242, 145, 139, 80, 183, 240, 47, 53, 207, 140, 134, 171, 175, 189, 3, 32, 219, 111, 92, 14, 209, 211, 46, 207, 212, 223, 219, 112, 240, 254, 215, 128, 126, 89, 55, 239, 28, 91, 86, 27, 29, 141, 166, 187, 196, 11, 208, 63, 216, 69, 209, 157, 33, 208, 111, 31, 201 }, new byte[] { 206, 8, 179, 49, 210, 130, 162, 77, 203, 74, 13, 247, 113, 101, 62, 26, 123, 165, 185, 174, 64, 86, 134, 132, 147, 244, 114, 121, 51, 49, 225, 237, 180, 32, 6, 23, 200, 54, 61, 176, 144, 181, 126, 202, 132, 62, 140, 199, 56, 245, 126, 31, 163, 230, 158, 119, 119, 180, 26, 79, 175, 111, 116, 11, 214, 168, 199, 181, 213, 83, 40, 60, 121, 93, 32, 195, 45, 188, 214, 34, 105, 78, 121, 85, 44, 226, 139, 191, 67, 246, 94, 222, 227, 170, 242, 192, 150, 173, 7, 192, 211, 64, 150, 149, 61, 26, 136, 0, 154, 205, 204, 230, 173, 126, 94, 32, 194, 16, 29, 180, 201, 114, 13, 210, 31, 29, 153, 209 } });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationRecords",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(851), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(860), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7133), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7134), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7136), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7137), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7138), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7139), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7138) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7140), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7141), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7144) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7145), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7146), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7146) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7147), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7148), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7148) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7149), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7150), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7155) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7156), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7157), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7158), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7159), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7159) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7160), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7161), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7162) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7166) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7167), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7168), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7168) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7169), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7170), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7169) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7171), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7172), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7171) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7205) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7206), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7207), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7207) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7208), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7209), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7209) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7210), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7211), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7210) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7212), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7213), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7212) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7214) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7216) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7217), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7218), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7219), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7220), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7219) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7221), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7222), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7221) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7223) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7224), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7225), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7225) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7226), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7227), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7226) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7228), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7229), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7228) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7230) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7232) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7233), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7234), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7234) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7235), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7236), new DateTime(2025, 2, 28, 0, 21, 56, 2, DateTimeKind.Utc).AddTicks(7236) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9328), new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9330), new DateTime(2025, 2, 28, 0, 21, 56, 3, DateTimeKind.Utc).AddTicks(9329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 4, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 4, DateTimeKind.Utc).AddTicks(1239));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 2, 28, 0, 21, 56, 14, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2962));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2964));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 19, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8435), new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8436), new DateTime(2025, 2, 28, 0, 21, 56, 22, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 28, 0, 21, 56, 26, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2811), new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2812), new DateTime(2025, 2, 28, 0, 21, 56, 27, DateTimeKind.Utc).AddTicks(2813), new byte[] { 53, 173, 17, 222, 137, 228, 156, 215, 220, 46, 7, 193, 250, 166, 146, 114, 98, 114, 250, 48, 140, 155, 216, 133, 151, 188, 87, 91, 155, 72, 75, 123, 244, 244, 241, 148, 35, 137, 53, 13, 174, 127, 116, 35, 120, 114, 3, 188, 252, 159, 254, 73, 124, 86, 128, 160, 209, 211, 223, 74, 108, 58, 47, 194 }, new byte[] { 190, 162, 234, 180, 25, 192, 168, 119, 57, 127, 168, 176, 120, 113, 53, 1, 131, 45, 235, 174, 141, 36, 209, 84, 96, 49, 101, 45, 190, 220, 71, 190, 159, 60, 159, 14, 42, 119, 120, 113, 126, 57, 70, 221, 153, 46, 114, 41, 157, 168, 222, 240, 175, 84, 158, 207, 117, 186, 17, 150, 107, 5, 49, 249, 216, 182, 94, 69, 93, 141, 64, 147, 3, 123, 227, 23, 122, 0, 230, 41, 145, 152, 14, 205, 122, 140, 96, 81, 243, 167, 180, 88, 64, 111, 3, 38, 89, 242, 72, 175, 150, 9, 119, 131, 133, 76, 148, 149, 154, 80, 77, 222, 49, 7, 160, 114, 17, 45, 170, 17, 191, 3, 13, 203, 210, 82, 201, 197 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 2, 28, 0, 21, 56, 29, DateTimeKind.Utc).AddTicks(3991), new byte[] { 154, 89, 59, 114, 120, 43, 41, 80, 220, 0, 136, 152, 46, 66, 136, 134, 113, 109, 150, 9, 57, 4, 64, 71, 20, 113, 24, 2, 95, 1, 220, 67, 139, 110, 171, 48, 231, 199, 218, 56, 158, 162, 172, 122, 227, 39, 28, 169, 35, 76, 39, 230, 197, 219, 34, 123, 1, 68, 211, 80, 137, 106, 243, 39 }, new byte[] { 177, 224, 32, 101, 86, 1, 200, 235, 175, 192, 114, 83, 230, 116, 26, 31, 237, 4, 45, 135, 130, 226, 234, 243, 190, 134, 184, 53, 103, 13, 243, 70, 30, 166, 221, 109, 4, 252, 129, 109, 133, 44, 243, 198, 24, 149, 82, 109, 150, 199, 133, 36, 225, 215, 140, 210, 57, 87, 83, 56, 131, 142, 33, 54, 196, 211, 224, 45, 196, 190, 250, 192, 227, 250, 172, 169, 253, 136, 162, 41, 48, 98, 83, 168, 214, 0, 151, 47, 120, 222, 84, 248, 62, 74, 80, 251, 24, 198, 87, 254, 215, 196, 69, 190, 226, 130, 47, 55, 82, 93, 110, 10, 186, 225, 96, 210, 98, 176, 237, 149, 99, 239, 75, 104, 177, 133, 65, 169 } });
        }
    }
}
