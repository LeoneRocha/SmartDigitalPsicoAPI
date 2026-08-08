using Azure.Storage.Blobs.Models;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Shim Obsolete — implementação canônica em SmartDigitalPsico.Core.SDK.
    /// </summary>
    // Movido para SmartDigitalPsico.Core.SDK
    [Obsolete("Movido para SmartDigitalPsico.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsico.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class BlobFileHelper
    {
        public static BlobHttpHeaders GetBlobHeadersAzure(FileBase file)
            => SmartDigitalPsico.Core.SDK.Domain.Helpers.BlobFileHelper.GetBlobHeadersAzure(file);
    }
}
