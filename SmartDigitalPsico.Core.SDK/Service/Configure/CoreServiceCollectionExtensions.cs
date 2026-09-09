using SmartCoreHub.Core.SDK.Common.Attributes;

namespace SmartDigitalPsico.Core.SDK.Service.Configure;

/// <summary>
/// Catálogo documental dos aliases DI <c>AddCore*</c> alinhados a SCH
/// <c>CoreServiceCollectionExtensions</c>. Implementações vivem nos namespaces por área
/// (<c>Configure.Logging</c>, <c>Configure.Mapping</c>, …) para evitar ambiguidade de extension methods.
/// </summary>
/// <remarks>
/// <para><b>Mapeamento SCH → SDP:</b></para>
/// <list type="bullet">
/// <item><c>AddCoreLogging</c> → <c>Configure.Logging</c> (<c>IAppLogger</c> SDP)</item>
/// <item><c>AddCoreMapping</c> / <c>AddCoreMapper</c> → <c>Configure.Mapping</c></item>
/// <item><c>AddCoreSmtp</c> → <c>Configure.Smtp</c></item>
/// <item><c>AddCoreReportInfrastructure</c> → <c>Configure.Report</c></item>
/// <item><c>AddCoreCaching</c> → <c>Configure.Caching</c> (MemoryCache; repos no host)</item>
/// <item><c>AddCoreSwagger</c> → <c>Configure.Documentation</c> (Swashbuckle local)</item>
/// <item><c>AddCoreJwtBearer</c> → <c>Configure.Security</c> (JwtBearer completo; SCH = stub)</item>
/// <item><c>AddCoreLocalization</c> / <c>AddCoreRequestLocalization</c> → <c>Configure.Localization</c></item>
/// <item><c>AddCoreEntityBaseService</c> → <c>Configure.EntityBase</c> (impl retida)</item>
/// <item><c>AddCoreCrypto</c> → <c>Configure.Security</c></item>
/// <item><c>AddCoreCacheAndStorageRepositories</c> → <c>Configure.Repository</c> (+ blob Azure)</item>
/// <item><c>AddCoreStorageQueue</c> → <c>Configure.Queue</c> (concreto; SCH = stub)</item>
/// <item>SDP-only: <c>AddCoreCors</c>, <c>AddCoreMvcControllers</c>, <c>AddCoreEndpointsApiExplorer</c>, <c>AddCoreAppSettings</c></item>
/// </list>
/// <para>Hosts FQN SCH: adiado — casca SDP namespaces estáveis; cutover clínico opcional pós-MVP.</para>
/// </remarks>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Service.DependenciesCollection.Extensions.CoreServiceCollectionExtensions",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Catálogo AddCore* SDP; impls por área. JwtBearer/EntityBase/Swagger/Queue divergem do SCH com retenção documentada.")]
public static class CoreServiceCollectionExtensions
{
}
