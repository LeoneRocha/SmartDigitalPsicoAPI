using SmartDigitalPsico.Core.SDK.Domain.Enuns;

namespace SmartDigitalPsico.Domain.Constants
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK — implementação canônica no pacote Core.
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class EntityTypeConfigurationConstants
    {
        public const string Type_Varchar_255 = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Type_Varchar_255;
        public const string Type_Varchar_40 = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Type_Varchar_40;
        public const string Type_Varchar_20 = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Type_Varchar_20;

        public const string Type_Text_MySql = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Type_Text_MySql;
        public const string Type_Text_SqlServer = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Type_Text_SqlServer;

        public const string Language_Default_PTBR = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.Language_Default_PTBR;

        public const string ApplicationLanguage_ResourceKey_Default = SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.ApplicationLanguage_ResourceKey_Default;

        public static string GetTypeTextByTypeDataBase(ETypeDataBase eTypeDataBase)
            => SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.GetTypeTextByTypeDataBase(eTypeDataBase);

        public static int GetMaxLengthByTypeDataBase(ETypeDataBase eTypeDataBase)
            => SmartDigitalPsico.Core.SDK.Domain.Constants.EntityTypeConfigurationConstants.GetMaxLengthByTypeDataBase(eTypeDataBase);
    }
}
