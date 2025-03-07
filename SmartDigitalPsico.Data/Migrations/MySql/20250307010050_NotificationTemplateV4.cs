using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class NotificationTemplateV4 : Migration
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8950), new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8954), new DateTime(2025, 3, 6, 23, 47, 57, 701, DateTimeKind.Utc).AddTicks(8953) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4655), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4664), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4663) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4665), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4666), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4666) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4668) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4669), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4670), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4670) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4671), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4672), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4673), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4674), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4674) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4675), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4676), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4675) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4677), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4678), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4677) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4679) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4681) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4682), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4683), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4683) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4684), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4685), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4685) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4686), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4687), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4688), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4689), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4688) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4690) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4692), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4693), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4694), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4695), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4698) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4699), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4700), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4700) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4701), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4702), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4702) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4703), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4704), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4704) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4705), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4706), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4706) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4707), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4708), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4707) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4709), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4710), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4709) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4714), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4715), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4715) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4716), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4717), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4717) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4718), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4719), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4718) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4720), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4721), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4720) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4724) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4725), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4726), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4727), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4728), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4727) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4729), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4730), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4729) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4731) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4734), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4735), new DateTime(2025, 3, 6, 23, 47, 57, 702, DateTimeKind.Utc).AddTicks(4735) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 703, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 703, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9308));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 706, DateTimeKind.Utc).AddTicks(9313));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9073), new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9075), new DateTime(2025, 3, 6, 23, 47, 57, 713, DateTimeKind.Utc).AddTicks(9075) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3283), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3286), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3285) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3288), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3289), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3291), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3292), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3293), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3294), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3294) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3298), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3299), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(3298) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6646), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6648), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6647) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6650) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6652), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6653), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6652) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6654), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6655), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6656), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6657), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6656) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6658), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6659), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6658) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6660), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6661), new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(6660) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 722, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4942), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4943), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4970), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4970), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4975), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4976), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4980), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4984) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4987), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4988), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994), new DateTime(2025, 3, 6, 23, 47, 57, 726, DateTimeKind.Utc).AddTicks(4994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 729, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5418));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 6, 23, 47, 57, 730, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1290), new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1291), new DateTime(2025, 3, 6, 23, 47, 57, 731, DateTimeKind.Utc).AddTicks(1292), new byte[] { 70, 29, 171, 242, 170, 46, 91, 177, 239, 144, 188, 38, 251, 134, 82, 136, 123, 63, 159, 102, 159, 128, 246, 230, 124, 153, 66, 41, 142, 217, 123, 224, 20, 249, 162, 247, 223, 49, 145, 196, 225, 201, 60, 9, 67, 255, 205, 198, 137, 141, 231, 20, 104, 25, 80, 251, 97, 153, 182, 57, 46, 123, 214, 198 }, new byte[] { 252, 203, 85, 134, 251, 98, 255, 141, 7, 141, 2, 233, 70, 99, 100, 55, 78, 60, 45, 24, 225, 212, 230, 247, 91, 91, 103, 32, 191, 86, 107, 163, 14, 4, 57, 58, 234, 85, 55, 68, 66, 219, 166, 100, 19, 92, 27, 75, 116, 95, 54, 131, 58, 176, 251, 121, 152, 223, 22, 151, 141, 60, 159, 20, 134, 195, 134, 176, 79, 78, 110, 112, 207, 14, 154, 140, 102, 44, 134, 157, 27, 232, 137, 58, 77, 174, 11, 38, 209, 206, 213, 254, 117, 244, 13, 165, 73, 95, 27, 173, 148, 18, 98, 29, 108, 88, 159, 61, 190, 119, 188, 66, 167, 111, 49, 217, 92, 48, 128, 63, 52, 69, 133, 42, 220, 139, 162, 187 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3106), new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3107), new DateTime(2025, 3, 6, 23, 47, 57, 733, DateTimeKind.Utc).AddTicks(3108), new byte[] { 217, 199, 221, 91, 77, 203, 215, 117, 66, 42, 88, 254, 100, 109, 86, 142, 118, 44, 150, 233, 205, 181, 126, 177, 48, 76, 185, 29, 55, 206, 235, 42, 163, 167, 85, 160, 25, 182, 230, 176, 18, 80, 28, 54, 186, 188, 142, 240, 52, 93, 23, 92, 111, 164, 134, 233, 174, 198, 40, 253, 92, 121, 132, 26 }, new byte[] { 250, 73, 224, 250, 97, 197, 157, 63, 35, 41, 188, 165, 15, 198, 4, 166, 127, 89, 216, 157, 185, 25, 72, 165, 114, 140, 21, 80, 87, 135, 117, 196, 132, 166, 223, 158, 162, 155, 146, 111, 46, 33, 154, 110, 124, 5, 70, 74, 66, 171, 198, 146, 249, 199, 62, 223, 78, 247, 37, 16, 38, 182, 254, 132, 91, 182, 126, 54, 253, 127, 113, 191, 1, 27, 107, 115, 126, 86, 87, 70, 94, 244, 36, 111, 35, 251, 121, 153, 250, 59, 233, 159, 182, 53, 232, 200, 197, 164, 107, 172, 160, 107, 134, 125, 186, 130, 33, 44, 58, 15, 185, 172, 106, 26, 174, 127, 114, 73, 50, 116, 241, 160, 76, 249, 44, 235, 91, 181 } });
        }
    }
}
