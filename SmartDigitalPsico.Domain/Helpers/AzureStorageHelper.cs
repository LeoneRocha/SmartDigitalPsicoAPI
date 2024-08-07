using Azure.Storage.Blobs.Models;

namespace SmartDigitalPsico.Domain.Helpers
{
    public static class AzureStorageHelper
    {
        public static BlobHttpHeaders GetBlobHeaders(string filePath)
        {
            var headers = new BlobHttpHeaders();
            var extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".txt":
                    headers.ContentType = "text/plain; charset=utf-8;";
                    headers.ContentEncoding = "UTF-8";
                    break;
                case ".csv":
                    headers.ContentType = "text/csv; charset=utf-8;";
                    headers.ContentEncoding = "UTF-8";
                    break;
                case ".mp4":
                    headers.ContentType = "audio/mp4";
                    break;
                case ".3gp":
                    headers.ContentType = "audio/3gpp";
                    break;
            }
            return headers;
        }

    }
}
