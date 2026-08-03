using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por NotificationRecordsTokenIdDropScheduleCalendarFk.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class NotificationRecordsTokenIdDropScheduleCalendarFk : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop FK if present (partial applies / prior runs).
            migrationBuilder.Sql(@"
                SET @fk := (
                    SELECT CONSTRAINT_NAME
                    FROM information_schema.TABLE_CONSTRAINTS
                    WHERE CONSTRAINT_SCHEMA = DATABASE()
                      AND TABLE_NAME = 'NotificationRecords'
                      AND CONSTRAINT_NAME = 'FK_NotificationRecords_ScheduleCalendar_ScheduleCalendarId'
                      AND CONSTRAINT_TYPE = 'FOREIGN KEY'
                    LIMIT 1
                );
                SET @sql := IF(@fk IS NULL, 'SELECT 1',
                    CONCAT('ALTER TABLE `NotificationRecords` DROP FOREIGN KEY `', @fk, '`'));
                PREPARE stmt FROM @sql;
                EXECUTE stmt;
                DEALLOCATE PREPARE stmt;
            ");

            migrationBuilder.AddColumn<Guid>(
                name: "TokenId",
                schema: "dbo",
                table: "NotificationRecords",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            // Backfill from ScheduleCalendar.UniqueToken before dropping ScheduleCalendarId.
            migrationBuilder.Sql(@"
                UPDATE `NotificationRecords` nr
                INNER JOIN `ScheduleCalendar` sc ON nr.ScheduleCalendarId = sc.Id
                SET nr.TokenId = sc.UniqueToken
                WHERE sc.UniqueToken IS NOT NULL
                  AND CHAR_LENGTH(sc.UniqueToken) = 36;
            ");

            migrationBuilder.Sql(@"
                SET @idx := (
                    SELECT INDEX_NAME
                    FROM information_schema.STATISTICS
                    WHERE TABLE_SCHEMA = DATABASE()
                      AND TABLE_NAME = 'NotificationRecords'
                      AND INDEX_NAME = 'IX_NotificationRecords_ScheduleCalendarId'
                    LIMIT 1
                );
                SET @sql := IF(@idx IS NULL, 'SELECT 1',
                    'ALTER TABLE `NotificationRecords` DROP INDEX `IX_NotificationRecords_ScheduleCalendarId`');
                PREPARE stmt FROM @sql;
                EXECUTE stmt;
                DEALLOCATE PREPARE stmt;
            ");

            migrationBuilder.DropColumn(
                name: "ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_TokenId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "TokenId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_TokenId_EventDate",
                schema: "dbo",
                table: "NotificationRecords",
                columns: new[] { "TokenId", "EventDate" });
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_NotificationRecords_TokenId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.DropIndex(
                name: "IX_NotificationRecords_TokenId_EventDate",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.AddColumn<long>(
                name: "ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                type: "bigint",
                nullable: true);

            migrationBuilder.Sql(@"
                UPDATE `NotificationRecords` nr
                INNER JOIN `ScheduleCalendar` sc ON sc.UniqueToken = nr.TokenId
                SET nr.ScheduleCalendarId = sc.Id;
            ");

            migrationBuilder.DropColumn(
                name: "TokenId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationRecords_ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "ScheduleCalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_ScheduleCalendar_ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "ScheduleCalendarId",
                principalSchema: "dbo",
                principalTable: "ScheduleCalendar",
                principalColumn: "Id");
        }
    }
}
