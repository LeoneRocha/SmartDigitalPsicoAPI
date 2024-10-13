using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalUpdateTimeWork : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndWorkingTime",
                schema: "dbo",
                table: "Medical",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "StartWorkingTime",
                schema: "dbo",
                table: "Medical",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(58), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(60), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(60) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1453), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1455), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1456), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1457), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1457) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1458), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1459), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1459) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1460), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1461), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1461) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1462), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1463), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1462) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1464), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1465), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1464) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1466) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1468) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1469), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1470), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1470) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1471), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1472), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1473), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1474), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1473) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1475), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1476), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1479) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1483), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1484), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1485), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1486), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1485) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1487), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1488), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1492), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1493), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1494), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1495), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1496), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1497), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1501), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1502), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1505), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1506), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1510), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1513), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1515), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1520), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1521), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1522), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1523), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1524), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525), new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(1525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(304), new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(305), new DateTime(2024, 10, 13, 19, 14, 2, 831, DateTimeKind.Utc).AddTicks(305) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 812, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "EndWorkingTime", "LastAccessDate", "ModifyDate", "StartWorkingTime" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2303), new TimeSpan(0, 20, 0, 0, 0), new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(2305), new TimeSpan(0, 6, 0, 0, 0) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 819, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7690), new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7691), new DateTime(2024, 10, 13, 19, 14, 2, 822, DateTimeKind.Utc).AddTicks(7692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1185));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1186));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5925), new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5926), new DateTime(2024, 10, 13, 19, 14, 2, 825, DateTimeKind.Utc).AddTicks(5926), new byte[] { 176, 102, 77, 214, 38, 73, 248, 65, 196, 220, 23, 75, 41, 15, 224, 153, 103, 184, 188, 146, 85, 91, 132, 228, 149, 99, 68, 177, 137, 39, 58, 150, 105, 41, 45, 70, 32, 56, 184, 98, 95, 113, 213, 130, 118, 238, 247, 253, 132, 124, 139, 140, 101, 225, 138, 198, 175, 253, 9, 173, 89, 76, 156, 196 }, new byte[] { 5, 6, 207, 190, 211, 28, 207, 92, 2, 133, 201, 237, 192, 218, 92, 126, 93, 168, 132, 109, 59, 213, 88, 239, 153, 25, 29, 92, 163, 209, 36, 74, 23, 13, 62, 143, 169, 222, 253, 185, 188, 180, 112, 57, 22, 118, 205, 251, 81, 233, 46, 48, 71, 213, 0, 253, 231, 173, 132, 84, 229, 188, 177, 165, 56, 163, 203, 203, 55, 62, 45, 177, 185, 138, 234, 4, 198, 207, 48, 242, 9, 103, 183, 150, 88, 140, 126, 153, 30, 250, 17, 91, 20, 131, 137, 140, 50, 17, 82, 230, 236, 78, 97, 232, 52, 96, 64, 19, 165, 24, 159, 32, 133, 246, 27, 229, 252, 127, 225, 109, 203, 54, 167, 47, 40, 190, 128, 83 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7296), new DateTime(2024, 10, 13, 19, 14, 2, 827, DateTimeKind.Utc).AddTicks(7296), new byte[] { 216, 110, 178, 81, 131, 227, 197, 114, 202, 36, 96, 225, 76, 177, 70, 112, 58, 206, 21, 50, 82, 249, 208, 204, 161, 63, 91, 181, 125, 152, 14, 52, 180, 133, 122, 225, 94, 92, 147, 154, 112, 172, 157, 88, 1, 172, 30, 127, 121, 188, 231, 127, 143, 231, 215, 74, 210, 144, 94, 213, 145, 113, 202, 221 }, new byte[] { 204, 84, 112, 104, 225, 186, 78, 130, 43, 171, 26, 32, 23, 152, 233, 93, 73, 182, 9, 102, 18, 143, 140, 253, 115, 231, 127, 202, 116, 59, 122, 229, 231, 20, 16, 170, 24, 114, 205, 131, 86, 233, 124, 22, 240, 235, 79, 137, 39, 0, 181, 38, 3, 114, 49, 30, 237, 130, 119, 203, 105, 184, 32, 31, 145, 225, 14, 125, 85, 253, 91, 16, 102, 213, 208, 125, 16, 156, 198, 52, 231, 124, 119, 240, 0, 37, 216, 247, 161, 196, 174, 41, 201, 11, 200, 84, 218, 77, 34, 9, 163, 232, 40, 74, 92, 162, 154, 15, 81, 106, 148, 97, 53, 53, 27, 101, 55, 220, 75, 83, 89, 90, 140, 104, 70, 115, 126, 209 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndWorkingTime",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.DropColumn(
                name: "StartWorkingTime",
                schema: "dbo",
                table: "Medical");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4152), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4155), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(4154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5450), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5451), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5450) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5476) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5478), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5479), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5478) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5480), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5483), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5484), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5485), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5487), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5488), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5492), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5496), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5503), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5508), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5509), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5509) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5510), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5511), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5513), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5518), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5519), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5520), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5521), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5526), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5528), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5529), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5528) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5531), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5530) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5532) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5533), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5534), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5534) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5535), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5536), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5535) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5538), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5537) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5539) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5541), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5541) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5542), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5543), new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5373), new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5374), new DateTime(2024, 10, 12, 16, 48, 43, 571, DateTimeKind.Utc).AddTicks(5374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 553, DateTimeKind.Utc).AddTicks(6271));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1001), new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(1002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 560, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4974), new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4976), new DateTime(2024, 10, 12, 16, 48, 43, 563, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 12, 16, 48, 43, 565, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3800), new DateTime(2024, 10, 12, 16, 48, 43, 566, DateTimeKind.Utc).AddTicks(3801), new byte[] { 152, 167, 23, 220, 236, 251, 14, 36, 118, 212, 182, 46, 149, 247, 63, 8, 31, 147, 144, 182, 13, 99, 65, 53, 107, 157, 245, 101, 152, 255, 110, 119, 2, 94, 88, 231, 46, 117, 79, 105, 36, 63, 248, 172, 204, 106, 37, 112, 169, 75, 136, 107, 227, 250, 185, 116, 251, 81, 48, 151, 24, 30, 161, 22 }, new byte[] { 243, 55, 23, 190, 113, 88, 155, 171, 92, 202, 5, 126, 137, 190, 61, 148, 34, 43, 209, 244, 152, 57, 252, 80, 226, 246, 111, 163, 169, 31, 16, 94, 178, 71, 173, 107, 251, 220, 170, 190, 45, 42, 189, 62, 47, 235, 40, 156, 89, 220, 184, 27, 140, 13, 32, 154, 162, 34, 6, 26, 31, 6, 163, 14, 221, 49, 74, 25, 229, 253, 3, 151, 233, 171, 249, 188, 230, 2, 186, 147, 162, 242, 98, 193, 221, 46, 23, 145, 114, 215, 76, 91, 242, 145, 156, 1, 78, 207, 162, 60, 63, 35, 243, 123, 227, 236, 131, 227, 102, 198, 125, 207, 75, 108, 88, 68, 34, 142, 215, 71, 28, 142, 3, 174, 249, 161, 231, 16 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4713), new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4714), new DateTime(2024, 10, 12, 16, 48, 43, 568, DateTimeKind.Utc).AddTicks(4714), new byte[] { 8, 39, 44, 104, 88, 1, 63, 10, 251, 166, 205, 125, 64, 21, 252, 122, 126, 201, 62, 123, 179, 211, 170, 243, 135, 225, 116, 153, 140, 221, 131, 139, 159, 57, 2, 231, 111, 19, 86, 1, 186, 230, 138, 29, 205, 165, 237, 89, 49, 54, 177, 70, 14, 193, 86, 201, 139, 191, 215, 238, 16, 247, 39, 183 }, new byte[] { 81, 0, 142, 169, 190, 35, 105, 16, 247, 99, 129, 42, 186, 136, 26, 243, 46, 8, 167, 188, 201, 10, 0, 163, 243, 160, 138, 48, 3, 50, 132, 95, 251, 217, 180, 28, 173, 142, 120, 118, 163, 145, 93, 19, 25, 32, 123, 73, 77, 224, 175, 216, 128, 185, 228, 187, 179, 170, 237, 20, 57, 22, 52, 101, 29, 18, 169, 59, 84, 113, 137, 248, 157, 216, 20, 36, 156, 81, 88, 204, 154, 91, 110, 72, 123, 75, 62, 176, 196, 17, 165, 98, 14, 201, 253, 202, 250, 223, 94, 182, 217, 225, 198, 158, 99, 226, 120, 51, 182, 165, 50, 43, 42, 98, 229, 244, 53, 255, 43, 175, 246, 188, 159, 157, 93, 245, 72, 108 } });
        }
    }
}
