using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class ScheduleBatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleBatch",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    ScheduleData = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    BatchToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleBatch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ScheduleBatch_User_ModifyUserId",
                        column: x => x.ModifyUserId,
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
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6226), new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6229), new DateTime(2025, 3, 29, 21, 51, 50, 410, DateTimeKind.Utc).AddTicks(6228) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1886), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1887), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1888), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1889), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1896), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1897), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1898), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1899), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1900), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1901), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1902), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1903), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1904), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1905), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1906) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1909), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1910), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1911), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1912), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1913), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1914), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1913) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1915), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1916), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1915) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1920), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1921), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1922), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1923), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1924), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1925), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1926), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1927), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1928), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1929), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1933), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1934), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1935), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1936), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1937), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1938), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1937) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1939), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1940), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1941), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1942), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1943), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1944), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1948), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1949), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1950), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1951), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1952), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1953), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1954), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1955), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989), new DateTime(2025, 3, 29, 21, 51, 50, 411, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 412, DateTimeKind.Utc).AddTicks(2809));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 412, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 415, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2823), new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2824), new DateTime(2025, 3, 29, 21, 51, 50, 422, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1836), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1837), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1837) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1840), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1841), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1845), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1846), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1850), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1851), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4830), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4831), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4831) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4833), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4834), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4835), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4836), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4837), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4838), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4839), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4840), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4841), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4842), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4843), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(4843) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 425, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3124), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3125), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3126) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3153), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3154), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3154) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3159), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3160), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3168) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3175), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3176), new DateTime(2025, 3, 29, 21, 51, 50, 429, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 432, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(4141));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9467), new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9468), new DateTime(2025, 3, 29, 21, 51, 50, 434, DateTimeKind.Utc).AddTicks(9468), new byte[] { 48, 73, 188, 237, 233, 69, 180, 248, 66, 152, 105, 74, 162, 185, 125, 183, 128, 130, 199, 200, 115, 120, 221, 225, 218, 122, 24, 199, 51, 191, 88, 75, 216, 34, 235, 91, 167, 199, 112, 153, 24, 143, 149, 245, 63, 1, 225, 193, 24, 181, 186, 129, 44, 236, 180, 171, 129, 165, 180, 179, 221, 102, 98, 127 }, new byte[] { 100, 229, 75, 75, 24, 176, 155, 231, 44, 50, 61, 99, 196, 93, 166, 132, 59, 19, 209, 59, 142, 191, 32, 195, 144, 226, 61, 162, 75, 191, 175, 36, 27, 44, 240, 210, 70, 72, 184, 203, 246, 186, 156, 57, 17, 157, 111, 104, 56, 248, 18, 184, 160, 105, 251, 112, 222, 201, 70, 158, 3, 17, 208, 87, 50, 104, 24, 132, 47, 116, 78, 160, 136, 28, 100, 221, 151, 33, 79, 0, 210, 223, 243, 3, 173, 251, 197, 139, 4, 52, 55, 252, 10, 16, 58, 136, 105, 202, 10, 146, 240, 51, 178, 126, 239, 118, 138, 90, 1, 128, 216, 135, 157, 107, 220, 200, 105, 105, 170, 210, 231, 194, 145, 20, 69, 245, 144, 40 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(671), new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(671), new DateTime(2025, 3, 29, 21, 51, 50, 437, DateTimeKind.Utc).AddTicks(672), new byte[] { 187, 3, 142, 55, 59, 241, 39, 218, 242, 1, 121, 229, 41, 168, 139, 100, 152, 116, 19, 139, 254, 219, 33, 90, 129, 10, 117, 102, 167, 146, 37, 73, 106, 247, 199, 240, 29, 180, 45, 161, 43, 161, 246, 92, 40, 191, 45, 173, 93, 31, 171, 209, 97, 145, 74, 88, 227, 43, 172, 63, 51, 47, 114, 102 }, new byte[] { 55, 13, 85, 166, 169, 65, 3, 254, 21, 87, 85, 237, 137, 50, 23, 72, 139, 92, 98, 30, 16, 26, 245, 126, 209, 99, 206, 50, 6, 92, 202, 44, 219, 86, 98, 156, 140, 243, 65, 108, 176, 247, 226, 151, 244, 145, 190, 105, 219, 178, 32, 242, 246, 202, 230, 167, 44, 59, 127, 146, 236, 79, 62, 116, 130, 87, 217, 160, 57, 61, 15, 131, 10, 1, 250, 150, 178, 123, 17, 153, 104, 203, 125, 87, 178, 210, 255, 196, 186, 31, 45, 60, 78, 198, 57, 73, 68, 201, 32, 251, 58, 252, 90, 11, 187, 64, 220, 113, 196, 218, 5, 249, 133, 32, 231, 157, 72, 215, 163, 137, 223, 198, 123, 3, 204, 178, 100, 84 } });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_BatchToken",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "BatchToken");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_CreatedUserId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_MedicalId_PatientId_Period",
                schema: "dbo",
                table: "ScheduleBatch",
                columns: new[] { "MedicalId", "PatientId", "StartPeriod", "EndPeriod" });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_ModifyUserId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_PatientId",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleBatch",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(3208), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(3212), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(3211) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9845) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9858) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9860), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9863), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9873), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9875), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9878), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9880), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9880), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9882) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9884), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9884), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9884) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9886), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9886) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9887), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9888), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9888) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9889), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9890), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9890) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9891), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9892), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9892) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9893), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9894), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9895), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9896), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9897), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9897), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9899), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9899), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9901), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9902), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9903), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9903) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9904), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9905), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9905) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9906), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9907), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9907) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9908), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9909), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9908) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9910), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9911), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9910) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9912), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9913), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9912) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9914), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9915), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9914) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9916), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9917), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9918), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9918), new DateTime(2025, 3, 7, 1, 0, 49, 818, DateTimeKind.Utc).AddTicks(9918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 820, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 820, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 823, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 830, DateTimeKind.Utc).AddTicks(9414), new DateTime(2025, 3, 7, 1, 0, 49, 830, DateTimeKind.Utc).AddTicks(9416), new DateTime(2025, 3, 7, 1, 0, 49, 830, DateTimeKind.Utc).AddTicks(9417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(486), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(489), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(489) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(492), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(494), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(495), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(496), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(496) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(498), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(499), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(498) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(500), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(501), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(502), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(503), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3794), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3795), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3795) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3797), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3798), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3797) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3799), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3800), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3800) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3801), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3802), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3802) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3803), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3804), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3804) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3805), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3806), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3806) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3807), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3808), new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(3808) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 834, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4469), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4471), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4471) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4506), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4507), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4512), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4513), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4513) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4517), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4518), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4572), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4573) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4577), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4577), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4578) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4581), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 3, 7, 1, 0, 49, 838, DateTimeKind.Utc).AddTicks(4582) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9229));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 841, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 7, 1, 0, 49, 842, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 843, DateTimeKind.Utc).AddTicks(2312), new DateTime(2025, 3, 7, 1, 0, 49, 843, DateTimeKind.Utc).AddTicks(2313), new DateTime(2025, 3, 7, 1, 0, 49, 843, DateTimeKind.Utc).AddTicks(2314), new byte[] { 23, 63, 2, 24, 75, 4, 17, 5, 163, 188, 55, 134, 102, 156, 183, 213, 151, 51, 36, 192, 250, 241, 96, 22, 111, 164, 175, 67, 81, 71, 158, 47, 239, 79, 84, 223, 233, 21, 222, 61, 113, 19, 112, 159, 111, 77, 176, 232, 139, 61, 181, 74, 78, 124, 103, 248, 42, 78, 124, 151, 128, 150, 135, 217 }, new byte[] { 144, 165, 101, 78, 119, 115, 24, 10, 145, 54, 250, 98, 161, 157, 101, 91, 49, 84, 213, 121, 166, 126, 233, 131, 136, 58, 9, 65, 41, 200, 165, 91, 31, 112, 99, 179, 136, 189, 64, 209, 59, 97, 10, 169, 47, 237, 217, 242, 142, 226, 130, 121, 108, 31, 72, 41, 8, 188, 102, 68, 27, 121, 71, 98, 48, 74, 39, 162, 56, 43, 111, 136, 14, 250, 0, 89, 198, 104, 57, 188, 69, 255, 18, 234, 14, 207, 212, 123, 29, 72, 183, 81, 235, 162, 38, 185, 215, 206, 190, 22, 216, 188, 27, 37, 67, 91, 88, 236, 240, 180, 178, 29, 106, 177, 245, 187, 200, 216, 166, 176, 222, 229, 124, 188, 141, 78, 242, 51 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 7, 1, 0, 49, 845, DateTimeKind.Utc).AddTicks(4979), new DateTime(2025, 3, 7, 1, 0, 49, 845, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 7, 1, 0, 49, 845, DateTimeKind.Utc).AddTicks(4980), new byte[] { 160, 224, 65, 14, 131, 232, 157, 185, 77, 23, 253, 231, 252, 252, 114, 17, 28, 211, 7, 150, 223, 152, 98, 95, 117, 133, 131, 210, 115, 64, 81, 227, 169, 181, 38, 64, 122, 47, 218, 119, 242, 155, 92, 229, 189, 1, 150, 23, 135, 238, 63, 178, 164, 208, 137, 32, 243, 0, 98, 40, 145, 73, 105, 21 }, new byte[] { 144, 220, 164, 20, 99, 213, 24, 55, 201, 168, 28, 252, 193, 185, 75, 133, 53, 211, 122, 33, 186, 243, 120, 226, 9, 183, 105, 23, 110, 163, 144, 52, 204, 5, 130, 80, 254, 96, 49, 215, 123, 174, 254, 206, 97, 223, 136, 154, 241, 131, 83, 239, 124, 243, 17, 237, 228, 150, 59, 163, 173, 98, 105, 170, 190, 241, 159, 1, 199, 143, 96, 79, 2, 227, 237, 211, 43, 171, 152, 18, 81, 10, 152, 148, 27, 86, 252, 23, 1, 193, 213, 144, 69, 40, 83, 50, 225, 37, 216, 202, 113, 119, 215, 10, 38, 16, 124, 153, 229, 162, 191, 120, 153, 184, 48, 130, 54, 51, 44, 242, 60, 128, 196, 122, 65, 39, 235, 46 } });
        }
    }
}
