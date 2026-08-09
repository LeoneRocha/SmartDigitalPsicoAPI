namespace SmartDigitalPsico.Domain.Interfaces.Common
{
    /// <summary>
    /// Interface (contrato) responsável por IBackgroundJobService.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IBackgroundJobService
    {
        /// <summary>
        /// Método ExecuteNotificationProcessAsync: executa a operação ExecuteNotificationProcessAsync.
        /// </summary>
        Task ExecuteNotificationProcessAsync();
    }
}
