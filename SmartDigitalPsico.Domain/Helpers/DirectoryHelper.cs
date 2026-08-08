using Microsoft.Extensions.Configuration;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class DirectoryHelper
    {
        public static string GetDiretoryTemp(IConfiguration configuration)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretoryTemp(configuration);

        public static string GetDiretory(string pathCreate)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetDiretory(pathCreate);

        public static string GetPathSaveCache(string pathCache)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.DirectoryHelper.GetPathSaveCache(pathCache);
    }
}
