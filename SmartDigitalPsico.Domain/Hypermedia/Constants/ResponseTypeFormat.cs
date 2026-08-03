using SmartDigitalPsico.Domain.Constants;

namespace SmartDigitalPsico.Domain.Hypermedia.Constants
{
    /// <summary>
    /// Classe responsável por ResponseTypeFormat.
    /// Responsabilidade: constantes compartilhadas do sistema.
    /// Relação: integra as camadas Domain/Data/Service/WebAPI do SmartDigitalPsico.
    /// </summary>
    public static class ResponseTypeFormat
    { 
        public const string DefaultGet = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPost = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPut = AppConfigConstants.ApplicationContentJon;
        public const string DefaultPatch = AppConfigConstants.ApplicationContentJon;
    }
}
