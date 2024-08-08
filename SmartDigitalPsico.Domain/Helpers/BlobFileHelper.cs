using Azure.Storage.Blobs.Models;
using SmartDigitalPsico.Domain.ModelEntity.Contracts;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class BlobFileHelper
    {
        public static BlobHttpHeaders GetBlobHeadersAzure(FileBase file)
        {
            var headers = new BlobHttpHeaders();
            headers.ContentType = file.FileContentType; 
            return headers;
        }
    }
}
