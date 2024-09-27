using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditDataSelectiveEntityLog",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RowKey = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    PartitionKey = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
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
                    table.PrimaryKey("PK_AuditDataSelectiveEntityLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditDataSelectiveEntityLog_User_UserAuditedId",
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
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3618) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3620) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3623), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3624), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3624) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3625), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3626), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3627), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3628), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3628) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3630), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3631), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3632), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3631) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3633) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3635) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3637) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3638), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3642), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3643), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3644), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3646), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3649), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3651), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3652), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3654), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3655) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3657) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3659) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3662), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3663), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3664), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3665), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3665) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3666), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3667), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3667) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3668), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3669), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3673), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3674), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3675), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3676), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3676) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3678), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3682), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3683), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3684), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3685), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3685) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3686), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3687), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3687) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3688), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3689), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3970), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3971), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4171), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4172), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4398));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4404));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4512), new DateTime(2024, 9, 26, 0, 58, 36, 317, DateTimeKind.Utc).AddTicks(4513), new byte[] { 145, 196, 85, 136, 233, 205, 232, 63, 226, 44, 120, 165, 191, 113, 0, 191, 171, 28, 73, 88, 204, 164, 75, 162, 217, 198, 212, 158, 184, 233, 74, 98, 196, 5, 48, 125, 38, 110, 26, 237, 68, 92, 228, 57, 198, 118, 231, 224, 11, 40, 6, 77, 93, 194, 248, 94, 95, 142, 228, 189, 130, 94, 223, 132 }, new byte[] { 0, 27, 97, 201, 83, 204, 108, 95, 19, 111, 221, 214, 10, 81, 68, 140, 50, 184, 41, 78, 254, 34, 203, 246, 184, 128, 234, 151, 137, 141, 207, 136, 6, 86, 251, 230, 232, 29, 158, 97, 57, 213, 143, 91, 129, 15, 246, 169, 209, 103, 184, 224, 142, 51, 209, 11, 57, 26, 184, 202, 221, 93, 21, 95, 154, 116, 222, 48, 255, 132, 193, 211, 205, 254, 53, 14, 191, 232, 167, 246, 149, 105, 24, 223, 214, 215, 72, 211, 214, 95, 139, 205, 90, 57, 151, 246, 222, 133, 125, 145, 128, 184, 143, 107, 189, 97, 134, 174, 10, 191, 251, 83, 57, 105, 59, 214, 59, 233, 66, 191, 200, 120, 222, 150, 67, 6, 154, 254 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6721), new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6723), new DateTime(2024, 9, 26, 0, 58, 36, 319, DateTimeKind.Utc).AddTicks(6724), new byte[] { 70, 132, 118, 220, 115, 210, 93, 48, 54, 6, 147, 54, 148, 14, 33, 120, 197, 165, 22, 81, 196, 157, 200, 228, 42, 87, 78, 2, 238, 72, 2, 246, 166, 135, 66, 202, 195, 218, 110, 123, 183, 238, 158, 253, 143, 248, 111, 37, 134, 103, 95, 170, 158, 82, 179, 66, 159, 64, 64, 105, 104, 158, 217, 94 }, new byte[] { 235, 172, 121, 111, 214, 66, 166, 172, 181, 183, 204, 98, 28, 91, 123, 110, 155, 19, 160, 203, 73, 138, 110, 143, 120, 68, 232, 83, 250, 196, 7, 56, 41, 91, 36, 57, 58, 157, 82, 107, 79, 73, 57, 139, 52, 154, 220, 87, 162, 189, 68, 179, 239, 180, 8, 220, 128, 73, 78, 215, 255, 219, 244, 249, 209, 134, 137, 75, 188, 81, 150, 28, 148, 220, 219, 30, 87, 132, 171, 220, 160, 81, 236, 33, 195, 157, 148, 123, 91, 207, 227, 2, 222, 38, 123, 1, 249, 7, 179, 53, 78, 166, 157, 189, 98, 106, 59, 104, 130, 39, 105, 54, 180, 131, 18, 236, 170, 105, 126, 42, 60, 175, 146, 63, 52, 225, 237, 93 } });

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                columns: new[] { "TableName", "Operation" });

            migrationBuilder.CreateIndex(
                name: "IX_AuditDataSelectiveEntityLog_UserAuditedId",
                schema: "dbo",
                table: "AuditDataSelectiveEntityLog",
                column: "UserAuditedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditDataSelectiveEntityLog",
                schema: "dbo");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6750), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6752), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6752) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6967), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6969), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6971), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6974), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6975), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6977), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6977), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6979), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6981), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6982), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6983), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6984), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6985), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6986), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6987), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6988), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6989), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6990), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6991), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6992), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6992), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6994), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6994), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6996), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6998), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6998), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(6999), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7000), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7000) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7001), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7002), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7004), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7004) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7005), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7006), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7006) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7007), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7008), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7009), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7010), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7012), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7011) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7013), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7014), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7013) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7015), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7015) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7017), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7017) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7019), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7019) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7020), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7021), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7021) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7022), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7023), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7023) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7024), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7025), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7024) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7026), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7027), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7026) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7028), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7029), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7028) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7031), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7030) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7032), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7032) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7034) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7035), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7036), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7036) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7038), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7038) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7293), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7294) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7505), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7506), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7506) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7619));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7623));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7846), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7846), new DateTime(2024, 9, 25, 2, 35, 19, 359, DateTimeKind.Utc).AddTicks(7847), new byte[] { 239, 23, 61, 180, 49, 66, 227, 27, 176, 117, 39, 109, 240, 74, 44, 35, 199, 159, 134, 95, 169, 9, 193, 116, 14, 123, 166, 61, 217, 227, 169, 80, 184, 187, 182, 51, 65, 73, 169, 247, 179, 198, 65, 61, 209, 160, 112, 138, 193, 148, 75, 27, 48, 213, 156, 156, 99, 29, 122, 195, 227, 142, 229, 235 }, new byte[] { 23, 151, 184, 186, 223, 99, 176, 26, 74, 110, 120, 138, 131, 212, 171, 199, 165, 180, 167, 158, 86, 94, 66, 110, 160, 115, 130, 77, 220, 150, 142, 195, 39, 22, 15, 47, 94, 175, 98, 127, 69, 149, 69, 86, 9, 222, 255, 132, 9, 123, 77, 246, 200, 121, 247, 182, 14, 212, 161, 193, 114, 128, 238, 63, 212, 48, 62, 22, 180, 89, 214, 43, 171, 69, 134, 255, 223, 207, 108, 220, 226, 22, 97, 218, 1, 34, 153, 231, 70, 1, 63, 15, 167, 77, 146, 187, 13, 75, 83, 80, 27, 115, 63, 84, 72, 234, 150, 223, 102, 86, 30, 110, 83, 158, 59, 76, 108, 60, 48, 172, 22, 22, 185, 107, 78, 102, 232, 115 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 35, 19, 361, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 9, 25, 2, 35, 19, 361, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 9, 25, 2, 35, 19, 361, DateTimeKind.Utc).AddTicks(9961), new byte[] { 196, 2, 76, 97, 166, 253, 73, 80, 0, 226, 248, 90, 89, 242, 39, 106, 178, 198, 206, 126, 56, 78, 124, 139, 15, 103, 147, 89, 175, 253, 2, 119, 201, 186, 228, 176, 78, 157, 127, 117, 108, 5, 33, 157, 154, 133, 4, 243, 148, 237, 105, 45, 87, 170, 128, 76, 39, 41, 57, 119, 95, 255, 33, 46 }, new byte[] { 51, 230, 44, 165, 224, 248, 105, 27, 238, 145, 171, 75, 228, 81, 76, 10, 21, 52, 58, 99, 179, 251, 34, 112, 229, 174, 216, 187, 170, 126, 19, 67, 187, 250, 8, 70, 197, 119, 215, 122, 60, 140, 245, 152, 228, 201, 145, 114, 213, 232, 253, 246, 237, 76, 121, 219, 159, 11, 138, 33, 94, 144, 29, 141, 170, 73, 29, 87, 65, 185, 220, 188, 150, 103, 112, 20, 193, 232, 13, 59, 89, 2, 210, 204, 120, 105, 177, 40, 12, 242, 210, 188, 166, 221, 71, 118, 209, 236, 128, 225, 26, 197, 51, 203, 161, 168, 94, 21, 183, 71, 179, 96, 144, 187, 207, 225, 155, 34, 109, 250, 225, 133, 84, 242, 128, 209, 202, 43 } });
        }
    }
}
