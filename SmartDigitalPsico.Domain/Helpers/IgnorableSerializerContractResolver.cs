using Newtonsoft.Json.Serialization;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public class IgnorableSerializerContractResolver : SmartDigitalPsico.Core.SDK.Domain.Helpers.IgnorableSerializerContractResolver
    {
        public IgnorableSerializerContractResolver(IEnumerable<string> propertiesToIgnore) : base(propertiesToIgnore) { }

        /// <summary>
        /// Exposes Core ignore rules for Domain.Test coverage (InternalsVisibleTo).
        /// </summary>
        public new void ApplyIgnoreRulesForTests(JsonProperty property)
            => base.ApplyIgnoreRulesForTests(property);
    }
}
