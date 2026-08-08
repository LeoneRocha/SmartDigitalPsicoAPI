using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Service.Infrastructure.Notification
{
    using User = SmartDigitalPsico.Domain.EntityModels.User;
    using Patient = SmartDigitalPsico.Domain.EntityModels.Patient;
    using Medical = SmartDigitalPsico.Domain.EntityModels.Medical;
    using RoleGroup = SmartDigitalPsico.Domain.EntityModels.RoleGroup;
    using Gender = SmartDigitalPsico.Domain.EntityModels.Gender;
    using Leaves = SmartDigitalPsico.Domain.EntityModels.Leaves;
    using Office = SmartDigitalPsico.Domain.EntityModels.Office;
    using Specialty = SmartDigitalPsico.Domain.EntityModels.Specialty;
    /// <summary>
    /// Classe responsável por WhatsAppService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class WhatsAppService : IWhatsAppService
    {
        /// <summary>
        /// Método SendAsync: dispara notificação ou comunicação.
        /// </summary>
        public async Task SendAsync(DataNotificationTemplateVO template, Dictionary<string, string> tokens)
        {
            await Task.CompletedTask;
        }
    }
}
