using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update_05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1242), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1244), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1244) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1450), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1451), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1452), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1453), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1454), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1455), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1458) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1459), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1460) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1467) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1469) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1473), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1472) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1474) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1478), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1481), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1481) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1486), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1488), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1490), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1517), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "ApplicationLanguage",
                columns: new[] { "Id", "CreatedDate", "Description", "Enable", "Language", "LanguageKey", "LanguageValue", "LastAccessDate", "ModifyDate", "ResourceKey" },
                values: new object[] { 39L, new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1519), "Ocorreu erro no processo.", true, "pt-BR", "GenericErroMessage", "Ocorreu erro no processo.", new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1519), "SharedResource" });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1743) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1862));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1964), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2171));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2176));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2277), new DateTime(2024, 6, 16, 20, 25, 13, 976, DateTimeKind.Utc).AddTicks(2277), new byte[] { 58, 207, 111, 72, 252, 192, 199, 184, 24, 102, 2, 173, 173, 25, 128, 135, 4, 82, 133, 100, 101, 104, 248, 176, 63, 122, 42, 187, 31, 16, 253, 44, 76, 17, 242, 44, 189, 196, 105, 178, 183, 137, 20, 133, 9, 175, 113, 199, 225, 220, 122, 97, 22, 141, 55, 45, 156, 182, 37, 69, 250, 219, 220, 126 }, new byte[] { 253, 173, 26, 3, 16, 153, 242, 244, 231, 38, 110, 50, 0, 0, 17, 78, 116, 95, 159, 83, 37, 224, 135, 169, 175, 209, 236, 246, 5, 155, 108, 242, 36, 20, 67, 43, 239, 25, 96, 86, 255, 47, 107, 17, 1, 24, 143, 213, 98, 255, 75, 84, 87, 61, 87, 66, 148, 24, 119, 241, 142, 192, 54, 137, 36, 213, 44, 109, 1, 79, 47, 223, 209, 178, 44, 243, 195, 127, 11, 219, 123, 80, 201, 59, 93, 128, 124, 212, 134, 75, 112, 238, 154, 226, 180, 31, 112, 40, 250, 68, 185, 255, 42, 16, 218, 63, 129, 91, 31, 165, 62, 106, 52, 238, 206, 241, 190, 166, 57, 47, 255, 75, 80, 186, 26, 155, 209, 160 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3548), new DateTime(2024, 6, 16, 20, 25, 13, 978, DateTimeKind.Utc).AddTicks(3549), new byte[] { 96, 80, 188, 98, 100, 82, 95, 88, 141, 18, 48, 218, 104, 237, 9, 254, 20, 138, 98, 197, 208, 62, 194, 41, 119, 196, 154, 251, 167, 12, 92, 199, 145, 183, 58, 231, 195, 39, 9, 7, 214, 60, 206, 20, 238, 19, 220, 37, 253, 229, 255, 113, 78, 8, 132, 185, 204, 174, 85, 133, 217, 205, 135, 149 }, new byte[] { 217, 114, 226, 84, 148, 221, 241, 251, 211, 223, 51, 109, 174, 101, 30, 42, 62, 171, 150, 226, 58, 56, 117, 95, 131, 188, 3, 108, 186, 70, 1, 195, 2, 88, 22, 84, 155, 122, 96, 207, 31, 184, 198, 170, 92, 61, 126, 4, 181, 70, 114, 177, 133, 47, 222, 254, 117, 100, 225, 216, 172, 113, 230, 38, 74, 222, 30, 192, 167, 129, 41, 116, 139, 96, 188, 212, 156, 113, 219, 48, 254, 148, 16, 184, 247, 106, 143, 20, 178, 185, 113, 168, 138, 149, 135, 37, 149, 153, 137, 234, 80, 203, 118, 199, 233, 253, 234, 190, 49, 220, 168, 245, 37, 47, 232, 103, 137, 97, 76, 80, 10, 242, 117, 173, 8, 129, 184, 209 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6216), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6219), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6218) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6420), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6424), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6424) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6427), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6427) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6430), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6431), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6431) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6433) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6434) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6438) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6439), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6440), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6441), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6442), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6446), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6447), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6448), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6454), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6455), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6456), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6457), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6458), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6460), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6461), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6492) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6494) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6497), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6498), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6499), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6500), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6504), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6505), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6506), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6508), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6509), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6511), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6512), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6513), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6514), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6515), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6516), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6945), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6946), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(6946) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7262), new DateTime(2024, 5, 29, 17, 31, 45, 824, DateTimeKind.Utc).AddTicks(7262), new byte[] { 102, 219, 35, 255, 244, 125, 55, 207, 248, 133, 244, 190, 155, 110, 49, 8, 111, 64, 141, 203, 210, 138, 48, 26, 241, 189, 23, 52, 25, 162, 87, 58, 155, 242, 78, 174, 205, 235, 37, 1, 244, 197, 71, 149, 16, 228, 183, 88, 22, 21, 58, 109, 213, 78, 24, 201, 211, 187, 231, 71, 182, 240, 70, 243 }, new byte[] { 55, 75, 165, 123, 90, 250, 116, 199, 236, 141, 166, 93, 250, 170, 248, 60, 149, 37, 151, 111, 0, 53, 68, 158, 57, 241, 235, 80, 48, 241, 215, 0, 98, 172, 114, 148, 152, 233, 172, 233, 28, 129, 51, 213, 144, 78, 26, 149, 133, 77, 197, 152, 255, 74, 127, 100, 194, 99, 113, 225, 250, 177, 80, 204, 3, 181, 167, 156, 243, 134, 89, 24, 76, 158, 1, 80, 137, 237, 111, 214, 246, 113, 6, 93, 226, 231, 72, 178, 66, 72, 90, 188, 137, 104, 20, 226, 9, 174, 1, 8, 233, 152, 140, 156, 40, 165, 111, 197, 118, 61, 223, 24, 124, 251, 210, 219, 23, 58, 106, 156, 64, 156, 186, 55, 86, 253, 189, 109 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8552), new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8553), new DateTime(2024, 5, 29, 17, 31, 45, 826, DateTimeKind.Utc).AddTicks(8553), new byte[] { 35, 195, 133, 204, 115, 91, 149, 1, 190, 162, 188, 250, 124, 138, 214, 128, 186, 228, 129, 180, 105, 198, 152, 9, 185, 0, 96, 106, 52, 140, 151, 246, 180, 180, 156, 113, 157, 86, 117, 144, 77, 98, 18, 223, 237, 194, 5, 32, 122, 254, 10, 108, 129, 19, 160, 226, 179, 216, 191, 169, 237, 166, 248, 22 }, new byte[] { 80, 250, 98, 193, 40, 226, 6, 51, 127, 111, 226, 135, 11, 121, 123, 69, 23, 219, 193, 212, 45, 241, 65, 0, 250, 228, 75, 104, 84, 183, 156, 114, 214, 123, 16, 130, 140, 12, 162, 183, 252, 86, 101, 50, 204, 72, 66, 43, 215, 115, 175, 162, 27, 77, 25, 1, 218, 120, 237, 78, 208, 73, 8, 185, 167, 81, 14, 128, 66, 178, 25, 232, 28, 80, 164, 51, 115, 243, 136, 18, 240, 239, 62, 18, 0, 204, 64, 204, 134, 220, 80, 205, 89, 202, 45, 212, 190, 17, 93, 215, 198, 74, 56, 203, 186, 0, 63, 155, 18, 246, 37, 27, 64, 141, 53, 173, 46, 92, 124, 222, 101, 198, 226, 234, 37, 130, 157, 42 } });
        }
    }
}
