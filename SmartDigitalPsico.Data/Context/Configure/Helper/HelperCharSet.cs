using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public static class HelperCharSet
    {
        public static void AddCharSet<T>(EntityTypeBuilder<T> builder, ETypeDataBase eTypeDataBase) where T : class
            => SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper.HelperCharSet.AddCharSet(builder, eTypeDataBase);
    }
}
