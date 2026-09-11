using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Core.SDK.Data.Context.Configure.Helper;

/// <summary>
/// Casca HelperCharSet — charset Fluent API por tipo de banco (latin1 MySQL legado SDP).
/// SCH aplica utf8mb4 + collation e usa DatabaseProviderType — comportamento distinto.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.Configurations.Helper.HelperCharSet",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Espelho marcado; corpo local (latin1 + ETypeDataBase) — SCH usa utf8mb4/DatabaseProviderType.")]
public static class HelperCharSet
{
    public static void AddCharSet<T>(EntityTypeBuilder<T> builder, ETypeDataBase eTypeDataBase) where T : class
    {
        if (eTypeDataBase == ETypeDataBase.Mysql)
            builder.HasAnnotation("MySql:CharSet", "latin1");
    }
}
