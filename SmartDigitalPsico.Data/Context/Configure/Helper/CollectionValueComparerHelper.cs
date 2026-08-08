using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public static class CollectionValueComparerHelper
    {
        public static ValueComparer<T[]> ForArray<T>()
            => SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper.CollectionValueComparerHelper.ForArray<T>();

        public static ValueComparer<T[]> ForJsonArray<T>()
            => SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper.CollectionValueComparerHelper.ForJsonArray<T>();
    }
}
