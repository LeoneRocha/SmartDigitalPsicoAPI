using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por DropMedicalCalendarAndScheduleBatch.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class DropMedicalCalendarAndScheduleBatch : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // FK may already be absent (prior partial apply / DropFk allow-truncate).
            migrationBuilder.Sql(@"
                SET @fk := (
                    SELECT CONSTRAINT_NAME
                    FROM information_schema.TABLE_CONSTRAINTS
                    WHERE CONSTRAINT_SCHEMA = DATABASE()
                      AND TABLE_NAME = 'NotificationRecords'
                      AND CONSTRAINT_NAME = 'FK_NotificationRecords_MedicalCalendar_MedicalCalendarId'
                      AND CONSTRAINT_TYPE = 'FOREIGN KEY'
                    LIMIT 1
                );
                SET @sql := IF(@fk IS NULL, 'SELECT 1',
                    CONCAT('ALTER TABLE `NotificationRecords` DROP FOREIGN KEY `', @fk, '`'));
                PREPARE stmt FROM @sql;
                EXECUTE stmt;
                DEALLOCATE PREPARE stmt;
            ");

            // Backfill MedicalCalendarId → ScheduleCalendar.Id (via TokenRecurrence = UniqueToken)
            // before rename; unmatched ids become NULL so the new FK succeeds.
            migrationBuilder.Sql(@"
                UPDATE `NotificationRecords` nr
                INNER JOIN `MedicalCalendar` mc ON nr.MedicalCalendarId = mc.Id
                INNER JOIN `ScheduleCalendar` sc ON sc.UniqueToken = mc.TokenRecurrence
                SET nr.MedicalCalendarId = sc.Id;
            ");

            migrationBuilder.Sql(@"
                UPDATE `NotificationRecords` nr
                LEFT JOIN `ScheduleCalendar` sc ON nr.MedicalCalendarId = sc.Id
                SET nr.MedicalCalendarId = NULL
                WHERE nr.MedicalCalendarId IS NOT NULL AND sc.Id IS NULL;
            ");

            migrationBuilder.RenameColumn(
                name: "MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                newName: "ScheduleCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationRecords_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                newName: "IX_NotificationRecords_ScheduleCalendarId");

            migrationBuilder.DropTable(
                name: "MedicalCalendar",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "ScheduleBatch",
                schema: "dbo");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_ScheduleCalendar_ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "ScheduleCalendarId",
                principalSchema: "dbo",
                principalTable: "ScheduleCalendar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationRecords_ScheduleCalendar_ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords");

            migrationBuilder.RenameColumn(
                name: "ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                newName: "MedicalCalendarId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationRecords_ScheduleCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                newName: "IX_NotificationRecords_MedicalCalendarId");

            migrationBuilder.CreateTable(
                name: "MedicalCalendar",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    ColorCategoryHexa = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Description = table.Column<string>(type: "text", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    EndDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAllDay = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPushedCalendar = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Location = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ReasonCancellation = table.Column<string>(type: "text", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceCount = table.Column<short>(type: "smallint", nullable: true),
                    RecurrenceDays = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    RecurrenceEndDate = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    RecurrenceType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Status = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    TimeZone = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    Title = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    TokenRecurrence = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalCalendar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_Medical_MedicalId",
                        column: x => x.MedicalId,
                        principalSchema: "dbo",
                        principalTable: "Medical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_Patient_PatientId",
                        column: x => x.PatientId,
                        principalSchema: "dbo",
                        principalTable: "Patient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_User_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MedicalCalendar_User_ModifyUserId",
                        column: x => x.ModifyUserId,
                        principalSchema: "dbo",
                        principalTable: "User",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "latin1");

            migrationBuilder.CreateTable(
                name: "ScheduleBatch",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedUserId = table.Column<long>(type: "bigint", nullable: true),
                    MedicalId = table.Column<long>(type: "bigint", nullable: false),
                    ModifyUserId = table.Column<long>(type: "bigint", nullable: true),
                    PatientId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EndPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastAccessDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ScheduleData = table.Column<string>(type: "text", maxLength: 65535, nullable: false)
                        .Annotation("MySql:CharSet", "latin1"),
                    StartPeriod = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UniqueToken = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "latin1")
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

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_Inc_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "TokenRecurrence");

            migrationBuilder.CreateIndex(
                name: "Idx_TokenRecurrence_PatientId_MedicalId_StartDateTime_EndDateTime_TokenRecurrence",
                schema: "dbo",
                table: "MedicalCalendar",
                columns: new[] { "TokenRecurrence", "PatientId", "MedicalId", "StartDateTime", "EndDateTime" });

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_CreatedUserId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_MedicalId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "MedicalId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_ModifyUserId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "ModifyUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCalendar_PatientId",
                schema: "dbo",
                table: "MedicalCalendar",
                column: "PatientId");

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

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleBatch_UniqueToken",
                schema: "dbo",
                table: "ScheduleBatch",
                column: "UniqueToken",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationRecords_MedicalCalendar_MedicalCalendarId",
                schema: "dbo",
                table: "NotificationRecords",
                column: "MedicalCalendarId",
                principalSchema: "dbo",
                principalTable: "MedicalCalendar",
                principalColumn: "Id");
        }
    }
}
