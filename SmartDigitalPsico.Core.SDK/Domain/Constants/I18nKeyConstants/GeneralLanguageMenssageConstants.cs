using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

/// <summary>
/// Casca GeneralLanguageMenssageConstants — espelho de mensagens i18n SCH (typo Menssage preservado).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants.GeneralLanguageMenssageConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando GeneralLanguageMenssageConstants do SCH.")]
public static class GeneralLanguageMenssageConstants
{
    public const string RegisterCreated = Sch.GeneralLanguageMenssageConstants.RegisterCreated;
    public const string RegisterDeleted = Sch.GeneralLanguageMenssageConstants.RegisterDeleted;
    public const string RegisterUpdated = Sch.GeneralLanguageMenssageConstants.RegisterUpdated;
    public const string RegisterIsFound = Sch.GeneralLanguageMenssageConstants.RegisterIsFound;
    public const string RegisterIsNotFound = Sch.GeneralLanguageMenssageConstants.RegisterIsNotFound;
    public const string RegisterExist = Sch.GeneralLanguageMenssageConstants.RegisterExist;
    public const string RegisterFind = Sch.GeneralLanguageMenssageConstants.RegisterFind;
    public const string RegisterCounted = Sch.GeneralLanguageMenssageConstants.RegisterCounted;

    public const string DefaultPtBr = Sch.GeneralLanguageMenssageConstants.DefaultPtBr;
    public const string LangValid = Sch.GeneralLanguageMenssageConstants.LangValid;
    public const string LangErrors = Sch.GeneralLanguageMenssageConstants.LangErrors;
    public const string GenericErroMessage = Sch.GeneralLanguageMenssageConstants.GenericErroMessage;
    public const string PermissionDenied = Sch.GeneralLanguageMenssageConstants.PermissionDenied;
    public const string MedicalUpdateTitle = Sch.GeneralLanguageMenssageConstants.MedicalUpdateTitle;
    public const string WrongPassword = Sch.GeneralLanguageMenssageConstants.WrongPassword;
    public const string UserLogout = Sch.GeneralLanguageMenssageConstants.UserLogout;
    public const string UserLogged = Sch.GeneralLanguageMenssageConstants.UserLogged;
}
