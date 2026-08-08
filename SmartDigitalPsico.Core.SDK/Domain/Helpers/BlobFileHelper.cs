using Azure.Storage.Blobs.Models;
using SmartDigitalPsico.Core.SDK.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Core.SDK.Domain.Helpers
{
    /// <summary>
    /// Classe responsável por BlobFileHelper.
    /// Responsabilidade: utilitário auxiliar do domínio.
    /// Relação: usado por Services e Domain para regras compartilhadas.
    /// </summary>
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
