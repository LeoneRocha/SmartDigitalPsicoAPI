using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.Enuns;
using Sch = SmartCoreHub.Core.SDK.Infrastructure.Data;
using SchCommon = SmartCoreHub.Core.SDK.Common;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants;

/// <summary>
/// Casca EntityTypeConfigurationConstants — delega constantes e helpers ao SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Infrastructure.Data.EntityTypeConfigurationConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando EntityTypeConfigurationConstants ao SCH; enum Enuns convertido por int.")]
public static class EntityTypeConfigurationConstants
{
    public const string Type_Varchar_255 = Sch.EntityTypeConfigurationConstants.Type_Varchar_255;
    public const string Type_Varchar_40 = Sch.EntityTypeConfigurationConstants.Type_Varchar_40;
    public const string Type_Varchar_20 = Sch.EntityTypeConfigurationConstants.Type_Varchar_20;

    public const string Type_Text_MySql = Sch.EntityTypeConfigurationConstants.Type_Text_MySql;
    public const string Type_Text_SqlServer = Sch.EntityTypeConfigurationConstants.Type_Text_SqlServer;

    public const string Language_Default_PTBR = Sch.EntityTypeConfigurationConstants.Language_Default_PTBR;

    public const string ApplicationLanguage_ResourceKey_Default = Sch.EntityTypeConfigurationConstants.ApplicationLanguage_ResourceKey_Default;

    public static string GetTypeTextByTypeDataBase(ETypeDataBase eTypeDataBase)
        => Sch.EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase((SchCommon.ETypeDataBase)(int)eTypeDataBase);

    public static int GetMaxLengthByTypeDataBase(ETypeDataBase eTypeDataBase)
        => Sch.EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase((SchCommon.ETypeDataBase)(int)eTypeDataBase);
}
