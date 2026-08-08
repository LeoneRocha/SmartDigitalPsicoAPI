using Microsoft.EntityFrameworkCore;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using System.Reflection;

namespace SmartDigitalPsico.Data.Context.Configure.Helper
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_REPO")]
    public static class ModelBuilderExtensions
    {
        public static void AddConfigurationEntities(this ModelBuilder modelBuilder, ETypeDataBase eDataBaseType, Assembly assembly, List<Type> manuallyConfiguredTypes)
            => SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper.ModelBuilderExtensions.AddConfigurationEntities(
                modelBuilder, eDataBaseType, assembly, manuallyConfiguredTypes);
    }
}
