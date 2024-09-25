using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditDataEntityLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TableName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Operation = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    KeyValues = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    OldValues = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    NewValues = table.Column<string>(type: "text", maxLength: 4000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    AuditDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserAuditedLogin = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    UserAuditedId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditDataEntityLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditDataEntityLog_User_UserAuditedId",
                        column: x => x.UserAuditedId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1454), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1457), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1456) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1688), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1689), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1694), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1695) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1697) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1698), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1699), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1699) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1700), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1701), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1701) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1702), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1703), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1703) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1704), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1705), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1706), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1707), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1708) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1710) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1711), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1712), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1712) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1713), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1714), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1715), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1716), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1719) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1720), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1721), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1721) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1722), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1723), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1723) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1725), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1726), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1727), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1728), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1729), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1730), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1731), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1732), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1733), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1732) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1734), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1735), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1734) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1736), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1737), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1739), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1738) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1740), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1741), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1740) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1742) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1745), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1746), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1747), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1748), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1747) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1749), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1749) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1753) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1755) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1756), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1757) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1758), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1759), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1759) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1760), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1760) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1991), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2249), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2250) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2366));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2371));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2596), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2597), new DateTime(2024, 9, 25, 2, 13, 30, 879, DateTimeKind.Utc).AddTicks(2597), new byte[] { 87, 75, 213, 69, 196, 68, 155, 65, 100, 123, 34, 87, 95, 109, 85, 246, 95, 11, 16, 193, 136, 14, 218, 182, 25, 164, 66, 108, 22, 42, 143, 17, 251, 84, 151, 227, 47, 51, 203, 22, 184, 205, 189, 145, 32, 33, 136, 221, 224, 100, 120, 13, 147, 216, 72, 150, 126, 136, 49, 137, 139, 120, 230, 129 }, new byte[] { 115, 166, 165, 82, 12, 192, 15, 77, 222, 250, 74, 116, 144, 39, 117, 160, 123, 157, 0, 111, 254, 181, 140, 251, 151, 26, 64, 31, 204, 145, 218, 136, 255, 203, 96, 164, 150, 9, 152, 239, 35, 78, 118, 24, 243, 152, 35, 86, 228, 219, 62, 222, 27, 219, 86, 175, 123, 143, 58, 102, 109, 238, 188, 36, 39, 158, 46, 9, 78, 246, 59, 252, 73, 187, 192, 132, 211, 186, 252, 78, 245, 185, 165, 55, 70, 60, 35, 153, 218, 201, 222, 59, 235, 26, 40, 115, 159, 61, 164, 90, 178, 149, 146, 155, 59, 166, 230, 95, 216, 182, 81, 16, 135, 248, 34, 28, 30, 78, 58, 1, 185, 131, 255, 2, 83, 179, 91, 181 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3914), new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3915), new DateTime(2024, 9, 25, 2, 13, 30, 881, DateTimeKind.Utc).AddTicks(3916), new byte[] { 142, 213, 105, 194, 230, 130, 97, 47, 142, 107, 238, 115, 190, 237, 63, 223, 125, 84, 207, 244, 182, 151, 58, 62, 90, 96, 128, 40, 31, 203, 92, 101, 47, 181, 152, 61, 47, 162, 226, 184, 170, 40, 230, 143, 200, 160, 220, 33, 46, 240, 78, 67, 106, 195, 117, 45, 119, 16, 6, 89, 88, 207, 117, 220 }, new byte[] { 195, 116, 110, 73, 203, 181, 114, 141, 165, 137, 85, 203, 254, 55, 153, 60, 170, 161, 8, 48, 250, 236, 100, 154, 32, 94, 61, 138, 228, 190, 102, 10, 77, 53, 73, 39, 8, 245, 102, 101, 195, 150, 109, 219, 187, 140, 193, 71, 236, 146, 42, 31, 14, 46, 186, 97, 232, 94, 48, 2, 2, 164, 252, 108, 212, 159, 71, 135, 180, 109, 29, 117, 82, 81, 237, 167, 95, 226, 131, 84, 185, 169, 150, 34, 204, 104, 186, 154, 28, 45, 242, 63, 179, 163, 218, 203, 176, 118, 144, 114, 171, 236, 235, 193, 37, 30, 61, 19, 169, 228, 185, 73, 164, 193, 91, 194, 35, 216, 255, 252, 35, 225, 6, 205, 123, 61, 61, 232 } });

            migrationBuilder.CreateIndex(
                name: "IX_AuditDataEntityLog_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                column: "UserAuditedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditDataEntityLog",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7507), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7508), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7507) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7509), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7510), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7513), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7514), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7515), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7516), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7518), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7519), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7520), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7555), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7556), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7561), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7562), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7563), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7564), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7563) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7565), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7566), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7565) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7569) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7570), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7571), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7571) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7572), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7573), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7574), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7575), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7574) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7576) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7579), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7581), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7582), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7583), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7584), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7583) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7585), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7586), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7585) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7587) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7589) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7591), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7591) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7592), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7593), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7592) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7594), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7595), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7596) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7597), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7598), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7598) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7601), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7602), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7601) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7603), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7604), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7605) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7606), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7607), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7607) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7608), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7609), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7609) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7610), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7611), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7610) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7847), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7848), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8049), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8050), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8051) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 2, 2, 2, 14, 297, DateTimeKind.Utc).AddTicks(8403), new byte[] { 152, 50, 41, 84, 26, 37, 212, 92, 190, 139, 234, 239, 208, 182, 64, 204, 167, 228, 197, 58, 205, 13, 209, 200, 198, 94, 161, 86, 65, 197, 69, 171, 48, 217, 140, 98, 50, 105, 127, 137, 140, 53, 2, 82, 96, 225, 252, 211, 144, 11, 35, 81, 141, 32, 188, 0, 205, 111, 210, 248, 0, 78, 51, 209 }, new byte[] { 233, 32, 7, 29, 98, 119, 3, 42, 86, 226, 68, 186, 215, 204, 222, 189, 241, 162, 236, 112, 141, 100, 86, 190, 188, 167, 162, 45, 150, 205, 183, 134, 77, 30, 211, 137, 160, 177, 134, 186, 82, 149, 89, 214, 150, 243, 106, 151, 239, 244, 105, 51, 25, 126, 55, 90, 248, 121, 25, 21, 16, 229, 107, 119, 110, 45, 71, 22, 145, 252, 218, 52, 239, 183, 188, 63, 179, 169, 98, 245, 176, 160, 3, 232, 158, 123, 252, 93, 219, 213, 167, 42, 33, 195, 99, 16, 45, 221, 248, 135, 122, 130, 134, 76, 33, 38, 134, 10, 114, 50, 213, 124, 88, 147, 84, 57, 17, 95, 134, 98, 146, 177, 243, 44, 255, 254, 152, 250 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9866), new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 9, 2, 2, 2, 14, 299, DateTimeKind.Utc).AddTicks(9867), new byte[] { 232, 218, 129, 65, 70, 129, 54, 240, 235, 166, 47, 18, 100, 60, 230, 219, 217, 108, 30, 115, 121, 148, 191, 199, 209, 121, 24, 232, 202, 201, 45, 29, 11, 26, 250, 76, 37, 140, 89, 85, 143, 221, 31, 129, 33, 126, 166, 72, 41, 157, 205, 11, 186, 130, 168, 38, 14, 132, 122, 209, 127, 225, 135, 178 }, new byte[] { 235, 69, 150, 153, 209, 63, 84, 112, 47, 101, 174, 88, 208, 216, 138, 166, 247, 181, 146, 103, 178, 158, 71, 17, 132, 58, 128, 186, 202, 215, 63, 120, 123, 100, 149, 68, 84, 41, 74, 30, 34, 84, 21, 254, 44, 167, 250, 54, 237, 142, 45, 109, 241, 191, 87, 44, 170, 55, 0, 59, 73, 113, 149, 225, 174, 194, 122, 92, 50, 157, 204, 246, 187, 78, 181, 16, 98, 250, 156, 148, 170, 236, 132, 211, 111, 57, 18, 223, 104, 44, 227, 104, 161, 6, 125, 228, 54, 143, 234, 75, 161, 13, 76, 109, 196, 59, 130, 87, 180, 123, 205, 190, 244, 56, 158, 140, 0, 92, 35, 241, 131, 221, 34, 83, 221, 120, 16, 113 } });
        }
    }
}
