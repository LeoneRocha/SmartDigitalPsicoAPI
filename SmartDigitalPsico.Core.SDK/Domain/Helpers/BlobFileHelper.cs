using Azure.Storage.Blobs.Models;
using SmartCoreHub.Core.SDK.Common.Attributes;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;
using Sch = SmartCoreHub.Core.SDK.Domain.Helpers;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers;

/// <summary>
/// Casca BlobFileHelper — delega a SCH (content-type).
/// </summary>
[SdkWrappedSource(
    targetType: "SmartCoreHub.Core.SDK.Domain.Helpers.BlobFileHelper",
    targetPackage: "SmartCoreHub.Core.SDK",
    description: "Casca/wrapper delegando BlobFileHelper ao SCH.")]
public static class BlobFileHelper
{
    public static BlobHttpHeaders GetBlobHeadersAzure(FileBase file)
        => Sch.BlobFileHelper.GetBlobHeadersAzure(file.FileContentType);
}
