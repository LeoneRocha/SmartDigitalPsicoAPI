using Azure.Storage.Blobs.Models;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por SmartDigitalPsicoAPI.Core.SDK.Domain.Helpers.BlobFileHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
        // Movido para SmartDigitalPsicoAPI.Core.SDK.
    [Obsolete("Movido para SmartDigitalPsicoAPI.Core.SDK. Use o tipo correspondente no pacote SmartDigitalPsicoAPI.Core.SDK.", error: false, DiagnosticId = "SDP_CORE_SDK_HELPER")]
    public static class BlobFileHelper
    {
        /// <summary>
        /// Método GetBlobHeadersAzure: consulta e retorna dados.
        /// </summary>
        public static BlobHttpHeaders GetBlobHeadersAzure(FileBase file)
        {
            var headers = new BlobHttpHeaders();
            headers.ContentType = file.FileContentType; 
            return headers;
        }
    }
}
