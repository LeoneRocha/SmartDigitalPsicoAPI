using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class AddEmailTemplate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailTemplate",
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
                    Body = table.Column<string>(type: "text", maxLength: 8000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
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
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9414), new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9421), new DateTime(2024, 10, 2, 1, 15, 48, 575, DateTimeKind.Utc).AddTicks(9421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(940), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(941), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(942), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(943), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(946), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(951), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(959), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(962), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(962) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(963), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(966), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(971), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(973), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(978), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(980) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(981), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(982), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(982) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(983), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(984), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(988), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(989), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(990), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(993) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(994), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(995), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(996), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(997), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(998), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(999), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1003), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1004), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1005), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1006), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1007), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1008), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011), new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "EmailTemplate",
                columns: new[] { "Id", "Body", "CreatedDate", "Description", "Enable", "Language", "LastAccessDate", "ModifyDate", "Subject" },
                values: new object[] { 1L, "<html>\r\n<head>\r\n    <style>\r\n        body {{ font-family: Arial, sans-serif; background-color: #f4f4f9; color: #333; padding: 20px; }}\r\n        .container {{ max-width: 600px; margin: 0 auto; background-color: #fff; padding: 20px; border-radius: 10px; box-shadow: 0 0 10px rgba(0, 0, 0, 0.1); }}\r\n        .header {{ text-align: center; padding-bottom: 20px; }}\r\n        .header h1 {{ margin: 0; color: #4CAF50; }}\r\n        .content {{ line-height: 1.6; }}\r\n        .footer {{ text-align: center; padding-top: 20px; font-size: 0.9em; color: #777; }}\r\n    </style>\r\n</head>\r\n<body>\r\n    <div class='container'>\r\n        <div class='header'>\r\n            <h1>Access Granted</h1>\r\n        </div>\r\n        <div class='content'>\r\n            <p>Hello,</p>\r\n            <p>Your access has been granted. Below are your login details:</p>\r\n            <p><strong>URL:</strong> <a href='{{AccessUrl}}'>{{AccessUrl}}</a></p>\r\n            <p><strong>Email:</strong> {{Email}}</p>\r\n            <p><strong>Temporary Password:</strong> {{Password}}</p>\r\n            <p>Please change your password after your first login.</p>\r\n        </div>\r\n        <div class='footer'>\r\n            <p>Thank you for joining us!</p>\r\n        </div>\r\n    </div>\r\n</body>\r\n</html>", new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9991), "Welcome Email", true, "pt-BR", new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9992), new DateTime(2024, 10, 2, 1, 15, 48, 593, DateTimeKind.Utc).AddTicks(9992), "Access Granted" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 576, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6205), new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6206), new DateTime(2024, 10, 2, 1, 15, 48, 582, DateTimeKind.Utc).AddTicks(6206) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 583, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(411), new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(412), new DateTime(2024, 10, 2, 1, 15, 48, 586, DateTimeKind.Utc).AddTicks(412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2755));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2782));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 10, 2, 1, 15, 48, 588, DateTimeKind.Utc).AddTicks(6686), new byte[] { 73, 78, 157, 49, 149, 0, 151, 77, 68, 239, 77, 79, 79, 181, 53, 169, 212, 62, 17, 180, 137, 87, 7, 148, 81, 91, 7, 232, 182, 114, 207, 79, 10, 207, 155, 54, 220, 13, 112, 173, 57, 219, 139, 202, 166, 157, 180, 19, 209, 37, 54, 221, 39, 128, 154, 124, 55, 242, 203, 174, 52, 152, 71, 115 }, new byte[] { 205, 216, 30, 238, 39, 193, 246, 249, 162, 187, 16, 249, 54, 129, 223, 225, 115, 240, 16, 120, 0, 193, 113, 182, 78, 120, 60, 50, 217, 3, 113, 67, 204, 121, 105, 28, 79, 49, 9, 235, 171, 10, 143, 73, 19, 133, 167, 108, 28, 252, 91, 35, 25, 141, 74, 178, 10, 245, 58, 227, 81, 12, 150, 126, 51, 71, 160, 32, 151, 77, 142, 218, 251, 16, 142, 105, 143, 185, 238, 121, 4, 172, 233, 80, 26, 150, 66, 130, 14, 199, 250, 145, 141, 76, 63, 45, 48, 215, 200, 9, 57, 64, 221, 64, 159, 208, 213, 233, 135, 225, 223, 116, 203, 30, 145, 131, 213, 13, 142, 137, 162, 240, 129, 123, 45, 31, 35, 72 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8447), new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8448), new DateTime(2024, 10, 2, 1, 15, 48, 590, DateTimeKind.Utc).AddTicks(8448), new byte[] { 73, 212, 158, 81, 45, 83, 146, 191, 213, 141, 183, 248, 106, 225, 72, 173, 190, 231, 111, 200, 157, 209, 156, 29, 16, 22, 225, 6, 40, 146, 111, 217, 110, 157, 218, 126, 203, 45, 17, 8, 203, 150, 76, 36, 148, 87, 207, 63, 105, 82, 113, 109, 218, 105, 69, 5, 211, 69, 37, 3, 234, 208, 234, 31 }, new byte[] { 125, 130, 72, 115, 126, 240, 188, 83, 149, 213, 159, 204, 147, 183, 43, 1, 189, 234, 238, 43, 226, 222, 200, 188, 223, 55, 126, 205, 15, 253, 85, 3, 78, 254, 47, 218, 70, 217, 239, 106, 137, 144, 141, 221, 206, 53, 150, 188, 49, 94, 57, 210, 210, 55, 85, 205, 138, 249, 151, 72, 29, 122, 69, 236, 62, 199, 246, 60, 46, 190, 168, 6, 84, 107, 22, 35, 16, 100, 184, 152, 92, 145, 174, 55, 12, 252, 168, 60, 70, 127, 196, 183, 123, 47, 64, 38, 105, 139, 204, 35, 218, 193, 142, 173, 215, 4, 217, 20, 165, 180, 37, 126, 104, 213, 245, 182, 146, 100, 37, 156, 147, 223, 96, 107, 241, 166, 143, 241 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailTemplate",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 10, 1, 23, 58, 19, 669, DateTimeKind.Utc).AddTicks(9346) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2625) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2628), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2629), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2631) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2633), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2636), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2637), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2636) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2638), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2639), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2639) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2644), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2645), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2644) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2646), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2647), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2651), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2652), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2653), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2654), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2656), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2657), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2658), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2659), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2661), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2662), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2663), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2664), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2664) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2665), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2666), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2667), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2668), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2670), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2671), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2673), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2674), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2678), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2679), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2680), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2681), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2687), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2689), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2692), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2696), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2697), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2704), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2708), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2709), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2711), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2712), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2713), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2714), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2716), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2717), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2719), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2721), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2722), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2725), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2727), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2729), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2730), new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(2730) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 670, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8557), new DateTime(2024, 10, 1, 23, 58, 19, 680, DateTimeKind.Utc).AddTicks(8557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 681, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9146), new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9152), new DateTime(2024, 10, 1, 23, 58, 19, 685, DateTimeKind.Utc).AddTicks(9153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7597), new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7598), new DateTime(2024, 10, 1, 23, 58, 19, 689, DateTimeKind.Utc).AddTicks(7598), new byte[] { 205, 132, 138, 253, 146, 243, 58, 76, 34, 5, 98, 80, 92, 211, 227, 12, 252, 246, 231, 252, 134, 116, 140, 241, 178, 18, 145, 112, 33, 161, 121, 179, 20, 14, 222, 13, 15, 60, 136, 91, 182, 253, 80, 172, 214, 94, 90, 121, 158, 169, 202, 226, 203, 58, 186, 40, 203, 90, 249, 220, 127, 230, 69, 32 }, new byte[] { 165, 20, 34, 42, 17, 210, 24, 205, 11, 199, 121, 246, 63, 183, 170, 162, 14, 199, 240, 7, 106, 69, 140, 190, 159, 225, 177, 116, 96, 205, 125, 162, 88, 212, 160, 15, 12, 156, 118, 145, 246, 230, 70, 99, 34, 61, 203, 131, 138, 123, 13, 62, 184, 56, 96, 178, 45, 136, 157, 43, 22, 41, 136, 105, 21, 90, 23, 96, 194, 104, 165, 1, 67, 38, 249, 101, 30, 81, 184, 52, 49, 164, 214, 40, 30, 110, 113, 24, 228, 246, 40, 123, 231, 26, 87, 62, 123, 45, 3, 99, 212, 48, 249, 160, 215, 41, 147, 164, 132, 248, 41, 106, 29, 43, 201, 204, 136, 254, 73, 61, 254, 12, 210, 151, 122, 33, 189, 165 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2706), new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2707), new DateTime(2024, 10, 1, 23, 58, 19, 692, DateTimeKind.Utc).AddTicks(2708), new byte[] { 16, 119, 45, 234, 32, 248, 201, 208, 107, 119, 4, 31, 46, 159, 83, 199, 121, 78, 170, 185, 225, 11, 212, 253, 215, 254, 19, 220, 150, 197, 150, 145, 94, 194, 223, 176, 80, 120, 36, 6, 133, 136, 246, 149, 212, 253, 202, 219, 137, 200, 121, 196, 89, 21, 229, 194, 174, 169, 4, 139, 253, 53, 254, 55 }, new byte[] { 179, 95, 102, 42, 141, 238, 39, 36, 61, 7, 150, 244, 166, 85, 31, 182, 3, 203, 207, 10, 28, 246, 98, 161, 80, 74, 103, 236, 21, 166, 147, 119, 194, 216, 151, 84, 14, 1, 15, 76, 143, 25, 46, 61, 2, 211, 11, 123, 4, 140, 103, 72, 219, 227, 138, 234, 240, 213, 117, 177, 223, 170, 13, 117, 43, 71, 64, 24, 168, 90, 243, 57, 220, 216, 61, 167, 223, 200, 161, 40, 202, 53, 190, 71, 93, 213, 169, 111, 213, 56, 128, 127, 170, 57, 150, 115, 47, 190, 10, 162, 58, 29, 115, 13, 226, 211, 179, 91, 235, 213, 10, 181, 87, 171, 97, 175, 127, 135, 76, 232, 152, 135, 22, 177, 170, 71, 189, 254 } });
        }
    }
}
