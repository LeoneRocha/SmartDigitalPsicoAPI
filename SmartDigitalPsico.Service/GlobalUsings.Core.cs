// SDP-AJUSTE (SA.1) — FQN SCH seguros no NuGet 20260910.6.0.
// DI AddCore* permanece em SmartDigitalPsico.Core.SDK.Service.Configure.* (registra tipos casca).
// RETIDOS SDP: ServiceResponse, Enuns, Hypermedia enrichers, FileHelper quirk,
// EntityBaseService, CultureDateTimeHelper (DTOs SDP), OrderAttribute (ReflectionHelpers),
// HelperValidation (ErrorResponse VO), SecurityHelper password, ServiceCollectionHelper.

global using DateHelper = SmartCoreHub.Core.SDK.Domain.Helpers.DateHelper;
global using DirectoryHelper = SmartCoreHub.Core.SDK.Domain.Helpers.DirectoryHelper;
global using HtmlSanitizerHelper = SmartCoreHub.Core.SDK.Domain.Helpers.HtmlSanitizerHelper;
global using ValidationErrorCodes = SmartCoreHub.Core.SDK.Domain.Validation.ValidationErrorCodes;
global using AppWarningException = SmartCoreHub.Core.SDK.Common.Exceptions.AppWarningException;
global using AesKeyGeneratorHelper = SmartCoreHub.Core.SDK.Domain.Helpers.Security.AesKeyGeneratorHelper;
global using AppSettingsConfigurationHelperSch = SmartCoreHub.Core.SDK.Domain.Helpers.AppSettingsConfigurationHelper;
global using ConfigurationSectionHelper = SmartCoreHub.Core.SDK.Domain.Helpers.ConfigurationSectionHelper;
