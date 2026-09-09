using SmartDigitalPsico.Core.SDK.Service.Configure.EntityBase;
using SmartDigitalPsico.Core.SDK.Service.Configure.Queue;
using SmartDigitalPsico.Core.SDK.Service.Configure.Report;
using SmartDigitalPsico.Core.SDK.Service.Configure.Repository;
using SmartDigitalPsico.Core.SDK.Service.Configure.Security;
using SmartDigitalPsico.Core.SDK.Service.Configure.Smtp;

namespace SmartDigitalPsico.Service.Configure;

/// <summary>
/// Bridge documental DI (SDP-AJUSTE SA.2) — hosts usam aliases <c>AddCore*</c> da casca SDP
/// (<c>SmartDigitalPsico.Core.SDK.Service.Configure.*</c>), alinhados semanticamente a
/// <c>SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions</c>.
/// </summary>
/// <remarks>
/// <para>
/// <b>Não</b> chamar diretamente <c>SchDi.AddCoreSmtp</c> / <c>AddCoreCaching</c> etc.:
/// o SCH registra tipos SCH; a casca SDP registra wrappers/ifaces SDP consumidos pelo produto.
/// Orchestrators: <c>WebApplicationConfigureServiceCollections</c>,
/// <c>ServiceCollectionConfigureServicesDomain</c>, <c>ServicesDomainReport</c>,
/// <c>ServicesDomainRepository</c>.
/// </para>
/// <para>
/// FQN SCH nos hosts (SA.1): helpers/exceptions via <c>GlobalUsings.Core.cs</c>
/// (DateHelper, DirectoryHelper, AesKeyGeneratorHelper, config helpers, HtmlSanitizer, ValidationErrorCodes).
/// Retidos em SDP: ServiceResponse, Enuns, Hypermedia enrichers, FileHelper quirk,
/// EntityBaseService, CultureDateTimeHelper (DTOs), OrderAttribute (ReflectionHelpers),
/// HelperValidation (ErrorResponse VO), SecurityHelper password, ServiceCollectionHelper, Configure.
/// </para>
/// </remarks>
public static class HostConfigureBridge
{
    // Marker type — usings acima documentam a surface DI casca usada pelos orchestrators.
    // Métodos AddCore* vivem nas extensões SDP referenciadas pelos usings.
}
