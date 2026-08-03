namespace SmartDigitalPsico.Domain.Interfaces
{
    /// <summary>
    /// Interface (contrato) responsável por IApiBaseController.
    /// Responsabilidade: contrato de abstração do domínio.
    /// Relação: implementado nas camadas Data/Service.
    /// </summary>
    public interface IApiBaseController
    {
        /// <summary>
        /// Método setUserIdCurrent: configura estado ou dependências.
        /// </summary>
        void setUserIdCurrent();

        /// <summary>
        /// Método setUserCurrentCulture: configura estado ou dependências.
        /// </summary>
        Task setUserCurrentCulture(long userId);

    }
}
