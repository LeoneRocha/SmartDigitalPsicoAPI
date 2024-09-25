using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAuditDataLogv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Idx_AuditDataEntityLog_TableName_Operation_Inc_",
                schema: "dbo",
                table: "AuditDataEntityLog",
                newName: "Idx_AuditDataEntityLog_TableName_Operation_Inc_AuditDate_UserAuditedId");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2724), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2726) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2933), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2934), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2934) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2936) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2938) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2939), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2940), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2940) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2941), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2942), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2942) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2943), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2944), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2943) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2945), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2946), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2945) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2948), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2949), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2949) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2950), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2951), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2951) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2952), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2953), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2952) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2954), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2955), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2954) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2956) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2957), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2958), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2958) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2959), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2960) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2961), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2962), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2961) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2963), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2964), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2963) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2965) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2967) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2968), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2969) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2970), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2971), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2971) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2972), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2973), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2972) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2976) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2977), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2978), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2978) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2979), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2980), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2979) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2981), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2982), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2981) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2983) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2984), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2985), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2985) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2986), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2987) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2988), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2989), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2990) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2992) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2993), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2994), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2994) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2995), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2996), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2995) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2997) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(2999) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3000), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3001), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3001) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3002), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3003), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3002) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3233) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3462), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3463), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3463) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3577));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3579));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3677));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 9, 25, 2, 28, 29, 551, DateTimeKind.Utc).AddTicks(3782), new byte[] { 41, 88, 55, 66, 191, 229, 116, 203, 255, 126, 97, 109, 164, 188, 81, 133, 238, 80, 147, 119, 123, 49, 107, 91, 123, 114, 156, 119, 130, 200, 67, 78, 89, 108, 244, 201, 200, 136, 177, 89, 65, 212, 253, 149, 74, 125, 152, 210, 97, 87, 7, 50, 166, 25, 222, 231, 125, 136, 112, 233, 247, 197, 185, 114 }, new byte[] { 232, 87, 48, 23, 95, 4, 199, 234, 77, 93, 192, 44, 47, 215, 195, 142, 118, 52, 116, 82, 50, 202, 83, 210, 113, 221, 38, 108, 164, 35, 249, 14, 110, 62, 180, 191, 80, 250, 205, 15, 141, 169, 121, 208, 209, 125, 4, 182, 140, 88, 209, 61, 175, 122, 240, 204, 81, 211, 148, 107, 78, 238, 58, 244, 212, 221, 217, 6, 255, 174, 54, 220, 183, 25, 107, 13, 118, 173, 65, 178, 230, 75, 12, 213, 147, 130, 40, 245, 194, 205, 45, 128, 72, 167, 141, 123, 102, 228, 156, 123, 253, 141, 67, 74, 251, 12, 139, 121, 229, 103, 245, 97, 155, 240, 24, 46, 141, 63, 171, 27, 235, 140, 27, 109, 195, 248, 77, 205 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5413), new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5414), new DateTime(2024, 9, 25, 2, 28, 29, 553, DateTimeKind.Utc).AddTicks(5414), new byte[] { 13, 136, 152, 125, 7, 102, 13, 153, 180, 161, 170, 203, 134, 127, 87, 1, 171, 154, 10, 124, 26, 237, 227, 77, 7, 93, 113, 59, 222, 171, 236, 194, 128, 131, 239, 34, 212, 112, 179, 215, 34, 177, 240, 131, 219, 225, 135, 62, 177, 142, 6, 128, 160, 200, 220, 230, 68, 203, 3, 32, 234, 124, 252, 70 }, new byte[] { 60, 120, 32, 51, 241, 157, 29, 14, 185, 88, 58, 66, 47, 249, 153, 220, 0, 225, 78, 18, 172, 25, 237, 91, 118, 254, 135, 102, 64, 156, 181, 224, 13, 147, 42, 0, 246, 229, 62, 52, 115, 167, 141, 212, 89, 51, 214, 96, 212, 15, 12, 9, 171, 208, 43, 68, 251, 126, 67, 218, 5, 1, 222, 40, 13, 222, 253, 97, 239, 109, 175, 102, 202, 196, 156, 69, 5, 192, 148, 254, 45, 126, 153, 52, 38, 245, 77, 101, 54, 147, 60, 93, 198, 67, 177, 218, 126, 77, 184, 198, 124, 67, 113, 176, 115, 71, 168, 191, 0, 105, 159, 131, 36, 32, 143, 149, 158, 143, 202, 159, 206, 145, 17, 44, 166, 156, 177, 227 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameIndex(
                name: "Idx_AuditDataEntityLog_TableName_Operation_Inc_AuditDate_UserAuditedId",
                schema: "dbo",
                table: "AuditDataEntityLog",
                newName: "Idx_AuditDataEntityLog_TableName_Operation_Inc_");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationConfigSetting",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8143), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8352), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8353), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8355), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8355) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8357), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8358), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8357) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8359), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8361), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8362), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8363), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8364), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8363) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8365) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8367) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8368), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8369), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8369) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8371) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8372), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8373), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8373) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8374), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8375), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8374) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8376), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8377), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8376) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8378), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8380) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8382) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8384) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8385), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8386), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8386) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8388), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8388) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8390), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8389) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8391), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8392), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8391) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8393), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8394), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8393) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8395) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8396), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8397), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8397) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8399), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8399) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8400), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8401), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8401) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8404), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8404) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8406), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8406) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8408) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8410) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8411), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8412), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8412) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8413), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8414), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8414) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8416), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8416) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8417), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8418), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8417) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8419), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8421), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8422), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8423), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8424), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8423) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "ApplicationLanguage",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8425), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8426), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8425) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Gender",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Medical",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8645), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8646), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8646) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Office",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Patient",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "RoleGroup",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9130));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "Specialty",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9237), new DateTime(2024, 9, 25, 2, 24, 16, 111, DateTimeKind.Utc).AddTicks(9238), new byte[] { 202, 60, 15, 105, 181, 91, 134, 70, 79, 49, 249, 150, 1, 113, 89, 26, 196, 15, 254, 152, 88, 213, 209, 199, 60, 59, 28, 190, 149, 16, 232, 17, 115, 26, 178, 107, 220, 185, 27, 8, 227, 243, 97, 22, 78, 66, 95, 188, 9, 250, 251, 174, 201, 162, 114, 180, 217, 32, 9, 182, 78, 221, 99, 201 }, new byte[] { 164, 67, 163, 162, 226, 139, 1, 9, 81, 87, 253, 115, 221, 129, 249, 132, 109, 213, 73, 129, 25, 224, 42, 35, 88, 156, 51, 75, 33, 31, 246, 205, 146, 110, 156, 146, 230, 150, 1, 224, 138, 62, 43, 35, 250, 200, 18, 172, 33, 203, 23, 208, 99, 42, 24, 165, 177, 121, 255, 25, 23, 45, 26, 110, 230, 111, 176, 136, 215, 88, 69, 55, 243, 70, 19, 64, 236, 155, 202, 213, 105, 167, 234, 146, 91, 2, 41, 220, 154, 3, 72, 24, 186, 107, 208, 225, 221, 14, 221, 121, 132, 42, 250, 203, 125, 216, 59, 182, 138, 24, 167, 253, 162, 116, 180, 221, 62, 241, 126, 17, 69, 45, 73, 45, 132, 55, 32, 127 } });

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "User",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedDate", "LastAccessDate", "ModifyDate", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(725), new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 9, 25, 2, 24, 16, 114, DateTimeKind.Utc).AddTicks(726), new byte[] { 181, 219, 196, 6, 106, 129, 91, 189, 20, 197, 178, 199, 77, 35, 216, 33, 34, 246, 234, 85, 108, 217, 25, 5, 250, 59, 181, 205, 188, 126, 32, 206, 31, 168, 10, 69, 213, 208, 132, 188, 219, 70, 153, 153, 85, 77, 60, 150, 83, 2, 0, 76, 86, 234, 176, 151, 12, 139, 19, 62, 147, 171, 155, 176 }, new byte[] { 215, 98, 101, 170, 208, 158, 207, 16, 213, 83, 93, 107, 195, 190, 82, 117, 12, 81, 64, 16, 42, 155, 118, 51, 87, 135, 6, 196, 173, 199, 207, 71, 219, 154, 161, 182, 196, 223, 94, 216, 248, 97, 44, 116, 154, 162, 88, 207, 143, 169, 104, 127, 182, 173, 117, 40, 65, 144, 94, 179, 211, 5, 116, 70, 243, 30, 105, 59, 46, 241, 164, 13, 151, 17, 164, 49, 101, 99, 119, 164, 39, 219, 102, 130, 165, 113, 152, 127, 49, 123, 116, 188, 155, 76, 149, 30, 196, 62, 50, 175, 41, 252, 48, 208, 225, 140, 200, 240, 12, 215, 64, 63, 27, 218, 205, 66, 197, 220, 149, 33, 189, 139, 152, 81, 230, 28, 208, 187 } });
        }
    }
}
