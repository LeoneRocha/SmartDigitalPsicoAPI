// SDP-AJUSTE (SA.1) — FQN SCH seguros no NuGet 20260910.6.0.
// RETIDOS SDP: CultureDateTimeHelper (DTOs), OrderAttribute (ReflectionHelpers casca),
// FileHelper quirk, ServiceResponse, Enuns, clínicos.

global using DateHelper = SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper;
global using DirectoryHelper = SmartCoreHub.Core.SDK.Domain.Helpers.DirectoryHelper;
global using RichContentSanitizerHelper = SmartCoreHub.Core.SDK.Domain.Sanitization.RichContentSanitizerHelper;
global using ValidationErrorCodes = SmartCoreHub.Core.SDK.Domain.Validation.ValidationErrorCodes;
global using AppWarningException = SmartCoreHub.Core.SDK.Common.Exceptions.AppWarningException;
global using AppSettingsConfigurationHelperSch = SmartCoreHub.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper;
global using ConfigurationSectionHelper = SmartCoreHub.Core.SDK.Domain.Helpers.ConfigurationSectionHelper;
