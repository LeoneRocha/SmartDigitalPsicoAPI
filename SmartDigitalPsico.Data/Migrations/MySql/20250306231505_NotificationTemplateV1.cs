using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationTemplateV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplate",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "NotificationTemplate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Subject = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Body = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TagApi = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationTemplate", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9160), new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9161), new DateTime(2025, 3, 6, 23, 15, 4, 688, DateTimeKind.Utc).AddTicks(9161) });

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

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Id", "Body", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "Subject", "TagApi" },
                values: new object[,]
                {
                    { 1L, "<p>Seu acesso foi concedido com sucesso.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7297), "Liberar Login", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7298), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7298), "Acesso Concedido", "LoginReleaseEmail" },
                    { 2L, "<p>Seus dados da conta foram atualizados com sucesso.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7300), "Alteração de Conta Concluída", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7300), "Dados da Conta Atualizados", "AccountChangeSuccess" },
                    { 3L, "<p>Sua consulta foi agendada com sucesso.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7302), "Consulta Agendada", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7303), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7302), "Sua Consulta Foi Agendada", "AppointmentScheduledSuccess" },
                    { 4L, "<p>Sua consulta foi remarcada com sucesso.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304), "Consulta Remarcada", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7304), "Sua Consulta Foi Remarcada", "AppointmentRescheduled" },
                    { 5L, "<p>Sua consulta foi cancelada.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306), "Consulta Cancelada", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7306), "Sua Consulta Foi Cancelada", "AppointmentCancelled" },
                    { 6L, "<p>Seus dados médicos foram atualizados com sucesso.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7307), "Atualização de Cadastro Médico", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7308), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7308), "Dados Médicos Atualizados", "MedicalUpdateEmail" },
                    { 7L, "<p>Este é um lembrete para sua consulta agendada.</p>", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7309), "Lembrete de Consulta", true, "pt-BR", new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7310), new DateTime(2025, 3, 6, 23, 15, 4, 696, DateTimeKind.Utc).AddTicks(7310), "Lembrete de Consulta Agendada", "AppointmentReminder" }
                });

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
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5008), new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5009), new DateTime(2025, 3, 6, 23, 15, 4, 706, DateTimeKind.Utc).AddTicks(5010), new byte[] { 126, 115, 177, 74, 5, 224, 242, 63, 57, 153, 8, 79, 231, 125, 80, 227, 172, 27, 173, 184, 195, 250, 61, 162, 1, 2, 98, 205, 111, 157, 216, 91, 56, 154, 121, 109, 231, 14, 97, 35, 203, 119, 169, 185, 124, 184, 224, 16, 18, 184, 135, 42, 211, 9, 220, 230, 219, 29, 120, 82, 53, 118, 1, 42 }, new byte[] { 126, 79, 141, 235, 190, 253, 255, 132, 251, 192, 103, 246, 226, 108, 45, 101, 134, 24, 211, 174, 30, 249, 228, 136, 67, 168, 72, 194, 179, 159, 174, 94, 102, 70, 124, 193, 63, 41, 193, 83, 253, 79, 169, 249, 242, 185, 226, 111, 226, 122, 96, 72, 230, 128, 48, 238, 76, 223, 28, 119, 148, 237, 28, 126, 184, 72, 132, 251, 105, 177, 109, 31, 214, 249, 64, 52, 1, 148, 94, 246, 13, 114, 138, 214, 44, 39, 131, 156, 2, 169, 69, 255, 178, 163, 96, 30, 107, 61, 55, 66, 106, 157, 248, 171, 79, 14, 203, 101, 213, 6, 36, 94, 90, 243, 124, 101, 94, 8, 172, 55, 214, 152, 135, 182, 230, 162, 46, 143 } });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language",
                schema: "dbo",
                table: "NotificationTemplate",
                column: "Language");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "NotificationTemplate",
                columns: new[] { "Language", "TagApi", "Enable" });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationTemplate_TagApi",
                schema: "dbo",
                table: "NotificationTemplate",
                column: "TagApi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationTemplate",
                schema: "dbo");

            migrationBuilder.CreateTable(
                name: "EmailTemplate",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Body = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Language = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Subject = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TagApi = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailTemplate", x => x.Id);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 580, DateTimeKind.Utc).AddTicks(5917), new DateTime(2025, 3, 4, 19, 38, 34, 580, DateTimeKind.Utc).AddTicks(5920), new DateTime(2025, 3, 4, 19, 38, 34, 580, DateTimeKind.Utc).AddTicks(5920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1465), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1468), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1469), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1470), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1471), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1471), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1473), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1474), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1475), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1476), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1477), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1478), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1479), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1480), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1481), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1482), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1483), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1484), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1485), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1486), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1486), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1488), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1488), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1489), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1490), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1491), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1492), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1493), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1494), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1495), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1496), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1497), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1497), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1497) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1499), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1499), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1501), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1501), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1502), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1503), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1504), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1505), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1506), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1507), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1508), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1509), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1510), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1510), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1512), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1512), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1513), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1514), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1515), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1516), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1517), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1518), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1519), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1520), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1521), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1521), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1523), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1523), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1524), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1525), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1526), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1527), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1528), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1529), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1530), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 3, 4, 19, 38, 34, 581, DateTimeKind.Utc).AddTicks(1530) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "EmailTemplate",
                columns: new[] { "Id", "Body", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "Subject", "TagApi" },
                values: new object[,]
                {
                    { 1L, "<p>Seu acesso foi concedido com sucesso.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1934), "Liberar Login", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1935), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1935), "Acesso Concedido", "LoginReleaseEmail" },
                    { 2L, "<p>Seus dados da conta foram atualizados com sucesso.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1937), "Alteração de Conta Concluída", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1937), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1937), "Dados da Conta Atualizados", "AccountChangeSuccess" },
                    { 3L, "<p>Sua consulta foi agendada com sucesso.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1939), "Consulta Agendada", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1940), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1939), "Sua Consulta Foi Agendada", "AppointmentScheduledSuccess" },
                    { 4L, "<p>Sua consulta foi remarcada com sucesso.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1941), "Consulta Remarcada", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1942), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1941), "Sua Consulta Foi Remarcada", "AppointmentRescheduled" },
                    { 5L, "<p>Sua consulta foi cancelada.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1943), "Consulta Cancelada", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1944), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1943), "Sua Consulta Foi Cancelada", "AppointmentCancelled" },
                    { 6L, "<p>Seus dados médicos foram atualizados com sucesso.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1945), "Atualização de Cadastro Médico", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1946), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1945), "Dados Médicos Atualizados", "MedicalUpdateEmail" },
                    { 7L, "<p>Este é um lembrete para sua consulta agendada.</p>", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1947), "Lembrete de Consulta", true, "pt-BR", new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(1947), "Lembrete de Consulta Agendada", "AppointmentReminder" }
                });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 582, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 585, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 592, DateTimeKind.Utc).AddTicks(6936), new DateTime(2025, 3, 4, 19, 38, 34, 592, DateTimeKind.Utc).AddTicks(6938), new DateTime(2025, 3, 4, 19, 38, 34, 592, DateTimeKind.Utc).AddTicks(6938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8460), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8462), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8464), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8465), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8467), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8468), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8469), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8470), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8472), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8495), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8497), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8498), new DateTime(2025, 3, 4, 19, 38, 34, 600, DateTimeKind.Utc).AddTicks(8498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 601, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 601, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 601, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8339), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8340), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8341) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8364), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8364), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8369), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8370), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8373), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8374), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8377), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8378), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8381), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8382), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8385), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8386), new DateTime(2025, 3, 4, 19, 38, 34, 604, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9896));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9903));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9907));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 607, DateTimeKind.Utc).AddTicks(9908));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 4, 19, 38, 34, 608, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 609, DateTimeKind.Utc).AddTicks(1530), new DateTime(2025, 3, 4, 19, 38, 34, 609, DateTimeKind.Utc).AddTicks(1531), new DateTime(2025, 3, 4, 19, 38, 34, 609, DateTimeKind.Utc).AddTicks(1531), new byte[] { 54, 216, 88, 227, 179, 98, 129, 170, 10, 221, 106, 255, 184, 156, 168, 99, 140, 150, 23, 119, 74, 222, 52, 132, 12, 235, 235, 179, 116, 119, 11, 47, 66, 31, 185, 161, 103, 21, 214, 15, 81, 33, 32, 90, 120, 188, 54, 171, 246, 91, 221, 102, 130, 133, 139, 223, 63, 163, 64, 109, 248, 172, 229, 233 }, new byte[] { 211, 52, 79, 78, 117, 248, 212, 10, 155, 71, 50, 54, 141, 167, 186, 109, 55, 204, 101, 28, 66, 13, 135, 50, 10, 103, 236, 175, 15, 124, 17, 35, 61, 159, 45, 98, 85, 157, 59, 153, 4, 126, 29, 241, 239, 30, 115, 64, 64, 16, 153, 107, 28, 49, 229, 245, 6, 66, 250, 243, 64, 179, 121, 6, 232, 129, 61, 200, 58, 100, 45, 238, 160, 113, 119, 35, 125, 199, 179, 36, 127, 193, 48, 24, 195, 164, 57, 216, 3, 113, 187, 77, 171, 236, 121, 184, 251, 182, 48, 240, 244, 239, 60, 253, 169, 32, 58, 169, 153, 22, 65, 245, 253, 189, 192, 177, 239, 209, 86, 14, 133, 60, 92, 4, 18, 167, 102, 27 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 4, 19, 38, 34, 611, DateTimeKind.Utc).AddTicks(3339), new DateTime(2025, 3, 4, 19, 38, 34, 611, DateTimeKind.Utc).AddTicks(3340), new DateTime(2025, 3, 4, 19, 38, 34, 611, DateTimeKind.Utc).AddTicks(3340), new byte[] { 199, 77, 14, 46, 162, 45, 241, 10, 161, 90, 76, 46, 236, 222, 200, 238, 8, 248, 65, 230, 205, 105, 241, 145, 144, 218, 10, 245, 187, 140, 25, 164, 81, 146, 94, 28, 140, 0, 99, 5, 162, 210, 185, 42, 105, 125, 247, 8, 40, 114, 60, 29, 14, 156, 208, 173, 104, 184, 29, 121, 113, 84, 186, 233 }, new byte[] { 10, 87, 26, 12, 11, 161, 72, 38, 14, 43, 118, 79, 183, 226, 115, 99, 57, 254, 251, 20, 121, 96, 231, 165, 102, 119, 113, 210, 82, 183, 120, 41, 169, 27, 51, 121, 217, 200, 230, 44, 68, 157, 180, 111, 52, 46, 10, 128, 85, 214, 246, 168, 243, 11, 175, 110, 143, 141, 152, 60, 243, 25, 61, 204, 178, 120, 155, 87, 163, 216, 204, 96, 90, 224, 109, 249, 118, 5, 251, 99, 110, 206, 128, 113, 21, 126, 64, 255, 211, 216, 38, 243, 61, 70, 47, 49, 93, 118, 14, 172, 194, 111, 169, 61, 243, 114, 75, 28, 208, 28, 48, 156, 180, 239, 222, 205, 95, 118, 171, 68, 8, 159, 199, 136, 91, 114, 69, 208 } });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_Language",
                schema: "dbo",
                table: "EmailTemplate",
                column: "Language");

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "EmailTemplate",
                columns: new[] { "Language", "TagApi", "Enable" });

            migrationBuilder.CreateIndex(
                name: "IX_EmailTemplate_TagApi",
                schema: "dbo",
                table: "EmailTemplate",
                column: "TagApi");
        }
    }
}
