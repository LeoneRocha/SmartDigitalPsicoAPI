namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class EmailHelper
    {
        public static string ReplaceTokens(string template, Dictionary<string, string> tokens)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.EmailHelper.ReplaceTokens(template, tokens);
    }
}
