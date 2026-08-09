using SmartDigitalPsico.Domain.Events;

namespace SmartDigitalPsico.Domain.Interfaces.Notification
{
    /// <summary>
    /// Interface (contrato) responsável por INotificationDispatchJobService.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface INotificationDispatchJobService
    {
        /// <summary>
        /// Método ProcessPendingNotificationsAsync: executa a operação ProcessPendingNotificationsAsync.
        /// </summary>
        Task ProcessPendingNotificationsAsync();
        event EventHandler<NotificationProgressEventArgs>? ProgressChanged;
    }
}
