namespace SmartDigitalPsico.Domain.AppException
{
    /// <summary>
    /// Classe responsável por AppWarningException.
    /// Responsabilidade: componente do backend SmartDigitalPsico.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class AppWarningException : SmartDigitalPsicoAPI.Core.SDK.Domain.AppException.AppWarningException
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
