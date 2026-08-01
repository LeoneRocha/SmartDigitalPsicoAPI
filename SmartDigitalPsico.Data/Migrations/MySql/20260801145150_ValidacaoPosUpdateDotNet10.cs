using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    public partial class ValidacaoPosUpdateDotNet10 : Migration
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
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 30, DateTimeKind.Utc).AddTicks(574), new DateTime(2026, 8, 1, 14, 51, 50, 30, DateTimeKind.Utc).AddTicks(844), new DateTime(2026, 8, 1, 14, 51, 50, 30, DateTimeKind.Utc).AddTicks(733) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3863), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3868), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3867) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3872), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3872), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3872) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3873), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3874), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3874) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3875), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3876), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3875) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3877), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3877), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3877) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3878), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3879), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3879) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3891), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3891), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3891) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3892), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3893), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3893) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3894), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3895), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3894) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3896), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3896), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3896) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3897), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3898), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3898) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3913), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3915), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3914) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3916), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3917), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3916) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3918), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3918) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3919), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3920), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3920) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3921), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3922), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3921) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3923), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3923), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3923) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3924), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3925), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3925) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3926), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3926), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3926) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3928), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3928), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3928) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3929), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3930), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3931), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3931), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3931) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3939), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3941), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3942), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3944), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3945), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3946), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3946) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3947), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3948), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3949), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3950), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3951), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3952), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3954), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3955), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3956), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3956), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3959), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3959), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3961), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3962), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3963), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3964), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3964) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3966), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3966), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3966) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3968), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3968), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3968) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3969), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3970), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3970) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3971), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3971), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3973), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3973), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3973) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3974), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3975), new DateTime(2026, 8, 1, 14, 51, 50, 35, DateTimeKind.Utc).AddTicks(3974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 43, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 43, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(6946), new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7648), new DateTime(2026, 2, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7650), new DateTime(2026, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7651), new DateTime(2026, 4, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7652), new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7656), new DateTime(2026, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7657), new DateTime(2026, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7658), new DateTime(2026, 10, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7659), new DateTime(2026, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7661), new DateTime(2026, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 49, DateTimeKind.Utc).AddTicks(7662), new DateTime(2026, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 61, DateTimeKind.Utc).AddTicks(7062), new DateTime(2026, 8, 1, 14, 51, 50, 61, DateTimeKind.Utc).AddTicks(7066), new DateTime(2026, 8, 1, 14, 51, 50, 61, DateTimeKind.Utc).AddTicks(7067) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(352), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(358), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(358) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(361), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(362), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(363), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(364), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(364) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(365), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(366), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(366) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(367), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(368), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(368) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(369), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(370), new DateTime(2026, 8, 1, 14, 51, 50, 72, DateTimeKind.Utc).AddTicks(370) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1311), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1313), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1313) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1316), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1316), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1316) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1318), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1318), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1327), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1327), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1327) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1329), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1329), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1329) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1331), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1331), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1331) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1332), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1333), new DateTime(2026, 8, 1, 14, 51, 50, 74, DateTimeKind.Utc).AddTicks(1333) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 75, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 75, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 75, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(3431), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(3436), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5671), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5671), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5672) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5678), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5678), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5678) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5681), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5682), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5685), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5686), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5689), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5689), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5692), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5692), new DateTime(2026, 8, 1, 14, 51, 50, 82, DateTimeKind.Utc).AddTicks(5692) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8281));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 91, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3052));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2026, 8, 1, 14, 51, 50, 96, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 98, DateTimeKind.Utc).AddTicks(4474), new DateTime(2026, 8, 1, 14, 51, 50, 98, DateTimeKind.Utc).AddTicks(4477), new DateTime(2026, 8, 1, 14, 51, 50, 98, DateTimeKind.Utc).AddTicks(4477), new byte[] { 255, 33, 28, 105, 67, 228, 255, 42, 122, 11, 205, 251, 91, 166, 141, 163, 190, 223, 169, 205, 238, 88, 22, 170, 101, 125, 161, 156, 245, 208, 175, 216, 71, 238, 155, 120, 37, 52, 73, 121, 7, 43, 134, 120, 92, 163, 106, 42, 204, 83, 163, 202, 224, 5, 20, 51, 179, 30, 63, 204, 3, 24, 192, 76 }, new byte[] { 115, 108, 70, 28, 51, 205, 78, 9, 206, 123, 192, 41, 109, 0, 223, 74, 5, 103, 58, 175, 26, 109, 109, 17, 78, 140, 41, 211, 251, 92, 191, 92, 248, 203, 222, 173, 253, 68, 51, 4, 98, 239, 254, 53, 106, 2, 171, 48, 36, 223, 65, 193, 97, 84, 158, 186, 124, 91, 14, 41, 104, 239, 173, 51, 146, 150, 239, 28, 145, 228, 48, 161, 8, 107, 121, 94, 100, 2, 165, 251, 153, 235, 2, 171, 205, 83, 68, 9, 97, 241, 147, 221, 96, 254, 124, 66, 199, 192, 19, 239, 182, 86, 249, 242, 34, 193, 12, 93, 62, 71, 76, 235, 205, 121, 48, 113, 223, 129, 236, 108, 62, 46, 27, 13, 164, 136, 65, 105 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2026, 8, 1, 14, 51, 50, 143, DateTimeKind.Utc).AddTicks(781), new DateTime(2026, 8, 1, 14, 51, 50, 143, DateTimeKind.Utc).AddTicks(785), new DateTime(2026, 8, 1, 14, 51, 50, 143, DateTimeKind.Utc).AddTicks(785), new byte[] { 200, 160, 24, 181, 71, 174, 40, 55, 89, 64, 209, 243, 26, 169, 246, 1, 226, 57, 123, 58, 167, 88, 200, 196, 232, 22, 48, 132, 72, 27, 12, 65, 39, 248, 112, 155, 224, 34, 218, 19, 197, 234, 94, 73, 72, 57, 252, 164, 148, 152, 211, 125, 156, 57, 47, 114, 79, 63, 230, 229, 122, 163, 202, 225 }, new byte[] { 46, 13, 212, 233, 15, 125, 229, 154, 161, 248, 96, 111, 236, 50, 156, 25, 171, 242, 142, 80, 89, 210, 236, 135, 181, 122, 189, 51, 94, 194, 68, 190, 150, 88, 150, 247, 219, 129, 80, 80, 235, 150, 20, 28, 215, 219, 247, 137, 252, 101, 77, 245, 243, 6, 197, 216, 244, 20, 71, 203, 11, 26, 99, 7, 32, 178, 42, 81, 102, 173, 169, 168, 150, 113, 50, 24, 3, 29, 157, 147, 111, 206, 81, 187, 45, 34, 229, 130, 184, 29, 48, 232, 117, 74, 140, 239, 190, 167, 128, 240, 84, 50, 75, 190, 50, 116, 202, 226, 184, 188, 149, 150, 45, 207, 34, 3, 132, 127, 90, 178, 86, 178, 218, 150, 175, 175, 90, 156 } });
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
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8616), new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8620), new DateTime(2025, 3, 30, 15, 25, 43, 326, DateTimeKind.Utc).AddTicks(8619) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3979), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3986), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3986) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3988), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3989), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3990), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3991), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3992), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3993), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3996) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3997), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3998), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3998) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3999), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4000), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4001), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4004), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4007) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4008), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4009), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4009) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4010), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4011), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4010) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4012), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4013), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4014) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4015), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4016), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4016) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4043) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4047) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4048), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4049), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4049) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4050), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4051), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4052), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4053), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4054) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4055), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4056), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4056) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4057), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4058), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4059), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4060), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4059) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4061), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4062), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4061) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4063) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4065) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4066), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4067), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4067) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4068), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4069), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4068) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4070), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4071), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4070) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4072) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4074) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4075), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4076), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4077), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4078), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4079), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4080), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4079) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4081) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083), new DateTime(2025, 3, 30, 15, 25, 43, 327, DateTimeKind.Utc).AddTicks(4083) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 328, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 328, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3540), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3547), new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3549), new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3550), new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3551), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3554), new DateTime(2025, 6, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3556), new DateTime(2025, 9, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3557), new DateTime(2025, 10, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3558), new DateTime(2025, 11, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3590), new DateTime(2025, 11, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Leaves",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "StartDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 332, DateTimeKind.Utc).AddTicks(3592), new DateTime(2025, 12, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7946), new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7948), new DateTime(2025, 3, 30, 15, 25, 43, 339, DateTimeKind.Utc).AddTicks(7948) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8681), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8683), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8682) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8686), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8687), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8686) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8688), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8689), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8689) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8691), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8692), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8691) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8693), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8694), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8694) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationRules",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8695), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8696), new DateTime(2025, 3, 30, 15, 25, 43, 342, DateTimeKind.Utc).AddTicks(8696) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2047), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2048), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2048) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2050) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2052), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2053), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2052) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2054), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2055), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2055) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2056), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2057), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2056) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2058), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2059), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2058) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2060), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2061), new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(2060) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4302));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 343, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3137), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3138), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3139) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3156), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3157), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3162), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3162), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3169), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3170), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3173), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3174), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3177), new DateTime(2025, 3, 30, 15, 25, 43, 347, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 350, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2025, 3, 30, 15, 25, 43, 352, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3382), new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3383), new DateTime(2025, 3, 30, 15, 25, 43, 353, DateTimeKind.Utc).AddTicks(3383), new byte[] { 239, 236, 156, 77, 230, 105, 152, 99, 15, 84, 206, 86, 169, 193, 11, 230, 49, 107, 69, 172, 222, 180, 161, 76, 42, 151, 177, 1, 146, 19, 175, 252, 4, 250, 124, 191, 95, 169, 31, 190, 92, 53, 228, 74, 127, 97, 182, 185, 211, 46, 74, 113, 125, 6, 40, 205, 25, 146, 11, 227, 63, 159, 129, 181 }, new byte[] { 135, 91, 225, 189, 12, 159, 120, 179, 125, 124, 47, 54, 108, 10, 137, 234, 137, 37, 149, 166, 185, 21, 76, 28, 197, 142, 30, 23, 26, 69, 154, 10, 242, 202, 252, 204, 109, 92, 7, 34, 217, 112, 168, 129, 117, 129, 69, 109, 241, 113, 117, 94, 58, 167, 58, 138, 149, 2, 124, 74, 167, 55, 245, 17, 138, 153, 200, 123, 33, 63, 249, 78, 152, 11, 49, 123, 200, 166, 115, 95, 200, 187, 46, 186, 147, 18, 226, 26, 51, 53, 83, 185, 27, 145, 27, 245, 169, 153, 222, 50, 143, 135, 67, 191, 109, 84, 236, 133, 188, 16, 126, 41, 25, 92, 233, 97, 201, 41, 51, 54, 164, 62, 233, 19, 53, 227, 175, 242 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5813), new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5814), new DateTime(2025, 3, 30, 15, 25, 43, 355, DateTimeKind.Utc).AddTicks(5814), new byte[] { 21, 46, 165, 170, 165, 124, 150, 81, 18, 253, 168, 136, 252, 227, 190, 19, 79, 237, 72, 53, 216, 129, 239, 28, 129, 227, 204, 57, 232, 162, 164, 199, 227, 133, 102, 54, 151, 27, 190, 209, 141, 86, 153, 118, 81, 223, 104, 73, 182, 24, 28, 246, 159, 126, 51, 93, 60, 196, 34, 145, 99, 70, 41, 8 }, new byte[] { 134, 50, 211, 221, 221, 71, 146, 0, 20, 17, 15, 23, 252, 185, 115, 190, 48, 247, 54, 14, 167, 52, 111, 62, 100, 137, 47, 252, 22, 13, 153, 140, 185, 186, 52, 110, 156, 203, 215, 72, 183, 253, 106, 45, 105, 54, 235, 124, 41, 41, 238, 208, 61, 219, 167, 227, 167, 118, 183, 129, 244, 144, 118, 177, 128, 223, 22, 20, 105, 98, 136, 130, 129, 248, 234, 191, 117, 204, 207, 123, 212, 181, 160, 222, 28, 132, 97, 61, 232, 104, 30, 220, 198, 27, 21, 134, 60, 139, 236, 163, 78, 179, 81, 72, 4, 8, 21, 59, 120, 149, 154, 21, 230, 189, 139, 118, 201, 98, 153, 90, 211, 104, 220, 121, 94, 161, 67, 117 } });
        }
    }
}
