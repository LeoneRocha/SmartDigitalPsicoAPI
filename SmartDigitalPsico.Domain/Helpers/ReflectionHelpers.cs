namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class ReflectionHelpers
    {
        public static IOrderedEnumerable<System.Reflection.PropertyInfo> GetProperties(object dataObject, List<string> propertiesToIgnore)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ReflectionHelpers.GetProperties(dataObject, propertiesToIgnore);

        public static string GetLabelProperty(System.Reflection.PropertyInfo property)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.ReflectionHelpers.GetLabelProperty(property);
    }
}
