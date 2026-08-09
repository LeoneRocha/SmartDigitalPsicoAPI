using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por RenameNotificationTemplateTagApiToTemplateKey.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class RenameNotificationTemplateTagApiToTemplateKey : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TagApi",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "TemplateKey");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_TagApi",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_TemplateKey");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Unique",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_Language_TemplateKey_Unique");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_Language_TagApi_Enable",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_Language_TemplateKey_Enable");
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TemplateKey",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "TagApi");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_TemplateKey",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_TagApi");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_Language_TemplateKey_Unique",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_Language_TagApi_Unique");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationTemplate_Language_TemplateKey_Enable",
                schema: "dbo",
                table: "NotificationTemplate",
                newName: "IX_NotificationTemplate_Language_TagApi_Enable");
        }
    }
}
