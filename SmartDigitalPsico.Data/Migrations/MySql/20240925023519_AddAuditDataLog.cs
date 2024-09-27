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

            migrationBuilder.CreateIndex(
                name: "Idx_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                columns: new[] { "TableName", "Operation" });

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
