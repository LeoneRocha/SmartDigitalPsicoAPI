using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class UserTokenSession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserTokenSession",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessToken = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RefreshToken = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Refresh_token_expiry_time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokenSession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokenSession_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9148), new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9151), new DateTime(2024, 10, 2, 23, 17, 58, 887, DateTimeKind.Utc).AddTicks(9150) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(477), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(478), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(477) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(480), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(480) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(482) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(484) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(486) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(488) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(489), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(490), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(491), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(492), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(491) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(493), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(494), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(493) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(495) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(497) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(498), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(499), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(499) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(501), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(501) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(502), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(503), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(503) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(504), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(504) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(506), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(507), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(510), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(511), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(510) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(512) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(516), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(516) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(517), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(519), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(520), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(519) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(521), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(522), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(521) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(523) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(525) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(545) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(550), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(551), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(551) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(553) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(554), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(555), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(554) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(557), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(556) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(558) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(560) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(563), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(564) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(566), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4642), new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4644), new DateTime(2024, 10, 2, 23, 17, 58, 906, DateTimeKind.Utc).AddTicks(4643) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 888, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6281), new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6282), new DateTime(2024, 10, 2, 23, 17, 58, 894, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 895, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3986), new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3987), new DateTime(2024, 10, 2, 23, 17, 58, 898, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 23, 17, 58, 900, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1371), new DateTime(2024, 10, 2, 23, 17, 58, 901, DateTimeKind.Utc).AddTicks(1371), new byte[] { 232, 225, 180, 31, 242, 194, 48, 50, 8, 226, 183, 182, 172, 192, 138, 113, 160, 162, 237, 254, 58, 172, 66, 232, 188, 44, 207, 16, 100, 36, 80, 5, 168, 243, 27, 26, 134, 157, 32, 199, 187, 243, 214, 170, 216, 101, 120, 6, 69, 223, 29, 27, 154, 199, 252, 89, 147, 198, 115, 165, 60, 58, 195, 114 }, new byte[] { 190, 248, 8, 58, 43, 120, 2, 15, 249, 3, 98, 213, 204, 126, 82, 222, 174, 170, 58, 241, 199, 40, 33, 67, 202, 132, 112, 193, 32, 47, 30, 156, 72, 23, 228, 141, 183, 106, 125, 118, 200, 252, 189, 105, 237, 157, 50, 236, 57, 210, 153, 24, 133, 66, 120, 240, 80, 237, 254, 86, 255, 73, 179, 196, 240, 73, 43, 253, 41, 24, 10, 1, 252, 197, 64, 0, 233, 193, 192, 93, 20, 255, 123, 158, 209, 108, 251, 18, 230, 210, 105, 70, 35, 124, 108, 67, 86, 166, 106, 219, 248, 175, 228, 85, 25, 163, 217, 28, 175, 22, 127, 37, 151, 209, 174, 170, 148, 148, 101, 11, 186, 148, 81, 121, 7, 212, 39, 167 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3289), new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 10, 2, 23, 17, 58, 903, DateTimeKind.Utc).AddTicks(3291), new byte[] { 136, 215, 65, 222, 200, 6, 170, 62, 194, 234, 181, 28, 135, 197, 38, 158, 28, 239, 35, 113, 54, 45, 247, 143, 37, 151, 235, 224, 143, 213, 170, 67, 144, 119, 129, 175, 167, 245, 226, 89, 250, 85, 1, 51, 213, 65, 72, 228, 202, 113, 230, 22, 65, 38, 17, 14, 105, 250, 63, 75, 122, 10, 185, 16 }, new byte[] { 139, 11, 160, 127, 192, 46, 153, 97, 186, 61, 75, 95, 59, 62, 11, 82, 17, 172, 53, 211, 84, 201, 112, 88, 90, 161, 94, 243, 57, 74, 150, 140, 92, 47, 215, 248, 108, 182, 116, 88, 141, 254, 164, 28, 85, 228, 75, 60, 213, 60, 148, 10, 142, 241, 164, 232, 120, 118, 52, 179, 4, 133, 209, 176, 78, 27, 19, 147, 210, 180, 46, 194, 198, 80, 100, 210, 132, 100, 191, 179, 21, 196, 99, 234, 112, 113, 235, 69, 143, 224, 130, 11, 51, 185, 67, 81, 42, 56, 89, 112, 59, 108, 79, 55, 26, 45, 114, 39, 26, 212, 124, 34, 44, 239, 4, 70, 147, 125, 217, 248, 83, 155, 0, 151, 82, 219, 175, 119 } });

            migrationBuilder.CreateIndex(
                name: "IX_UserTokenSession_UserId",
                schema: "dbo",
                table: "UserTokenSession",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserTokenSession",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1593), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3116), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3118), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3120), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3121), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3121) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3122), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3123), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3123) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3125) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3126), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3127), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3127) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3128), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3129), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3129) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3130), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3131), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3130) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3132), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3133), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3132) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3134) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3136) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3138) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3140) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3142), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3142) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3143), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3144), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3145), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3146), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3147) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3152), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3154), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3156), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3156) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3159), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3161), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3164), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3165) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3168), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3169) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3171) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3172), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3176) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3178), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3181), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3186), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3187), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3190), new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(3190) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5667), new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5668), new DateTime(2024, 10, 2, 1, 51, 54, 690, DateTimeKind.Utc).AddTicks(5667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 672, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9303), new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 10, 2, 1, 51, 54, 678, DateTimeKind.Utc).AddTicks(9304) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 679, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 10, 2, 1, 51, 54, 682, DateTimeKind.Utc).AddTicks(3714) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 2, 1, 51, 54, 684, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1010), new DateTime(2024, 10, 2, 1, 51, 54, 685, DateTimeKind.Utc).AddTicks(1011), new byte[] { 81, 211, 123, 111, 82, 6, 24, 223, 154, 173, 67, 252, 93, 103, 148, 146, 213, 132, 5, 246, 70, 216, 230, 233, 10, 38, 190, 41, 165, 188, 210, 172, 45, 163, 53, 78, 90, 74, 3, 97, 247, 88, 202, 18, 210, 4, 152, 33, 207, 236, 43, 180, 93, 186, 37, 43, 42, 21, 176, 26, 242, 58, 4, 85 }, new byte[] { 74, 44, 214, 227, 206, 39, 128, 15, 45, 7, 96, 60, 127, 31, 186, 253, 159, 86, 255, 4, 87, 13, 76, 153, 221, 51, 26, 191, 193, 7, 250, 156, 31, 106, 128, 26, 215, 206, 32, 90, 100, 145, 70, 248, 29, 177, 83, 173, 188, 86, 198, 204, 48, 171, 110, 82, 20, 54, 71, 82, 135, 33, 161, 107, 72, 229, 75, 113, 162, 147, 172, 37, 22, 45, 192, 225, 217, 132, 25, 5, 249, 156, 232, 96, 29, 209, 131, 49, 149, 177, 72, 38, 136, 142, 39, 111, 80, 212, 235, 185, 89, 176, 88, 112, 136, 55, 189, 245, 172, 245, 163, 23, 102, 1, 192, 210, 186, 202, 165, 191, 118, 132, 178, 101, 125, 133, 197, 145 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3483), new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3485), new DateTime(2024, 10, 2, 1, 51, 54, 687, DateTimeKind.Utc).AddTicks(3485), new byte[] { 76, 237, 200, 195, 200, 126, 98, 215, 145, 165, 59, 165, 226, 5, 153, 57, 56, 72, 246, 249, 135, 86, 128, 65, 211, 211, 106, 97, 97, 1, 147, 125, 125, 88, 11, 210, 64, 127, 254, 223, 226, 14, 17, 189, 102, 118, 3, 232, 74, 240, 197, 243, 0, 106, 149, 176, 178, 210, 132, 15, 94, 113, 220, 40 }, new byte[] { 211, 209, 134, 38, 84, 49, 170, 142, 173, 208, 247, 20, 180, 165, 217, 190, 23, 24, 254, 88, 135, 203, 187, 45, 57, 249, 134, 170, 107, 230, 48, 199, 204, 147, 0, 69, 58, 193, 131, 225, 183, 64, 179, 67, 181, 155, 30, 120, 78, 143, 236, 139, 137, 199, 200, 126, 175, 43, 179, 127, 230, 139, 42, 113, 228, 41, 26, 235, 188, 73, 175, 0, 94, 87, 228, 126, 54, 227, 161, 211, 235, 8, 114, 102, 38, 177, 168, 147, 128, 36, 81, 240, 83, 223, 255, 235, 168, 171, 98, 74, 244, 9, 227, 222, 87, 93, 46, 36, 147, 201, 149, 245, 100, 193, 29, 153, 49, 38, 49, 84, 184, 133, 144, 119, 186, 161, 241, 32 } });
        }
    }
}
