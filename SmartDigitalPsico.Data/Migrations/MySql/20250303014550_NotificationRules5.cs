using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationRules5 : Migration
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
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6266), new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6274), new DateTime(2025, 3, 3, 1, 45, 49, 832, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1402), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1404), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1411), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1412), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1413), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1414), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1415), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1416), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1417), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1418), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1419), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1420), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1423) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1424), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1425), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1426), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1427), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1427) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1428), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1429), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1428) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1430) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1432) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1433), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1434), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1434) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1435), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1436), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1436) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1437), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1438), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1437) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1439) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1441) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1443) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1444), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1445), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1445) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1446), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1447), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1447) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1448), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1449), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1448) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1450), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1451), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1452) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1453), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1454), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1455), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1456), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1457), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1458), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1459), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1460), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1462), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1463), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1464), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1465), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1465) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1466), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1467), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1468), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1469), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1486), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1487), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1488), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1489), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1490), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1491), new DateTime(2025, 3, 3, 1, 45, 49, 833, DateTimeKind.Utc).AddTicks(1490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2130), new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2132), new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(2131) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 834, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 837, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7451), new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7452), new DateTime(2025, 3, 3, 1, 45, 49, 843, DateTimeKind.Utc).AddTicks(7453) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4967), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4969), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4968) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4974), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4979), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4981), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4982), new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4982) });

            migrationBuilder.InsertData(
                schema: "dbo",
                table: "NotificationRules",
                columns: new[] { "Id", "CreatedDate", "Description", "ENotificationServiceType", "Enable", "IntervalType", "IntervalValue", "IsBefore", "IsEnabled", "Language", "LastAccessDate", "MedicalId", "ModifyDate", "NotificationType" },
                values: new object[] { 6L, new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4983), "Envio 48 horas antes do agendamento", "0", true, (short)1, (short)48, true, true, "pt-BR", new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4984), 1L, new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(4984), (short)0 });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 851, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9659), new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9660), new DateTime(2025, 3, 3, 1, 45, 49, 854, DateTimeKind.Utc).AddTicks(9661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 857, DateTimeKind.Utc).AddTicks(9869));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 3, 1, 45, 49, 858, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(849), new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(850), new DateTime(2025, 3, 3, 1, 45, 49, 859, DateTimeKind.Utc).AddTicks(851), new byte[] { 185, 38, 212, 49, 159, 6, 233, 150, 6, 141, 190, 65, 32, 195, 212, 89, 100, 12, 140, 209, 119, 211, 15, 98, 206, 63, 133, 82, 135, 172, 95, 241, 133, 132, 90, 142, 28, 38, 56, 32, 17, 23, 24, 193, 18, 71, 239, 103, 215, 252, 18, 183, 106, 67, 18, 193, 25, 250, 58, 251, 38, 11, 164, 77 }, new byte[] { 162, 77, 225, 177, 172, 22, 136, 177, 95, 220, 44, 207, 52, 225, 160, 125, 242, 244, 85, 23, 242, 178, 104, 248, 175, 31, 217, 54, 182, 245, 29, 24, 84, 224, 171, 209, 97, 94, 91, 61, 244, 123, 206, 19, 62, 252, 155, 77, 164, 44, 89, 188, 194, 72, 243, 219, 134, 63, 13, 134, 90, 136, 120, 169, 77, 122, 146, 115, 137, 68, 54, 240, 46, 48, 192, 112, 231, 248, 54, 7, 247, 83, 119, 102, 20, 19, 135, 242, 176, 199, 149, 179, 162, 165, 180, 101, 127, 110, 51, 177, 225, 211, 247, 166, 206, 174, 63, 75, 242, 126, 132, 1, 238, 158, 76, 235, 237, 125, 108, 31, 111, 119, 111, 133, 52, 67, 189, 149 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2672), new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2673), new DateTime(2025, 3, 3, 1, 45, 49, 861, DateTimeKind.Utc).AddTicks(2674), new byte[] { 201, 28, 88, 164, 3, 237, 148, 103, 25, 51, 195, 98, 226, 154, 53, 110, 190, 53, 58, 229, 180, 207, 229, 51, 126, 75, 183, 230, 93, 155, 240, 99, 120, 57, 166, 188, 198, 60, 191, 191, 177, 16, 52, 158, 85, 157, 165, 97, 126, 184, 27, 125, 174, 58, 181, 21, 55, 160, 154, 72, 104, 150, 157, 76 }, new byte[] { 224, 233, 243, 79, 67, 85, 138, 72, 32, 1, 82, 169, 121, 173, 221, 214, 67, 112, 196, 183, 197, 142, 163, 51, 2, 29, 170, 123, 39, 60, 189, 210, 174, 84, 238, 37, 117, 101, 77, 209, 232, 65, 58, 189, 62, 159, 97, 12, 164, 111, 125, 7, 44, 104, 84, 110, 89, 10, 154, 226, 51, 162, 58, 170, 42, 170, 111, 225, 147, 235, 164, 228, 233, 237, 191, 18, 148, 70, 51, 239, 125, 9, 239, 120, 44, 100, 223, 223, 97, 174, 251, 207, 41, 56, 51, 145, 181, 234, 120, 163, 24, 199, 180, 201, 7, 51, 253, 224, 238, 75, 132, 239, 33, 42, 157, 169, 184, 175, 131, 42, 137, 131, 217, 4, 103, 93, 61, 69 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7096), new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7100), new DateTime(2025, 3, 2, 2, 52, 7, 267, DateTimeKind.Utc).AddTicks(7099) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2495), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2500), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2501), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2507), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2508), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2509), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2510), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2511), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2512), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2513), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2514), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2515), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2516), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2515) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2517) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2518), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2519), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2521), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2522), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2523), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2522) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2524), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2525), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2524) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2526) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2527), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2528), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2530), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2531), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2532), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2531) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2533), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2534), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2533) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2538), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2539), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2541), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2540) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2542), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2543), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2542) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2544) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2546) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2547), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2548), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2548) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2549), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2550), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2551), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2552), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2554), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2555), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2555) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2556), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2557), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2557) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2558), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2559), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2560), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2561), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2563), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2564), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2565), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2566), new DateTime(2025, 3, 2, 2, 52, 7, 268, DateTimeKind.Utc).AddTicks(2566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(3933) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 269, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 272, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(6));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 273, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5969), new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5970), new DateTime(2025, 3, 2, 2, 52, 7, 280, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1180), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1181), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1181) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1184), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1185), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1187) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1189), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1190), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1189) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1191), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1192), new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(1192) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3154));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 289, DateTimeKind.Utc).AddTicks(3156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9084), new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9085), new DateTime(2025, 3, 2, 2, 52, 7, 292, DateTimeKind.Utc).AddTicks(9086) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 296, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4689));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 2, 2, 52, 7, 297, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1323), new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1324), new DateTime(2025, 3, 2, 2, 52, 7, 298, DateTimeKind.Utc).AddTicks(1324), new byte[] { 199, 29, 73, 24, 145, 81, 10, 137, 21, 152, 254, 64, 50, 245, 203, 9, 177, 231, 158, 249, 190, 41, 37, 94, 207, 146, 149, 122, 150, 228, 85, 245, 155, 226, 163, 211, 4, 96, 70, 9, 231, 235, 126, 94, 40, 208, 202, 106, 24, 200, 66, 158, 212, 115, 39, 250, 126, 205, 233, 165, 38, 13, 32, 103 }, new byte[] { 255, 30, 80, 86, 215, 243, 66, 162, 241, 170, 250, 238, 116, 68, 99, 163, 224, 55, 188, 6, 180, 108, 219, 205, 234, 84, 64, 175, 196, 27, 223, 244, 191, 154, 220, 132, 25, 77, 214, 135, 186, 2, 178, 229, 118, 220, 220, 213, 253, 105, 12, 87, 137, 88, 101, 169, 167, 61, 24, 161, 246, 190, 26, 50, 225, 56, 118, 99, 165, 147, 215, 253, 82, 216, 93, 117, 73, 18, 35, 89, 16, 149, 3, 128, 222, 218, 152, 226, 168, 7, 41, 16, 117, 109, 192, 127, 234, 12, 8, 116, 209, 166, 225, 104, 6, 116, 106, 1, 222, 59, 33, 254, 24, 120, 72, 7, 214, 107, 122, 128, 124, 92, 181, 51, 253, 162, 122, 227 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3896), new DateTime(2025, 3, 2, 2, 52, 7, 300, DateTimeKind.Utc).AddTicks(3896), new byte[] { 89, 120, 155, 250, 99, 59, 153, 145, 35, 169, 128, 211, 70, 17, 68, 82, 228, 159, 235, 159, 181, 195, 173, 23, 25, 186, 7, 176, 175, 81, 45, 186, 241, 126, 204, 22, 105, 198, 242, 252, 52, 76, 221, 48, 100, 131, 54, 37, 103, 89, 116, 98, 44, 111, 63, 166, 117, 179, 251, 235, 167, 64, 146, 220 }, new byte[] { 122, 99, 99, 221, 16, 77, 30, 6, 218, 64, 33, 242, 195, 120, 127, 157, 29, 13, 17, 164, 102, 109, 57, 63, 29, 19, 102, 29, 165, 71, 90, 94, 11, 147, 218, 12, 65, 45, 144, 167, 192, 208, 138, 173, 62, 20, 222, 84, 106, 73, 45, 186, 64, 137, 229, 190, 86, 28, 168, 183, 230, 108, 244, 81, 234, 238, 175, 196, 89, 218, 33, 138, 233, 1, 32, 112, 114, 235, 122, 60, 72, 234, 54, 191, 114, 225, 10, 68, 86, 205, 10, 91, 228, 27, 95, 50, 223, 153, 204, 198, 226, 113, 62, 44, 234, 23, 65, 2, 65, 145, 15, 147, 85, 15, 142, 201, 126, 32, 233, 103, 157, 104, 75, 202, 249, 53, 93, 139 } });
        }
    }
}
