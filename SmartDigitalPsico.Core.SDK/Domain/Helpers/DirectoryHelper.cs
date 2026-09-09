using Microsoft.Extensions.Configuration;
using SmartCoreHub.Core.SDK.Common.Attributes;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca: helpers de diretório — delega a <see cref="Sch.DirectoryHelper"/>.
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.DirectoryHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando para DirectoryHelper em SmartCoreHub.Core.SDK.")]
public static class DirectoryHelper
{
    public static string GetDiretoryTemp(IConfiguration configuration)
        => Sch.DirectoryHelper.GetDiretoryTemp(configuration);

    public static string GetDiretory(string pathCreate)
        => Sch.DirectoryHelper.GetDiretory(pathCreate);

    public static string GetPathSaveCache(string pathCache)
        => Sch.DirectoryHelper.GetPathSaveCache(pathCache);
}
