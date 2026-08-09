using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartDigitalPsico.Data.Migrations.MySql
{
    /// <inheritdoc />
    /// <summary>
    /// Classe responsável por UpdateNotificationTemplateDistinctBackgrounds.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public partial class UpdateNotificationTemplateDistinctBackgrounds : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Método Up: executa a operação Up.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(224, 242, 241, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(0, 150, 136, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Acesso Concedido</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seu acesso foi concedido com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(232, 234, 246, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(63, 81, 181, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Dados da Conta Atualizados</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seus dados da conta foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(243, 229, 245, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(156, 39, 176, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Confirmada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Sua consulta com o(a) médico(a) [{MedicalName}] foi confirmada.</p><p>Confira os detalhes e organize-se para comparecer no horário agendado:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(255, 243, 224, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(255, 152, 0, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Remarcada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Sua consulta com o(a) médico(a) [{MedicalName}] foi remarcada.</p><p>Confira os novos detalhes abaixo:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Nova Data de Início:</strong> [{StartDateTime}]</li><li><strong>Nova Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Por favor, confirme sua disponibilidade para o novo horário.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(255, 235, 238, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(244, 67, 54, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Cancelada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Informamos que sua consulta com o(a) médico(a) [{MedicalName}] foi cancelada.</p><p>Confira os dados da consulta cancelada:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se desejar reagendar ou obter mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(224, 247, 250, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(0, 188, 212, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Dados Médicos Atualizados</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seus dados médicos foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(227, 242, 253, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(33, 150, 243, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Lembrete de Consulta</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Este é um lembrete da sua consulta com o(a) médico(a) [{MedicalName}].</p><p>Confira os detalhes e organize-se para comparecer no horário agendado:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");
        }

        /// <inheritdoc />
        /// <summary>
        /// Método Down: executa a operação Down.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(0, 150, 136, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Acesso Concedido</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seu acesso foi concedido com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(63, 81, 181, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Dados da Conta Atualizados</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seus dados da conta foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 3L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(156, 39, 176, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Confirmada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Sua consulta com o(a) médico(a) [{MedicalName}] foi confirmada.</p><p>Confira os detalhes e organize-se para comparecer no horário agendado:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 4L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(255, 152, 0, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Remarcada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Sua consulta com o(a) médico(a) [{MedicalName}] foi remarcada.</p><p>Confira os novos detalhes abaixo:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Nova Data de Início:</strong> [{StartDateTime}]</li><li><strong>Nova Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Por favor, confirme sua disponibilidade para o novo horário.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 5L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(244, 67, 54, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Consulta Cancelada</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Informamos que sua consulta com o(a) médico(a) [{MedicalName}] foi cancelada.</p><p>Confira os dados da consulta cancelada:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se desejar reagendar ou obter mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 6L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(0, 188, 212, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Dados Médicos Atualizados</h1></div><div style=\"padding:20px;\"><p>Olá,</p><p>Seus dados médicos foram atualizados com sucesso.</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");

            migrationBuilder.UpdateData(
                schema: "dbo",
                table: "NotificationTemplate",
                keyColumn: "Id",
                keyValue: 7L,
                column: "Body",
                value: "<div style=\"font-family:Arial, sans-serif;background-color:rgba(244, 244, 249, 1);padding:20px;\"><div style=\"max-width:600px;margin:0 auto;background-color:rgba(255, 255, 255, 1);border-radius:10px;overflow:hidden;\"><div style=\"background-color:rgba(33, 150, 243, 1);padding:20px;text-align:center;\"><h1 style=\"margin:0;color:rgba(255, 255, 255, 1);\">Lembrete de Consulta</h1></div><div style=\"padding:20px;\"><p>Olá, [{PatientName}],</p><p>Este é um lembrete da sua consulta com o(a) médico(a) [{MedicalName}].</p><p>Confira os detalhes e organize-se para comparecer no horário agendado:</p><ul><li><strong>Título:</strong> [{Title}]</li><li><strong>Data de Início:</strong> [{StartDateTime}]</li><li><strong>Data de Término:</strong> [{EndDateTime}]</li><li><strong>Local:</strong> [{AppointmentLocation}]</li></ul><p><strong>Observação:</strong> [{Description}]</p><p>Se precisar de mais informações, entre em contato conosco.</p></div></div></div>");
        }
    }
}
