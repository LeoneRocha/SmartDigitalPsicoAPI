using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class MedicalSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalSettings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    GoogleCalendarId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoogleAccessToken = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoogleRefreshToken = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GoogleTokenExpiry = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalSettings_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2296), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2299), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(2298) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3886), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3887), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3887) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3889), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3890), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3891), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3892), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3893), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3894), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3897) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3898), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3899), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3899) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3900), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3901), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3902), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3903), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3902) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3904) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3930), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3931), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3932), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3933), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3932) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3939), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3940), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3941), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3942), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3943), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3944), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3948), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3949), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3951), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3952), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3953), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3954), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3955), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3957), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3958), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3959), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3960), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3961), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3962), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3963), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3964), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3968), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3969), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3970), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3971), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3972), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3973), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3977), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3978), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3980), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3981), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3982), new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(3981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5299), new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5301), new DateTime(2025, 2, 20, 20, 32, 22, 72, DateTimeKind.Utc).AddTicks(5300) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 50, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(136), new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(139), new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6024));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 59, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2389), new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2391), new DateTime(2025, 2, 20, 20, 32, 22, 63, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9618));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 65, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5502), new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5503), new DateTime(2025, 2, 20, 20, 32, 22, 66, DateTimeKind.Utc).AddTicks(5504), new byte[] { 122, 58, 243, 95, 239, 142, 159, 9, 46, 36, 246, 114, 101, 89, 236, 110, 215, 211, 169, 70, 177, 25, 90, 169, 115, 215, 141, 189, 150, 217, 170, 16, 43, 142, 148, 8, 66, 58, 242, 169, 79, 11, 47, 94, 209, 109, 152, 203, 133, 110, 85, 60, 185, 249, 117, 36, 178, 83, 17, 239, 45, 177, 153, 26 }, new byte[] { 198, 117, 146, 194, 119, 21, 223, 2, 199, 172, 142, 173, 173, 59, 141, 192, 25, 231, 18, 43, 93, 69, 87, 15, 227, 169, 24, 172, 5, 234, 33, 226, 212, 49, 63, 113, 59, 216, 249, 26, 76, 223, 26, 206, 50, 239, 123, 146, 98, 0, 170, 206, 63, 171, 237, 126, 83, 163, 11, 84, 223, 86, 133, 134, 198, 201, 243, 121, 178, 202, 43, 235, 202, 133, 188, 188, 215, 22, 11, 181, 7, 159, 36, 101, 19, 226, 33, 20, 248, 175, 197, 210, 65, 138, 118, 184, 177, 211, 145, 218, 17, 27, 58, 215, 78, 125, 242, 240, 216, 40, 98, 169, 239, 241, 216, 205, 45, 41, 97, 243, 67, 162, 191, 109, 60, 186, 172, 221 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8220), new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8221), new DateTime(2025, 2, 20, 20, 32, 22, 68, DateTimeKind.Utc).AddTicks(8221), new byte[] { 91, 189, 154, 49, 194, 49, 39, 166, 161, 181, 33, 40, 49, 219, 207, 58, 35, 47, 130, 195, 139, 247, 153, 198, 173, 229, 63, 96, 156, 88, 47, 75, 36, 154, 229, 162, 83, 210, 158, 52, 118, 227, 93, 25, 139, 91, 252, 254, 187, 192, 185, 28, 101, 37, 132, 156, 28, 183, 124, 24, 101, 204, 95, 57 }, new byte[] { 185, 91, 137, 204, 156, 194, 2, 115, 9, 21, 84, 57, 76, 156, 35, 121, 113, 184, 81, 176, 15, 74, 121, 52, 67, 153, 94, 187, 165, 42, 154, 0, 92, 179, 164, 26, 95, 47, 28, 172, 5, 153, 132, 90, 33, 92, 49, 112, 9, 82, 113, 91, 209, 116, 154, 1, 104, 55, 39, 93, 74, 79, 104, 186, 223, 83, 168, 170, 131, 121, 153, 181, 52, 196, 50, 89, 158, 18, 62, 152, 159, 182, 6, 183, 41, 165, 164, 227, 210, 75, 185, 84, 23, 98, 243, 254, 87, 137, 152, 119, 162, 153, 89, 119, 233, 208, 42, 143, 104, 160, 4, 235, 13, 199, 74, 97, 97, 252, 200, 235, 200, 149, 165, 105, 228, 0, 223, 35 } });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalSettings_MedicalId",
                table: "MedicalSettings",
                column: "MedicalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalSettings");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8451), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8454), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9812), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9813), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9813) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9815) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9817), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9818), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9817) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9819), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9820), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9819) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9821), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9822), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9821) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9823) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9825) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9827) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9828), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9829), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9829) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9830), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9831), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9831) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9832), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9833), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9833) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9834), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9835), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9834) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9836), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9837), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9836) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9838), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9839), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9840) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9842) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9843), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9844), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9844) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9845), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9846), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9846) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9847), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9848), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9848) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9849), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9850), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9851), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9852), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9853), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9854), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9854) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9855), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9856), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9855) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9857), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9858), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9861) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9862), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9863), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9864), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9865), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9866), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9867), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9868), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9869), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9870), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9871), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9870) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9875), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9876), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9876) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9877), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9878), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9878) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9879), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9880), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9881), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9882), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9881) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9883), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9884), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9883) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885), new DateTime(2025, 2, 14, 1, 41, 10, 158, DateTimeKind.Utc).AddTicks(9885) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "EmailTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8317), new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8319), new DateTime(2025, 2, 14, 1, 41, 10, 177, DateTimeKind.Utc).AddTicks(8318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 159, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 159, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1516), new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1518), new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(1518) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 166, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7301), new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7302), new DateTime(2025, 2, 14, 1, 41, 10, 169, DateTimeKind.Utc).AddTicks(7302) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(142));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 2, 14, 1, 41, 10, 172, DateTimeKind.Utc).AddTicks(4715), new byte[] { 0, 111, 14, 25, 223, 39, 19, 195, 27, 162, 189, 60, 187, 245, 98, 186, 212, 176, 14, 3, 186, 252, 107, 74, 205, 5, 86, 247, 120, 188, 159, 38, 201, 185, 208, 85, 147, 49, 160, 192, 0, 214, 93, 212, 85, 231, 238, 235, 126, 30, 182, 208, 243, 120, 225, 201, 26, 59, 103, 1, 46, 243, 161, 66 }, new byte[] { 117, 107, 59, 5, 199, 203, 156, 78, 19, 79, 184, 174, 211, 244, 23, 250, 113, 95, 98, 41, 100, 144, 21, 229, 43, 175, 144, 16, 97, 108, 82, 105, 31, 6, 140, 233, 135, 246, 244, 208, 135, 237, 188, 245, 11, 131, 159, 230, 90, 190, 134, 188, 29, 146, 88, 86, 191, 60, 196, 89, 0, 153, 240, 116, 240, 212, 51, 203, 2, 26, 133, 235, 199, 12, 40, 173, 154, 40, 61, 17, 251, 37, 143, 208, 65, 77, 158, 109, 175, 192, 150, 151, 84, 215, 239, 215, 237, 150, 8, 207, 158, 183, 155, 218, 215, 32, 13, 140, 91, 52, 53, 119, 238, 132, 251, 9, 52, 14, 154, 183, 176, 142, 214, 27, 51, 167, 28, 141 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6468), new DateTime(2025, 2, 14, 1, 41, 10, 174, DateTimeKind.Utc).AddTicks(6469), new byte[] { 203, 199, 175, 122, 115, 202, 221, 154, 191, 240, 48, 205, 55, 85, 94, 178, 233, 76, 253, 26, 9, 137, 76, 158, 21, 106, 47, 54, 82, 54, 134, 117, 122, 111, 130, 42, 248, 237, 214, 78, 231, 217, 1, 63, 5, 176, 14, 103, 43, 56, 95, 140, 183, 231, 154, 231, 230, 129, 237, 147, 24, 104, 94, 144 }, new byte[] { 95, 240, 231, 216, 64, 58, 247, 216, 21, 113, 137, 78, 25, 70, 228, 240, 254, 173, 48, 179, 101, 211, 48, 4, 154, 111, 228, 251, 89, 83, 144, 240, 250, 53, 186, 194, 56, 234, 222, 232, 100, 212, 195, 36, 120, 206, 7, 205, 92, 149, 25, 136, 119, 18, 185, 39, 1, 171, 32, 160, 220, 162, 208, 202, 133, 141, 236, 169, 57, 95, 72, 186, 175, 181, 10, 205, 4, 252, 239, 65, 106, 175, 88, 201, 214, 48, 189, 122, 6, 222, 189, 238, 218, 114, 232, 137, 239, 147, 155, 38, 115, 167, 74, 213, 214, 215, 209, 185, 206, 253, 248, 80, 29, 24, 59, 102, 77, 219, 47, 233, 159, 206, 163, 77, 115, 16, 193, 176 } });
        }
    }
}
