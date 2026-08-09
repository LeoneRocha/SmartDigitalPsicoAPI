namespace SmartDigitalPsico.Core.SDK.Domain.Interfaces.Infrastructure
{
    /// <summary>
    /// Interface (contrato) responsável por IStorageQueueContract.
    /// Responsabilidade: infraestrutura transversal (cache, notificação, etc.).
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public interface IStorageQueueContract
    {
        /// <summary>
        /// Método EnqueueMessageAsync: executa a operação EnqueueMessageAsync.
        /// </summary>
        Task EnqueueMessageAsync(string message);
        /// <summary>
        /// Método DequeueMessageAsync: executa a operação DequeueMessageAsync.
        /// </summary>
        Task<string> DequeueMessageAsync();
        /// <summary>
        /// Método DeleteMessageAsync: remove ou cancela um registro/recurso.
        /// </summary>
        Task DeleteMessageAsync(string messageId, string popReceipt);
    }
}
