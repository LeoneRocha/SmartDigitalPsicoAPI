using SmartDigitalPsico.Core.SDK.Domain.VO;

using SmartDigitalPsico.Domain.Interfaces.Notification;
namespace SmartDigitalPsico.Service
{
    /// <summary>
    /// Classe responsável por SmsService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: suporta Services e jobs de background.
    /// </summary>
    public class SmsService : ISmsService
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
