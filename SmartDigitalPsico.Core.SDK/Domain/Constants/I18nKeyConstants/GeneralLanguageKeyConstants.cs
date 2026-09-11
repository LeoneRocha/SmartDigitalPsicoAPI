using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants;

namespace SmartDigitalPsico.Core.SDK.Domain.Constants.I18nKeyConstants;

/// <summary>
/// Casca GeneralLanguageKeyConstants — espelho de chaves i18n SCH.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Constants.I18nKeyConstants.GeneralLanguageKeyConstants",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper espelhando GeneralLanguageKeyConstants do SCH.")]
public static class GeneralLanguageKeyConstants
{
    public const string RegisterCreated = Sch.GeneralLanguageKeyConstants.RegisterCreated;
    public const string RegisterDeleted = Sch.GeneralLanguageKeyConstants.RegisterDeleted;
    public const string RegisterUpdated = Sch.GeneralLanguageKeyConstants.RegisterUpdated;
    public const string RegisterIsFound = Sch.GeneralLanguageKeyConstants.RegisterIsFound;
    public const string RegisterIsNotFound = Sch.GeneralLanguageKeyConstants.RegisterIsNotFound;
    public const string RegisterExist = Sch.GeneralLanguageKeyConstants.RegisterExist;
    public const string RegisterFind = Sch.GeneralLanguageKeyConstants.RegisterFind;
    public const string RegisterCounted = Sch.GeneralLanguageKeyConstants.RegisterCounted;

    public const string DefaultPtBr = Sch.GeneralLanguageKeyConstants.DefaultPtBr;
    public const string LangValid = Sch.GeneralLanguageKeyConstants.LangValid;
    public const string LangErrors = Sch.GeneralLanguageKeyConstants.LangErrors;
    public const string GenericErroMessage = Sch.GeneralLanguageKeyConstants.GenericErroMessage;
    public const string PermissionDenied = Sch.GeneralLanguageKeyConstants.PermissionDenied;
    public const string MedicalUpdateTitle = Sch.GeneralLanguageKeyConstants.MedicalUpdateTitle;
    public const string WrongPassword = Sch.GeneralLanguageKeyConstants.WrongPassword;
    public const string UserLogout = Sch.GeneralLanguageKeyConstants.UserLogout;
    public const string UserLogged = Sch.GeneralLanguageKeyConstants.UserLogged;
}
