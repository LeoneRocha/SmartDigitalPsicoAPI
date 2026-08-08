namespace SmartDigitalPsicoAPI.Core.SDK.Domain.AppException
{
    /// <summary>
    /// Classe responsável por AppWarningException.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public class AppWarningException : Exception
    {
        /// <summary>
        /// Método AppWarningException: executa a operação AppWarningException.
        /// </summary>
        public AppWarningException()
        {
        }

        /// <summary>
        /// Método AppWarningException: executa a operação AppWarningException.
        /// </summary>
        public AppWarningException(string? message) : base(message)
        {
        }

        /// <summary>
        /// Método AppWarningException: executa a operação AppWarningException.
        /// </summary>
        public AppWarningException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
